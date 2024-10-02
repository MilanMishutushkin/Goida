/*namespace Game
{
public class Game
{
    private static uint m_HiddenNumber;
    private static uint m_GuessNumber;
    private static uint GetNumOfDigit(uint number)
    {
        string input = Convert.ToString(number);
        return Convert.ToUInt32(input.Length);
    }
    private static uint[] GetDigitArrayOfNum(uint number)
    {
        uint countOfDigit = GetNumOfDigit(number);
        uint[] result = new uint[countOfDigit];

        for (int i = 0; i < countOfDigit; i++)
        {
            uint lastDigit = number % 10;
            number = (number - lastDigit) / 10;
            result[countOfDigit - i - 1] = lastDigit;
        }
        return result;
    }
    public static uint GenerateNumber()
    {
        Random random = new Random();
        while (true)
        {
            uint num = Convert.ToUInt32(random.Next(0, 10000));
            uint[] hiddenArray = GetDigitArrayOfNum(num);
            bool isValid = true;

            for (int i = 0; i < hiddenArray.Length; i++)
            {
                for (int j = i + 1; j < hiddenArray.Length; j++)
                {
                    if (hiddenArray[i] == hiddenArray[j])
                    {
                        isValid = false;
                        break;
                    }
                }
                if (!isValid)
                {
                    break;
                }
            }

            if (isValid)
            {
                return num;
            }
        }
    }
    public static void PrintEncryptedNumber(uint count)
    {
        for (int i = 0; i < count; i++)
            Console.Write("*");
    }
    public static uint ReadNumber()
    {
        Console.WriteLine("\nВведите своё число");
        string? input = Console.ReadLine();
        uint result = Convert.ToUInt32(input);
        return result;
    }
    public static void PointCounter(uint[] hiddenArray, uint[] guessArray)
    {
        uint resultCow = 0;
        uint resultBuffalo = 0;
        string buffaloInput;
        string cowInput;
        for (int i = 0; i < hiddenArray.Length; i++)
        {
            if (guessArray[i] == hiddenArray[i])
                resultBuffalo++;
        }
        if (resultBuffalo % 10 == 1 && resultBuffalo != 11 && resultBuffalo != 0)
        {
            buffaloInput = " бык";
        }
        else if (resultBuffalo % 10 >= 2 && resultBuffalo % 10 <= 4 && (resultBuffalo < 10 || resultBuffalo > 20) && resultBuffalo != 0)
        {
            buffaloInput = " быка";
        }
        else
        {
            buffaloInput = " быков";
        }

        for (int i = 0; i < hiddenArray.Length; i++)
        {
            for (int j = 0; j < hiddenArray.Length; j++)
            {
                if (i != j && guessArray[i] == hiddenArray[j])
                    resultCow++;
            }
        }
        if (resultCow % 10 == 1 && resultCow != 11 && resultCow != 0)
        {
            cowInput = " корова";
        }
        else if (resultCow % 10 >= 2 && resultCow % 10 <= 4 && (resultCow < 10 || resultCow > 20) && resultCow != 0)
        {
            cowInput = " коровы";
        }
        else
        {
            cowInput = " коров";
        }
        Console.Write($"{resultBuffalo}{buffaloInput},{resultCow}{cowInput} \n");
    }
    public static void Guess()
    {
        m_HiddenNumber = GenerateNumber();
        uint[] hiddenDigitArray = GetDigitArrayOfNum(m_HiddenNumber);
        ////////////////////////////////////
        Console.WriteLine(m_HiddenNumber);
        ////////////////////////////////////
        while (true)
        {
            PrintEncryptedNumber(Convert.ToUInt32(hiddenDigitArray.Length));
            m_GuessNumber = ReadNumber();
            uint[] guessDigitArray = GetDigitArrayOfNum(m_GuessNumber);
            PointCounter(hiddenDigitArray, guessDigitArray);
            if (m_GuessNumber == m_HiddenNumber)
            {
                Console.WriteLine("Как же ты хорош");
                Environment.Exit(0);
            }

        }
    }
    public static void Run()
    {
        RulesMenu.RunRulesMenu();
        Guess();
    }
    }
    class RulesMenu
    {
        public static bool IsAccept(string input)
        {
            return (input == "Yes" || input == "Да" || input == "да" || input == "нет") ? true : false;
        }
        public static bool IsAppropriateAnswer(string input)
        {
            if (input != "Yes" && input != "Да" && input != "да" && input != "yes" && input != "No" && input != "Нет" && input != "no" && input != "нет")
            {
                Console.WriteLine($"Засунь свой {input} себе в анальное отверстие!");
                return false;
            }
            return true;
        }
        public static bool IsReady()
        {
            while (true)
            {
                Console.WriteLine("Вы готовы?");
                string? input = Console.ReadLine();

                if (!IsAppropriateAnswer(input))
                    continue;

                if (input == "No" || input == "Нет")
                {
                    Console.WriteLine("Ты даааааааун");
                    Environment.Exit(0);
                }

                return true;
            }
        }
        private static void PrintRules()
        {
            Console.WriteLine("В свой ход игрок называет числа, у которых не повторяются цифры.       ");
            Console.WriteLine("Компьютер должен будет сравнить названное число с тем, что он загадал,");
            Console.WriteLine("и ответить, сколько цифр угадано и стоит на нужном месте (это «быки»),");
            Console.WriteLine("а сколько цифр угадано, но стоит не на своём месте (это «коровы»).    ");
        }
        public static void RunRulesMenu()
        {
            bool runRulesMenu = true;
            while (runRulesMenu)
            {
                Console.WriteLine("Приветствую Вас, давайте сыграем в игру \"Быки и коровы\". Вы знаете правила этой игры?");
                string? input = Console.ReadLine();
                if (!IsAppropriateAnswer(input))
                    continue;
                if (IsAccept(input))
                {
                    if (IsReady())
                        runRulesMenu = false;
                }
                else
                {
                    PrintRules();
                }
            }
        }
    }

}
*/