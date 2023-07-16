// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double lenght(int xA, int yA, int zA, int xB, int yB, int zB) 
{
    double distance = Math.Sqrt(Math.Pow(xB - xA, 2)+Math.Pow(yB - yA, 2)+Math.Pow(zB - yA, 2));
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
int coorA3 = GetInfo ("Ведите координату z точки А:");
int coorB1 = GetInfo ("Ведите координату Х точки В:");
int coorB2 = GetInfo ("Ведите координату У точки В:");
int coorB3 = GetInfo ("Ведите координату z точки B:");

Console.WriteLine($"Расстояние между точками на плоскости равно: {lenght(coorA1, coorB1 ,coorA2, coorB2, coorA3, coorB3)}");