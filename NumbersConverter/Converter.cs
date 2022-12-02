using System.Text.RegularExpressions;

namespace NumbersConverter
{
    public static class Converter
    {
        public static void DecimalToBinary()
        {
            Console.Write("\nPositive Decimal Number: ");
            string number = Console.ReadLine();
            if (!CheckDecimalEnter(number))
            {
                return;
            }
            else
            {
                var decimalNumber = uint.Parse(number);
                var binaryNumber = string.Empty;
                while (decimalNumber > 0)
                {
                    binaryNumber = (decimalNumber % 2) + binaryNumber;
                    decimalNumber /= 2;
                }
                Console.WriteLine("Binary Number: " + binaryNumber);
                Console.WriteLine();
            }
        }

        public static void BinaryToDecimal()
        {
            Console.Write("\nBinary Number: ");
            string binaryNumber = Console.ReadLine();
            if (!CheckBinaryEnter(binaryNumber))
            {
                return;
            }
            else
            {
                var exponent = 0;
                var result = 0u;
                for (var i = binaryNumber.Length - 1; i >= 0; i--)
                {
                    if (binaryNumber[i] == '1')
                    {
                        result += Convert.ToUInt32(Math.Pow(2, exponent));
                    }
                    exponent++;
                }
                Console.WriteLine("Decimal Number: " + result);
                Console.WriteLine();
            }
        }

        private static bool CheckBinaryEnter(string s)
        {
            Regex binary = new Regex("^[01]{1,32}$", RegexOptions.Compiled);
            if (binary.IsMatch(s))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Input number was not matched to binary: " + s);
                return false;
            }
        }

        private static bool CheckDecimalEnter(string s)
        {
            try
            {
                uint res = uint.Parse(s);
                if (res == 0)
                {
                    Console.WriteLine($"Please enter number > 0: {s}");
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
