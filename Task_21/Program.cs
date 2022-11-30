// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//Найдем расстояние между точками A3; 6; 8, B2; 1; -7:
//d = √(xb - xa)2 + (yb - ya)2 + (zb - za)2 =
//= (2 - 3)2 + (1 - 6)2 + (-7 - 8)2 =
//= (-1)2 + (-5)2 + (-15)2 = 1 + 25 + 225 =
//= √251 ≈ 15.84297951775486

//Найдем расстояние между точками A7; -5; 0, B1; -1; 9:
//d = √(xb - xa)2 + (yb - ya)2 + (zb - za)2 =
//= (1 - 7)2 + (-1 - (-5))2 + (9 - 0)2 =
//= (-6)2 + 42 + 92 = 36 + 16 + 81 =
//= √133 ≈ 11.532562594670797

Console.Write("Введите координаты точки А (X): "); 
int xa = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координаты точки А (Y): "); 
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки А (Z): "); 
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B (X): "); 
int xb = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координаты точки B (Y): "); 
int yb = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координаты точки B (Z): "); 
int zb = Convert.ToInt32(Console.ReadLine()); 

//d = √(xb - xa)2 + (yb - ya)2 + (zb - za)2 
double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));  
Console.WriteLine(Math.Round(res, 2, MidpointRounding.ToZero));
