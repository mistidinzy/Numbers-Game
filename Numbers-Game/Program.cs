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
                Console.WriteLine("I'm sorry. Something went wrong here." + ex.Message);
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
            Console.WriteLine("Hello! Give me a number greater than zero, please.");

            string userInput = Console.ReadLine();
            Console.WriteLine($"You chose { userInput}.");

            try
            {
                //convert the user’s input to an integer
                int userInputNumber = Convert.ToInt32(userInput);
                Console.WriteLine($"The array will have...{userInput} numbers in it.");

                //Instantiate a new integer array that is the size the user just inputted.
                int[] newArray = new int[userInputNumber];

                //call the Populate method, arguments: int array (?)
                int[] populatedArray = Populate(newArray);

                //Capture the sum by calling the GetSum method
                int captureSum = GetSum(populatedArray);
                Console.WriteLine($"The sum of all of the numbers in your array is... {captureSum}.");

                //Capture the product by calling the GetProduct method
                int captureProduct = GetProduct(populatedArray, captureSum);
                Console.WriteLine($"The product is... {captureProduct}.");

                //Capture the quotient by calling the GetQuotient method
                //int captureQuotient = GetQuotient();

                //output to the console the details of all these values
                Console.WriteLine("");

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
            Console.WriteLine($"Please choose a number between 1 and { intArr.Length - 1}.");

            string userInput = Console.ReadLine();
            Console.WriteLine("You chose " + userInput + ". Whichever number is in that array position will be what we multiply against the sum.");

            Console.WriteLine("Checking the value...");

            int indexPosition = Convert.ToInt32(userInput);
            Console.WriteLine("The value in that position is " + intArr[indexPosition] + ".");

            Console.WriteLine("Calculating the product...");

            int product = sum * indexPosition;            
            return product;
        }
    }
}
