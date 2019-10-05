using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var referenciaB = new Referencia("B", 4);
            var conjuntoB = new Componente(referenciaB);

            var referenciaB1 = new Referencia("B1", 1);
            var piezaB1 = new Componente(referenciaB1);

            var referenciaB2 = new Referencia("B2", 2);
            var conjuntoB2 = new Componente(referenciaB2);

            var referenciaB21 = new Referencia("B21", 1);
            var piezaB21 = new Componente(referenciaB21);

            var referenciaB22 = new Referencia("B22", 2);
            var piezaB22 = new Componente(referenciaB22);

            conjuntoB2.Añadir(3, piezaB21);
            conjuntoB2.Añadir(2, piezaB22);

            conjuntoB.Añadir(5, piezaB1);
            conjuntoB.Añadir(3, conjuntoB2);

            Console.WriteLine("Coste de " + conjuntoB.Nombre + ":");
            Console.WriteLine(conjuntoB.CalcularCoste(1));
            Console.ReadKey();
        }
    }
    public class Referencia
    {
        public Referencia(string nombre, decimal coste)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException(nameof(nombre));

            if (coste < 0)
                throw new ArgumentException(nameof(coste));

            Nombre = nombre;
            Coste = coste;
        }
        public string Nombre { get; }
        public decimal Coste { get; }
    }
    public class Componente
    {
       
        private readonly Referencia _referencia;
        private readonly List<Componente> _subComponentes;

        public int Cantidad { get; set; }

        public string Nombre
        {
            get { return _referencia.Nombre; }
        }

        public void Añadir(Componente componente)
        {
            _subComponentes.Add(componente);
        }

        public void Quitar(Componente componente)
        {
            _subComponentes.Remove(componente);
        }

        public Componente(Referencia referencia)
        {
            _referencia = referencia;
            _subComponentes = new List<Componente>();
            Cantidad = 1;
        }

        public void Añadir(int cantidad, Componente componente)
        {
            componente.Cantidad = cantidad;
            Añadir(componente);

        }


        public decimal CalcularCoste(int nivel)
        {
            decimal coste = _referencia.Coste;

            Console.WriteLine(new String('-', nivel) + $" {Nombre} - Coste: {coste} - Cantidad: {Cantidad}");

            foreach (var componenteProducto in _subComponentes)
            {
                coste = coste + componenteProducto.CalcularCoste(nivel + 1)
                                * componenteProducto.Cantidad;
            }

            return coste;
        }
    }

}
