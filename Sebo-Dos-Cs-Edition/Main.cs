while (true)
{
    string DosInput = Console.ReadLine();

    string command0 = "help";
    string command1 = "say";

    if (DosInput == command0)
    {
        Console.WriteLine("Commands:");
        Console.WriteLine(command0);
        Console.WriteLine(command1);
    }
    else if (DosInput == command1)
    {
        Console.WriteLine(DosInput);
    }
    else
    {
        Console.WriteLine("{" + DosInput + "} is not a command!");
    }
    Console.WriteLine("");
}