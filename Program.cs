
// Challenge 1
// bool amProgrammer = "true"; // Error, el valor de amProgrammer es un string, no un boolean
// La solución es:   
bool amProgrammer = true;
Console.WriteLine(amProgrammer);
/*bool amProgrammer = Boolean.Parse("true");
Console.WriteLine($"{amProgrammer.GetType()}: {amProgrammer}");*/

// int Age = 27.9; // Error, el valor de Age es un double, no un int
// La solución es: 
int Age = 28;
Console.WriteLine(Age);
/*int Age = (int)Math.Round(27.9);
Console.WriteLine($"{Age.GetType()}: {Age}");*/

List<string> Names = new List<string>();
// Names = "Monica"; // Error, no se puede agregar directamente un valor string en una lista
// La solución es: 
Names.Add("Monica");

Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
// MyDictionary.Add("Hi there", 0); // Error, el valor de la key "Hi there" no puede ser un int 
// porque la declaración del diccionario es <string, string>
// La solución es:
MyDictionary.Add("Hi there", "0");
// MyDictionary.Add("Hi there", (0).ToString());
foreach (var num in MyDictionary)
{
    Console.WriteLine(num);
}

// This is a tricky one! Hint: look up what a char is in C#
// string MyName = 'MyName'; // Error, no se puede declarar el valor tipo char en varios carácteres 
// con una variable string
// La solución es:
string MyName = "MyName";
Console.WriteLine(MyName);

// Challenge 2
List<int> Numbers = new List<int>() { 2, 3, 6, 7, 1, 5 };
// for (int i = Numbers.Count; i >= 0; i--) // Error, en la variable indice 'i' está fuera de rango 
//de la cantidad de indices de la lista 
// La solución es:
for (int i = Numbers.Count - 1; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}

// Challenge 3
List<int> MoreNumbers = new List<int>() { 12, 7, 10, -3, 9 };
foreach (int i in MoreNumbers)
{
    // Console.WriteLine(MoreNumbers[i]); // Error, MoreNumbers[i] no corresponde, ni se utiliza para iterar
    // dentro de un foreach
    // La solución es:
    Console.WriteLine(i);
}

// Challenge 4
List<int> EvenMoreNumbers = new List<int> { 3, 6, 9, 12, 14 };
foreach (int num in EvenMoreNumbers)
{
    if (num % 3 == 0)
    {
        // num = 0; // Error, no se puede inicializar la variable num porque corresponde a la iteración
        // foreach
        // La solución es: no declarar nuevamente y imprimir num por consola
        Console.WriteLine(num);
    }
}
// Challenge 5
// What can we learn from this error message?
string MyString = "superduberawesome";
// MyString[7] = "p"; // Error, la variable MyString es string no un array tipo string
// La Solución es:
Console.WriteLine($"Antes de reemplazar un carácter: {MyString}");
string NuevoString = MyString.Replace('b', 'p');
Console.WriteLine($"Después de reemplazar un carácter: {NuevoString}");

// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(12);
// if (randomNum == 12) // Si randomNum es igual a 12, jamás se imprimirá el resultado por consola  
// La solución es:
if (randomNum < 12)
{
    Console.WriteLine("Hello");
}

