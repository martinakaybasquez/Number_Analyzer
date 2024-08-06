//name 
Console.Write("What is your name? ");
string name = Console.ReadLine();
Console.WriteLine(name);

Console.WriteLine();

Console.WriteLine($"{name}, Please choose a number from 1 to 100.");
int pickNum = int.Parse(Console.ReadLine());

Console.WriteLine();

if (pickNum % 2 == 0) // even
{
        if (Enumerable.Range(2, 24).Contains(pickNum))
        {
                Console.WriteLine("The number chosen is even and less than 25.");
        }
        else if (Enumerable.Range(26, 60).Contains(pickNum))
        {
                Console.WriteLine("The number chosen is even and between 26 and 60.");
        }
        else if (pickNum > 60)
        {
                Console.WriteLine("The number chosen is even and greater than 60.");
        }
}
else
{
        if (pickNum < 60)
        {
                Console.WriteLine("The number chosen is odd and less than 60.");
        }
        else if (pickNum > 60)
        {
                Console.WriteLine("The number chosen is odd and greater than 60.");
        }
}



