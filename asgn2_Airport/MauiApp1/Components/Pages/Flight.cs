using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Components.Pages
    {
    internal class Flight
        {

        public string Code { get; set; }
        public string Airline { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string WeekDay { get; set; }
        public string Time { get; set; }
        public int SeatNum { get; set; }
        public double Price { get; set; }

        //constructor 
        public Flight(string code, string airline, string departuer, string destination, string weekDay, string time,int seatNum, double price)
            {
            Code = code;
            Airline = airline;
            Departure = departuer;
           Destination = destination;
            WeekDay = weekDay;
            Time = time;
           SeatNum = seatNum;
            Price = price;
            }






        }
    }
