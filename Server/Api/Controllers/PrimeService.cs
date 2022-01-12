namespace Api.Controllers
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }

            }

            return true;
        }

        public bool Compare(int number1, int number2)
        {
            return number1 > number2;
        }
    }
}
