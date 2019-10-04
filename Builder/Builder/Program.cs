using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definimos un director, pasándole un constructor de Audi como parámetro
            VehiculoDirector directorAudi = new VehiculoDirector(new A3SportbackBuilder());

            // El director construye el vehiculo, delegando en el constructor la tarea de
            // creación de cada una de las piezas
            directorAudi.ConstruirVehiculo();

            // Obtenemos el vehículo directamente del director, aunque la instancia del vehículo
            // se encuentra en el constructor.
            Vehiculo audiA3 = directorAudi.GetVehiculo();

            // Repetimos el proceso con un constructor distinto.
            VehiculoDirector directorCitroen = new VehiculoDirector(new CitroenXsaraBuilder());
            directorCitroen.ConstruirVehiculo();
            Vehiculo citroen = directorCitroen.GetVehiculo();

            // Mostramos por pantalla los dos vehiculos:
            Console.WriteLine("PRIMER VEHICULO:" + Environment.NewLine);
            Console.WriteLine(audiA3.GetPrestaciones());

            Console.WriteLine("SEGUNDO VEHICULO:" + Environment.NewLine);
            Console.WriteLine(citroen.GetPrestaciones());

            Console.ReadLine();
        }
    }
    // Tipo de rueda: diámetro, llanta y neumático
    public class Rueda
    {
        public int Diametro { get; set; }
        public string Llanta { get; set; }
        public string Neumatico { get; set; }
    }
    // Tipo de carrocería
    public class Carroceria
    {
        public bool HabitaculoReforzado { get; set; }
        public string Material { get; set; }
        public string TipoCarroceria { get; set; }
    }
    // Interfaz que expone las propiedades del motor
    public interface IMotor
    {
        string ConsumirCombustible();
        string InyectarCombustible(int cantidad);
        string RealizarEscape();
        string RealizarExpansion();
    }
}
