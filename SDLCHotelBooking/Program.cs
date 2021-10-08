using System;
using System.Collections.Generic;
using System.Linq;
//I want to design a room booking software for my hotel, so that all my bookings will be transparent for taxation. And I can search the data to find a customer
namespace SDLCHotelBooking
{    
    class Program
    {
        static void Main(string[] args)
        {
            CustomerPublish customerPublish = new CustomerPublish();
            Room room = new Room();
            RoomDetailsCollection saveDetails = new RoomDetailsCollection();

            double afterTaxRegular = room.regularRoomPrice * 1.07;
            double afterTaxDeluxe = room.deluxeRoomPrice * 1.07;
            double afterTaxSuite = room.suiteRoomPrice * 1.07;

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("--SDLC Hotel Booking--");
                Console.WriteLine("1. Register customer");
                Console.WriteLine("2. Book a room");
                Console.WriteLine("3. Search customers by room");
                int input = Int32.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter customer name: ");
                            string inputName = Console.ReadLine();
                            customerPublish.AddCustomer(inputName);
                            Console.WriteLine(inputName + " added!\n");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter customer name to book: ");
                            string inputName = Console.ReadLine();
                            Customer customerObj = null;
                            foreach (Customer customer in customerPublish.GetCustomer())
                            {
                                if (string.Equals(inputName, customer.customername))
                                {
                                    customerObj = customer;
                                }
                            }
                            if (customerObj != null)
                            {
                                Console.WriteLine("Select room to book:");
                                Console.WriteLine("1. Regular $100");
                                Console.WriteLine("2. Deluxe $500");
                                Console.WriteLine("3. Suite $1000");
                                int selectRoom = Int32.Parse(Console.ReadLine());
                                if (selectRoom == 1)
                                {
                                    Console.WriteLine("The total bill for " + inputName + " after tax is: $" + afterTaxRegular);
                                    saveDetails.RegularObj.Add(inputName);
                                }
                                if (selectRoom == 2)
                                {
                                    Console.WriteLine("The total bill for " + inputName + " after tax is: $" + afterTaxDeluxe);
                                    saveDetails.DeluxeObj.Add(inputName);
                                }
                                if (selectRoom == 3)
                                {
                                    Console.WriteLine("The total bill for " + inputName + " after tax is: $" + afterTaxSuite);
                                    saveDetails.SuiteObj.Add(inputName);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Customer does not exist.");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Select room to search:");
                            Console.WriteLine("1. Regular");
                            Console.WriteLine("2. Deluxe");
                            Console.WriteLine("3. Suite");
                            int selectRoomSearch = Int32.Parse(Console.ReadLine());
                            if (selectRoomSearch == 1)
                            {
                                Console.WriteLine("Currently staying in a regular room:");
                                foreach (var regular in saveDetails.RegularObj)
                                {
                                    Console.WriteLine(regular);
                                }
                            }
                            if (selectRoomSearch == 2)
                            {
                                Console.WriteLine("Currently staying in a deluxe room:");
                                foreach (var deluxe in saveDetails.DeluxeObj)
                                {
                                    Console.WriteLine(deluxe);
                                }
                            }
                            if (selectRoomSearch == 1)
                            {
                                Console.WriteLine("Currently staying in a suite:");
                                foreach (var suite in saveDetails.SuiteObj)
                                {
                                    Console.WriteLine(suite);
                                }
                            }
                            //foreach (var roomtype in saveDetails.DetailsDictObj)
                            //{
                            //    if (selectRoomSearch == 1 && roomtype.Key == afterTaxRegular)
                            //    {
                            //        Console.WriteLine(roomtype.Value.customername);
                            //    }
                            //    if (selectRoomSearch == 2 && roomtype.Key == afterTaxDeluxe)
                            //    {
                            //        Console.WriteLine(roomtype.Value.customername);
                            //    }
                            //    if (selectRoomSearch == 3 && roomtype.Key == afterTaxSuite)
                            //    {
                            //        Console.WriteLine(roomtype.Value.customername);
                            //    }
                            //}  
                            break;
                        }
                }
            }
        }

    }

}
