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

            try
            {
                //convert the user’s input to an integer
                int toNumber = Convert.ToInt32(userInput);

                //Instantiate a new integer array that is the size the user just inputted.
                int[] newArray = new int[toNumber];

                //call the Populate method, arguments: int array (?)
                int[] populatedArray = Populate(newArray);

                //Capture the sum by calling the GetSum method

                //int captureSum = GetSum(populatedArray);

                //Capture the product by calling the GetProduct method

                //int captureProduct = GetProduct(populatedArray, theSum);

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
                Console.WriteLine($"Please enter a number");

                //Store the response into a string first
                string userInput = Console.ReadLine();

                //convert the user’s input to an integer
                int toNumber = Convert.ToInt32(userInput);

                //Add the number just inputted into the array
                numArr[i] = toNumber;
            }

            //return the populated array
            return numArr;
        }

        //static int[] GetSum(int[] sumArray)
        //{
        //    //Declare an integer variable named sum
        //    int sum = 0;

        //    //Iterate through the array
        //    for (int i = 0; i < sumArray.Length; i++)
        //    {
        //        //populate the sum variable with the sum of all the numbers together.
        //        sumArray[i] = sum;

        //    }

        //    //return sum;
        //}



    }
}
