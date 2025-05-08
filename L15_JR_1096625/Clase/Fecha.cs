
namespace reservas.Clase{
    public class Fecha{
        private int  dia;
        private int mes;
        private int anio;
        private int Horaini;
        private int Horafin;

        public Fecha(int day, int month, int year, int HourBegi, int HourEnd){
            this.dia = day;
            this.mes = month;
            this.año = year;
            this.Horaini= HourBegi;
            this.Horafin = HourEnd;
        }
        public void setdia(int d){
            this.dia = d;
        }
        public int getdia(){
            return this.dia;
        }
        public void setmonth(int m){
            this.month = m;
        }
        public int getmonth(){
            return this.month;
        }
        public void setyear(int y){
            this.anio = y;
        }
        public int getyear(){
            return this.anio;
        }
        public void setHoraini(int hi){
            this.Horaini = hi;
        }
        public int getHoraini(){
            return this.Horaini;
        }
        public void setHorafin(int hf){
            this.Horafin = hf;
        }
        public int getHorafin(){
            return this.Horafin;
        }
        public bool Fechaposible(){
            Console.WriteLine("Dia: "+ this.get());
            Console.WriteLine("Autor: "+ this.getAutor());
            Console.WriteLine("Año de publicacion: "+ this.getAnioPublicacion());
           string disp;
            if(this.disponibilidad == true){
                disp = "Si";
            }
            else{
                disp = "No";
            }
            Console.WriteLine("Disponibilidad: "+ disp);
        }

    
    public void prestarLibro(){
        if(this.getDisponibilidad()== true){
            this.setDisponibilidad(false);
        }
    }
    public void devolverLibro(){
    if(this.getDisponibilidad()== false){
            this.setDisponibilidad(true);
        }
    }
    };
}