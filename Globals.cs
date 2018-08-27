using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalGUIFinal
{
    public static class Globals
    {
        public static string DatabaseLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\BicycleRental.accdb";
        public static string Access2013ConnectionString =@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=" + DatabaseLocation;
    }
}
