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
        //save the path of file
        public static string airportFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\Resources\Files\airports.csv");
        public static string flightFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\Resources\Files\flights.csv");

        //save flights from the flight.cvs
        public static List<Flight> flightList = new List<Flight>();
        //save airport from the airports.cvs
        public static List<string> airportList = new List<string>();
        public static List<string> weekdayList = new List<string>() { "Monday", "Tuesday", "Wednesday","Thursday","Friday","Saturday","Sunday"};
        //save flights which have been found
        public static List<Flight> foundFlight = new List<Flight>();
        
        //constructor: populate data when there is a new object
        public FlightManager() { 
            PopulateAirportFile();
            PopulateFlightFile();
            }


        public static void PopulateAirportFile()
            {
            airportList.Clear();

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

        public static void PopulateFlightFile()
        {
            flightList.Clear();
            StreamReader sr = new StreamReader(flightFile);
            string line= sr.ReadLine();
            while (line != null)
                {
                string[] part = line.Split(",");
                string code = part[0];
                string airline = part[1];
                string depature = part[2];
                string destination = part[3];
                string day = part[4];
                string time = part[5];
                int seatNumber = Convert.ToInt32(part[6]);
                double price = Convert.ToDouble(part[7]);
                Flight flight  = new Flight(code, airline, depature, destination, day, time,seatNumber,price);
                flightList.Add(flight);
                line = sr.ReadLine();
                }
            }






        }

       
        


        
    }
