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
    public partial class InsertBicycleScreen : Form
    {
        BicycleRentalAgent myCaller;

        public InsertBicycleScreen(BicycleRentalAgent caller)
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
            string newBicycleBikeMake = bikeMakeBox.Text;
            string newBicycleModelNumber = modelNumberBox.Text;
            string newBicycleSerialNumber = serialNumberBox.Text;
            string newBicycleColor = colorBox.Text;
            string newBicycleDescription = descriptionBox.Text;
            string newBicycleLocation = locationBox.Text;
            string newBicyclePhysicalCondition = "Good";// physicalConditionBox.Text;
            string newBicycleNotes = notesBox.Text;
            string newBicycleStatus = statusBox.Text;
            string curDate = DateTime.Now.ToString("yyyy-MM-dd");

            Vehicle newBicycle = new Vehicle(newBicycleBikeMake, newBicycleModelNumber, newBicycleSerialNumber, newBicycleColor, newBicycleDescription, newBicycleLocation, newBicyclePhysicalCondition, newBicycleNotes, newBicycleStatus, curDate);
            newBicycle.insert();

            bikeMakeBox.Clear();
            modelNumberBox.Clear();
            serialNumberBox.Clear();
            colorBox.Clear();
            descriptionBox.Clear();
            locationBox.Clear();
           // physicalConditionBox.Clear();
            notesBox.Clear();
            statusBox.Clear();

            //NewBicycleNotificationLabel.Text = "Bicycle successfully rented";
        }
    }
}
