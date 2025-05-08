using System;

class Program
{
    static int[] miVector;

    static int Menu()
    {
        Console.WriteLine("Elige un número de opción:");
        Console.WriteLine("1. Introducir valores");
        Console.WriteLine("2. Leer Datos");
        Console.WriteLine("3. Desplegar los datos");
        Console.WriteLine("4. Buscar un dato");
        Console.WriteLine("5. Actualizar un dato");
        Console.WriteLine("6. Ordenar los valores");
        Console.WriteLine("7. Salir");
        int opt = int.Parse(Console.ReadLine());
        return opt;
    }

    static int[] IntroducirValores(int cantidad)
    {
        int[] vector = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingresa el número " + (i + 1) + ": ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        return vector;
    }

    static void Ingresodatos()
    {
        Console.Write("¿Cuántos valores deseas ingresar? ");
        int cantidad = int.Parse(Console.ReadLine());
        miVector = IntroducirValores(cantidad);
    }

    static void LeerDatos()
    {
        if (miVector == null || miVector.Length == 0)
        {
            Console.WriteLine("El vector está vacío.");
            return;
        }

        Console.WriteLine("Valores actuales en el vector:");
        for (int i = 0; i < miVector.Length; i++)
        {
            Console.WriteLine("Posición " + i + ": " + miVector[i]);
        }
    }

    static void Desple()
    {
        if (miVector == null || miVector.Length == 0)
        {
            Console.WriteLine("No hay valores ingresados aún.");
            return;
        }

        Console.WriteLine("Los valores ingresados son:");
        for (int i = 0; i < miVector.Length; i++)
        {
            Console.Write(miVector[i] + " ");
        }
        Console.WriteLine();
    }

    static void BuscarDato()
    {
        if (miVector == null || miVector.Length == 0)
        {
            Console.WriteLine("No hay datos para buscar.");
            return;
        }

        Console.Write("Ingresa el número que deseas buscar: ");
        int numero = int.Parse(Console.ReadLine());
        bool encontrado = false;

        for (int i = 0; i < miVector.Length; i++)
        {
            if (miVector[i] == numero)
            {
                Console.WriteLine("El número se encuentra en la posición " + i);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Número no encontrado en el vector.");
        }
    }

    static void ActualizarDato()
    {
        if (miVector == null || miVector.Length == 0)
        {
            Console.WriteLine("No hay datos para actualizar.");
            return;
        }

        Console.Write("Ingresa la posición que deseas actualizar: ");
        int posicion = int.Parse(Console.ReadLine());

        if (posicion >= 0 && posicion < miVector.Length)
        {
            Console.Write("Ingresa el nuevo valor: ");
            int nuevoValor = int.Parse(Console.ReadLine());
            miVector[posicion] = nuevoValor;
            Console.WriteLine("Valor actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("Posición inválida.");
        }
    }

    static void OrdenarValores()
    {
        if (miVector == null || miVector.Length == 0)
        {
            Console.WriteLine("No hay datos para ordenar.");
            return;
        }

        for (int i = 0; i < miVector.Length - 1; i++)
        {
            for (int j = i + 1; j < miVector.Length; j++)
            {
                if (miVector[i] > miVector[j])
                {
                    int temp = miVector[i];
                    miVector[i] = miVector[j];
                    miVector[j] = temp;
                }
            }
        }

        Console.WriteLine("Vector ordenado de menor a mayor.");
    }

    static void Main()
    {
        int num;
        do
        {
            num = Menu();

            switch (num)
            {
                case 1:
                    Ingresodatos();
                    break;
                case 2:
                    LeerDatos();
                    break;
                case 3:
                    Desple();
                    break;
                case 4:
                    BuscarDato();
                    break;
                case 5:
                    ActualizarDato();
                    break;
                case 6:
                    OrdenarValores();
                    break;
                case 7:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }

        } while (num != 7);
    }


    /*
    //Codigo 2
     struct Producto
    {
        public string Nombre;
        public string Codigo;
        public decimal Precio;
        public int Cantidad;
    }

    static Producto[] inventario = new Producto[100]; // Capacidad máxima de 100 productos
    static int totalProductos = 0;

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- Menú de Inventario ---");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Modificar precio de un producto");
            Console.WriteLine("3. Mostrar productos");
            Console.WriteLine("4. Calcular valor total del inventario");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarProducto();
                    break;
                case 2:
                    ModificarPrecio();
                    break;
                case 3:
                    MostrarProductos();
                    break;
                case 4:
                    CalcularValorInventario();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 5);
    }

    static void AgregarProducto()
    {
        if (totalProductos >= inventario.Length)
        {
            Console.WriteLine("Inventario lleno. No se pueden agregar más productos.");
            return;
        }

        Producto nuevo;
        Console.Write("Nombre del producto: ");
        nuevo.Nombre = Console.ReadLine();
        Console.Write("Código del producto: ");
        nuevo.Codigo = Console.ReadLine();
        Console.Write("Precio del producto: ");
        nuevo.Precio = decimal.Parse(Console.ReadLine());
        Console.Write("Cantidad del producto: ");
        nuevo.Cantidad = int.Parse(Console.ReadLine());

        inventario[totalProductos] = nuevo;
        totalProductos++;

        Console.WriteLine("Producto agregado correctamente.");
    }

    static void ModificarPrecio()
    {
        Console.Write("Ingrese el código del producto: ");
        string codigo = Console.ReadLine();
        bool encontrado = false;

        for (int i = 0; i < totalProductos; i++)
        {
            if (inventario[i].Codigo == codigo)
            {
                Console.Write("Nuevo precio: ");
                decimal nuevoPrecio = decimal.Parse(Console.ReadLine());
                inventario[i].Precio = nuevoPrecio;
                Console.WriteLine("Precio modificado correctamente.");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    static void MostrarProductos()
    {
        Console.WriteLine("\n--- Lista de Productos ---");
        for (int i = 0; i < totalProductos; i++)
        {
            Console.WriteLine("Nombre: " + inventario[i].Nombre + ", Código: " + inventario[i].Codigo + ", Precio: " + inventario[i].Precio + ", Cantidad: " + inventario[i].Cantidad);
        }
    }

    static void CalcularValorInventario()
    {
        decimal total = 0;
        for (int i = 0; i < totalProductos; i++)
        {
            total += inventario[i].Precio * inventario[i].Cantidad;
        }
        Console.WriteLine("Valor total del inventario: " + total);
    }
    */
}

