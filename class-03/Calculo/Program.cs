Console.Clear();

Console.WriteLine("Este programa calcula la superficie de un rectangulo.");

Console.WriteLine("Ingrese la base del rectangulo:");
//double baseRectangulo = Convert.ToDouble(Console.ReadLine());
double baseRectangulo = double.Parse(Console.ReadLine());


Console.WriteLine("Ingrese la altura del rectangulo:");
double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo = baseRectangulo * alturaRectangulo;

Console.WriteLine("La superficie del rectangulo es: " + superficieRectangulo);

bool isGreaterThanTen = superficieRectangulo > 10;

if (isGreaterThanTen)
{
    Console.WriteLine("La superficie es mayor a 10.");

}
else
{
    Console.WriteLine("La superficie es menor o igual a 10.");
}

Console.ReadKey();