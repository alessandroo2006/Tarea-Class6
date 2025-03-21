using claseOOP1.misclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clas6.misclases
{
    class AutoDeCombustión : vehiculos

    {
        private int nivelGasolina = 20;
        private int velocidad;
        public AutoDeCombustión(int anio, string model, string elColor) : base(anio, model, elColor)

            public int Velocidad
        {
            get { return velocidad; }
            private set { velocidad = value; }
        }

        public void Frenar()
        {
            if (Velocidad > 0)
            {
                Velocidad -= 10; 
                Console.WriteLine($"El vehículo ha frenado. Velocidad actual: {Velocidad} km/h");
            }
            else
            {
                Console.WriteLine("El vehículo ya está detenido.");
            }
        }


        public void cargarGasolina()
        {
            nivelGasolina++;
        }

        public int verNivelGasolina()
        {
            return nivelGasolina;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Año: {anio}, Modelo: {Modelo}, Color: {Color}, Velocidad: {Velocidad} km/h");
        }

    }

}