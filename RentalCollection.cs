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
    class RentalCollection : Persistable
    {
        private List<Rental> rentals;
        public RentalCollection()
            : base()
        {
            rentals = new List<Rental>();
            connectionString = Globals.Access2013ConnectionString;
        }

        public void populateWithRentedOutBikes()
        {
            string query = "SELECT * FROM Rental WHERE (DateReturned = '0')";
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
                        if (count % 11 == 0) //Mod 10 because there are 11 columns in the Rental table
                        {
                            Rental nextRental = new Rental();
                            nextRental.populate(Convert.ToInt32(rowValue));
                            rentals.Add(nextRental);

                            count++;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no rentals that have yet to be returned.");
            }
        }

        public List<Rental> GetRentalList()
        {
            return rentals;
        }
    }
}
