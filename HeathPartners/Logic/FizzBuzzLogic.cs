namespace Logic
{
    public class FizzBuzzLogic : IFizzBuzzLogic
    {
        public IEnumerable<string> Solve(IEnumerable<object> data)
        {
            foreach (var item in data) 
            {
                _ = ProcessSingleRow(item);
            }

            return null;
        }

        private string ProcessSingleRow(object Number)
        {
            IsValid();

            return null;

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