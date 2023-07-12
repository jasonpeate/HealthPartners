using Logic;

namespace Tests
{
    [TestClass]
    public class FizBuzzTests
    {


        [TestMethod]
        [DataRow(-2)]
        [DataRow(105)]
        [DataRow(0)]
        public void Solve_ThrowsExceptionWhenOutOfRange(int input)
        {
            //Arrange
            IFizzBuzzLogic logic = new FizzBuzzLogic();

            //Act
            List<object> data = new()
            {
                input
            };

            //Assert
            Assert.ThrowsException<InvalidObjectPassedInException>(() => { logic.Solve(data); });
        }
    }
}