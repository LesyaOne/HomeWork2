void ThirdDigit(int num)
{
    if(num<100 && num>-100) Console.Write("There is no third digit");
    if(num>99 && num<1000) 
    {
        int result = num%10;
        Console.Write($"Third digit is {result}");
    }
    if(num<-99 && num>-1000)
    {
        int result = num%10 * (-1);
        Console.Write($"Third digit is {result}");
    }
    if(num>999 && num<10000)
    {
        int result = (num%100 - num%10)/(10);
        Console.Write($"Third digit is {result}");
    }
    if(num<-999 && num>-10000)
    {
        int result = (num%100 - num%10)/(-10);
        Console.Write($"Third digit is {result}");
    }
    if(num>9999 && num<100000)
    {
        int result = (num%1000 - num%100)/100;
        Console.Write($"Third digit is {result}");
    }
    if(num<-9999 && num>-100000)
    {
        int result = (num%1000 - num%100)/(-100);
        Console.Write($"Third digit is {result}");
    }
    if(num>99999 || num<-99999) Console.Write("Error");
}
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
ThirdDigit(number);