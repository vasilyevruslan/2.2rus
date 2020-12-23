using System;

static double Resist(double ro, double s)
{
    return ro * 1.0 / s;
}
System.Console.Write("Введите удельное сопротивление r1 = ");
var r1 = double.Parse(System.Console.ReadLine());
System.Console.Write("Введите площадь сечения s1 = ");
var s1 = double.Parse(System.Console.ReadLine());
System.Console.Write("Введите удельное сопротивление r2 = ");
var r2 = double.Parse(System.Console.ReadLine());
Console.Write("Введите площадь сечения s2 = ");
var s2 = double.Parse(System.Console.ReadLine());
Console.Write("Введите удельное сопротивление r3 = ");
var r3 = double.Parse(Console.ReadLine());
Console.Write("Введите площадь сечения s3 = ");
var s3 = double.Parse(Console.ReadLine());
var arr = new double[] { Resist(r1, s1), Resist(r2, s2), Resist(r3, s3) };
var rmax = double.MinValue;
var imax = 0;
for (var i = 0; i < arr.Length; i++)
{
    if (!(arr[i] > rmax)) continue;
    rmax = arr[i];
    imax = i;
}
Console.WriteLine("Проводник с максимальным сопротивлением №: {0}", imax + 1);

Console.ReadKey();