using System; // Importa el espacio de nombres System, que contiene clases fundamentales para el uso de la consola, la generación de números aleatorios, etc.

class Program {
    static void Main() {

        // Se declaran variables de control y de estado para la ejecución del juego.
        // "valido", "valido1" y "valido2" controlan la validación de entradas de usuario mediante bucles.
        bool valido = false;
        int valor = 0;

        bool valido1 = false;
        int valor1 = 0;

        bool valido2 = false;
        int valor2 = 0;

        // Variables iniciales que representan el estado de la misión
        int dias        = 0;     // Cuenta los días de la misión
        int Combustible = 30;    // Nivel inicial de combustible
        int Oxigeno     = 70;    // Nivel inicial de oxígeno

        double Suministros = 70; // Cantidad de suministros disponibles (en un tipo de dato double para permitir cálculos decimales)
        int nave        = 100;   // Porcentaje de integridad de la nave (100 indica estado perfecto)
        int multi = 0;           // Variable utilizada para multiplicar el porcentaje de reparación por el costo en suministros

        int rendir = 0;          // Variable que indica si el usuario se rinde (valor 1 representa rendición)

        // Se crea la instancia "random" para generar números aleatorios a lo largo del juego.
        Random random = new Random();

        // Limpia la pantalla y comienza la simulación del viaje espacial.
        Console.Clear();
        // Mensaje de bienvenida y presentación de la narrativa del juego.
        Console.WriteLine("Bienvenido Capitán Tadeus, soy tu asistente y te acompañare en tu viaje galactico");
        // Pausa de 2000 milisegundos para simular carga y generar tensión.
        Thread.Sleep(2000);
        Console.WriteLine("Presiona una tecla para despegar");
        // Espera a que el usuario presione una tecla para continuar con el despegue.
        Console.ReadKey();
        Console.WriteLine("Despegando, sujetate...");
        Thread.Sleep(1500);

        // Bucle principal del juego: se ejecuta mientras se cumplan las condiciones de días y recursos.
        while (dias <= 10 && Combustible > 0 && Oxigeno > 0 && nave > 0){
            // Incrementa el contador de días con cada iteración.
            dias++;
            // Reduce la cantidad de oxígeno cada día; se garantiza que el oxígeno no sea negativo.
            //Oxigeno -= 20;
            if (Oxigeno < 0) Oxigeno = 0;
            // Reduce los suministros diarios; se garantiza que tampoco sean negativos.
            //Suministros -= 30;
            if (Suministros < 0) Suministros = 0;

            // Muestra el estado actual de la misión: día, integridad de la nave y recursos vitales.
            Console.WriteLine("El numero de dia es " + dias + " El estado de la nave es " + nave);
            Console.WriteLine("Los datos vitales para la mision son, Combustible " + Combustible + " Oxigeno " + Oxigeno + " Suministros " + Suministros);
    
            // Verifica condiciones críticas para terminar la misión: si alguno de los recursos llega a 0.
            if (Oxigeno == 0){
                break;
            }
            if (Combustible == 0){
                break;
            }
            if (Suministros == 0){
                break;
            }

            Thread.Sleep(2500);
    
            // Presenta el menú de opciones al usuario para elegir la siguiente acción.
            Console.WriteLine("1 Explorar planeta nuevo");
            Console.WriteLine("2 Reparar la nave");
            Console.WriteLine("3 Enviar señal");
            Console.WriteLine("4 Rendirse");

            // Bucle que valida la entrada del usuario utilizando TryParse.
            // Se asegura de que el usuario ingrese un número entero válido dentro del rango permitido.
            while (!valido)
            {
                Console.WriteLine("Ingrese un número válido:");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out valor))
                {
                    if (valor <= 4 && valor > 0)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un numero dentro del rango solicitado");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Ingrese un valor numerico.");
                }
            }
            // Se almacena la opción validada en la variable "num"
            int num = valor;
    
            // Se utiliza una estructura switch para ejecutar acciones según la opción elegida por el usuario.
            switch (num)
            {
                case 1:
                    // Opción 1: Explorar un nuevo planeta.
                    // Solo permite explorar si hay suficiente combustible (mínimo 15 unidades).
                    if(Combustible >= 15){
                        //Combustible -=15;
                        Console.WriteLine("Explorando nuevo Planeta");

                        Thread.Sleep(500);

                        Console.WriteLine("ha llegado al nuevo planeta");
                        Console.WriteLine("En busca de oxigeno, combustible y suministros");

                        Thread.Sleep(1500);
                        // Uso de un número aleatorio para determinar la probabilidad de encontrar oxígeno.
                        if (random.Next(0, 100) <= 60){
                            int oxigenoEncontrado = random.Next(20,40);
                            Console.WriteLine("Encontraste oxigeno " + oxigenoEncontrado);
                            Oxigeno += oxigenoEncontrado;
                        }else{
                            Console.WriteLine("No se econtro oxigeno");
                        }

                        // Probabilidad de encontrar combustible durante la exploración.
                        if (random.Next(0, 100) <= 25){ 
                            int combustiblenontrado = random.Next(10,30);
                            Console.WriteLine("encontraste combustible " + combustiblenontrado);
                            Combustible += combustiblenontrado;
                        }else{
                            Console.WriteLine("No se econtro combustible");
                        }
                        // Probabilidad de encontrar suministros.
                        if (random.Next(0, 100) <=50){ 
                            int suministroencontrado = random.Next(30,100);
                            Console.WriteLine("encontraste suministros " + suministroencontrado);
                            Suministros += suministroencontrado;
                        }else{
                            Console.WriteLine("No se econtro nada mas");
                        }
                        Console.WriteLine("Seguire con mi camino \r\n");

                        Thread.Sleep(5000);

                        // Eventos aleatorios que pueden dañar la nave durante la exploración:
                        // Posible tormenta electrica.
                        if (random.Next(0, 100) <=25){ 
                            int tormentaelectrica = random.Next(10,20);
                            nave -= tormentaelectrica;
                            Console.WriteLine("Oh no una tormenta electrica");
                            Thread.Sleep(2000);
                            Console.WriteLine("Calculando daños de la nave");
                            Thread.Sleep(1500);
                            Console.WriteLine("El porcentaje de daños de la nave es de " + tormentaelectrica);
                        }
                        // Posible aterrizaje forzado que causa daño.
                        if (random.Next(0, 100) <=25){ 
                            int aterrizajeforzad = random.Next(10,20);
                            nave -= aterrizajeforzad;
                            Console.WriteLine("Tenemos problemas en la nave parece que vamos a caer, sujetate!!");
                            Thread.Sleep(3000);
                            Console.WriteLine("Calculando daños de la nave...");
                            Thread.Sleep(1500);
                            Console.WriteLine("El porcentaje de daños de la nave es de " + aterrizajeforzad);
                        }
                    } else {
                        Console.WriteLine("No tiene suficiente combustible para explorar un nuevo planeta " + Combustible);
                    }
                    break;

                case 2:
                    // Opción 2: Reparar la nave.
                    // Primero se verifica si la nave ya se encuentra en perfecto estado.
                    if (nave == 100){
                        Console.WriteLine("La intengridad de la nave esta al 100 no es necesario reparar");
                    } else {
                        // Solo permite reparar si la integridad de la nave es superior a 25 (como lógica interna del juego)
                        if (nave > 25){
                            int resta = 100 - nave; // Daño total a reparar
                            double convertirSuminis = Suministros / 10; // Conversión de suministros disponibles en porcentaje de reparación
                            Console.WriteLine("Hay disponible para reparar: " + convertirSuminis + " (aproximado de la cantidad de suministros disponibles para reparar)");
                            Console.WriteLine("Recuerda que cada porcentaje reparado consume 10 unidades de suministro. Cuentas con: " + Suministros);
                            Console.WriteLine("Daño en la nave: " + resta);

                            // Se valida la entrada del usuario para determinar el porcentaje a reparar
                            while (!valido1)
                            {
                                Console.WriteLine("¿Cuanto porcentaje desea reparar?");
                                string entrada1 = Console.ReadLine();

                                if (int.TryParse(entrada1, out valor1))
                                {
                                    multi = valor1 * 10; // Calcula el costo en suministros para la reparación

                                    if (valor1 < 1 || valor1 > 100)
                                    {
                                        Console.WriteLine("El numero ingresado no está dentro del rango del 1 al 100");
                                    }
                                    else if (valor1 > resta)
                                    {
                                        Console.WriteLine("La cantidad ingresada excede el daño de la nave");
                                    }
                                    else if (multi > Suministros)
                                    {
                                        Console.WriteLine("La cantidad ingresada excede la cantidad de suministros disponibles");
                                    }
                                    else
                                    {
                                        valido1 = true; // Condición válida para salir del bucle de validación
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error: Ingrese un número numérico.");
                                }
                            }
                            int porcenNv = valor1; // Porcentaje de reparación que se aplicará

                            Suministros -= multi; // Descuenta los suministros usados en la reparación
                            nave += porcenNv;     // Incrementa la integridad de la nave según la reparación realizada
                            Console.WriteLine("Nave reparada. " + nave);
                        }
                    }
                    break;

                case 3:
                    // Opción 3: Enviar señal.
                    // Se envía una señal que puede desencadenar diferentes eventos aleatorios.
                    Console.WriteLine("Enviando senal.....");
                    Thread.Sleep(3000);
                    int evento = random.Next(1,3);
                    if (evento == 1){
                        // Evento favorable: se encuentra combustible.
                        Combustible += 60;
                        Console.WriteLine("encontraste combustible 60, en total tienes " + Combustible);
                    }
                    if (evento == 2){
                        // Evento desfavorable: se atraen piratas espaciales que dañan la nave y consumen suministros.
                        Console.WriteLine("Se ha recibido una respueta.... No son buenas noticias");
                        Thread.Sleep(1500);
                        Console.WriteLine("Piratas espaciales han recibido la senal y vienen hacia nuesta posicion");
                        Thread.Sleep(1500);
                        Console.WriteLine("Preparate");
                        Thread.Sleep(3000);
                        Console.WriteLine("Calculando daños de la nave.....");
                        Thread.Sleep(3000);
                        nave -= 15;
                        Suministros -= 20; 
                        Console.WriteLine("La integridad de la nave es de " + nave);
                        Console.WriteLine("Tambien hemos perdido suministros nos quedan " + Suministros);
                    }
                    break;

                case 4:
                    // Opción 4: Rendirse. Esta opción asigna el valor 1 a "rendir" para finalizar el juego.
                    Console.WriteLine(" Te has rendido ");
                    rendir = 1;
                    break;
            }
            
            // Si el usuario decidió rendirse, se rompe el bucle principal y finaliza el juego.
            if (rendir == 1){
                break;
            }

            // Mensaje de transición que simula el paso de la jornada y el descanso nocturno.
            Console.WriteLine("Ha llegado la noche espero todo este traquilo... descansare \r\n");
            
            // Evento aleatorio nocturno: posibilidad de enfrentar adversidades durante la noche.
            if (random.Next(0, 100) <=15){ 
                int evento1 = random.Next(1,4);
                if (evento1 == 1){
                    // Evento: Tormenta cósmica que afecta el oxígeno.
                    Oxigeno -= 10;
                    Console.WriteLine("Se avecina una tormenta cosmica eso afecta los suministros de oxigeno");
                    Console.WriteLine("Hemos perdidos 10 unidades de oxigeno\r\n");
                }

                if (evento1 == 2){
                    // Evento: Contacto con aliens que puede resultar en un incremento de combustible o en daños.
                    int eventoalien = random.Next(1,3);
                    if (eventoalien == 1){
                        Console.WriteLine("Se detectan señales de proximidad...");
                        Console.WriteLine("Son Aliens!!!");
                        Console.WriteLine("Vienen en son de paz y traen con ellos combustible para la nave, haz recibido 20 unidades de combustible\r\n");
                        Combustible += 20; 
                    }
                    if (eventoalien == 2){
                        Console.WriteLine("Se detectan señales de proximidad...");
                        Console.WriteLine("Son Aliens!!!");
                        Console.WriteLine("No vienen en son de paz son hostiles!!! nos disparan cuidado!!!");
                        Thread.Sleep(3000);
                        Console.WriteLine("Han dañado la integridad de la nave en 10 unidades\r\n");
                        nave -= 10;
                    }
                }
                if (evento1 == 3){
                    // Evento: Lluvia de meteoritos, donde el usuario debe escoger entre gastar combustible para maniobrar o recibir el impacto.
                    Console.WriteLine("Los radares indican lluvia de metioritos, CUIDADO!!!!");
                    Console.WriteLine("Deseas maniobrar gastando combustible o recibir el impacto dañando la integridad de la nave");
                    Console.WriteLine("1. Para esquibar");
                    Console.WriteLine("2. Para recibir el impacto");
                    // Se valida la opción del usuario para tomar la decisión en este escenario.
                    while (!valido2)
                    {
                        Console.WriteLine("Ingrese un número válido:");
                        string entrada2 = Console.ReadLine();

                        if (int.TryParse(entrada2, out valor2))
                        {
                            if(valor2 <= 2 && valor2 >= 1)
                            {
                                valido2 = true;
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un numero dentro del rango solicitado entre 1 y 2");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: Ingrese un número numerico.");
                        }
                    }
                    int opt = valor2;
                    
                    if(opt == 1){
                        // Opción: Maniobras evasivas que no dañan la nave, pero consumen combustible.
                        Console.WriteLine("Ejecutando maniobras evasivas");
                        Thread.Sleep(3000);
                        int combustiblegasta = random.Next(10,30);
                        Console.WriteLine("No se daño la nave pero perdimos combustible, combustible gastado " + combustiblegasta + "\r\n");
                        Combustible -= combustiblegasta;
                    }
                    if(opt == 2){
                        // Opción: Recibir el impacto y sufrir daños en la nave.
                        Console.WriteLine("Preparate para recibir el impacto");
                        Thread.Sleep(3000);
                        int impacto1 = random.Next(15,25);
                        Console.WriteLine("Impacto recibido los daños totales fueron de " + impacto1 + "\r\n");
                        nave -= impacto1;
                    }
                }
            }
    
            // Restablecimiento de variables de validación para la siguiente iteración del menú.
            valor = 0;
            valido = false;
        }

        // Verifica condiciones de término del juego y muestra un mensaje final basado en el recurso que se agotó o en el paso de los días.
        if (dias >= 10){
            Console.WriteLine("Juego terminado, Has llegado a tu destino");
        }
        if (Combustible == 0){
            Console.WriteLine("Juego terminado, sin combustible");
        }
        if (Oxigeno == 0){
            Console.WriteLine("Juego terminado, sin Oxigeno");
        }
        if (Suministros == 0)
        {
            Console.WriteLine("Juego terminado, sin suministros");
        }
    }
}
