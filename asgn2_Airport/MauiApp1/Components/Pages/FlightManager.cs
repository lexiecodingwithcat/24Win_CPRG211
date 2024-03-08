using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MauiApp1.Components.Pages
    {
    internal class FlightManager
        {
        //save flights from the flight.cvs
        public static List<Flight> flightList = new List<Flight>();
        //save airport from the airports.cvs
        public static List<string> airportList = new List<string>();
        public static List<string> weekdayList = new List<string>() { "Monday", "Tuesday", "wednesday","Thursday","Friday","Saturday","Sunday"};
        //constructor: populate data when there is a new object
        public FlightManager() { 
            PopulateAirportFile();
            }


        public static void PopulateAirportFile()
            {
            airportList.Clear();
            string airportFile = @"D:\SAIT\c#\Assignment2_Skeleton\airports.csv";
            //oepn the file
            StreamReader sr = new StreamReader(airportFile);
            string line=  sr.ReadLine();
            while (line != null)
                {
            string[] part = line.Split(",");
             string apCode = part[0];
             
              airportList.Add(apCode);
             line = sr.ReadLine();
             }
            }

            }
        


        
    }
