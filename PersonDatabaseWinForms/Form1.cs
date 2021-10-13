using PersonDatabaseLogic.PersonLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonDatabaseWinForms
{
    public partial class mainForm : Form
    {
        private PersonController personController = new PersonController();
        public mainForm()
        {
            InitializeComponent();
            SetupList();
        }

        private void SetupList()
        {
            List<Person> people = personController.GetPeople();
            personsListBox.DataSource = people;
            personsListBox.DisplayMember = "FullName";
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            try
            {
                personController.AddPerson(new Person { FirstName = firstNameTextBox.Text, LastName = lastNameTextBox.Text });
                SetupList();
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
            }
            catch(ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Person selectedPerson = (Person)personsListBox.SelectedItem;
            if(selectedPerson != null)
            {
                if( MessageBox.Show($"Odstranit {selectedPerson.FullName}?","Odstranit osobu",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    personController.DeletePerson(selectedPerson.Id);
                    SetupList();
                }
            }
        }
    }
}
