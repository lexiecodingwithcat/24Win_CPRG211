using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Components.Pages
    {
    internal class Reservation
        {
        public string ReserveCode { get; set; }
        public string ReserveName { get; set; }    
        public string ReserveCitizenship { get; set; }
        public string ReserveAirline { get; set; }
        public Reservation(string code,string name, string citizenship, string airline) {
            ReserveCode = code;
            ReserveName = name;
            ReserveCitizenship = citizenship;
            ReserveAirline = airline;
            }





        }
    }
