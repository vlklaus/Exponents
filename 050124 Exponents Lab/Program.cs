Console.WriteLine("Learn your squares and cubes!");


bool again = true;
while (again)
{
    Console.Write("Enter an integer up to 1290: ");
    int value = int.Parse(Console.ReadLine());

    //validation
    if (value < 1)
    {
        continue;
    }

    //header
    Console.WriteLine("Number\t\tSquared\t\tCubed");
    Console.WriteLine("=======\t\t=======\t\t======");

    for (int row = 1; row <= value; row++)
    {
        int squared = row * row;
        int cubed = row * row * row;

        Console.WriteLine($"{row,7} {squared,15} {cubed,14}");
    }

    Console.WriteLine("Continue? (y/n): ");
    string response = Console.ReadLine();

    if (response == "y")
    {
        continue;
    }
    else
    {
        again = false;
        break;
    }
  
}




