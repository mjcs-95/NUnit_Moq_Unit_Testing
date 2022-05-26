using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.TestNinja;

namespace TestNinja.UnitTest
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            //Act
            
            //Assert
        }
        [TestMethod]
        public void CanBeCancelledBy_MadeBy_ReturnsTrue()
        {
        }
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsFalse()
        {
        }
    }
}
