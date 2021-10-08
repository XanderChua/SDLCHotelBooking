using System;
using System.Collections.Generic;
using System.Text;

namespace SDLCHotelBooking
{
    class Room
    {
        private const double regularPrice = 100.00;
        private const double deluxePrice = 500.00;
        private const double suitePrice = 1000.00;
        public double regularRoomPrice
        {
            get
            {
                return regularPrice;
            }
        }
        public double deluxeRoomPrice
        {
            get
            {
                return deluxePrice;
            }
        }
        public double suiteRoomPrice
        {
            get
            {
                return suitePrice;
            }
        }
    }
}
