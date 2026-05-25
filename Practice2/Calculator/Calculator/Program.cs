
decimal typedNumber1 = 0;
decimal typedNumber2 = 0;

decimal result = 0;

int typedOption = 0;

Console.WriteLine("Welcome to the calculator!");
Console.WriteLine("Please enter the first number:");

try
{
    typedNumber1 = Convert.ToDecimal(Console.ReadLine()) ;
}
catch (Exception)
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    typedNumber1 = 0;
}

Console.WriteLine("Please enter the second number:");
//typedNumer2 = Convert.ToDecimal(Console.ReadLine());

decimal.TryParse(Console.ReadLine(), out typedNumber2);

Console.WriteLine("Please select the operation you want to perform:");

Console.WriteLine("1. Addition");
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

if (typedOption == 1)
{
    //var tempInt = 15;
    // int tempInt = 15;
    //  tempInt = 15;
    result = typedNumber1 + typedNumber2;
    // Console.WriteLine(tempInt);
    // typedNumber1 = 0;
}
if (typedOption == 2)
{
    //  int tempInt = 15;
    result = typedNumber1 - typedNumber2;
    //  Console.WriteLine(tempInt);
}
if (typedOption == 3)
{
    result = typedNumber1 * typedNumber2;
}
if (typedOption == 4)
{
    result = typedNumber1 / typedNumber2;
}
if (typedOption == 5)
{
    result = 0;
}



Console.WriteLine($"The result is: {result}");

Console.ReadKey();


