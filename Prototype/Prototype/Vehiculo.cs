using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public Rueda TipoRueda { get; set; }
        public Carroceria TipoCarroceria { get; set; }

        public string VehiculoInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Marca: ").Append(Marca).Append(Environment.NewLine);
            sb.Append("Modelo: ").Append(Modelo).Append(Environment.NewLine);
            sb.Append("Color: ").Append(Color).Append(Environment.NewLine);
            sb.Append("Ruedas: ").Append(TipoRueda.Llanta).Append(" ");
            sb.Append(TipoRueda.Diametro).Append(" ").Append(TipoRueda.Neumatico).Append(Environment.NewLine);
            sb.Append("Carroceria: ").Append(TipoCarroceria.HabitaculoReforzado).Append(" ");
            sb.Append(TipoCarroceria.TipoCarroceria).Append(" ").Append(TipoCarroceria.Material).Append(Environment.NewLine);

            return sb.ToString();
        }

        ///#region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }   
}