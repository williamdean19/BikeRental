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
    public partial class ModifyBicycleScreen2 : Form
    {
        Vehicle myBikeToModify;
        BicycleRentalAgent myMainScreen;

        public ModifyBicycleScreen2(Vehicle bikeToModify, BicycleRentalAgent mainScreen)
        {
            myBikeToModify = bikeToModify;
            myMainScreen = mainScreen;

            InitializeComponent();
            colorBox.Text = myBikeToModify.GetColor();
            descriptionBox.Text = myBikeToModify.GetDescription();
            locationBox.Text = myBikeToModify.GetLocation();
            physicalConditionBox.Text = myBikeToModify.GetPhysicalCond();
            notesBox.Text = myBikeToModify.GetNotes();
            statusBox.Text = myBikeToModify.GetStatus();
        }

        private void ModifyBicycleScreen2_Load(object sender, EventArgs e)
        {
                
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            myMainScreen.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            myBikeToModify.SetColor(colorBox.Text);
            myBikeToModify.SetDescription(descriptionBox.Text);
            myBikeToModify.SetLocation(locationBox.Text);
            myBikeToModify.SetPhysicalCond(physicalConditionBox.Text);
            myBikeToModify.SetNotes(notesBox.Text);
            myBikeToModify.SetStatus(statusBox.Text);
            

            myBikeToModify.update();
            this.Hide();
            myMainScreen.Show();
        }
    }
}
