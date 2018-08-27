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
    public partial class DeleteBicycleScreen : Form
    {
        BicycleRentalAgent myCaller;

        public DeleteBicycleScreen(BicycleRentalAgent caller)
        {
            myCaller = caller;
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Vehicle bikeToDelete = new Vehicle();
            bikeToDelete.populate(Convert.ToInt32(UserIDToDeleteTextBox.Text));
            bikeToDelete.SetStatus("Removed");
            bikeToDelete.update();
            DeleteNotification.Text = "Bicycle Deleted";
            UserIDToDeleteTextBox.Clear();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }
    }
}
