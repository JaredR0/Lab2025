using System;

class Program
{
    
    //Ejercicio 1
    static char Letra_Dni(int numeroDni)
    {
        string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
        int posicion = numeroDni % 23;
        return letras[posicion];
    }
     static bool CompruebaLetraDni(int numeroDni, char letraIngresada)
    {
        char letraCorrecta = Letra_Dni(numeroDni);
        return char.ToUpper(letraIngresada) == letraCorrecta;
    }
   

    static void Main()
    {
        Console.WriteLine("Introduce tu número de DNI (*6 numeros* sin letra): ");
        int numeroDni = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Introduce la letra del DNI: ");
        char letraDni = char.ToUpper(Console.ReadKey().KeyChar);
        

        if (CompruebaLetraDni(numeroDni, letraDni))
        {
            Console.WriteLine("\nBienvenido");
        }
        else
        {
            Console.WriteLine("\nHa cometido Ud. un error");
        }
        
    }
    
/*
//Ejercicio 2
    static bool ValidarFormato(string contrasena)
    {
        // Validar longitud mínima
        if (contrasena.Length < 8) return false;

        bool tieneMayuscula = false;
        bool tieneNumero = false;

        foreach (char c in contrasena)
        {
            // Verificar mayúscula usando ASCII (A-Z)
            if (c >= 65 && c <= 90) tieneMayuscula = true;
            
            // Verificar número usando ASCII (0-9)
            if (c >= 48 && c <= 57) tieneNumero = true;
        }

        return tieneMayuscula && tieneNumero;
    }

    static string QuitarEspacios(string input)
    {
        // Eliminar espacios manualmente
        int start = 0, end = input.Length - 1;
        while (start <= end && input[start] == ' ') start++;
        while (end >= start && input[end] == ' ') end--;
        return input.Substring(start, end - start + 1);
    }

    static void SolicitarContrasena(string contrasenaCorrecta)
    {
        int intentos = 0;
        while (intentos < 3)
        {
            Console.Write("Introduce tu contraseña: ");
            string entrada = QuitarEspacios(Console.ReadLine());

            if (!ValidarFormato(entrada))
            {
                Console.WriteLine("Formato inválido. Debe tener al menos 8 caracteres, una mayúscula y un número.");
            }
            else if (entrada == contrasenaCorrecta)
            {
                Console.WriteLine("Acceso permitido.");
                return;
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta.");
            }
            intentos++;
        }
        Console.WriteLine("Acceso denegado.");
    }

    static void Main()
    {
        string contrasenaCorrecta = "Samsung2024";
        Console.WriteLine("Validación de contraseña");
        SolicitarContrasena(contrasenaCorrecta);
    }
*/
    /*
    Ejercicio 3
static void MostrarMenu()
    {
        Console.WriteLine("Seleccione una opción: ");
        Console.WriteLine("1. Consultar saldo");
        Console.WriteLine("2. Depositar dinero");
        Console.WriteLine("3. Retirar dinero");
        Console.WriteLine("4. Salir");
       
    }

    static void ConsultarSaldo(double saldo)
    {
        Console.WriteLine("Su saldo actual es: "+saldo + " Quetzales");
    }

    static double Depositar(double saldo, double cantidad)
{
    double nuevoSaldo = saldo + cantidad;
    Console.WriteLine("Su saldo actualizado es " + nuevoSaldo + " Quetzales");
    return nuevoSaldo;
}

    static double Retirar(double saldo, double cantidad)
    {
        if (cantidad > saldo)
        {
            Console.WriteLine("No tiene suficiente saldo.");
            return saldo;
        }
        double nuevoSaldo1 = saldo - cantidad;
        Console.WriteLine("Su saldo actualizado es " + nuevoSaldo1 + " Quetzales");
        return nuevoSaldo1;
    }

    static void Main()
{
    double saldo = 1000;
    MostrarMenu();

    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            ConsultarSaldo(saldo);
            break;
        case 2:
            Console.Write("Ingrese cantidad a depositar: ");
            int cantidad1 = int.Parse(Console.ReadLine()); 
            if (cantidad1 > 0)
            {
                saldo = Depositar(saldo, cantidad1);
            }
            else
            {
                Console.WriteLine("Cantidad inválida.");
            }
            break;
        case 3:
            Console.Write("Ingrese cantidad a retirar: ");
            int cantidad2 = int.Parse(Console.ReadLine()); 
            if (cantidad2 > 0)
            {
                saldo = Retirar(saldo, cantidad2);
            }
            else
            {
                Console.WriteLine("Cantidad inválida.");
            }
            break;
        case 4:
            Console.WriteLine("Gracias por usar el cajero automático.");
            break;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }
}
*/
    }


