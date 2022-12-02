using NumbersConverter;

while (true)
{
        Console.Write("1 - Decimal to Binary\n2 - Binary to Decimal\n\nMode: ");
        String Mode = Console.ReadLine();
        switch (Mode)
        {
            case "1":
                Converter.DecimalToBinary();
                break;
            case "2":
                Converter.BinaryToDecimal();
                break;
            default:
                Console.WriteLine("No such option.");
                break;
        }
}



