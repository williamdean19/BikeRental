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
    public partial class ModifyWorkerScreen : Form
    {
        BicycleRentalAgent myCaller;
        public ModifyWorkerScreen(BicycleRentalAgent caller)
        {
            myCaller = caller;
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.Hide();
            Worker workerToModify = new Worker(UserIDToModifyTextBox.Text);
            ModifyWorkerScreen2 modifyData = new ModifyWorkerScreen2(workerToModify, myCaller);
            modifyData.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }
    }
}
