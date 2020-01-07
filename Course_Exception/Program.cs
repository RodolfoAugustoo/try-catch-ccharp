using System;
using Course_Exception.Entities;

namespace Course_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkin >= checkout)
            {
                Console.WriteLine("Error! Check-out must be after check-in! ");
            }
            else
            {
                Reservation res = new Reservation(num, checkin, checkout);
                Console.WriteLine("\r\n" + res.ToString());

                Console.WriteLine("\r\nEnter the data to update the reservation: ");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if (checkin < now || checkout < now)
                {
                    Console.WriteLine("Error in reservation! Reservation dates must be future date. ");
                }
                else if (checkout <= checkin)
                {
                    Console.WriteLine("Error! Check-out must be after check-in. ");
                }
                else
                {
                    res.UpdateDates(checkin, checkout);
                    Console.WriteLine("\r\nReservation: " + res.ToString());
                }                
            }
        }
    }
}
