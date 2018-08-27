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
    public partial class BicycleRentalAgent : Form
    {
        LoginScreen myCaller;
        Worker myWorker;

        public BicycleRentalAgent(LoginScreen caller, Worker currentWorker)
        {
            InitializeComponent();
            myCaller = caller;
            myWorker = currentWorker;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            myCaller.Show();
        }

        private void InsertUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertUserScreen insertScreen = new InsertUserScreen(this);
            insertScreen.Show();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUserScreen deleteUserScreen = new DeleteUserScreen(this);
            deleteUserScreen.Show();

        }

        private void ModifyUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyUserScreen modifyUserScreen = new ModifyUserScreen(this);
            modifyUserScreen.Show();
        }

        private void RentBicycle_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentBicycleScreen rentBike = new RentBicycleScreen(this, myWorker);
            rentBike.Show();
        }

        private void ReturnBicycle_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBicycleScreen returnBike = new ReturnBicycleScreen(this, myWorker);
            returnBike.Show();
        }

        private void InsertWorker_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertWorkerScreen insertWorkerScreen = new InsertWorkerScreen(this);
            insertWorkerScreen.Show();

        }

        private void InsertBicycle_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertBicycleScreen insertBicycleScreen = new InsertBicycleScreen(this);
            insertBicycleScreen.Show();
        }

        private void ModifyWorker_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyWorkerScreen modifyWorker = new ModifyWorkerScreen(this);
            modifyWorker.Show();
        }

        private void DeleteWorker_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteWorkerScreen deleteWorker = new DeleteWorkerScreen(this);
            deleteWorker.Show();
        }

        private void ModifyBicycle_Click(object sender, EventArgs e)
        {
           this.Hide();
           ModifyBicycleScreen modifyBicycle = new ModifyBicycleScreen(this);
           modifyBicycle.Show();
        }

        private void DeleteBicycle_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteBicycleScreen deleteBicycleScreen = new DeleteBicycleScreen(this);
            deleteBicycleScreen.Show();
        }
    }
}
