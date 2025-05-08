using System;

class Program{
    static void Main(){
       
       // Ejercicio 1
       int num = 0;
       int contador = 0;
       int sum = 0;
        while (num < 100){
           Console.WriteLine("Ingrese un numero");
           int num1 = int.Parse(Console.ReadLine());
           sum += num1;
           num = sum;
           contador++;
        }
        Console.WriteLine("Suma total es " + sum);
        Console.WriteLine("Cantidad de numeros "+ contador);
        
        /*
        // Ejercicio 2
        Console.WriteLine("Ingrese un numero");
            int var = int.Parse(Console.ReadLine());
        int mult = 0;
        for (int incre = 1; incre <= 10; incre++){
            mult = var * incre;
            Console.WriteLine(var + " por "+ incre + " igual a " + mult);
        } 
        */
        /*
        //Ejercicio 3
        Random random = new Random();
        int numerorandom = random.Next(1,51);
        int numelegido;
        Console.WriteLine("Adivine el numero entre 1 al 50");
        do{
            Console.WriteLine("Ingrese numero para adivinar");
            numelegido = int.Parse(Console.ReadLine());
            
            if (numelegido < numerorandom){
               Console.WriteLine("El numero secreto es mayor"); 
            }
            if(numelegido > numerorandom){
                Console.WriteLine("El numero secreto es menor");
            }
            if(numelegido == numerorandom){
                Console.WriteLine("Ha advinado el numero");
            }


        } while (numelegido != numerorandom);
        */
        /*
        // Ejercicio 4
        string asterisco = "";
        Console.WriteLine("Ingrese numero");
        int numeropira = int.Parse(Console.ReadLine());
        for (int incre2 = 1; incre2 <= numeropira; incre2++){
            asterisco += "*";
            Console.WriteLine(asterisco);
        }
        */
        
    }
}