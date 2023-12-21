using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UniteTests
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void CanBeCancelledByAdmin_True()
        {
            var adminUser = new User { IsAdmin = true };
            var reservation = new Reservation(new User());

            bool result = reservation.CanBeCancelledBy(adminUser);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledByUser_True()
        {
            var user = new User();
            var reservation = new Reservation(user);

            bool result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledByOtherUser_False()
        {
            var reservation = new Reservation(new User());
            var otherUser = new User();

            bool result = reservation.CanBeCancelledBy(otherUser);

            Assert.IsFalse(result);
        }

        /*

        [TestMethod]
        public void CanBeCancelledBy_NullUser_ReturnsFalse()
        {
            var reservation = new Reservation(new User());

            bool result = reservation.CanBeCancelledBy(null);

            Assert.IsFalse(result);
        }

        */
    }
}
