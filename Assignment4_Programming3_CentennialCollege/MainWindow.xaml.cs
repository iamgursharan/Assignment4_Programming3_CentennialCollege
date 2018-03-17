using System;
using System.Linq;
using System.Windows;
/*
 * Name: Gursharan Singh
 * Description: This is the main window class that shows the query related to datagrid
 * Version: 1.3- Added the resetBtn_Click method 
 */
namespace Assignment4_Programming3_CentennialCollege
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseballEntities entities = new BaseballEntities();
       
        public MainWindow()
        {
            InitializeComponent();
            baseballPlayersDatagrid.ItemsSource = entities.Players.ToList();
        }

        /// <summary>
        /// This is the resultBtn_Click method that shows the query result in the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resultBtn_Click(object sender, RoutedEventArgs e)
        {
            String searchPlayer = searchTextBox.Text.ToUpper();
            var item = from player in entities.Players.ToList()
                       select player;
            item = item.Where(player => player.LastName.ToUpper().Contains(searchPlayer));
            baseballPlayersDatagrid.ItemsSource = item;
        }

        /// <summary>
        /// This method resets the text of searchTextBox to Italics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTextBox_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            searchTextBox.FontStyle = FontStyles.Italic;
            searchTextBox.Text = "Double click to enter text";
        }

        /// <summary>
        /// This method changes the text of searchTextBox to empty string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTextBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            searchTextBox.FontStyle = FontStyles.Normal;
            searchTextBox.Text = "";
        }

        /// <summary>
        /// This is the reset button that returns the user the complete list of players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBtn_Click(object sender, RoutedEventArgs e)
        {
            baseballPlayersDatagrid.ItemsSource = entities.Players.Local;
        }
    } // class ends
}
