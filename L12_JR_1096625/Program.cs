using System; 
class Program 
{ 
static void Main(){ 

/*
//  Pedimos al usuario que ingrese una palabra. 
Console.Write("Ingresa una palabra: "); 
string palabra = Console.ReadLine(); 
// Creamos una nueva cadena vacía para almacenar la palabra invertida. 
string invertida = ""; 
//  Recorremos la palabra de atrás hacia adelante. 
for (int i = palabra.Length - 1; i >= 0; i--) 
{ 
// Vamos agregando cada carácter a la nueva cadena. 
invertida += palabra[i]; 
} 
// Mostramos el resultado. 
 Console.WriteLine("Palabra invertida: " + invertida);
 if (palabra == invertida){
    Console.WriteLine("Es un palindromo");
 }
 else{
    Console.WriteLine("No es un palindromo");
    
 }
 */
/*
//Solicita al usuario una frase. 
Console.Write("Ingresa una frase: "); 
string frase = Console.ReadLine().ToLower();
// Inicializamos contador. 
int contador = 0; 
int contador1 = 0;
int contador2 = 0;
int contador3 = 0;
int contador4 = 0;
foreach (char letra in frase) 
{ 
//  Si la letra es una vocal, aumentamos el contador. 
if ("a".Contains(letra)) 
{ 
contador++; 
} 
if ("e".Contains(letra)) 
{ 
contador1++; 
} 
if ("i".Contains(letra)) 
{ 
contador2++; 
} 
if ("o".Contains(letra)) 
{ 
contador3++; 
} 
if ("u".Contains(letra)) 
{ 
contador4++; 
} 
} 
//  Mostramos el resultado. 
Console.WriteLine("Número de vocal de a " + contador); 
Console.WriteLine("Número de vocal de e " + contador1); 
Console.WriteLine("Número de vocal de i " + contador2); 
Console.WriteLine("Número de vocal de o " + contador3); 
Console.WriteLine("Número de vocal de u " + contador4); 
*/
//  Pedimos al usuario la frase. 
Console.Write("Ingresa una frase: "); 
string frase = Console.ReadLine().ToLower(); 
//  Pedimos el carácter que se desea reemplazar. 
Console.Write("Ingrese la frase que desea reemplazar "); 
string original = Console.ReadLine().ToLower(); 
//  Pedimos el nuevo carácter. 
Console.Write("Frase nueva "); 
string nuevo = Console.ReadLine().ToLower(); 
//  Reemplazamos el carácter usando Replace. 
string modificada = frase.Replace(original, nuevo); 
//  Mostramos el resultado. 
Console.WriteLine("Frase modificada: " + modificada); 
} 
} 

