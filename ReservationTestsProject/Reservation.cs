using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationTestsProject
{
    public class Reservation
    {
        public User MadeBy { get; set; }
        public bool CanBeCancelledBy(User user)
        {
            //if (user.isAdmin)

            //    return true;

            //if (user == MadeBy)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}


            //if (user.isAdmin == true || MadeBy == user)
            //{
            //    return true;
            //}
            //return false;

            return user.isAdmin || MadeBy == user; // Code Sugar
        }
    }
}

