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
    public partial class ModifyUserDataScreen : Form
    {
        User myUserToModify;
        BicycleRentalAgent myMainScreen;

        public ModifyUserDataScreen(User userToModify, BicycleRentalAgent mainScreen)
        {
            myUserToModify = userToModify;
            
            myMainScreen = mainScreen;
            InitializeComponent();

            FirstNameTextBox.Text = myUserToModify.GetFirstName();
            LastNameTextBox.Text = myUserToModify.GetLastName();
            PhoneNumberTextBox.Text = myUserToModify.GetPhoneNumber();
            EmailTextBox.Text = myUserToModify.GetEmailAddress();
            UserTypeTextBox.Text = myUserToModify.GetUserType();
            NotesTextBox.Text = myUserToModify.GetNotes();
            StatusTextBox.Text = myUserToModify.GetStatus();
        }

        private void ModifyUserScreen2_Load(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            myUserToModify.SetFirstName(FirstNameTextBox.Text);
            myUserToModify.SetLastName(LastNameTextBox.Text);
            myUserToModify.SetPhoneNumber(PhoneNumberTextBox.Text); 
            myUserToModify.SetEmailAddress(EmailTextBox.Text);
            myUserToModify.SetUserType(UserTypeTextBox.Text);
            myUserToModify.SetNotes(NotesTextBox.Text);
            myUserToModify.SetStatus(StatusTextBox.Text);

            myUserToModify.update();

            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            PhoneNumberTextBox.Clear();
            EmailTextBox.Clear();
            UserTypeTextBox.Clear();
            NotesTextBox.Clear();
            StatusTextBox.Clear();

            NewWorkerNotificationLabel.Text = "User updated";
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            myMainScreen.Show();
        }
    }
}
