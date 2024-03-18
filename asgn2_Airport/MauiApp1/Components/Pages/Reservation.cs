using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Components.Pages
    {
     public class Reservation
        {
       public string ReserveCode { get; set; }
        public string ReserveName { get; set; }
        public string ReserveCitizenship { get; set; }
        public string ReserveAirline { get; set; }
        public string ReserveDeparture { get; set; }
        public string ReserveDestination { get; set; }
        public string ReserveTime { get; set; }
        public string ReserveDay { get; set; }
        public Reservation(string code,string name, string citizenship, string reserveDeparture, string reserveDestination,string airline, string reserveDay, string reserveTime) {
            ReserveCode = code;
            ReserveName = name;
            ReserveCitizenship = citizenship;
            ReserveDeparture = reserveDeparture;
            ReserveDestination = reserveDestination;
            ReserveAirline = airline;
            ReserveDay = reserveDay;
            ReserveTime = reserveTime;
            }





        }
    }
