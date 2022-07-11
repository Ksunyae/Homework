int a, b;
Console.Write("Введите любое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое число, отличное от предидуего: ");
b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write("max =");
    Console.WriteLine(a);
    Console.Write("min =");
    Console.WriteLine(b);
}
else
{
    Console.Write("max =");
    Console.WriteLine(b);
    Console.Write("min =");
    Console.WriteLine(a);
}