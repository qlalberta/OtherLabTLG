﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace TLG.Concordance
{
    class Concordance
    {
        static string inPath = string.Empty;
        static string outPath = string.Empty;
        static string excludedWordsPath = string.Empty;
        static string inputText = string.Empty;
        static string outputText = string.Empty;
        internal static string[] excludedWords;

        static void Main(string[] args)
        {

            Analyzer anlz = new Analyzer();

            // Set up paths from args
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid number of path specifications");
                return;
            }
            GetPaths(args);
            // Get the input data
            ReadInputs();
            // Identify paragraphs and sentences
            // Identify words and their location

            Stopwatch watch = new Stopwatch();
            watch.Start();

            anlz.Analyze(inputText);

            watch.Stop();
            Console.WriteLine("Elapsed time: "+ watch.Elapsed.ToString("g"));

            // SQL connection strings are very unforgiving as to content and punctuation;
            // A good way to obtain one is to set a data connection in the Visual Studio
            // Server Explorer.  The connection string may be copied from the 
            // connection properties.
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=Concordance;Integrated Security=True";
            // A SQL connection is a scarce resource and must be released when not needed.
            // The using block below will cause the connection to be cleaned up
            // when the scope is exited.  The behavior is similar to that of a 
            // finally block in structured exception handling.
            // A using block should be written whenver possible to ensure you do not 
            // forget to release a connection.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create an INSERT statement using parameters
                // Always use parameters as they are not parsed and thus will not be a SQL injection path
                string insertStmt = "INSERT INTO [AChristmasCarol].[WordRefs] (Word, ParagraphIndex, SentenceIndex, WordPositionIndex) VALUES(@word, @paragraph, @sentence, @wordPosition);";
                // Statements to clear previous run from tables
                string truncateStmtRefs = "TRUNCATE TABLE [AChristmasCarol].[WordRefs];";
                string truncateStmtWords = "TRUNCATE TABLE [AChristmasCarol].[UniqueWords];";
                // Statement to build unique word table
                string uniqueWordStmt = "INSERT INTO [AChristmasCarol].[UniqueWords] SELECT DISTINCT [Word] FROM [AChristmasCarol].[WordRefs];";
                // Set up a command object
                using (SqlCommand cmd = new SqlCommand(truncateStmtRefs, connection))
                {
                    connection.Open();

                    // Execute the truncations
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = truncateStmtWords;
                    cmd.ExecuteNonQuery();
                    
                    // Set up the Wordref insertion
                    cmd.CommandText = insertStmt;

                    // Define parameters
                    cmd.Parameters.Add("@word", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@paragraph", SqlDbType.Int);
                    cmd.Parameters.Add("@sentence", SqlDbType.Int);
                    cmd.Parameters.Add("@wordPosition", SqlDbType.Int);

                    // Loop through the Wordref list
                    foreach (Wordref wdref in anlz.wordRefs)
                    {
                        //cmd.Parameters["@word"].Value = new string(wdref.word);
                        cmd.Parameters["@word"].Value = wdref.word;
                        cmd.Parameters["@paragraph"].Value = wdref.paragraphIndex;
                        cmd.Parameters["@sentence"].Value = wdref.sentenceIndex;
                        cmd.Parameters["@wordPosition"].Value = wdref.wordPositionIndex;
                        cmd.ExecuteNonQuery();
                    }

                    // Build the UniqueWords table
                    cmd.Parameters.Clear();
                    cmd.CommandText = uniqueWordStmt;
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        static void ReadInputs()
        {
            try
            {
                inputText = File.ReadAllText(inPath);
                excludedWords = File.ReadAllLines(excludedWordsPath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading file " + e.Message);
            }
        }

        static void GetPaths(string[] args)
        {
            // Get the path to the input text file
            try
            {
                inPath = Path.GetFullPath(args[0]);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Invalid text input path {args[0]}");
            }

            // Get the path for the output file
            try
            {
                outPath = Path.GetFullPath(args[1]);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Invalid text output path {args[1]}");
            }

            // Get the path to the excluded words file
            try
            {
                excludedWordsPath = Path.GetFullPath(args[2]);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Invalid excluded words input path {args[1]}");
            }
        }

    }
}
