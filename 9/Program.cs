Console.Write("Введите пятизначное число:");
string nstr = Console.ReadLine();
if ((nstr[0] != nstr[4]) && (nstr[1] != nstr[3]))
{
    Console.WriteLine("Yes");
}
else
{
    Console.Write("No");
}