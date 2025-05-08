using System; 
class Program { 
static void Main() { 
    /*
    Console.WriteLine("Ingrese su edad");
     int edad = int.Parse(Console.ReadLine());   
     if(edad < 12){
        Console.WriteLine("Es un niño");
     }else if (edad > 12 && edad < 17){
        Console.WriteLine("Es un adolecente");
     }else if (edad > 18 && edad < 64){
        Console.WriteLine("Es un adulto");
     }else {
        Console.WriteLine("Es un adulto mayor");
     }
    */
    /*
    Console.WriteLine("Ingrese su calificacion");
     int notas = int.Parse(Console.ReadLine());   
     if(notas >= 0 && notas <= 59){
        Console.WriteLine("Reprobado");
     }else if (notas >= 60 && notas <= 79){
        Console.WriteLine("Aprobado");
     }else if (notas >= 80 && notas <= 89){
        Console.WriteLine("Notable");
     }else if (notas >=90 && notas <=100) {
        Console.WriteLine("Excelente");
     }else{
        Console.WriteLine("Nota imposible");
     }
    */
    int tar = 2;
    double tarest = 0;
    double tarniñ = 0;

    Console.WriteLine("Seleccione una de las siguiente opciones para calcular la tarifa a pagar");
    Console.WriteLine("Tarifa de Q. 2.00");
    Console.WriteLine("1. adulto");
    Console.WriteLine("2. Estudiante");
    Console.WriteLine("3. adulto mayor");
    Console.WriteLine("4. Niño, debe ingresar su edad");
    Console.WriteLine("5. salir");
    
    int opt = int.Parse(Console.ReadLine());

    switch(opt){ 

    case 1: 
    Console.WriteLine("Debe pagar la tarifa normal Q." + tar);
    break;
    case 2:
    tarest = tar - (tar*0.5);
    Console.WriteLine("Debe pagar Q." + tarest);
    break;
    case 3:
    tarest = tar - (tar*0.3);
    Console.WriteLine("Debe pagar Q." + tarest);
    break;
    case 4:
    Console.WriteLine("Ingrese la edad del niño");
    int edad = int.Parse(Console.ReadLine());
    if (edad <= 5){ 
    Console.WriteLine("Es gratis");
    } else if (edad > 5 && edad <= 12){
    tarniñ = tar - (tar*0.5);
    Console.WriteLine("La tarifa a pagar es de Q." + tarniñ);    
    }else{
    Console.WriteLine("No es un niño");   
    }
    break;
    case 5:
    Console.WriteLine("Salindo del programa");   
    break;

    default:
     Console.WriteLine("Opcion no disponible");   
     break;
    }
 }
}