float bas, alt, res;

Console.WriteLine("Digite Base:");
bas = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura");
alt = float.Parse(Console.ReadLine());

res = bas * alt / 2;

Console.WriteLine("A area é " + res);

Console.ReadKey();