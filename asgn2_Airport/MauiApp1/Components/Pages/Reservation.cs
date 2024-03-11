using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Components.Pages
    {
    internal class Reservation
        {
        //string ReserveCode { get; set; }
        string ReserveName { get; set; }    
        string ReserveCitizenship { get; set; }
        string ReserveAirline { get; set; }
        public Reservation(string name, string citizenship, string airline) {
            //ReserveCode = code;
            ReserveName = name;
            ReserveCitizenship = citizenship;
            ReserveAirline = airline;
            }





        }
    }
