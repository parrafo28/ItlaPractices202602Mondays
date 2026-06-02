try
{
    decimal typedNumber1 = 0;
    decimal typedNumber2 = 0;

    decimal result = 0;

    int typedOption = 0;

    Console.WriteLine("Welcome to the calculator!");
    Console.WriteLine("Please enter the first number:");


    typedNumber1 = Convert.ToDecimal(Console.ReadLine());


    Console.WriteLine("Please enter the second number :");
    //typedNumer2 = Convert.ToDecimal(Console.ReadLine());

    decimal.TryParse(Console.ReadLine(), out typedNumber2);

    Console.WriteLine("Please select the operation you want to perform:");

    Console.WriteLine("1.  Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");

    typedOption = Convert.ToInt32(Console.ReadLine());
    //result = typedNumer1 + typedNumer2;

    //Console.WriteLine("The result of the addition is: " + result);

    /* comparison operators (They are questions basically than ask if A element is equals, distinct, etc, about the B Element)
     == := equals to
     != <> distinct from
     <   less than
     >  greater than
     <= less than or equals to
     >= greater than or equals to 
    */

    //if (typedOption == 1)
    //{
    //    //var tempInt = 15;
    //    // int tempInt = 15;
    //    //  tempInt = 15;
    //    result = typedNumber1 + typedNumber2;
    //    // Console.WriteLine(tempInt);
    //    // typedNumber1 = 0;
    //}
    //if (typedOption == 2)
    //{
    //    //  int tempInt = 15;
    //    result = typedNumber1 - typedNumber2;
    //    //  Console.WriteLine(tempInt);
    //}
    //if (typedOption == 3)
    //{
    //    result = typedNumber1 * typedNumber2;
    //}
    //if (typedOption == 4)
    //{
    //    result = typedNumber1 / typedNumber2;
    //}
    //if (typedOption == 5)
    //{
    //    result = 0;
    //}



    //////////
    ///
    //if (typedOption == 1)
    //{
    //    var tempInt2 = 15;
    //    result = typedNumber1 + typedNumber2;
    //    Console.WriteLine(tempInt2);
    //}
    //else
    //{
    //    //tempInt2 = 15;
    //    var tempInt2 = 15;
    //    if (typedOption == 2)
    //    {
    //        result = typedNumber1 - typedNumber2;
    //        Console.WriteLine(tempInt2);
    //    }
    //    else
    //    {
    //        if (typedOption == 3)
    //        {
    //            result = typedNumber1 * typedNumber2;
    //            Console.WriteLine(tempInt2);
    //        }
    //        else
    //        {
    //            if (typedOption == 4)
    //            {
    //                result = typedNumber1 / typedNumber2;
    //            }
    //            else
    //            {
    //                //  Console.WriteLine(tempInt2);
    //                result = 0;
    //                //if (typedOption == 5)
    //                //{
    //                //    result = 0;
    //                //}
    //                //else
    //                //{
    //                //    //Console.WriteLine("Son of the playa, put a number from 1 to 5");
    //                //    result = 0;
    //                //}
    //            }
    //        }
    //    }
    //}


    //if (typedOption == 1)
    //{
    //    result = typedNumber1 + typedNumber2;
    //}
    //else if (typedOption == 2)
    //{
    //    result = typedNumber1 - typedNumber2;
    //}
    //else if (typedOption == 3)
    //{
    //    result = typedNumber1 * typedNumber2;
    //}
    //else if (typedOption == 4)
    //{
    //    result = typedNumber1 / typedNumber2;
    //}
    //else
    //{
    //    result = 0;
    //} 

    switch (typedOption)
    {
        case 1:
            {

                result = typedNumber1 + typedNumber2;
                break;
            }
        case 2:
            result = typedNumber1 - typedNumber2;
            break;
        case 3:
            result = typedNumber1 * typedNumber2;
            break;
        case 4:
            result = typedNumber1 / typedNumber2;
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

