namespace CalculatorLib
{


    public class SquareRoot
    {

        public decimal Do(decimal? x, decimal? y)
        {

            decimal ret = 0;

            decimal Sqrt(decimal x, decimal? guess = null)


            {
                var ourGuess = guess.GetValueOrDefault(x / 2m);
                var ret = x / ourGuess;
                var average = (ourGuess + ret) / 2m;

                if (average == ourGuess) // This checks for the maximum precision possible with a decimal.
                    ret = average;
                else
                    return Sqrt(x, average);
            }


              return ret;
        }

    }
}