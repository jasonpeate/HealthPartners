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
                10,
                20,
                input,
                90
            };

            //Assert
            Assert.ThrowsException<InvalidObjectPassedInException>(() => { logic.Solve(data); });
        }

        [TestMethod]
        [DataRow("asdfasdfas")]
        [DataRow(10.9999)]
        public void Solve_ThrowsExceptionWhenNotAInterger(object input)
        {
            //Arrange
            IFizzBuzzLogic logic = new FizzBuzzLogic();

            //Act
            List<object> data = new()
            {
                9,
                input,
                8
            };

            //Assert
            Assert.ThrowsException<InvalidObjectPassedInException>(() => { logic.Solve(data); });
        }

        [TestMethod]
        public void Solve_ReturnsNumbersWhenNothingDivisibleBy3or5()
        {
            //Arrange
            IFizzBuzzLogic logic = new FizzBuzzLogic();

            //Act
            List<object> data = new()
            {
                1,7,11,19
            };

            //Assert
            CollectionAssert.AreEqual(data.Select(a => a.ToString()).ToList(), logic.Solve(data).ToList()); //TODO : find a better way of doing this not ToList
        }
    }
}