
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MauiApp1.Components.Pages
    {
    internal class ReserveManager
        {

        // create a list holding all reserves populated from file
        public static List<Reservation> reserveList = new List<Reservation>();
        public static string reserve_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\Resources\Files\reservations.csv");

       public ReserveManager()
          {
          PopulateReservation();
         }

        //a method creating random reservation code
        public static string GenerateRandomNumber()
            {
            string code;
            Random random = new Random();
            char randomLetter1 = Convert.ToChar(random.Next('A', 'Z'));
            char randomLetter2 = Convert.ToChar(random.Next('A', 'Z'));
            string randomNumber = random.Next(1000,10000).ToString();
            code = string.Concat(randomLetter1,randomLetter2)+randomNumber ;
            return code;
            }

        //populate reservation from file
       public static void PopulateReservation()
            {
            StreamReader sr = new StreamReader(reserve_file);
            string line;
            using (sr)
                {
                line = sr.ReadLine();
                string[] parts = line.Split(",");
                string oldCode = parts[0];
                string oldName = parts[1];
                string oldCitizen = parts[2];   
                string oldAirline = parts[3];
                Reservation rs = new Reservation(oldCode, oldName, oldCitizen, oldAirline);
                reserveList.Add(rs);
                }
            }




        }
    }
