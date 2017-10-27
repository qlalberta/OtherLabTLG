using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace TLG.Concordance
{
    internal struct Wordref
    {
        internal string word;
        internal int paragraphIndex;
        internal int sentenceIndex;
    }

    internal struct Paragraph
    {
        internal string text;
        internal List<Sentence> sentences;

    }

    internal struct Sentence
    {
        internal string text;
        internal List<Wordref> words;
    }

    public class Analyzer
    {
        List<Paragraph> paragraphs = new List<Paragraph>();
        List<Wordref> wordList = new List<Wordref>();

        public void Analyze(string input)
        {
            SplitParagraphs(input);
            var query = from k in wordList orderby k.word group k.paragraphIndex by k.word
                           into g select new { Word = g.Key, WordCount = g.ToList().Count };
            foreach (var x in query)
            {
                Console.Write("{0}\n ", x);
            }        
        }

        // Find the paragraphs in the input
        void SplitParagraphs(string @in)
        {
            string[] paragraphStrings;

            Regex reg = new Regex("\r\n");
            paragraphStrings = reg.Split(@in);
            foreach (string pgstr in paragraphStrings)
            {
                if (pgstr != string.Empty)
                {
                    paragraphs.Add(new Paragraph { text = pgstr, sentences = new List<Sentence>() });
                    SplitSentences(paragraphs[paragraphs.Count - 1], paragraphs.Count - 1);
                }
              
            }
        }

        // Find the sentences in a paragraph
        void SplitSentences(Paragraph pg, int pgindex)
        {
            {
                string[] sentenceStrings;

                Regex reg = new Regex(@"[\.?!]");
                sentenceStrings = reg.Split(pg.text);
                foreach (string sent in sentenceStrings)
                {
                    pg.sentences.Add(new Sentence
                    { text = sent, words = new List<Wordref>() });
                    SplitWords(pg.sentences[pg.sentences.Count - 1], pgindex, pg.sentences.Count - 1);
                }
            }
        }

        // Find the words in each sentence
        void SplitWords(Sentence sent, int pgindex, int sentindex)
        {
            string[] wordStrings;

            Regex reg = new Regex(@"[\s+]");
            Regex reg2 = new Regex(@"\W");
            wordStrings = reg.Split(sent.text);
            foreach (string wd in wordStrings)
            {
                wordList.Add(new Wordref
                {
                    word = reg2.Replace(wd, "").ToLower(),
                    paragraphIndex = pgindex,
                    sentenceIndex = sentindex
                });

                sent.words.Add(new Wordref
                {
                    word = reg2.Replace(wd, "").ToLower(),
                    paragraphIndex = pgindex,
                    sentenceIndex = sentindex
                });    
            }
           
        }

    }

}