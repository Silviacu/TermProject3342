using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace _3342DevStepFinal
{
    [Serializable]
    public class UserVacation
    {
        public List<Experiences.Activities> activity;
        public List<int> activityQuan;
        public List<Flights.FlightClass> flight;
        public List<int> flightQuan;
        public List<Hotels.Room> room;
        public List<int> roomQuan;
        public List<Cars.Car> car;
        public List<int> carQuan;

        public UserVacation()
        {
            activity = new List<Experiences.Activities>();
            activityQuan = new List<int>();
            flight = new List<Flights.FlightClass>();
            flightQuan = new List<int>();
            room = new List<Hotels.Room>();
            roomQuan = new List<int>();
            car = new List<Cars.Car>();
            carQuan = new List<int>();
        }
    }
}