namespace dabdab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало: Введите шестнадцатеричное число (hex_num): ");

            string hex_num = Console.ReadLine();

            if (IsHexadecimal(hex_num))
            {
                int decimalNumber = ConvertHexToDecimal(hex_num);
                Console.WriteLine($"Успешное преобразование: десятичное число = {decimalNumber}");
            }
            else
            {
                Console.WriteLine("Ошибка: Некорректное шестнадцатеричное число.");
            }

            Console.WriteLine("Программа завершена.");
        }

        static bool IsHexadecimal(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            foreach (char c in input)
            {
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
                {
                    return false;
                }
            }
            return true;
        }

        static int ConvertHexToDecimal(string hex)
        {
            return Convert.ToInt32(hex, 16);
        }
    }
}
