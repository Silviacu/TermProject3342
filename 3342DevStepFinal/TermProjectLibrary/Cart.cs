using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectLibrary
{
    [Serializable]
    public class Cart
    {
        private ArrayList hotels;
        private ArrayList flights;
        private ArrayList events;
        private ArrayList cars;

        public Cart()
        {
            hotels = new ArrayList();
            flights = new ArrayList();
            events = new ArrayList();
            cars = new ArrayList();
        }

        public ArrayList Hotels
        {
            get { return hotels; }
            set { hotels = value; }
        }
        public ArrayList Flights
        {
            get { return flights; }
            set { flights = value; }
        }
        public ArrayList Events
        {
            get { return events; }
            set { events = value; }
        }
        public ArrayList Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public void AddtoCart(VacationItem item)
        {
            if (item.IsHotel)
                hotels.Add(item);
            else if (item.IsFlight)
                flights.Add(item);
            else if (item.IsEvent)
                events.Add(item);
            else
                cars.Add(item);
        }

        public void ClearCart()
        {
            hotels.Clear();
            flights.Clear();
            events.Clear();
            cars.Clear();
        }

    }
}
