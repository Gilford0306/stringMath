//Пользователь с клавиатуры вводит в строку ариф-
//метическое выражение. Приложение должно посчитать 
//его результат. Необходимо поддерживать только две 
//операции: + и –.
Console.WriteLine("input string to math");
string m = Console.ReadLine();
char ch1 = '+';
char ch2 = '-';
if (m.IndexOf(ch1) != -1)
{
    string[] words = m.Split(new char[] { '+' });
    int sum = 0;
    for (int i = 0; i<words.Length; i++)
    { 
        int num = int.Parse(words[i].ToString());
        sum += num;
    }
    Console.WriteLine(sum);
}
else if (m.IndexOf(ch2) != -1)
{
    string[] words = m.Split(new char[] { '-' });
    int diff = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (i == 0)
        {
            diff = int.Parse(words[i].ToString());
        }
        else {
            int num = int.Parse(words[i].ToString());
            diff -= num;
        }

    }
    Console.WriteLine(diff);
}
else
{
    Console.WriteLine("Errore - only + or - ");
}

