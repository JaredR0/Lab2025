using System;
using System.ComponentModel;
class Program { 
static void Main() { 
/*
//Ejercicio 1
//Entrada de datos 
Console.Write("Ingrese cuanto gasto el cliente "); 
Double gasta = Convert.ToDouble(Console.ReadLine()); 
// Salida de datos 
if (gasta >= 100){
// Operacion
Double Descuento = gasta - (gasta * 0.20);
 Console.WriteLine("El precio con descuento es de, " + Descuento);

}
if (gasta >= 50 && gasta <= 99){
// Operacion
Double Descuento = gasta - (gasta * 0.10);
 Console.WriteLine("El precio con descuento es de, " + Descuento);

}
if (gasta < 50){
// Operacion
 Console.WriteLine("No se aplica descuento");

}
*/
/*
//Ejercicio 2
//Entrada de datos
Console.Write("Ingrese su edad "); 
Double edad = Convert.ToDouble(Console.ReadLine());
if (edad < 18){
// Operacion
    Console.WriteLine("Acceso denegado");
}
*/
/*
//Ejercicio 3
//Entrada de datos
Console.Write("Ingrese primer nuemero"); 
int n1 = int.Parse(Console.ReadLine()); 
Console.Write("Ingrese segundo numero"); 
int n2 = int.Parse(Console.ReadLine()); 
int i=0;
    if(n1 == n2)
    {
    // Operacion
        i=n1*n2;
    }
    if(n1 > n2)
    {
    // Operacion
        i= n1-n2;
    }
    if(n1 < n2){
    // Operacion
        i= n1+n2;
    }

    Console.WriteLine("El resultado es" + i);
*/
/*
 //Ejercicio 4
 // Entrada de datos
    Console.WriteLine("Ingrese el nombre del vendedor");
    string name= Console.ReadLine();
    Console.WriteLine("ingresa la cantidad de autos vendidos al mes");
    int ncarros= int.Parse(Console.ReadLine());
    // Operaciones
    int sueldo = ncarros *335;
    double sueldone= sueldo *0.95;
    double impuesto= sueldo * 0.05;

    Console.WriteLine("El nombre del vendedor es: " + name + "\r\n el sueldo bruto es: "+ sueldo + "\r\n El impuesto es: "+ impuesto+ "\r\n El sueldo neto es: " + sueldone);
*/
/*
Console.WriteLine("Ingrese su edad");
int edad = int.Parse(Console.ReadLine());

if (edad < 5){
    Console.WriteLine("Su viaje es gratis");
}
else{
    if(edad <= 5 && edad <= 17){
    double des = edad - (edad*0.5);
    Console.WriteLine("Tiene 50% de descuente"+des);
    }
else {
    if(edad >= 60 ){
    double des2 = edad - (edad*0.3);
    Console.WriteLine("Tiene 30% de descuente"+des2);
}
    }
}
*/
/*
Console.WriteLine("Ingrese variable 1");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese variable 2");
int n2 = int.Parse(Console.ReadLine());

if (n1 > n2){
    Console.WriteLine("Verdadero");
}
else{
    Console.WriteLine("Falso");
}
Console.WriteLine("ingrese distancia a recorrer");
int distan = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese distancia a Dias de estancia");
int dia = int.Parse(Console.ReadLine());

if (distan > 800 && dia > 7){
    double billete = distan * 2.5;
    double billetedes = billete - (billete * 0.3);
    Console.WriteLine("ingrese distancia a Dias de estancia" + billetedes);
}
*/

}
} 
