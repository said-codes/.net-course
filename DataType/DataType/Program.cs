// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// numerical data type
byte byte_number = 0;
//int int_number = 289;
long long_number = 200;
double double_number = 0.5;
decimal decimal_number = 0;
float float_number = 0.5F;

// logical data type
bool bool_data = false;

// text data type
string string_data = "text";

Console.WriteLine(string_data);

string_data = "modified text";

Console.WriteLine(string_data);

// input
Console.WriteLine("Enter the value : ");
string_data = Console.ReadLine();


//output
Console.WriteLine(string_data);


// const
const string text_const = "this is a const";

//boolean
bool it_is_raining = true;

try
{
    Console.WriteLine("Enter a number: ");
    string string_number = Console.ReadLine();  // Correcta invocación de la función
    int int_number = Convert.ToInt32(string_number);  // Convertir a número entero
    Console.WriteLine(int_number);
}
catch (FormatException)
{
    Console.WriteLine("The input is not a valid number. Please enter a valid number.");
}

