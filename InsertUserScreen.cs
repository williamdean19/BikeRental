using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRentalGUIFinal
{
    public partial class InsertUserScreen : Form
    {
        BicycleRentalAgent myCaller;

        public InsertUserScreen(BicycleRentalAgent caller)
        {
            InitializeComponent();
            myCaller = caller;
        }

        private void InsertUserScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newWorkerSubmit_Click(object sender, EventArgs e)
        {
            string newUserBannerId = BannerTextBox.Text;
            string newUserFirstName = FirstNameTextBox.Text;
            string newUserLastName = LastNameTextBox.Text;
            string newUserPhoneNumber = PhoneNumberTextBox.Text;
            string newUserEmail = EmailTextBox.Text;
            string newUserUserType = UserTypeTextBox.Text;
            string newUserNotes = NotesTextBox.Text;
            string newUserStatus = StatusTextBox.Text;

            User newUser = new User(newUserBannerId, newUserFirstName, newUserLastName, newUserPhoneNumber, newUserEmail, newUserUserType, newUserNotes, newUserStatus);
            newUser.insert();

            BannerTextBox.Clear();
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            PhoneNumberTextBox.Clear();
            EmailTextBox.Clear();
            UserTypeTextBox.Clear();
            NotesTextBox.Clear();
            StatusTextBox.Clear();

            NewWorkerNotificationLabel.Text = "User added to database";

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            myCaller.Show();
        }
    }
}
