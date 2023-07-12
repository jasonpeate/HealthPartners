namespace Logic
{
    public class FizzBuzzLogic : IFizzBuzzLogic
    {
        public List<string> Solve(IEnumerable<object> data)
        {
            List<string> result = new();

            foreach (var item in data) 
            {
                result.Add(ProcessSingleRow(item));
            }

            return result;
        }

        private string ProcessSingleRow(object Number)
        {
            int NumberToProcess = IsValid();

            if (IsDivisibleBy(3) && IsDivisibleBy(5))
            {
                return Constants.FizzBuzz;
            }
            else if (IsDivisibleBy(3))
            {
                return Constants.Fizz;
            } 
            else if (IsDivisibleBy(5))
            {
                return Constants.Buzz;
            }

            return NumberToProcess.ToString();

            int IsValid()
            {
                if (Number is int AsNumber)
                {
                    if (AsNumber < 1 || AsNumber > 100)
                    {
                        throw new InvalidObjectPassedInException();
                    }

                    return AsNumber;
                } 
                else
                {
                    throw new InvalidObjectPassedInException();
                }
            }

            bool IsDivisibleBy(int divisible)
            {
                return (NumberToProcess % divisible) == 0;
            }
        }

    }
}