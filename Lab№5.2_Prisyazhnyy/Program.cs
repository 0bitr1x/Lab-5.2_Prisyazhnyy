//сборник задач/тема 5/подтема 5.2/средний уровень/вариант 24
using System.Text;

Console.WriteLine("Введите текст: ");
string str_ch = Console.ReadLine();
StringBuilder item1 = new StringBuilder();
StringBuilder item0 = new StringBuilder();
for (int i = 0; i < str_ch.Length; i++)
{
    if (i % 2 == 0) item0.Append(str_ch[i]);
    if (i % 2 == 1) item1.Append(str_ch[i]); 
}
Console.WriteLine("Символы с четным индексом: " + item0.ToString());
Console.WriteLine("Символы с нечетным индексом: " + item1.ToString());

