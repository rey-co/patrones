using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class VehiculoBuilder
    {
        // Declaramos la referencia del producto a construir
        protected Vehiculo v;

        // Declaramos el método que recuperará el objeto
        public Vehiculo GetVehiculo()
        {
            return v;
        }

        #region Métodos Abstractos

        public abstract void DefinirVehiculo();
        public abstract void ConstruirRuedas();
        public abstract void ConstruirHabitaculo();
        public abstract void ConstruirMotor();
        public abstract void DefinirExtras();

        #endregion
    }
}
