//datatypes
//numerical data

byte byte_number = 0; // 0 to 255
int int_number = 10; // -2,147,483,648 to 2,147,483,647
long long_number = 200; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
double double_number = 200;  // -1.7976931348623157E+308 to 1.7976931348623157E+308
float float_number = 400; // -3.402823E+38 to 3.402823E+38


//logical data
bool data_boll = true; // true or false

//text data
String string_data = "test text"; // text data

Console.WriteLine(string_data);

string_data = "modified text"; // text data

Console.WriteLine(string_data);


Console.WriteLine(int_number);
//output
Console.WriteLine("Please enter a long number : ");
//input

if (long.TryParse(Console.ReadLine(), out long_number))
{
    Console.WriteLine($"You entered: {long_number}");
}
else
{
    Console.WriteLine("Invalid number.");
}

string string_number = Console.ReadLine();
int integer_number = Convert.ToInt32(string_number);

Console.WriteLine(integer_number);

//const 
const string constant_string = "This is a constant string.";
