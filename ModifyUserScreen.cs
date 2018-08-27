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
    public partial class ModifyUserScreen : Form
    {
        BicycleRentalAgent myCaller;

        public ModifyUserScreen(BicycleRentalAgent caller)
        {
            myCaller = caller;
            InitializeComponent();
        }

        private void DeleteUserTitle_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserIDToDeleteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            User userToModify = new User(UserIDToModifyTextBox.Text);
            ModifyUserDataScreen modifyData = new ModifyUserDataScreen(userToModify, myCaller);
            modifyData.Show();
        }
    }
}
