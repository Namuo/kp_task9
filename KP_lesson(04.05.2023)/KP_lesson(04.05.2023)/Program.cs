//void text(string predl)
//{
//    predl = predl.Replace('4', 'ч');
//    predl = predl.Replace("100", "сто");
//    predl = predl.Replace("_", "");
//    predl = predl.ToLower();
//    predl = predl.Trim();
//    for (int j = 0; j < predl.Length - 1; j++)
//    {
//        for (int i = 0; i < predl.Length - 1; i++)
//        {
//            if (predl[i] == predl[i + 1])
//                predl = predl.Replace(predl[i] + "" + predl[i + 1], predl[i].ToString()); ======> попытка сделать через метод
//        }
//    }
//    predl = predl.Replace("..", "");
//    Console.WriteLine(predl);
//}

//string a = "пРиФФки 4увиха... твои тя_ги просто ..... жесть";
//text(a);




string str1 = "пРиФФкИ 4увиха...твои тя_ги просто .......... ЖЕСТЬ";
str1 = str1.ToLower();
str1 = str1.Replace("_", "");
str1 = str1.Replace("4", "ч");
str1 = str1.Replace("тв", " Тв");
str1 = str1.Replace(" ..........", "");
str1 = str1 + ".";
string substr1 = str1.Substring(0, 1);
str1 = str1.Remove(0, 1);
substr1 = substr1.ToUpper();
str1 = substr1 + str1;
Console.WriteLine(str1);

string str2 = "!!! Эй,гошарь !!!! Иди на кУХНе пошарь, ххыыыы)))))))";
string substr2 = str2.Substring(0, 17);
str2 = str2.Remove(0, 17);
substr2 = substr2.Trim('!');
substr2 = substr2.Trim();
str2 = substr2 + str2;
str2 = str2.TrimEnd(')');
str2 = str2.TrimEnd('ы');
str2 = str2.TrimEnd('х') + "хы)";
str2 = str2.Replace("УХН", "ухн");
Console.WriteLine(str2);

string str3 = "Про100 4елове4ек Атсартировал пять колечегГг";
string substr3 = str3.Substring(0, 1);
str3 = str3.Remove(0, 1);
str3 = str3.Replace("100", "сто");
str3 = str3.Replace("4", "ч");
str3 = str3.ToLower();
str3 = substr3 + str3.TrimEnd('г') + "к.";
Console.WriteLine(str3);

string s = "Таким образом, исследование различных видов памяти современного персонального компьютера позволяет понять, как они работают и как взаимодействуют между собой.";
string resultstr = "";
char c = 'о';
List<char> stroka = new List<char>();
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == c) stroka.Add((char)(c + 1));
    else stroka.Add(s[i]);
}
foreach (char element in stroka)
{
    resultstr += element.ToString();
}
Console.WriteLine(resultstr);

Dictionary<char, int> entries = new Dictionary<char, int>();
string src = "Таким образом, исследование различных видов памяти современного персонального компьютера позволяет понять, как они работают и как взаимодействуют между собой.";
for (int i = 0; i < src.Length; i++)
{
    if (entries.ContainsKey(src[i]))
    {
        continue;
    }
    int count = 0;
    for (int j = i; j < src.Length; j++)
    {
        if (src[i] == src[j]) count++;
    }
    entries[src[i]] = count;
}
foreach (var key in entries)
{
    Console.WriteLine($"{key.Key} = {key.Value}");
}

string another_str = "Таким образом, исследование различных видов памяти современного персонального компьютера позволяет понять, как они работают и как взаимодействуют между собой.";
string find_str = "прикл";
for (int i = 0; i < another_str.Length - find_str.Length; i++)
{
    string temp_str = another_str.Substring(i, find_str.Length);
    if (temp_str == find_str)
    {
        Console.WriteLine($"Искомый фрагмент начинается с {i + 1} символа строки");
        break;  
    }
    if (i == another_str.Length - find_str.Length - 1) Console.WriteLine("Искомый фрагмент не найден");
}