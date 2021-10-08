using System;
using System.Collections.Generic;
using System.Text;

namespace SDLCHotelBooking
{
    class CustomerPublish //publisher
    {
        public delegate void CustomerCollectionUpdated(string customerName);
        public event CustomerCollectionUpdated customerAdded;
        private List<Customer> customerList = new List<Customer>();
        public List<Customer> GetCustomer()
        {
            return customerList;
        }
        public void AddCustomer(string name)
        {
            Customer customer = new Customer(name);
            customerList.Add(customer);
            customerAdded?.Invoke(name);
        }
    }
}
