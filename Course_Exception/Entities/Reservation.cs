using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Exception.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut - CheckIn;
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkin, DateTime checkout)
        {
            CheckIn = checkin;
            CheckOut = checkout;


            DateTime now = DateTime.Now;

            if (checkin < now || checkout < now)
            {
                return "Error in reservation! Reservation dates must be future date. ";
            }
            if (checkout <= checkin)
            {
                return "Error! Check-out must be after check-in. ";
            }

            return null;
        }

        public override string ToString()
        {
            return  "Room "
                    +RoomNumber
                    +", checkin: "
                    +CheckIn.ToString("dd/MM/yyyy")
                    +", checkout"
                    +CheckOut.ToString("dd/MM/yyyy")
                    +", "
                    +Duration()
                    +" nights";
        }
    }
}
