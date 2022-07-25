int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
    Console.WriteLine("1");
if (x < 0 && y > 0)
    Console.WriteLine("2");
if (x < 0 && y < 0)
    Console.WriteLine("3");
if (x > 0 && y < 0)
    Console.WriteLine("4");