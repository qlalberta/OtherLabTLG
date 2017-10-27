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
        Dictionary<string, List<Wordref>> wordDict = new Dictionary<string, List<Wordref>>();

        public void Analyze(string input)
        {
            SplitParagraphs(input);
            //var query = from k in wordList orderby k.word group k.paragraphIndex by k.word
            //               into g select new { Word = g.Key, WordCount = g.ToList().Count };     
        }

        public List<string> GetWordList()
        {
            List<string> result = new List<string>();
            var query = from  w in wordList
                        orderby w.word
                        group w by w.word
                        into wl
                        select new { wl.Key };
            foreach(var w in query)
            {
                result.Add(w.Key);
            }
            return result;
        }

        public int GetWordCount(string w)
        {
            int count = (from word in wordList
                        where word.word == w
                        select word).Count();
      
            return count;
        }

        public int GetRanking(string w)
        {
            var query =
                from word in wordDict
                orderby word.Value.Count descending
                select new { word.Key, word.Value.Count };
            List<string> words = new List<string>();
            foreach(var item in query)
            {
                words.Add(item.Key);
            }
            return words.IndexOf(w) + 1;
        }

        public string GetReferences(string w)
        {
            string result = "";
            foreach(Wordref wr in wordDict[w])
            {
                result += $"(p:{wr.paragraphIndex + 1}, s:{wr.sentenceIndex + 1}) ";
            }
            return result;
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
                Wordref wr = new Wordref
                {
                    word = reg2.Replace(wd, "").ToLower(),
                    paragraphIndex = pgindex,
                    sentenceIndex = sentindex
                };
                wordList.Add(wr);

                sent.words.Add(wr);

                if (wordDict.ContainsKey(wr.word))
                {
                    wordDict[wr.word].Add(wr);
                }
                else
                {
                    wordDict.Add(wr.word, new List<Wordref> { wr });
                }
            }
           
        }

    }

}