int[] numbers = new int[0];
string commandToExit = "exit";
string commandToSum = "sum";
int sumAllNumbers = 0;
int forTheAmount;
string userInput = null;

while (userInput != commandToExit)
{
    Console.WriteLine("Введите число. Если хотите увидеть сумму всех введённых вами чисел, введите sum, если хотите выйти, введите exit.");
    userInput = Console.ReadLine();

    if (userInput == commandToSum)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            sumAllNumbers += numbers[i];
        }

        Console.WriteLine("Сумма всех ваших чисел равна " + sumAllNumbers);
        sumAllNumbers = 0;
    }
    else if (userInput != commandToSum && userInput != commandToExit)
    {
        forTheAmount = Convert.ToInt32(userInput);
        int[] tempNumbers = new int[numbers.Length + 1];

        for (int j = 0; j < numbers.Length; j++)
        {
            tempNumbers[j] = numbers[j];
        }

        tempNumbers[tempNumbers.Length - 1] = forTheAmount;
        numbers = tempNumbers;
    }
}