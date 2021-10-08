using System;
using System.Collections.Generic;
using System.Text;

namespace SDLCHotelBooking
{
    class CustomerSubscribe //subscriber
    {
        public void SubscribeToEvent(CustomerPublish customerPublish)
        {
            customerPublish.customerAdded += CustomerPublish_customerAdded;
        }
        private void CustomerPublish_customerAdded(string customerName)
        {
            Console.WriteLine(customerName + " is registered.\n");
        }
    }
}
