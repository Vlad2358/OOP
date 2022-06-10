using Physics;

var isWorking = true;
while (isWorking)
{
    Console.WriteLine("1. Вычислить энергию 2. Выйти");
    var value = Console.ReadLine();
    switch (value)
    {
        case "1":
            Counting();
            break;
        case "2":
            isWorking = false;
            break;
        default:
            break;
    }
}

void Counting()
{
    try
    {
        Console.Write("Введите скорость: ");
        var v = double.Parse(Console.ReadLine());
        Console.Write("Введите массу: ");
        var m = double.Parse(Console.ReadLine());
        var e = new Energy(v, m);
        Console.WriteLine("Энергия тела = " + e.CalcEnergy().ToString());
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex);
    }
}