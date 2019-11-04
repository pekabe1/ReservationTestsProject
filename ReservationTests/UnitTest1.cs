using NUnit.Framework;
using ReservationTestsProject;

namespace Tests
{
    public class ReservationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanBeCancelledBy_Admin_ReturnsTrue()
        {
            Reservation reservation = new Reservation();
            User Admin = new User { isAdmin = true };
            reservation.MadeBy = Admin;
            var result = reservation.CanBeCancelledBy(Admin);
            Assert.IsTrue(result);
        }


        [Test]
        public void CanBeCancelledBy_User_ReturnsFalse()
        {
            Reservation reservation = new Reservation();
            User user = new User { isAdmin = false };
            User Admin = new User { isAdmin = true };
            reservation.MadeBy = Admin;
            var result = reservation.CanBeCancelledBy(user);
            Assert.False(result);
        }
    }
}