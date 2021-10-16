using PersonDatabaseLogic.DataAccess;
using PersonDatabaseLogic.PersonLogic;
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

namespace PersonDatabaseWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonController personController = new PersonController();
        public MainWindow()
        {
            InitializeComponent();
            SetupListBox();
        }

        private void SetupListBox()
        {
            usersListBox.ItemsSource = personController.GetPeople();
            usersListBox.DisplayMemberPath = "FullName";
        }

        private void saveUserButton_Click(object sender, RoutedEventArgs e)
        {
            Person newPerson = new Person { FirstName = firstNameTextBox.Text, LastName = secondNameTextBox.Text };
            try
            {
                personController.AddPerson(newPerson);
                firstNameTextBox.Text = "";
                secondNameTextBox.Text = "";
            }
            catch(ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            SetupListBox();
        }

        private void deleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            Person personToDelete = (Person)usersListBox.SelectedItem;
            if(personToDelete != null)
            {
                if (MessageBox.Show($"Odstranit {personToDelete.FullName}?", "Odstranit osobu", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    try
                    {
                        personController.DeletePerson(personToDelete.Id);
                        SetupListBox();
                    }
                    catch (PersonNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
