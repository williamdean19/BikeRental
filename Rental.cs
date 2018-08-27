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
    class Rental : Persistable
    {
        private int Id
        {
            get;
            set;
        }
        private int VehicleId
        {
            get;
            set;
        }

        private int RenterId
        {
            get;
            set;
        }

        private string DateRented
        {
            get;
            set;
        }

        private string TimeRented
        {
            get;
            set;
        }

        private string DateDue
        {
            get;
            set;
        }

        private string TimeDue
        {
            get;
            set;
        }

        private string DateRet
        {
            get;
            set;
        }

        private string TimeRet
        {
            get;
            set;
        }

        private int OutId
        {
            get;
            set;
        }

        private int InId
        {
            get;
            set;
        }

        public Rental()
            : base()
        {
            connectionString = Globals.Access2013ConnectionString;
        }

        public Rental(int vehicleId, int renterId, string dateRented, string timeRented, string dateDue, string timeDue, string dateRet, string timeRet, int outId, int inId)
            : base()
        {
            connectionString = Globals.Access2013ConnectionString;

            this.VehicleId = vehicleId;
            this.RenterId = renterId;
            this.DateRented = dateRented;
            this.TimeRented = timeRented;
            this.DateDue = dateDue;
            this.TimeDue = timeDue;
            this.DateRet = timeRet;
            this.OutId = outId;
            this.InId = inId;
        }

        public void populate(int Id)
        {
            string queryString = "SELECT * FROM Rental WHERE (ID = " + Id + ")";
            List<Object> results = getValues(queryString);
            if (results != null)
            {
                foreach (object result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;
                    int count = 0;
                    foreach (object rowValue in row)
                    {

                        if (count == 0)
                            this.Id = Convert.ToInt32(rowValue);
                        else if (count == 1)
                            this.VehicleId = Convert.ToInt32(rowValue);
                        else if (count == 2)
                            RenterId = Convert.ToInt32(rowValue);
                        else if (count == 3)
                            DateRented = Convert.ToString(rowValue);
                        else if (count == 4)
                            TimeRented = Convert.ToString(rowValue);
                        else if (count == 5)
                            DateDue = Convert.ToString(rowValue);
                        else if (count == 6)
                            TimeDue = Convert.ToString(rowValue);
                        else if (count == 7)
                            DateRet = Convert.ToString(rowValue);
                        else if (count == 8)
                            TimeRet = Convert.ToString(rowValue);
                        else if (count == 9)
                            OutId = Convert.ToInt32(rowValue);
                        else if (count == 10)
                            InId = Convert.ToInt32(rowValue);

                        count = count + 1;
                    }
                }
            }
        }
        //------------------------------------------------------------------
        public void insert()
        {

            string insertQuery =
            "INSERT INTO Rental (VehicleID, RenterID, DateRented, TimeRented, DateDue, TimeDue, DateReturned, TimeReturned, CheckoutWorkerID, CheckInWorkerID) " +
            "VALUES (" +
            "" + this.VehicleId + ", " +
            this.RenterId + ", '" +
            this.DateRented + "', '" +
            this.TimeRented + "', '" +
            this.DateDue + "', '" +
            this.TimeDue + "', '" +
            this.DateRet + "', '" +
            this.TimeRet + "', " +
            this.OutId + ", " +
            this.InId + ")";
            int returnCode = modifyDatabase(insertQuery);
            if (returnCode != 0)
            {
                Console.WriteLine("Error in inserting Rental object into database");
            }
            else
            {
                Console.WriteLine("Rental object successfully inserted");
                string idQueryString = "SELECT MAX(ID) FROM Rental";
                List<Object> results = getValues(idQueryString);
                if (results != null)
                {
                    // DEBUG Console.WriteLine("Got an id from id query");
                    foreach (object result in results)
                    {
                        IEnumerable<Object> row = result as IEnumerable<Object>;
                        foreach (object rowValue in row)
                        {
                            // DEBUG Console.WriteLine("Retrieved id = " + rowValue);
                            this.Id = Convert.ToInt32(rowValue);
                        }
                    }
                }
            }
        }
        //------------------------------------------------------------------
        public void update()
        {
            string updateQuery = "UPDATE Rental SET " +
                " RenterID = '" + this.RenterId + "' ," +
                " DateRented = '" + this.DateRented + "' ," +
                " TimeRented = '" + this.TimeRented + "', " +
                " DateDue = '" + this.DateDue + "', " +
                " TimeDue = '" + this.TimeDue + "', " +
                " DateReturned = '" + this.DateRet + "', " +
                " TimeReturned = '" + this.TimeRet + "', " +
                " CheckoutWorkerID = '" + this.OutId + "', " +
                " CheckInWorkerID = '" + this.InId + "' " +
                " WHERE " +
                " ID = " + this.Id;
            Console.WriteLine(updateQuery);
            int returnCode = modifyDatabase(updateQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in updating Rental object into database");
            else
                Console.WriteLine("Rental object successfully updated");
        }
        //------------------------------------------------------------------
        public void delete()
        {
            string deleteQuery = "DELETE FROM Rental WHERE " +
                " ID = " + this.VehicleId;
            Console.WriteLine(deleteQuery);
            int returnCode = modifyDatabase(deleteQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in deleting Rental object from database");
            else
                Console.WriteLine("Rental object successfully deleted");
        }
        public int GetId()
        {
            return this.Id;
        }
        public void SetId(int value)
        {
            this.Id = value;
        }

        public int getVehicleId()
        {
            return this.VehicleId;
        }

        public void setVehicleId(int value)
        {
            this.VehicleId = value;
        }

        public int getRenterId()
        {
            return this.RenterId;
        }

        public void setRenterId(int value)
        {
            this.RenterId = value;
        }

        public string getDateRented()
        {
            return DateRented;
        }

        public void setDateRented(string value)
        {
            this.DateRented = value;
        }

        public string getTimeRented()
        {
            return TimeRented;
        }

        public void setTimeRented(string value)
        {
            this.TimeRented = value;
        }

        public string getDateReturned()
        {
            return DateRet;
        }

        public void setDateReturned(string value)
        {
            this.DateRet = value;
        }

        public string getTimeReturned()
        {
            return TimeRet;
        }

        public void setTimeReturned(string value)
        {
            this.TimeRet = value;
        }
        public string getDateDue()
        {
            return this.DateDue;
        }
        public void setTimeDue(string value)
        {
            this.TimeDue = value;
        }
        public string getTimeDue()
        {
            return this.TimeDue;
        }

        public void setDateDue(string value)
        {
            this.DateDue = value;
        }
        public int getOutId()
        {
            return this.OutId;
        }

        public void setOutId(int value)
        {
            this.OutId = value;
        }

        public int getInId()
        {
            return this.InId;
        }

        public void setInId(int value)
        {
            this.InId = value;
        }
    }
}
