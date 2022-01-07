using System;

namespace Numbers_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"...I'm sorry. Something went wrong here. {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"|                                                                  |");
                Console.WriteLine($"|                            Goodbye!                              |");
                Console.WriteLine($"|                                                                  |");
                Console.WriteLine($"--------------------------------------------------------------------");
            }
        }

        static void StartSequence()
        {
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($"|                                                                  |");
            Console.WriteLine($"|                          NUMBERS GAME                            |");
            Console.WriteLine($"|                                                                  |");
            Console.WriteLine($"|------------------------------------------------------------------|");
            Console.WriteLine($"|                                                                  |");
            Console.WriteLine($"|                   Hello! Please give me a number.                |");
            Console.WriteLine($"|                                                                  |");
            Console.WriteLine($"|                     Preferably between 1 and 10.                 |");
            Console.WriteLine($"|                                                                  |");
            Console.WriteLine($"|                  This is how big the array will be.              |");
            Console.WriteLine($"|                                                                  |");
            Console.WriteLine($"--------------------------------------------------------------------");

            Console.WriteLine($" ");
            string userInput = Console.ReadLine();
            Console.WriteLine($" ");

            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($" ");
            Console.WriteLine($"                                 Okay!                              ");
            Console.WriteLine($" ");
            Console.WriteLine($"               The array will have {userInput} numbers in it!       ");
            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");

            try
            {
                //convert the user’s input to an integer
                int userInputNumber = Convert.ToInt32(userInput);

                //Instantiate a new integer array that is the size the user just inputted.
                int[] newArray = new int[userInputNumber];

                //call the Populate method, arguments: int array (?)
                int[] populatedArray = Populate(newArray);

                //Capture the sum by calling the GetSum method
                int captureSum = GetSum(populatedArray);

                //Capture the product by calling the GetProduct method
                int captureProduct = GetProduct(populatedArray, captureSum);

                //Capture the quotient by calling the GetQuotient method
                decimal captureQuotient = GetQuotient(captureProduct);

                //output to the console the details of all these values
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"|                                                                  |");
                Console.WriteLine($"|                     The program has completed!                   |");
                Console.WriteLine($"|                                                                  |");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($" ");
                Console.WriteLine($"                        ...In Conclusion...                         ");
                Console.WriteLine($" ");
                Console.WriteLine($"                          The sum was:                              ");
                Console.WriteLine($"                          {captureSum}                              ");
                Console.WriteLine($" ");
                Console.WriteLine($" ");
                Console.WriteLine($"                          The product was:                          ");
                Console.WriteLine($"                          {captureProduct}                          ");
                Console.WriteLine($" ");
                Console.WriteLine($" ");
                Console.WriteLine($"                          The quotient was:                         ");
                Console.WriteLine($"                          {captureQuotient}                         ");
                Console.WriteLine($" ");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"|                                                                  |");
                Console.WriteLine($"|                          Thanks for playing!                     |");
                Console.WriteLine($"|                                                                  |");
                Console.WriteLine($"--------------------------------------------------------------------");
            }
            catch (FormatException exc)
            {
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($" ");
                Console.WriteLine($"Error: {exc.Message}");
                Console.WriteLine($" ");
                Console.WriteLine($"--------------------------------------------------------------------");
            }
        }

        static int[] Populate(int[] numArr)
        {
            //Iterate through the array 
            for (int i = 0; i < numArr.Length; i++)
            {
                //prompt the user to enter a specific number
                Console.WriteLine($" ");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"|                                                                  |");
                Console.WriteLine($"|                         Please enter a number.                   |");
                Console.WriteLine($"|                                                                  |");
                Console.WriteLine($"|                   I will ask until the array is full.            |");
                Console.WriteLine($"|                                                                  |");
                Console.WriteLine($"--------------------------------------------------------------------");

                //Store the response into a string first
                Console.WriteLine($" ");
                string userInput = Console.ReadLine();
                Console.WriteLine($" ");

                //convert the user’s input to an integer
                int toNumber = Convert.ToInt32(userInput);

                //Add the number just inputted into the array
                numArr[i] = toNumber;

                Console.WriteLine($" ");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($" ");
                Console.WriteLine("                    The array so far is: [{0}]", string.Join(", ", numArr));
                Console.WriteLine($" ");
                Console.WriteLine($"--------------------------------------------------------------------");
            }

            //return the populated array
            return numArr;
        }

        static int GetSum(int[] sumArray)
        {
            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($"|                                                                  |");
            Console.WriteLine($"|                           GET THE SUM                            |");
            Console.WriteLine($"|                                                                  |");
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($" ");
            Console.WriteLine($"                             Okay, thanks!                          ");
            Console.WriteLine($" ");
            Console.WriteLine($"                       Now, I'll add them all up!                   ");
            Console.WriteLine($" ");

            //Declare an integer variable named sum
            int sum = 0;

            //Iterate through the array
            for (int i = 0; i < sumArray.Length; i++)
            {
                //populate the sum variable with the sum of all the numbers together.
                sum += sumArray[i];
            }

            Console.WriteLine($" ");
            Console.WriteLine($"                          ✧・ﾟ・✧・ﾟ・✧・ﾟ・✧                         ");
            Console.WriteLine($" ");
            Console.WriteLine($"                          ...Calculating...                         ");
            Console.WriteLine($" ");
            Console.WriteLine($"                          ✧・ﾟ・✧・ﾟ・✧・ﾟ・✧                         ");
            Console.WriteLine($" ");
            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($" ");
            Console.WriteLine($"              The sum of all numbers in your array is...            ");
            Console.WriteLine($" ");
            Console.WriteLine($" ");
            Console.WriteLine($"                                {sum}!");
            Console.WriteLine($" ");
            Console.WriteLine($" ");
            Console.WriteLine($"                  But how can we make that number bigger?           ");
            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");

            return sum;
        }

        static int GetProduct(int[] intArr, int sum)
        {
            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($"|                                                                  |");
            Console.WriteLine($"|                           GET THE PRODUCT                        |");
            Console.WriteLine($"|                                                                  |");
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($" ");
            Console.WriteLine($"                        Good idea.                                  ");
            Console.WriteLine($" ");
            Console.WriteLine($"                   Let's do some multiplication.                    ");
            Console.WriteLine($" ");
            Console.WriteLine($"                 Another number between 1 and {intArr.Length - 1}, please!");
            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");

            Console.WriteLine($" ");
            string userInput = Console.ReadLine();
            Console.WriteLine($" ");

            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($" ");
            Console.WriteLine($"                           You chose {userInput}!                   ");
            Console.WriteLine($" ");
            Console.WriteLine($"                Whichever value is in position #{userInput}         ");
            Console.WriteLine($"            Will be what we multiply against the sum.               ");
            Console.WriteLine($" ");
            Console.WriteLine($"                                  Let's see what it is.             ");
            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($" ");
            Console.WriteLine($"                        ... Checking the value ...                  ");
            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");

            int indexPosition = Convert.ToInt32(userInput);

            Console.WriteLine($" ");
            Console.WriteLine($"                 Aha! The value in that position is                 ");
            Console.WriteLine($" ");
            Console.WriteLine($"                     ...{ intArr[indexPosition]}. Okay!             ");
            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($" ");
            Console.WriteLine($"                          ✧・ﾟ・✧・ﾟ・✧・ﾟ・✧                         ");
            Console.WriteLine($" ");
            Console.WriteLine($"                          ...Calculating...                          ");
            Console.WriteLine($" ");
            Console.WriteLine($"                          ✧・ﾟ・✧・ﾟ・✧・ﾟ・✧                         ");
            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");

            int product = sum * intArr[indexPosition];

            Console.WriteLine($" ");
            Console.WriteLine($"       Wow! The product of {sum} and {intArr[indexPosition]} is...");
            Console.WriteLine($" ");
            Console.WriteLine($"                 {sum * intArr[indexPosition]}!                   ");
            Console.WriteLine($" ");
            Console.WriteLine($"                               ...Well, now that's just too much. ");
            Console.WriteLine($" ");
            Console.WriteLine($"------------------------------------------------------------------");

            return product;
        }

        static decimal GetQuotient(int product)
        {

            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($"|                                                                  |");
            Console.WriteLine($"|                           GET THE QUOTIENT                       |");
            Console.WriteLine($"|                                                                  |");
            Console.WriteLine($"--------------------------------------------------------------------");

            Console.WriteLine($" ");
            Console.WriteLine($"   To shrink that back down, we're going to have to divide it.      ");
            Console.WriteLine($" ");
            Console.WriteLine($"           What number should we divide it by?                      ");
            Console.WriteLine($" ");

            Console.WriteLine($" ");
            string userInput = Console.ReadLine();
            Console.WriteLine($" ");

            Console.WriteLine($" ");
            Console.WriteLine($"Hmm...Okay. The dividend will be {userInput}.");
            Console.WriteLine($" ");

            int dividend = Convert.ToInt32(userInput);

            decimal quotient = decimal.Divide(product, dividend);

            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($" ");
            Console.WriteLine($"                          ✧・ﾟ・✧・ﾟ・✧・ﾟ・✧                         ");
            Console.WriteLine($" ");
            Console.WriteLine($"                          ...Calculating...                         ");
            Console.WriteLine($" ");
            Console.WriteLine($"                          ✧・ﾟ・✧・ﾟ・✧・ﾟ・✧                         ");
            Console.WriteLine($" ");
            Console.WriteLine($"--------------------------------------------------------------------");

            Console.WriteLine($" ");
            Console.WriteLine($" ");
            Console.WriteLine($"   The quotient of {product} divided by {dividend} is {quotient}!   ");
            Console.WriteLine($" ");
            Console.WriteLine($" ");

            return quotient;
        }
    }
}
