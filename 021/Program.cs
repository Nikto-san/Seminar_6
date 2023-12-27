// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

string GetString()
{
    Console.Write("Введите слово: ");
    return Console.ReadLine();
}

static bool IsPalindrome(string str)
{
    for (int left = 0, right = str.Length - 1; left < right; left++, right--)
    {
        if (char.ToLower(str[left]) != char.ToLower(str[right]))
        {
            return false;
        }
    }
    return true;
}

string str = GetString();

if (IsPalindrome(str))
{
    Console.WriteLine($"Слово {str} является палиндромом.");
}
else
{
    Console.WriteLine($"Слово {str} не является палиндромом.");
}