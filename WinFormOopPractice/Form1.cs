using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormOopPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClearForm();
        }

        #region Methods

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            nudAge.Value = 0;
            lblOutput.Text = string.Empty;
        }

        private Person CreateNewPerson()
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            int age = Convert.ToInt32(nudAge.Value);

            Person createdPerson = new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
            };

            return createdPerson;
        }

        private void PrintPersonInfo(Person createdPerson)
        {
            ClearForm();
            lblOutput.Text = $"First Name: {createdPerson.FirstName}\nLast Name: {createdPerson.LastName}\nAge: {createdPerson.Age}";
        }

        #endregion

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PrintPersonInfo(CreateNewPerson());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }

    #region Classes

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    #endregion
}
