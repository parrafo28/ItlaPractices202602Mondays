try
{

    decimal[] typedNumers = new decimal[2];
    decimal result = 0;
    int typedOption = 0;
    int wantToContinue = 1;

    /*
    //arrays with fixed size of 5
    int[] ints = new int[5];
    ints[0] = 1;
    ints[4] = 2;
    ints[1] = 3;
    ints[2] = 4;
    ints[3] = 5;
    //this code will throw an exception because the array has only 5 elements, and the index 5 is out of range
    //ints[5] = 6;

    Console.WriteLine($"The first element of the array is: {ints[0]}");

    var theSecondElement = ints[1];

    int[] ints2 = new int[] { 1, 2, 3, 4, 5 };

    int[] ints3 = { 1, 2, 3, 4, 5 };

    ints2 = new int[] { 45, 5, 7, 8, 0, 15, 854};
    */

    //logic operators
    //And --> &&    , Or --> || , Not --> !
    //int age = 25;

    ////And 
    //// v && v = v
    //// v && f = f
    //// f && v = f
    //// f && f = f
    //if (age < 18)
    //{
    //    Console.WriteLine("You are a minor.");
    //}
    ////               v                  v
    //else if (   age >= 18    &&     age < 30    )
    //{       
    //    Console.WriteLine("You are a young adult.");
    //}
    //else if(age >= 30 && age < 60)
    //{
    //    Console.WriteLine("You are an adult.");
    //}
    //else
    //{
    //    Console.WriteLine("You are a senior.");
    //} 

    ////Or
    //// v || v = v
    //// v || f = v
    //// f || v = v
    //// f || f = f
    ////    f            v
    //if(age < 18 || age >= 60)
    //{
    //    Console.WriteLine("You are either a minor or a senior.");
    //}

    ////not 
    //// !v = f
    //// !f = v


    Console.WriteLine("Welcome to the calculator!");
    Console.WriteLine("Please enter the first number:");


    typedNumers[0] = Convert.ToDecimal(Console.ReadLine());


    //Console.WriteLine("Please enter the second number:");

    //decimal.TryParse(Console.ReadLine(), out typedNumers[1]);

    //Console.WriteLine("Want to continue typing more numbers? 1. yes, 2.No");

    //wantToContinue = int.Parse(Console.ReadLine());

    //if (wantToContinue == 1 || wantToContinue == 2)
    //{
    //    Console.WriteLine("Please enter the third number:");
    //    decimal.TryParse(Console.ReadLine(), out decimal thirdNumber);
    //    typedNumers = new decimal[] { typedNumers[0], typedNumers[1], thirdNumber };
    //}
    //else
    //{
    //    Console.WriteLine("You have selected to continue with only two numbers.");
    //}

    //if (  !( wantToContinue == 1 || wantToContinue == 2)  )
    //{
    //    Console.WriteLine("You have selected to continue with only two numbers.");

    //}
    //else
    //{
    //    Console.WriteLine("Please enter the third number:");
    //    decimal.TryParse(Console.ReadLine(), out decimal thirdNumber);
    //    typedNumers = new decimal[] { typedNumers[0], typedNumers[1], thirdNumber };

    //}

    while (wantToContinue == 1)
    {
        Console.WriteLine("Please enter the next number:");
        decimal.TryParse(Console.ReadLine(), out decimal nextNumber);
        //create a new array with the size of the old array + 1
        decimal[] newArray = new decimal[typedNumers.Length + 1];
        //copy the old array to the new array
        for (int i = 0; i < typedNumers.Length; i++) //i = i+1
        {
            newArray[i] = typedNumers[i];
        }
        //add the new number to the end of the new array
        newArray[newArray.Length - 1] = nextNumber;
        //assign the new array to the old array
        typedNumers = newArray;

        Console.WriteLine("Want to continue typing more numbers? 1. yes, 2.No");
        wantToContinue = int.Parse(Console.ReadLine());
    }
   


    Console.WriteLine("Please select the operation you want to perform:");

    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");

    typedOption = Convert.ToInt32(Console.ReadLine());


    switch (typedOption)
    {
        case 1:
            {
                result = typedNumers[0] + typedNumers[1];
                break;
            }
        case 2:
            result = typedNumers[0] - typedNumers[1];
            break;
        case 3:
            result = typedNumers[0] * typedNumers[1];
            break;
        case 4:
            result = typedNumers[0] / typedNumers[1];
            break;
        default:
            result = 0;
            break;
    }


    Console.WriteLine($"The result is: {result}");

    Console.ReadKey();

}

catch (Exception)
{
    Console.WriteLine("An error occurrs ");

}

