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
    public partial class RentBicycleScreen : Form
    {
        BicycleRentalAgent myCaller;
        Worker myWorker;
        List<Vehicle> availableBikes = new List<Vehicle>();

        public RentBicycleScreen(BicycleRentalAgent caller, Worker currentWorker)
        {

            myCaller = caller;
            myWorker = currentWorker;

            VehicleCollection vc = new VehicleCollection();
            vc.PopulateWithGoodAndAvailableBikes();
            availableBikes = vc.GetVehicleList();

            InitializeComponent();

            for (int i = 0; i < availableBikes.Count; i++)
            {
                 this.chooseCombo.Items.Add(Convert.ToString(availableBikes[i].GetVehicleId()));
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Rental newRental = new Rental();
            Vehicle bikeToRent = new Vehicle();
            User userRentingBike = new User(renterTextBox.Text);
            string curDate = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime today = DateTime.Now;
		    DateTime due = today.AddDays(1);
            string dueDate = due.ToString("yyyy-MM-dd");
            string curTime = DateTime.Now.ToString("HH:mm:ss tt");
          
            int workerId = myWorker.GetWorkerId();
            newRental.setOutId(workerId);
            newRental.setRenterId(userRentingBike.GetId());
            newRental.setDateRented(curDate);
            newRental.setTimeRented(curTime);
            newRental.setVehicleId(Convert.ToInt32(chooseCombo.SelectedItem.ToString()));;
            newRental.setTimeReturned("0");
            newRental.setDateReturned("0");

            newRental.setDateDue(dueDate);
            newRental.setTimeDue("23:59:59");

            bikeToRent.populate(Convert.ToInt32(chooseCombo.SelectedItem.ToString()));
            bikeToRent.SetStatus("Rented");
                
            newRental.insert();
            bikeToRent.update();
            this.Hide();
            myCaller.Show();
        }
    }
}
