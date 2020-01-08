using System;
using Course_Exception.Entities.Exceptions;

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
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error! Check-out must be after check-in. ");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut - CheckIn;
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Error in reservation! Reservation dates must be future date. ");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error! Check-out must be after check-in. ");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
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
