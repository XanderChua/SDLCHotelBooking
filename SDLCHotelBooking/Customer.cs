using System;
using System.Collections.Generic;
using System.Text;

namespace SDLCHotelBooking
{
    public class Customer
    {
        public string customername { get; private set; }
        public Customer(string name)
        {
            customername = name;
        }
    }
}
