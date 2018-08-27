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
    public partial class DeleteUserScreen : Form
    {
        BicycleRentalAgent myCaller;

        public DeleteUserScreen(BicycleRentalAgent caller)
        {
            myCaller = caller;
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            myCaller.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            User userToDelete = new User(UserIDToDeleteTextBox.Text);
            userToDelete.SetStatus("Inactive");
            userToDelete.update();
            DeleteNotification.Text = "User Deleted";
            UserIDToDeleteTextBox.Clear();
        }

        private void DeleteUserScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
