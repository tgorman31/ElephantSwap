using ElephantSwap;

Elephant lucinda = new Elephant() { Name = "Lucinda", earSize = 33 };
Elephant lloyd = new Elephant() { Name = "Lloyd", earSize = 40 };

Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

while (true)
{
	char? enteredValue = Console.ReadKey(true).KeyChar;
	if (int.TryParse(enteredValue.ToString(), out int value))
	{
		Console.WriteLine($"You pressed {value}");
		if (value == 1)
		{
			Console.WriteLine("Calling lloyd.WhoAmI()");
			lloyd.WhoAmI();
		} else if (value == 2)
        {
            Console.WriteLine("Calling lucinda.WhoAmI()");
            lucinda.WhoAmI();
        } else if (value == 3)
        {
            Elephant placeholder = lloyd;
            lloyd = lucinda;
            lucinda = placeholder;
            Console.WriteLine("References have been swapped\n");

        }
    }
}