// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//datos numericos
byte numero_byte = 0;
sbyte numero_sbyte = -10;
int numero_int = 0;
long numero_long = 200;
double numero_double = 0.0;
float numero_float = 0.0f;

//datos logicos
bool esVerdadero = true; // 0, apagado
bool esFalso = false; // 1, encendido

//datos de texto
string nombre = "Juan";

Console.WriteLine($"Hola {nombre}");

nombre = "Pedro";

Console.WriteLine($"Hola {nombre}");

Console.WriteLine(numero_int);

Console.WriteLine("Ingrese su nombre por favor: ");
string name = Console.ReadLine();
Console.WriteLine("Cuantos años tienes : ");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Hola {name}");
Console.WriteLine($"Tienes {edad} años");

//constante
const string dato_constante = "esto es una constante";
Console.WriteLine(dato_constante);