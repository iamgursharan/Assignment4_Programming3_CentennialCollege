using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using BooksExamples;
/*
 * Name: Gursharan Singh
 * Description: This is the codebehind class that handles the events 
 */
namespace QueryBooks_Q2
{
    public partial class Books_Q2 : Form
    {
        public BooksEntities entities = new BooksEntities();
        
        public Books_Q2()
        {
            InitializeComponent();
           
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (queryComboBox.SelectedIndex)
            {
                case 0:
                    resultTextBox.AppendText("\nResults sorted by title\n");
                    resultTextBox.AppendText("\n------------------------\n");
                    var sortTitleAuthor = from author in entities.Authors
                                          from title in entities.Titles
                                          orderby title.Title1
                                          select new { author.FirstName,
                                              author.LastName,title.Title1 };
                    foreach (var item in sortTitleAuthor)
                    { 
                    resultTextBox.AppendText($"\r\n{item.FirstName,-10}" +
                        $"{item.LastName,-10}{item.Title1,20}");
                    }
                    break;
                case 1:
                    resultTextBox.AppendText("\r\nResults sorted by last name " +
                        "and first name of author\n");
                    resultTextBox.AppendText("\r\n------------------------\n");

                    var sortAuthorLFName = from author in entities.Authors
                                               from title in entities.Titles
                                               orderby title.Title1,
                                               author.LastName, author.FirstName 
                                               select new { author.FirstName,
                                                   author.LastName, title.Title1 };
                    foreach (var item in sortAuthorLFName)
                    {
                        resultTextBox.AppendText($"\r\n{item.FirstName,-10}" +
                            $"{item.LastName,-10}{item.Title1,-20}");
                    }
                     break;
                case 2:
                    resultTextBox.AppendText("\r\nResults sorted by title grouped by author\n");
                    resultTextBox.AppendText("\r\n-----------------------------------------\n");
                    var titleGroupAuthor = from title in entities.Titles
                                           orderby title.Title1
                                           select new
                                           {
                                               Title = title.Title1,
                                               Author = from author in entities.Authors
                                                      orderby author.LastName, author.FirstName
                                                      select author.FirstName
                                           };
                    foreach (var title in titleGroupAuthor)
                    {
                        resultTextBox.AppendText($"\r\n{title.Title,-10}\n");
                        foreach (var author in title.Author )
                        {
                            resultTextBox.AppendText($"\r{author,-10}");
                        }
                    }
                    break;
            }
        }

        private void Books_Q2_Load(object sender, EventArgs e)
        {
            entities.Authors.Load(); // Loading the database
        }

        private void searchAgainButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = ""; // Reseting to empty textbox
        }
    }
}
