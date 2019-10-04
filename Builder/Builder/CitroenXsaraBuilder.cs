using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class CitroenXsaraBuilder:VehiculoBuilder
    {
        public override void DefinirVehiculo()
        {
            v = new Vehiculo();
            v.Marca = "Citroen";
            v.Modelo = "Xsara Picasso";
        }

        // Método que construirá las ruedas
        public override void ConstruirRuedas()
        {
            v.TipoRuedas = new Rueda();
            v.TipoRuedas.Diametro = 15;
            v.TipoRuedas.Llanta = "hierro";
            v.TipoRuedas.Neumatico = "Firestone";
        }

        public override void ConstruirMotor()
        {
            v.Motor = new MotorDiesel();
        }

        // Método que construirá el habitaculo
        public override void ConstruirHabitaculo()
        {
            v.TipoCarroceria = new Carroceria();
            v.TipoCarroceria.TipoCarroceria = "monovolumen";
            v.TipoCarroceria.HabitaculoReforzado = false;
            v.TipoCarroceria.Material = "acero";
            v.Color = "negro";
        }

        public override void DefinirExtras()
        {
            v.CierreCentralizado = false;
            v.DireccionAsistida = false;
        }
    }
}
