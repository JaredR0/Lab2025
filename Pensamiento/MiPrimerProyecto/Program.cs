//Ejercicio 1
using System; 
 
class Program { 
    static void Main(){
    /*
         //Entrada de usuario 
        Console.Write("¿Cómo te llamas? "); //Imprime sin salto de linea  
        string nombre = Console.ReadLine(); //Captura una entrada de texto del usuario
 
        // Salida de datos 
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!"); //Imprime con salto de linea
    */
        // Números 
        int numeroEntero = 10; 
        double numeroDecimal = 3.14; 
 
        // Texto 
        string texto = "Hola, C#"; 
 
        // Fechas 
        DateTime fechaActual = DateTime.Now; 
 
        // Booleanos 
        bool esMayor = true; 
 
        // Mostrar los valores 
        Console.WriteLine(numeroEntero); 
        Console.WriteLine(numeroDecimal); 
        Console.WriteLine(texto); 
        Console.WriteLine(fechaActual); 
        Console.WriteLine(esMayor); 
     
     /*  
    int a = 10; 
int b = 3; 
Console.WriteLine("Suma: " + (a + b));
 Console.WriteLine("Resta: " + (a - b));
         // 13 
        // 7 
Console.WriteLine("Multiplicación: " + (a * b)); // 30 
Console.WriteLine("División: " + (a / (double)b)); // 3.3333 
Console.WriteLine("Potencia: " + Math.Pow(a, b)); // 1000 (10^3) 
Console.WriteLine("Módulo (resto): " + (a % b)); // 1
*/
/*
int x = 5; 
int y = 8; 
Console.WriteLine(x == y);  // False (¿5 es igual a 8?) 
Console.WriteLine(x != y);  // True  (¿5 es diferente de 8?) 
Console.WriteLine(x < y);   // True  (¿5 es menor que 8?) 
Console.WriteLine(x > y);   // False (¿5 es mayor que 8?)
*/
/*
int edad = 20; 
bool esEstudiante = true; 
// AND: Ambas condiciones deben ser verdaderas 
Console.WriteLine(edad > 18 && esEstudiante);  // True 
// OR: Al menos una condición debe ser verdadera 
Console.WriteLine(edad > 18 || esEstudiante);   // True 
// NOT: Invierte el valor 
Console.WriteLine(!esEstudiante);  // False (porque esEstudiante es True)
*/
    } 
} 

