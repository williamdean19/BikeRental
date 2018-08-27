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
    public class User : Persistable
    {
        private int Id { get; set; }
        private string BannerId { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string PhoneNumber { get; set; }
        private string EmailAddress { get; set; }
        private string UserType { get; set; }
        private string Notes { get; set; }
        private string Status { get; set; }

        public User()
            : base()
        {
            connectionString = Globals.Access2013ConnectionString;
        }
        public User(string bannerId, string firstName, string lastName, string phoneNumber, string emailAddress, string userType, string notes, string status)
            : base()
        {
            connectionString = Globals.Access2013ConnectionString;

            this.BannerId = bannerId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            this.UserType = userType;
            this.Notes = notes;
            this.Status = status;
        }

        public User(string banId)
            : base()
        {
        connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
               @"Data source= C:\Users\Will\Documents\visual studio 2013\Projects\BikeRentalGUIFinal\BikeRentalGUIFinal" +
               @"\BicycleRental.accdb";

            string queryString = "SELECT * FROM [User] WHERE (BannerId = '" + banId + "')";
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
                            this.BannerId = Convert.ToString(rowValue);
                        else if (count == 2)
                            FirstName = Convert.ToString(rowValue);
                        else if (count == 3)
                            LastName = Convert.ToString(rowValue);
                        else if (count == 4)
                            PhoneNumber = Convert.ToString(rowValue);
                        else if (count == 5)
                            EmailAddress = Convert.ToString(rowValue);
                        else if (count == 6)
                            UserType = Convert.ToString(rowValue);
                        else if (count == 7)
                            Notes = Convert.ToString(rowValue);
                        else if (count == 8)
                            Status = Convert.ToString(rowValue);
                        
                        count = count + 1;
                    }
                }
            }
        }
        //------------------------------------------------------------------
        public void populate(int id)
        {
            string queryString = "SELECT * FROM [User] WHERE (ID = " + id + ")";
            List<Object> results = getValues(queryString);
            if (results != null)
            {
                foreach (object result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;
                    int count = 0;
                    foreach (object rowValue in row)
                    {
                        // DEBUGk   Console.WriteLine(rowValue);
                        if (count == 0)
                            this.Id = Convert.ToInt32(rowValue);
                        else if (count == 1)
                            this.BannerId = Convert.ToString(rowValue);
                        else if (count == 2)
                            FirstName = Convert.ToString(rowValue);
                        else if (count == 3)
                            LastName = Convert.ToString(rowValue);
                        else if (count == 4)
                            PhoneNumber = Convert.ToString(rowValue);
                        else if (count == 5)
                            EmailAddress = Convert.ToString(rowValue);
                        else if (count == 6)
                            UserType = Convert.ToString(rowValue);
                        else if (count == 7)
                            Notes = Convert.ToString(rowValue);
                        else if (count == 8)
                            Status = Convert.ToString(rowValue);

                        count = count + 1;
                    }
                }
            }
        }
        //------------------------------------------------------------------
        public void insert()
        {

            string insertQuery =
            "INSERT INTO [User] (BannerId, FirstName, LastName, PhoneNumber, EmailAddress, UserType, Notes, Status) " +
            "VALUES (" +
            "'" + this.BannerId + "' ,'" + 
            this.FirstName + "', '" +
            this.LastName + "', '" +
            this.PhoneNumber + "', '" +
            this.EmailAddress + "', '" +
            this.UserType + "', '" +
            this.Notes + "', '" +
            this.Status + "')";

            int returnCode = modifyDatabase(insertQuery);
            if (returnCode != 0)
            {
                Console.WriteLine("Error in inserting User object into database");
            }
            else
            {
                Console.WriteLine("User object successfully inserted");
                string idQueryString = "SELECT MAX(ID) FROM [User]";
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
                            this.BannerId = Convert.ToString(rowValue);
                        }
                    }
                }
            }
        }

        //------------------------------------------------------------------
        public void update()
        {
            string updateQuery = "UPDATE [User] SET" +
                " BannerId = '" + this.BannerId + "' ," + 
                " FirstName = '" + this.FirstName + "' ," +
                " LastName = '" + this.LastName + "' ," +
                " PhoneNumber = '" + this.PhoneNumber + "' ," +
                " EmailAddress = '" + this.EmailAddress + "' ," +
                " UserType = '" + this.UserType + "', " +
                " Notes = '" + this.Notes + "', " +
                " Status = '" + this.Status + "' " +
                " WHERE " +
                " BannerId = '" + this.BannerId + "'";
            Console.WriteLine(updateQuery);

            int returnCode = modifyDatabase(updateQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in updating User object into database");
            else
                Console.WriteLine("User object successfully updated");
        }
        //------------------------------------------------------------------
        public void delete()
        {
            string deleteQuery = "DELETE FROM [User] WHERE " +
                "BannerId = '" + this.BannerId + "'";
            Console.WriteLine(deleteQuery);
            int returnCode = modifyDatabase(deleteQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in deleting User object from database");
            else
                Console.WriteLine("User object successfully deleted");
        }
        //------------------------------------------------------------------

        public int GetId()
        {
            return this.Id;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public void SetFirstName(string value)
        {
            this.FirstName = value;
        }

        public string GetLastName()
        {
            return LastName;
        }
        public void SetLastName(string value)
        {
            this.LastName = value;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public void SetPhoneNumber(string value)
        {
            this.PhoneNumber = value;
        }
        
        public string GetEmailAddress()
        {
            return EmailAddress;
        }
        public void SetEmailAddress(string value)
        {
            this.EmailAddress = value;
        }
       
        public string GetUserType()
        {
            return UserType;
        }
        public void SetUserType(string value)
        {
            this.UserType = value;
        }
        
        public string GetNotes()
        {
            return Notes;
        }
        public void SetNotes(string value)
        {
            this.Notes = value;
        }

        public string GetStatus()
        {
            return Status;
        }
        public void SetStatus(string value)
        {
            this.Status = value;
        }
    }
}   
