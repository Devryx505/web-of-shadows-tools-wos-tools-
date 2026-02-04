using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WOSExtractorSearch
{
    public class SearchForm : Form
    {
        private TextBox searchBox;
        private Button searchButton;
        private ListBox resultsBox;

        public SearchForm()
        {
            this.Text = "Search PCPACK Files";

            searchBox = new TextBox { Left = 10, Top = 10, Width = 300 };
            searchButton = new Button { Left = 320, Top = 10, Text = "Search" };
            resultsBox = new ListBox { Left = 10, Top = 40, Width = 380, Height = 200 };

            searchButton.Click += SearchButton_Click;

            this.Controls.Add(searchBox);
            this.Controls.Add(searchButton);
            this.Controls.Add(resultsBox);

            this.Width = 420;
            this.Height = 300;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string folder = @"C:\Users\user"; // Change to your extractor folder
            string searchTerm = searchBox.Text;

            resultsBox.Items.Clear();

            if (Directory.Exists(folder))
            {
                var files = Directory.GetFiles(folder, "*" + searchTerm + "*", SearchOption.AllDirectories);
                resultsBox.Items.AddRange(files);
            }
            else
            {
                MessageBox.Show("Folder does not exist!");
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new SearchForm());
        }
    }
}
