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
    public partial class ModifyWorkerScreen2 : Form
    {
        Worker myWorkerToModify;
        BicycleRentalAgent myMainScreen;

        public ModifyWorkerScreen2(Worker workerToModify, BicycleRentalAgent mainScreen)
        {
            myMainScreen = mainScreen;
            myWorkerToModify = workerToModify;
            InitializeComponent();

            FirstNameTextBox.Text = myWorkerToModify.GetFirstName();
            LastNameTextBox.Text = myWorkerToModify.GetLastName();
            PhoneNumberTextBox.Text = myWorkerToModify.GetPhoneNumber();
            EmailTextBox.Text = myWorkerToModify.GetEmailAddress();
            UserTypeTextBox.Text = myWorkerToModify.GetCredential();
            NotesTextBox.Text = myWorkerToModify.GetNotes();
        }

        private void ModifyWorkerScreen2_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            myMainScreen.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            myWorkerToModify.SetFirstName(FirstNameTextBox.Text);
            myWorkerToModify.SetLastName(LastNameTextBox.Text);
            myWorkerToModify.SetPhoneNumber(PhoneNumberTextBox.Text);
            myWorkerToModify.SetEmailAddress(EmailTextBox.Text);
            myWorkerToModify.SetCredential(UserTypeTextBox.Text);
            myWorkerToModify.SetNotes(NotesTextBox.Text);
            this.Hide();
            myMainScreen.Show();
        }
    }
}
