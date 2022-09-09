int a = Coordinate("a", "A");
int b = Coordinate("b", "A");
int c = Coordinate("c", "A");
int d = Coordinate("d", "B");
int f = Coordinate("f", "B");
int g = Coordinate("g", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write("координаты двух точек {coorName} {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double a, double d, 
                double b, double f, 
                double c, double zg)
                {
  return Math.Sqrt(Math.Pow((d-a), 2) + 
                   Math.Pow((f-b), 2) + 
                   Math.Pow((g-c), 2));
}

double segmentLength =  Math.Round (Decision(a, b, c, d, f, g), 2 );

Console.WriteLine("расстояние между ними в 3D пространстве {segmentLength}");
