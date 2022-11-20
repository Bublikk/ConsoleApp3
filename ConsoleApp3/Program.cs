double a = Convert.ToDouble((string)Console.ReadLine());
double b = Convert.ToDouble((string)Console.ReadLine());
double e = Convert.ToDouble((string)Console.ReadLine());
double c,x;

double Sum(double x) => 2*Math.Sin(x)-Math.Atan(x);

while (b-a > 2*e)
{
    c = (a + b) / 2;
    if (Sum(a) * Sum(c) < 0)
    {
        b = c;
    }
    else
    {
        a = c;
    }

}
x = (a + b) / 2;
Console.WriteLine(Math.Round(x, 3));


