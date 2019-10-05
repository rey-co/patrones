using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaCajero cajero_automatico = new FachadaCajero();



            cajero_automatico.introducirCredenciales();

            cajero_automatico.sacarDinero();
        }
    }

    public class Autentificacion
    {

        /* ... */

        public Boolean leerTarjeta() { return true; }

        public String introducirClave() { return "Ok"; }

        public Boolean comprobarClave(String clave) { return true; }

        public Cuenta obtenerCuenta() { return null; }

        public void alFallar() { }

    }



    public class Cajero
    {

        /* ... */

        public int introducirCantidad() { return 15000; }

        public int tieneSaldo(int cantidad) { return 11500; }

        public int expedirDinero() { return 500; }

        public String imprimirTicket() { return "Se ha impreso"; }

    }



    public class Cuenta
    {

        /* ... */

        public double comprobarSaldoDisponible() { return 10000; }

        public Boolean bloquearCuenta() { return false; }

        public Boolean desbloquearCuenta() { return true; }

        public void retirarSaldo(int cantidad) { }

        public Boolean actualizarCuenta() { return true; }

        public void alFallar() { }

    }

    public class FachadaCajero
    {

        private Autentificacion autentificacion = new Autentificacion();

        private Cajero cajero = new Cajero();

        private Cuenta cuenta = null;



        public void introducirCredenciales()
        {

            bool tarjeta_correcta = autentificacion.leerTarjeta();

            if (tarjeta_correcta)
            {

                String clave = autentificacion.introducirClave();

                bool clave_correcta = autentificacion.comprobarClave(clave);

                if (clave_correcta)
                {

                    cuenta = autentificacion.obtenerCuenta();

                    return;

                }

            }

            autentificacion.alFallar();

        }



        public void sacarDinero()
        {

            if (cuenta != null)
            {

                int cantidad = cajero.introducirCantidad();

                int tiene_dinero = cajero.tieneSaldo(cantidad);

                if (tiene_dinero>0)
                {

                    bool hay_saldo_suficiente = ((int)cuenta.comprobarSaldoDisponible()) >= cantidad;

                    if (hay_saldo_suficiente)
                    {

                        cuenta.bloquearCuenta();

                        cuenta.retirarSaldo(cantidad);

                        cuenta.actualizarCuenta();

                        cuenta.desbloquearCuenta();



                        cajero.expedirDinero();

                        cajero.imprimirTicket();

                    }

                    else
                    {

                        cuenta.alFallar();

                    }

                }

            }

        }

    }


}
