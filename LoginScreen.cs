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
    public partial class LoginScreen : Form
    {
        private int WorkerId { get; set; }
        
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
        
        private void submit_Click(object sender, EventArgs e)
        {
            string workerIdString = WorkerIdText.Text;
            string passwordString = PasswordText.Text;
            Worker currentWorker = new Worker(workerIdString);
            
            //this.WorkerId = Convert.ToInt32(workerIdString);
            //Worker currentWorker = new Worker();
            //currentWorker.populate(WorkerId);
   
            if(passwordString.Equals(currentWorker.GetWorkerPassword()))
            {
                BicycleRentalAgent agent = new BicycleRentalAgent(this, currentWorker);
                this.Hide();
                WorkerIdText.Clear();
                PasswordText.Clear();
                agent.Show();
            }
            else
            {
                NotificationLabel.Text = "Invalid Worker ID or Password";
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
