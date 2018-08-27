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
    public partial class ReturnBicycleScreen : Form
    {
        BicycleRentalAgent myCaller;
        Worker myWorker;
        List<Rental> rentedBikes;

        public ReturnBicycleScreen(BicycleRentalAgent caller, Worker currentWorker)
        {
            myCaller = caller;
            myWorker = currentWorker;


            RentalCollection rc = new RentalCollection();
            rc.populateWithRentedOutBikes();
            rentedBikes = rc.GetRentalList();

            InitializeComponent();

            for (int i = 0; i < rentedBikes.Count; i++)
            {
                this.chooseCombo.Items.Add(Convert.ToString(rentedBikes[i].GetId()));
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Rental returningRental = new Rental();
            int rentalId = Convert.ToInt32(chooseCombo.SelectedItem.ToString());
            returningRental.populate(rentalId);


            Vehicle bikeToReturn = new Vehicle();

            string curDate = DateTime.Now.ToString("yyyy-MM-dd");
            string curTime = DateTime.Now.ToString("HH:mm:ss tt");

            int workerId = myWorker.GetWorkerId();
            returningRental.setInId(workerId);

            returningRental.SetId(Convert.ToInt32(chooseCombo.SelectedItem.ToString()));
            returningRental.setDateReturned(curDate);
            returningRental.setTimeReturned(curTime);
          
            bikeToReturn.populate(returningRental.getVehicleId());
            bikeToReturn.SetStatus("Available");

            returningRental.update();
            bikeToReturn.update();

            this.Hide();
            myCaller.Show();
        }
    }
}
