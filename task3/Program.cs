void WeekDay(int day)
{
    if (day < 1 || day > 7) Console.Write("There are only seven days in a week!");
    if (day == 6 || day == 7) Console.Write("It is a weekend! Have fun!");
    if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
    {
        Console.Write("It is a weekday, wake up and go to work!");
    }
}
Console.Write("Enter the number of the day: ");
int number = Convert.ToInt32(Console.ReadLine());
WeekDay(number);