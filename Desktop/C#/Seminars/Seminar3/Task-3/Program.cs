// Принимает координаты двух точек и определяет расстояние между ними


double lenght(int xA, int yA, int xB, int yB) 
{
    double distance = Math.Sqrt(Math.Pow(xB - xA, 2)+Math.Pow(yB - yA, 2));
    return distance;
}

int GetInfo(string mesage)
{
    Console.Write(mesage);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int coorA1 = GetInfo ("Ведите координату Х точки А:");
int coorA2 = GetInfo ("Ведите координату У точки А:");
int coorB1 = GetInfo ("Ведите координату Х точки В:");
int coorB2 = GetInfo ("Ведите координату У точки В:");

Console.WriteLine($"Расстояние между точками на плоскости равно: {lenght(coorA1, coorB1 ,coorA2, coorB2)}");