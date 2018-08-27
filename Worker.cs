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
    public class Worker : Persistable
    {
        private int Id { get; set; }
        private string BannerId { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string PhoneNumber { get; set; }
        private string EmailAddress { get; set; }
        private string Credential { get; set; }
        private string InitialRegistrationDate { get; set; }
        private string WorkerPassword { get; set; }
        private string Notes { get; set; }
        private string Status { get; set; }

        public Worker()
            : base()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source= C:\Users\Will\Documents\visual studio 2013\Projects\BikeRentalGUIFinal\BikeRentalGUIFinal" +
                @"\BicycleRental.accdb";
        }
        public Worker(string bannerId, string firstName, string lastName, string phoneNumber, string emailAddress, string credential, string initialRegistrationDate, string workerPassword, string notes, string status)
            : base()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source= C:\Users\Will\Documents\visual studio 2013\Projects\BikeRentalGUIFinal\BikeRentalGUIFinal" +
                @"\BicycleRental.accdb";

            this.BannerId = bannerId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            this.Credential = credential;
            this.InitialRegistrationDate = initialRegistrationDate;
            this.WorkerPassword = workerPassword;
            this.Notes = notes;
            this.Status = status;
        }
        public Worker(string banId)
            : base()
        {
            connectionString = Globals.Access2013ConnectionString;

            string queryString = "SELECT * FROM Worker WHERE (BannerID = '" + banId + "')";
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
                            Credential = Convert.ToString(rowValue);
                        else if (count == 7)
                            InitialRegistrationDate = Convert.ToString(rowValue);
                        else if (count == 8)
                            WorkerPassword = Convert.ToString(rowValue);
                        else if (count == 9)
                            Notes = Convert.ToString(rowValue);
                        else if (count == 10)
                            Status = Convert.ToString(rowValue);

                        count = count + 1;
                    }
                }
            }
        }

        //------------------------------------------------------------------
        public void populate(int id)
        {
            string queryString = "SELECT * FROM Worker WHERE (ID = " + id + ")";
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
                            Credential = Convert.ToString(rowValue);
                        else if (count == 7)
                            InitialRegistrationDate = Convert.ToString(rowValue);
                        else if (count == 8)
                            WorkerPassword = Convert.ToString(rowValue);
                        else if (count == 9)
                            Notes = Convert.ToString(rowValue);
                        else if (count == 10)
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
            "INSERT INTO Worker (BannerId, FirstName, LastName, PhoneNumber, EmailAddress, Credential, InitialRegistrationDate, WorkerPassword, Notes, Status) " +
            "VALUES (" +
            "'" + this.BannerId + "', '" +
            this.FirstName + "', '" +
            this.LastName + "', '" +
            this.PhoneNumber + "', '" +
            this.EmailAddress + "', '" +
            this.Credential + "', '" +
            this.InitialRegistrationDate + "', '" +
            this.WorkerPassword + "', '" +
            this.Notes + "', '" +
            this.Status + "')";

            int returnCode = modifyDatabase(insertQuery);
            if (returnCode != 0)
            {
                Console.WriteLine("Error in inserting Worker object into database");
            }
            else
            {
                Console.WriteLine("Worker object successfully inserted");
                string idQueryString = "SELECT MAX(ID) FROM Worker";
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
            string updateQuery = "UPDATE Worker SET" +
                " BannerId = '" + this.BannerId + "' ," + 
                " FirstName = '" + this.FirstName + "' ," +
                " LastName = '" + this.LastName + "' ," +
                " PhoneNumber = '" + this.PhoneNumber + "' ," +
                " EmailAddress = '" + this.EmailAddress + "' ," +
                " Credential = '" + this.Credential + "', " +
                " InitialRegistrationDate = '" + this.InitialRegistrationDate + "', " +
                " WorkerPassword = '" + this.WorkerPassword + "', " +
                " Notes = '" + this.Notes + "', " +
                " Status = '" + this.Status + "' " +
                " WHERE " +
                " ID = " + this.Id;
            Console.WriteLine(updateQuery);

            int returnCode = modifyDatabase(updateQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in updating Worker object into database");
            else
                Console.WriteLine("Worker object successfully updated");
        }
        //------------------------------------------------------------------
        public void delete()
        {
            string deleteQuery = "DELETE FROM Worker WHERE " +
                " BannerId = '" + this.BannerId + "'";
            Console.WriteLine(deleteQuery);
            int returnCode = modifyDatabase(deleteQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in deleting Worker object from database");
            else
                Console.WriteLine("Worker object successfully deleted");
        }
        //------------------------------------------------------------------
        public int GetWorkerId()
        {
            return this.Id;
        }
        public void SetBannerId(string value)
        {
            BannerId = value;
        }
        public string GetBannerId()
        {
            return BannerId;
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
            this.FirstName = value;
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

        public string GetCredential()
        {
            return Credential;
        }
        public void SetCredential(string value)
        {
            this.Credential = value;
        }

        public string GetInitialRegistrationDate()
        {
            return InitialRegistrationDate;
        }
        public void SetInitialRegistrationDate(string value)
        {
            this.InitialRegistrationDate = value;
        }

        public string GetWorkerPassword()
        {
            return WorkerPassword;
        }
        public void SetWorkerPassword(string value)
        {
            this.WorkerPassword = value;
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
