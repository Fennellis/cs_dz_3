Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void PalindromeOrNot(int num)
{
    int reverseNum = 0;
    int x = num;
    while (x != 0)
    {
        reverseNum = reverseNum * 10 + x % 10;
        x /= 10;
    }

    if (num == reverseNum) Console.WriteLine("Число является полиндромом");
    else Console.WriteLine("Число не является полиндромом");
}

PalindromeOrNot(number);
