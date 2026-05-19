


var num1 = 10;
var num2 = 2;
var num3 = 2;
var num4 = 2;
var num5 = 2;

var result7 = num1 + num2 * num3 * num4 ^ num5 + num2 - num5 * num4 % num5;
////result7 = num1 + num2 * num3 *   numtemp1  + num2 - num5 * num4 % num5; 
////result7 = num1 +  numtemp2   *   numtemp1  + num2 - num5 * num4 % num5;
////result7 = num1 +  numtemp2   *   numtemp1  + num2 - num5 *   numtemp3;
////result7 = num1 + numtemp4 + num2 - num5 * numtemp3;
////result7 = num1 + numtemp4 + num2 - numtemp5;
////result7 = numtemp6 + num2 - numtemp5;
////result7 = numtemp7 - numtemp5;
////result7 = numtemp8;

var result8 = ((num1 + ((num2 * num3) * (num4 ^ num5))) + (num2 - (num5 * (num4 % num5))));
var result9 = ((num1 + (num2 * num3 * (num4 ^ num5))) + (num2 - (num5 * (num4 % num5))));
var result10 = (num1 + (num2 * num3) * (num4 ^ num5) + (num2 - num5) * (num4 % num5));
var result11 = (num1 + num2) * num3 * (num4 ^ num5) + (num2 - num5 * (num4 % num5));

Console.WriteLine($"{result7}   {result8}   {result9}    {result10}     {result11}");

Console.ReadKey();