// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 

using System.Text;

string str = "aBCdefJHij";
Console.WriteLine($"Исходная строка: {str}");

string reverseStr = ToOppositeCase(str);
Console.WriteLine($"Изменная строка: {reverseStr}");

string ToOppositeCase(string str)
{
    char[] array = new char[str.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (char.IsLower(str[i]))
        {
            array[i] = char.ToUpper(str[i]);
        }
        else if (char.IsUpper(str[i]))
        {
            array[i] = char.ToLower(str[i]);
        }
    }
    return new string(array);
}
