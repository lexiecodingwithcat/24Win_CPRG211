using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Components.Pages
    {
    internal class Flight
        {
        string code;
        string airline;
        string departure;
        string destination;
        string weekDay;
        string time;
        int seatNum;
        double price;

        public string Code { get { return code; } set {  code = value; } }
        public string Airline { get {  return airline; } set {  airline = value; } }
        public string Departure { get {  return departure; } set {  departure = value; } }  
        public string Destination { get;set; }
        public string Time { get { return time; } set { time = value; } } 
        public int SeatNum { get {  return seatNum; } set {  seatNum = value; } }
        public double Price { get { return price; } set { price = value; } }    

        //constructor 
        public Flight(string code, string airline, string depatuer, string destination, string weekDay, string time,int seatNum, double price)
            {
            this.code = code;
            this.airline = airline;
            this.departure = depatuer;
            this.destination = destination;
            this.weekDay = weekDay;
            this.time = time;
            this.seatNum = seatNum;
            this.price = price;
            }






        }
    }
