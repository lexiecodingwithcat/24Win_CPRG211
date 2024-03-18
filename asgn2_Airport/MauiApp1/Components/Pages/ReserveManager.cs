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

   public class ReserveManager
        {

        public ReserveManager() { 
          PopulateReservation();
          }
        // create a list holding all reserves populated from file
        public static List<Reservation> reserveList = new List<Reservation>();
        public static string reserve_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\Resources\Files\reservations.csv");
       
   
        //a method creating random reservation code
        public static string GenerateRandomNumber()
            {
            string code;
            Random random = new Random();
            char randomLetter1 = Convert.ToChar(random.Next('A', 'Z'));
            char randomLetter2 = Convert.ToChar(random.Next('A', 'Z'));
            string randomNumber = random.Next(1000, 10000).ToString();
            code = string.Concat(randomLetter1, randomLetter2) + randomNumber;
            return code;
            }

       // populate reservation from file
        public static void PopulateReservation()
           {
           reserveList.Clear();
            if (new FileInfo(reserve_file).Length > 0)
                {
                StreamReader sr = new StreamReader(reserve_file);
                string line = sr.ReadLine();
                while (line != null)
                    {
                    string[] parts = line.Split(",");
                    string oldCode = parts[0];
                    string oldName = parts[1];
                    string oldCitizen = parts[2];
                    string oldFrom = parts[3];
                    string oldTo = parts[4];
                    string oldAirline = parts[5];
                    string oldDay = parts[6];
                    string oldTime = parts[7];
                    Reservation rs = new Reservation(oldCode, oldName, oldCitizen, oldFrom, oldTo, oldAirline, oldDay, oldTime);
                    reserveList.Add(rs);
                    line = sr.ReadLine();
                    }
                sr.Close();
                }
          }

        //public static List<Reservation> LoadReservations()
        //   {
        //   List<Reservation> res = new List<Reservation>();
        //   string line;
        //    using (StreamReader reader = new StreamReader(reserve_file))
        //        {
        //        line = reader.ReadLine();
        //        while(line != null)
        //            {
        //             string[] parts = line.Split(",");
        //            string oldCode = parts[0];
        //            string oldName = parts[1];
        //            string oldCitizen = parts[2];
        //            string oldFrom = parts[3];
        //            string oldTo = parts[4];
        //            string oldAirline = parts[5];
        //            string oldDay = parts[6];
        //            string oldTime = parts[7];
        //            Reservation rs = new Reservation(oldCode, oldName, oldCitizen, oldFrom, oldTo, oldAirline, oldDay, oldTime);
        //            reserveList.Add(rs);
        //     }
        //    }
        //   reserveList = res;
        //    return res;
        //   }
      

        } 
    }

