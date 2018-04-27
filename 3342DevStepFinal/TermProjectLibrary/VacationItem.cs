using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectLibrary
{
    [Serializable]
    public class VacationItem
    {
        private string description;
        private double price;
        private int quantity;
        private int carID;
        private int hotelID;
        private int roomID;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int flightID;
        private int airCarrierID;
        private int eventID;
        private bool isCar;
        private bool isHotel;
        private bool isFlight;
        private bool isEvent;

        public VacationItem()
        {
            description = "";
            price = 0;
            quantity = 1;
            carID = 0;
            hotelID = 0;
            roomID = 0;
            flightID = 0;
            eventID = 0;
        }

        public string CarAgencyName
        { get; set; }

        public string CarAgencyCity
        { get; set; }

        public string CarAgencyState
        { get; set; }

        public int EventAgencyID
        { get; set; }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool IsCar
        {
            get { return isCar; }
            set { isCar = value; }
        }

        public bool IsHotel
        {
            get { return isHotel; }
            set { isHotel = value; }
        }

        public bool IsFlight
        {
            get { return isFlight; }
            set { isFlight = value; }
        }

        public bool IsEvent
        {
            get { return isEvent; }
            set { isEvent = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int CarID
        {
            get { return carID; }
            set { carID = value; }
        }

        public int HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }

        public int FlightID
        {
            get { return flightID; }
            set { flightID = value; }
        }

        public int AirCarrierID
        {
            get { return airCarrierID; }
            set { airCarrierID = value; }
        }

        public int EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }
    }
}
