using System;
using Course_Exception.Entities;
using Course_Exception.Entities.Exceptions;

namespace Course_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation res = new Reservation(num, checkin, checkout);
                Console.WriteLine("\r\n" + res.ToString());

                Console.WriteLine("\r\nEnter the data to update the reservation: ");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("\r\nReservation: " + res.ToString());
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error!: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error! " + e.Message);
            }
        }
    }
}
