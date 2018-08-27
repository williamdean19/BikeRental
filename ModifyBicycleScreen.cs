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
    public partial class ModifyBicycleScreen : Form
    {
        BicycleRentalAgent myCaller;

        public ModifyBicycleScreen(BicycleRentalAgent caller)
        {
            myCaller = caller;
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Vehicle bikeToModify = new Vehicle();
            int bikeId = Convert.ToInt32(UserIDToModifyTextBox.Text);
            bikeToModify.populate(bikeId);
            ModifyBicycleScreen2 modifyData = new ModifyBicycleScreen2(bikeToModify, myCaller);
            this.Hide();
            modifyData.Show();
        }
    }
}
