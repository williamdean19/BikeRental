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
    class Fine : Persistable
    {
        private int Id { get; set; }

        private int BorrowerId
        {
            get;
            set;
        }

        private string FineAmt
        {
            get;
            set;
        }

        private string DateFineImposed
        {
            get;
            set;
        }

        private string Status
        {
            get;
            set;
        }

        public Fine()
            : base()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source= C:\Users\Will\Documents\visual studio 2013\Projects\BikeRentalGUIFinal\BikeRentalGUIFinal" +
                @"\BicycleRental.accdb";
        }

        public Fine(int borrowerId, string fineAmt, string dateFineImposed, string status)
            : base()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source= C:\Users\Will\Documents\visual studio 2013\Projects\BikeRentalGUIFinal\BikeRentalGUIFinal" +
                @"\BicycleRental.accdb";

            this.BorrowerId = borrowerId;
            this.FineAmt = fineAmt;
            this.DateFineImposed = dateFineImposed;
            this.Status = status;
        }

        public void populate(int Id)
        {
            string queryString = "SELECT * FROM Fine WHERE (ID = " + Id + ")";
            List<Object> results = getValues(queryString);
            if (results != null)
            {
                foreach (object result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;
                    int count = 0;
                    foreach (object rowValue in row)
                    {
                        // DEBUG Console.WriteLine(rowValue);
                        if (count == 0)
                            this.Id = Convert.ToInt32(rowValue);
                        if (count == 1)
                            this.BorrowerId = Convert.ToInt32(rowValue);
                        else if (count == 2)
                            FineAmt = Convert.ToString(rowValue);
                        else if (count == 3)
                            DateFineImposed = Convert.ToString(rowValue);
                        else if (count == 4)
                            Status = Convert.ToString(rowValue);
                        count = count + 1;
                    }
                }
            }
        }

        public void insert()
        {

            string insertQuery =
            "INSERT INTO Fine (BorrowerID, FineAmount, DateFineImposed, Status) " +
            "VALUES (" +
            this.BorrowerId + ", '" +
            this.FineAmt + "', '" +
            this.DateFineImposed + "', '" +
            this.Status + "')";
            int returnCode = modifyDatabase(insertQuery);
            if (returnCode != 0)
            {
                Console.WriteLine("Error in inserting Fine object into database");
            }
            else
            {
                Console.WriteLine("Fine object successfully inserted");
                string idQueryString = "SELECT MAX(ID) FROM Fine";
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
                            this.BorrowerId = Convert.ToInt32(rowValue);
                        }
                    }
                }
            }
        }

        public void update()
        {
            string updateQuery = "UPDATE Fine SET " +
                " BorrowerID = " + this.BorrowerId + ", " +
                " FineAmount = '" + this.FineAmt + "' ," +
                " DateFineImposed = '" + this.DateFineImposed + "' ," +
                " Status = '" + this.Status + "'" +
                " WHERE " +
                " ID = " + this.Id;
            Console.WriteLine(updateQuery);
            int returnCode = modifyDatabase(updateQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in updating Fine object into database");
            else
                Console.WriteLine("Fine object successfully updated");
        }

        public void delete()
        {
            string deleteQuery = "DELETE FROM Fine WHERE " +
                " ID = " + this.BorrowerId;
            Console.WriteLine(deleteQuery);
            int returnCode = modifyDatabase(deleteQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in deleting Fine object from database");
            else
                Console.WriteLine("Fine object successfully deleted");
        }

        public int getBorrowerId()
        {
            return BorrowerId;
        }

        public void setBorrowerId(int value)
        {
            this.BorrowerId = value;
        }

        public string getFineAmt()
        {
            return this.FineAmt;
        }

        public void setFineAmt(string value)
        {
            this.FineAmt = value;
        }

        public string getDateFineImposed()
        {
            return DateFineImposed;
        }

        public void setDateFineImposed(string value)
        {
            this.DateFineImposed = value;
        }

        public string getStatus()
        {
            return Status;
        }

        public void setStatus(string value)
        {
            this.Status = value;
        }
    }
}
