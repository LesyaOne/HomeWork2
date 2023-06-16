int SecondDigit(int num)
{
    int result = (num % 100 - (num %10)) / 10;
    if (result < 0) result = result * (-1);
    return result;
}
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
if((number>99 && number<1000) || (number< -99 && number > -1000))
{
    Console.WriteLine($"Second digit is {SecondDigit(number)}");
}
else Console.WriteLine("Wrong number, try again");