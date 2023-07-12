namespace Logic
{
    public class FizzBuzzLogic : IFizzBuzzLogic
    {
        public IEnumerable<string> Solve(IEnumerable<object> data)
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
        }

    }
}