﻿using System;
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

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            CheckIn = checkin;
            CheckOut = checkout;
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
