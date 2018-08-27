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
    public partial class DeleteWorkerScreen : Form
    {
        BicycleRentalAgent myCaller;

        public DeleteWorkerScreen(BicycleRentalAgent caller)
        {
            myCaller = caller;
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Worker workerToDelete = new Worker(UserIDToDeleteTextBox.Text);
            workerToDelete.SetStatus("Inactive");
            workerToDelete.update();
            DeleteNotification.Text = "Worker Deleted";
            UserIDToDeleteTextBox.Clear();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }
    }
}
