using static System.Console;

namespace Ch04Ex02PrimeFactorsLib
{
    public static class Primes
    {
        public static string PrimeFactors(int inputNumber)
        {
            List<int> primeFactors = []; 
            for (int numberToCheck = 2; numberToCheck <= inputNumber; numberToCheck++)
            {
                var inputNumberCopy = inputNumber;
                bool isPrimeNumber = true;

                for (var i = 2; i <= numberToCheck / 2; i++)
                {
                    if(numberToCheck % i == 0)
                    {
                        isPrimeNumber = false;
                        break ;
                    }
                }

                WriteLine(isPrimeNumber ? $"{numberToCheck} is prime number" : $"{numberToCheck} is not prime number");

                if (isPrimeNumber)
                {
                    while (inputNumberCopy % numberToCheck == 0)
                    {
                        primeFactors.Add(numberToCheck);
                        inputNumberCopy /= numberToCheck;
                    }
                }
            }

            primeFactors.Reverse();

            return primeFactors.Count > 1 ? $"Prime factors of {inputNumber} are {String.Join(" x ", primeFactors)}" : $"Prime factor of {inputNumber} is {inputNumber}";
        }
    }
}
