using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using TLG.Concordance;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Analyzer anlz;

        private void Application_Startup(object sender, StartupEventArgs e)
        {


            string inPath = string.Empty;
            string outPath = string.Empty;
            string excludedWordsPath = string.Empty;
            string inputText = string.Empty;
            string outputText = string.Empty;
            string[] excludedWords;

            anlz = new Analyzer();
            this.Properties["Analyzer"] = anlz;
            // Set up paths from args
            if (e.Args.Length != 3)
            {
                MessageBox.Show("Invalid number of path specifications");
                return;
            }
            GetPaths(e.Args);
            // Get the input data
            ReadInputs();
            // Identify paragraphs and sentences
            // Identify words and their location
            anlz.Analyze(inputText);



            void ReadInputs()
            {
                try
                {
                    inputText = File.ReadAllText(inPath);
                    excludedWords = File.ReadAllLines(excludedWordsPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file " + ex.Message);
                }
            }

            void GetPaths(string[] args)
            {
                // Get the path to the input text file
                try
                {
                    inPath = Path.GetFullPath(args[0]);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show($"Invalid text input path {args[0]}");
                }

                // Get the path for the output file
                try
                {
                    outPath = Path.GetFullPath(args[1]);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show($"Invalid text output path {args[1]}");
                }

                // Get the path to the excluded words file
                try
                {
                    excludedWordsPath = Path.GetFullPath(args[2]);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show($"Invalid excluded words input path {args[1]}");
                }
            }

        }
    }
}
