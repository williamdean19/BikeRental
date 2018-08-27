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
    public partial class InsertWorkerScreen : Form
    {
        BicycleRentalAgent myCaller;
        public InsertWorkerScreen(BicycleRentalAgent caller)
        {
            myCaller = caller;
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string newWorkerBannerId = bannerIdBox.Text;
            string newWorkerFirstName = firstNameBox.Text;
            string newWorkerLastName = lastNameBox.Text;
            string newWorkerPhoneNumber = phoneNumberBox.Text;
            string newWorkerEmail = emailBox.Text;
            string newWorkerCredential = credentialBox.Text;
            string newWorkerInitialRegistration = DateTime.Now.ToString("yyyy-MM-dd");
            string newWorkerPassword = passwordBox.Text;
            string newWorkerNotes = notesBox.Text;
            string newWorkerStatus = statusBox.Text;


            Worker newWorker = new Worker(newWorkerBannerId, newWorkerFirstName, newWorkerLastName, newWorkerPhoneNumber, newWorkerEmail, newWorkerCredential, newWorkerInitialRegistration, newWorkerPassword, newWorkerNotes, newWorkerStatus);
            newWorker.insert();

            bannerIdBox.Clear();
            firstNameBox.Clear();
            lastNameBox.Clear();
            phoneNumberBox.Clear();
            emailBox.Clear();
            credentialBox.Clear();
            passwordBox.Clear();
            notesBox.Clear();
            statusBox.Clear();

            NewWorkerNotificationLabel.Text = "Worker added to database";
        }
    }
}
