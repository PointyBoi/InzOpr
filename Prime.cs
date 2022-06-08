namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                throw new NotImplementedException($"Number {candidate} is too low.");
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    throw new NotImplementedException("Not implemented.");
                }
            }

            return true;
        }
    }
}

