using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal TLG.Concordance.Analyzer analyzer;

        public MainWindow()
        {
            analyzer = (TLG.Concordance.Analyzer)Application.Current.Properties["Analyzer"];
            InitializeComponent();
            List<string> wordList = analyzer.GetWordList();
            wordSelectionList.ItemsSource = wordList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selection = (string)wordSelectionList.SelectedItem;
            if(count.IsChecked == true)
            {
                string wordCount = Convert.ToString(analyzer.GetWordCount(selection));
                string ranking = Convert.ToString(analyzer.GetRanking(selection));
                resultsBox.Text = $"Selected word: {selection}\n";
                resultsBox.Text += $"Word Count: {wordCount}\n";
                resultsBox.Text += $"Word Rank: {ranking}";
            }
            else
            {
                string references = Convert.ToString(analyzer.GetReferences(selection));
                resultsBox.Text = $"Selected word: {selection}\n";
                resultsBox.Text += $"References: {references}";
            }
        }
    }
}
