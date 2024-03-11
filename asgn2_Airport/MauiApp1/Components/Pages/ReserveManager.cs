using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Components.Pages
    {
    internal class ReserveManager
        {
        // create a list holding all reserves
        public static List<Reservation> reserverList = new List<Reservation>();

        //a method creating random reservation code
        public static string GenerateRandomNumber()
            {
            string code;
            Random random = new Random();   
            code = random.Next(1000,10000).ToString(); 
            return code;
            }



        }
    }
