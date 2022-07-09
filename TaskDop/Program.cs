//Даны две строки. Определить можно ли из символов первой строки, собрать вторую. Допускается любое количество пробелов. Регистр символов различный в любой последовательности.
//Пример:
//Строка 1. Tom Marvolo Riddle
//Строка 2. I am Lord Voldemort
//Ответ: Да


using System;
using static System.Console;
Clear();


WriteLine("Введите первую строку:");
string s1 = ReadLine();
WriteLine("Введите вторую строку:");
string s2 = ReadLine();
bool b = true;
if (s1.ToLower().Length != s2.ToLower().Length)
    b = false;
else

    char[] ch1 = s1.ToCharArray();
    char[] ch2 = s2.ToCharArray();
   Array.Sort(ch1);
    Array.Sort(ch2);
    for (int i = 0; i < ch1.Length; i++)
        if (ch1[i] != ch2[i])
            b = false;

if (b)
    WriteLine("Можно!");
else
    WriteLine("Нельзя!");


// Попытался , что то похожее но немного не то, Не понимаю до конца в каком месте не работает.

