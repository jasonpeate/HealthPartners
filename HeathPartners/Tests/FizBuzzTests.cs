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
            CollectionAssert.AreEqual(data.Select(a => a.ToString()).ToList(), logic.Solve(data)); 
        }

        [TestMethod]
        public void Solve_ReturnsFizzWhenDivisibleBy3InRange()
        {
            //Arrange
            IFizzBuzzLogic logic = new FizzBuzzLogic();

            //Act
            List<object> data = new()
            {
                3,6,9,12,66,99
            };

            List<string> result = data.Select(a => Constants.Fizz).ToList();

            //Assert
            CollectionAssert.AreEqual(result, logic.Solve(data));
        }

        [TestMethod]
        [DataRow(11)]
        [DataRow(19)]
        [DataRow(37)]
        public void Solve_ReturnsFizzWhenDivisibleBy3WithNumbersInRange(object input)
        {
            //Arrange
            IFizzBuzzLogic logic = new FizzBuzzLogic();

            //Act
            List<object> data = new()
            {
                3,6,9,12,66,99,input
            };

            List<string> result = new();

            data.ForEach(a =>
            {
                if (a is int toProcess)
                {
                    if ((toProcess % 3) == 0)
                    {
                        result.Add(Constants.Fizz);
                    }
                    else
                    {
                        result.Add(toProcess.ToString());
                    }
                }
            });

            //Assert
            CollectionAssert.AreEqual(result, logic.Solve(data));
        }


        [TestMethod]
        public void Solve_ReturnsBuzzWhenDivisibleBy5InRange()
        {
            //Arrange
            IFizzBuzzLogic logic = new FizzBuzzLogic();

            //Act
            List<object> data = new()
            {
                5,25,40
            };

            List<string> result = data.Select(a => Constants.Buzz).ToList();

            //Assert
            CollectionAssert.AreEqual(result, logic.Solve(data));
        }

        [TestMethod]
        [DataRow(11)]
        [DataRow(19)]
        [DataRow(37)]
        public void Solve_ReturnsBuzzWhenDivisibleBy5WithNumbersInRange(object input)
        {
            //Arrange
            IFizzBuzzLogic logic = new FizzBuzzLogic();

            //Act
            List<object> data = new()
            {
                5,25,55,input
            };

            List<string> result = new();

            data.ForEach(a =>
            {
                if (a is int toProcess)
                {
                    if ((toProcess % 5) == 0)
                    {
                        result.Add(Constants.Buzz);
                    }
                    else
                    {
                        result.Add(toProcess.ToString());
                    }
                }
            });

            //Assert
            CollectionAssert.AreEqual(result, logic.Solve(data));
        }
    }
}