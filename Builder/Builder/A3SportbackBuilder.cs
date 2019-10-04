using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class A3SportbackBuilder:VehiculoBuilder
    {
        public override void DefinirVehiculo()
        {
            v = new Vehiculo();
            v.Marca = "Audi";
            v.Modelo = "A3 Sportback";
        }

        // Método que construirá las ruedas
        public override void ConstruirRuedas()
        {
            v.TipoRuedas = new Rueda();
            v.TipoRuedas.Diametro = 17;
            v.TipoRuedas.Llanta = "aluminio";
            v.TipoRuedas.Neumatico = "Michelin";
        }

        // Método que construirá el motor
        public override void ConstruirMotor()
        {
            v.Motor = new MotorDiesel();
        }

        // Método que construirá el habitaculo
        public override void ConstruirHabitaculo()
        {
            v.TipoCarroceria = new Carroceria();
            v.TipoCarroceria.TipoCarroceria = "deportivo";
            v.TipoCarroceria.HabitaculoReforzado = true;
            v.TipoCarroceria.Material = "fibra de carbono";
            v.Color = "plata cromado";
        }

        public override void DefinirExtras()
        {
            v.CierreCentralizado = true;
            v.DireccionAsistida = true;
        }
    }
}
