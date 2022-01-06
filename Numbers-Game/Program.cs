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
            //Generic Exception
            catch (Exception ex)
            {
                Console.WriteLine("I'm sorry. Something went wrong here. " + ex.Message);
            }
            //include a finally that tells us that the program is completed.
            finally
            {
                Console.WriteLine("The program has completed!");
            }
        }

        static void StartSequence()
        {
            //prompt the user to “Enter a number greater than zero”
            Console.WriteLine("Hello! Give me a number between one and ten, please.");

            string userInput = Console.ReadLine();
            Console.WriteLine($"You chose { userInput}.");
            Console.WriteLine(" ");

            try
            {
                //convert the user’s input to an integer
                int userInputNumber = Convert.ToInt32(userInput);
                Console.WriteLine($"The array will have...{userInput} numbers in it.");
                Console.WriteLine(" ");

                //Instantiate a new integer array that is the size the user just inputted.
                int[] newArray = new int[userInputNumber];

                //call the Populate method, arguments: int array (?)
                int[] populatedArray = Populate(newArray);

                //Capture the sum by calling the GetSum method
                int captureSum = GetSum(populatedArray);
                Console.WriteLine($"The sum of all of the numbers in your array is...{captureSum}.");
                Console.WriteLine(" ");

                //Capture the product by calling the GetProduct method
                int captureProduct = GetProduct(populatedArray, captureSum);
                Console.WriteLine($"The product is...{captureProduct}.");
                Console.WriteLine(" ");

                //Capture the quotient by calling the GetQuotient method
                decimal captureQuotient = GetQuotient(captureProduct);

                //output to the console the details of all these values
                Console.WriteLine($"The sum was {captureSum}. The product was {captureProduct}. The quotient was {captureQuotient}.");
                Console.WriteLine(" ");
                Console.WriteLine("Thanks for playing!");

            }
            catch (FormatException exc)
            {
                Console.WriteLine("Exception: ", exc.Message);
            }
        }

        static int[] Populate(int[] numArr)
        {
            //Iterate through the array 
            for (int i = 0; i < numArr.Length; i++)
            {
                //prompt the user to enter a specific number
                Console.WriteLine("Please enter a number to put into the array. I will ask until the array is full.");

                //Store the response into a string first
                string userInput = Console.ReadLine();

                //convert the user’s input to an integer
                int toNumber = Convert.ToInt32(userInput);

                //Add the number just inputted into the array
                numArr[i] = toNumber;

                Console.WriteLine("The array so far is: [{0}]", string.Join(", ", numArr));
                Console.WriteLine(" ");

            }

            //return the populated array
            return numArr;
        }

        static int GetSum(int[] sumArray)
        {
            //Declare an integer variable named sum
            int sum = 0;

            //Iterate through the array
            for (int i = 0; i < sumArray.Length; i++)
            {
                //populate the sum variable with the sum of all the numbers together.
                sum += sumArray[i];
            }

            return sum;
        }

        static int GetProduct(int[] intArr, int sum)
        {
            //Ask the user to select a number between 1 & the length of the integer array.
            Console.WriteLine($"Please choose a number between 1 and {intArr.Length - 1}.");
            Console.WriteLine(" ");

            string userInput = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine($"You chose {userInput}. Whichever number is in that array position will be what we multiply against the sum.");
            Console.WriteLine(" ");

            Console.WriteLine("Checking the value...");
            Console.WriteLine(" ");

            int indexPosition = Convert.ToInt32(userInput);

            Console.WriteLine($"The value in that position is {intArr[indexPosition]}.");
            Console.WriteLine(" ");


            Console.WriteLine("Calculating the product...");
            Console.WriteLine(" ");

            int product = sum * intArr[indexPosition];
            //Console.WriteLine($"The product is {sum * intArr[indexPosition]}.");
            return product;
        }

        static decimal GetQuotient(int product)
        {
            Console.WriteLine($"Now we're going to divide the product. What number should we divide it by?");
            Console.WriteLine(" ");

            string userInput = Console.ReadLine();
            Console.WriteLine($"Okay, the dividend will be {userInput}.");
            Console.WriteLine(" ");

            int dividend = Convert.ToInt32(userInput);

            decimal quotient = decimal.Divide(product, dividend);

            Console.WriteLine($"The quotient is {quotient}!");
            Console.WriteLine(" ");

            return quotient;
        }
    }
}
