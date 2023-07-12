using Logic;

namespace Tests
{
    [TestClass]
    public class FizBuzzTests
    {


        [TestMethod]
        public void Solve_ThrowsExceptionWhenOutOfRange()
        {
            //Arrange
            IFizzBuzzLogic logic = new FizzBuzzLogic();

            //Act
            List<object> data = new()
            {
                -1
            };

            //Assert
            Assert.ThrowsException<InvalidObjectPassedInException>(() => { logic.Solve(data); });
        }
    }
}