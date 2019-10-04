using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class MotorDiesel:IMotor
    {
        #region IMotor Members

        public string ConsumirCombustible()
        {
            return RealizarCombustion();
        }

        public string InyectarCombustible(int cantidad)
        {
            return string.Format("MotorDiesel: Inyectados {0} ml. de Gasoil.", cantidad);
        }

        public string RealizarEscape()
        {
            return "MotorDiesel: Realizado escape de gases";
        }

        public string RealizarExpansion()
        {
            return "MotorDiesel: Realizada expansion";
        }

        #endregion

        private string RealizarCombustion()
        {
            return "MotorDiesel: Realizada combustion del Gasoil";
        }
    }
}
