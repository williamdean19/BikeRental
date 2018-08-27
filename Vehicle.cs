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
    public class Vehicle : Persistable
    {
        private int Id {get; set;} 
        private string BikeMake { get; set; }
        private string ModelNumber { get; set; }
        private string SerialNumber { get; set; }
        private string Color { get; set; }
        private string Description { get; set; }
        private string Location { get; set; }
        private string PhysicalCondition { get; set; }
        private string Notes { get; set; }
        private string Status { get; set; }
        private string DateStatusUpdated { get; set; }

        public Vehicle()
            : base()
        {
            connectionString = Globals.Access2013ConnectionString;
        }
        public Vehicle(string bikeMake, string modelNumber, string serialNumber, string color, string description, string location, string physicalCond, string notes, string status, string dateStatusUpdated)
            :base()
        {
            connectionString = Globals.Access2013ConnectionString;

            this.BikeMake = bikeMake;
            this.ModelNumber = modelNumber;
            this.SerialNumber = serialNumber;
            this.Color = color;
            this.Description = description;
            this.Location = location;
            this.PhysicalCondition = physicalCond;
            this.Notes = notes;
            this.Status = status;
            this.DateStatusUpdated = dateStatusUpdated;
        }
        //------------------------------------------------------------------
        public void populate(int id)
        {
            string queryString = "SELECT * FROM Vehicle WHERE (ID = " + id + ")";
            List<Object> results = getValues(queryString);
            if (results != null)
            {
                foreach (object result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;
                    int count = 0;
                    foreach (object rowValue in row)
                    {
                        // DEBUG   Console.WriteLine(rowValue);
                        if (count == 0)
                            this.Id = Convert.ToInt32(rowValue);
                        else if (count == 1)
                            BikeMake = Convert.ToString(rowValue);
                        else if (count == 2)
                            ModelNumber = Convert.ToString(rowValue);
                        else if (count == 3)
                            SerialNumber = Convert.ToString(rowValue);
                        else if (count == 4)
                            Color = Convert.ToString(rowValue);
                        else if (count == 5)
                            Description = Convert.ToString(rowValue);
                        else if (count == 6)
                            Location = Convert.ToString(rowValue);
                        else if (count == 7)
                            PhysicalCondition = Convert.ToString(rowValue);
                        else if (count == 8)
                            Notes = Convert.ToString(rowValue);
                        else if (count == 9)
                            Status = Convert.ToString(rowValue);
                        else if (count == 10)
                            DateStatusUpdated = Convert.ToString(rowValue);

                        count = count + 1;
                    }
                }
            }
        }
        //------------------------------------------------------------------
        public void insert()
        {

            string insertQuery =
            "INSERT INTO Vehicle (BikeMake, ModelNumber, SerialNumber, Color, Description, Location, PhysicalCondition, Notes, Status, DateStatusUpdated) " +
            "VALUES (" +
            "'" + this.BikeMake + "', '" +
            this.ModelNumber + "', '" +
            this.SerialNumber + "', '" +
            this.Color + "', '" +
            this.Description + "', '" +
            this.Location + "', '" +
            this.PhysicalCondition + "', '" +
            this.Notes + "', '" +
            this.Status + "', '" +
            this.DateStatusUpdated + "')";

            int returnCode = modifyDatabase(insertQuery);
            if (returnCode != 0)
            {
                Console.WriteLine("Error in inserting Vehicle object into database");
            }
            else
            {
                Console.WriteLine("Vehicle object successfully inserted");
                string idQueryString = "SELECT MAX(ID) FROM Vehicle";
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
            string updateQuery = "UPDATE Vehicle SET" +
                " BikeMake = '" + this.BikeMake + "' ," +
                " ModelNumber = '" + this.ModelNumber + "' ," +
                " SerialNumber = '" + this.SerialNumber + "' ," +
                " Color = '" + this.Color + "' ," +
                " Description = '" + this.Description + "', " +
                " Location = '" + this.Location + "', " +
                " PhysicalCondition = '" + this.PhysicalCondition + "' ," +
                " Notes = '" + this.Notes + "', " +
                " Status = '" + this.Status + "', " +
                " DateStatusUpdated = '" + this.DateStatusUpdated + "' " +
                " WHERE " +
                " ID = " + this.Id;
            Console.WriteLine(updateQuery);

            int returnCode = modifyDatabase(updateQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in updating Vehicle object into database");
            else
                Console.WriteLine("Vehicle object successfully updated");
        }
        //------------------------------------------------------------------
        public void delete()
        {
            string deleteQuery = "DELETE FROM Vehicle WHERE " +
                " ID = " + this.Id;
            Console.WriteLine(deleteQuery);
            int returnCode = modifyDatabase(deleteQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in deleting Vehicle object from database");
            else
                Console.WriteLine("Vehicle object successfully deleted");
        }
        //------------------------------------------------------------------
        public int GetVehicleId()
        {
            return this.Id;
        }
        public string GetBikeMake()
        {
            return BikeMake;
        }
        public void SetBikeMake(string value)
        {
            this.BikeMake = value;
        }

        public string GetModelNumber()
        {
            return this.ModelNumber;
        }
        public void SetModelNumber(string value)
        {
            this.ModelNumber = value;
        }

        public string GetSerialNumber()
        {
            return this.SerialNumber;
        }
        public void SetSerialNumber(string value)
        {
            this.SerialNumber = value;
        }

        public string GetColor()
        {
            return this.Color;
        }
        public void SetColor(string value)
        {
            this.Color = value;
        }

        public string GetDescription()
        {
            return this.Description;
        }
        public void SetDescription(string value)
        {
            this.Description = value;
        }

        public string GetLocation()
        {
            return this.Location;
        }
        public void SetLocation(string value)
        {
            this.Location = value;
        }

        public string GetPhysicalCond()
        {
            return this.PhysicalCondition;
        }
        public void SetPhysicalCond(string value)
        {
            this.PhysicalCondition = value;
        }

        public string GetNotes()
        {
            return this.Notes;
        }
        public void SetNotes(string value)
        {
            this.Notes = value;
        }

        public string GetStatus()
        {
            return this.Status;
        }
        public void SetStatus(string value)
        {
            this.Status = value;
        }

        public string GetDateStatusUpdated()
        {
            return this.DateStatusUpdated;
        }
        public void SetDateStatusUpdated(string value)
        {
            this.DateStatusUpdated = value;
        }

    }
}
