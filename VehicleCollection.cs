using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* William Dean
 * Joseph Easton
 * CSC 495 Final Project
 * Phase 1
 * 4/15/2016 
 */

namespace BikeRentalGUIFinal
{
    class VehicleCollection : Persistable
    {
        private List<Vehicle> bikes;
        public VehicleCollection()
            : base()
        {
            bikes = new List<Vehicle>();
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source= C:\Users\Will\Documents\visual studio 2013\Projects\BikeRentalGUIFinal\BikeRentalGUIFinal" +
                @"\BicycleRental.accdb";
        }

        public void PopulateWithGoodAndAvailableBikes()
        {
            string query = "SELECT * FROM Vehicle WHERE (PhysicalCondition = 'Good' AND Status = 'Available')";
            List<Object> allDataRetrieved = getValues(query);

            if (allDataRetrieved != null)
            {
                foreach (object result in allDataRetrieved)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;
                    int count = 0;


                    foreach (object rowValue in row)
                    {
                        // DEBUG   Console.WriteLine(rowValue);
                        if (count % 11 == 0) //Mod 11 because there are 10 columns in the Vehicle table
                        {
                            Vehicle nextBike = new Vehicle();
                            nextBike.populate(Convert.ToInt32(rowValue));
                            bikes.Add(nextBike);

                            count++;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no good and available bikes right now!");
            }
        }

        public List<Vehicle> GetVehicleList()
        {
            return bikes;
        }
    }
}


