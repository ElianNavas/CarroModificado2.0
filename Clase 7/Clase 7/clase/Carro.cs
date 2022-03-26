using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7.clase
{
    internal class Carro
    {
        public String Marca { get; }
        public int KPH { get; }
        public string Color { get; set; }
 

        private int Encendido = 0;
        private int velocidad_actual = 0;
        private const int MAXVELOCIDAD = 150;
        private const int MINVELOCIDAD = 0;
        private int Apagado = 0;
        private int bocina = 0;
      
        
        

        public Carro(string _marca, int _kph, string _color)

        {
            Marca = _marca;
            KPH = _kph;
            Color = _color;
            Encendido = 0;
            
            this.velocidad_actual = 0;
        }

        public string GetVelocidadActual()
        {

            return $"Vamos a {velocidad_actual} KPH";

        }
        public void EncenderMotor()
        {
            if (Encendido == 0)
            {
                Console.WriteLine("Carro encendido, run run run , listo para correr");
                Encendido = 1;
                this.velocidad_actual = 0;
            }
            else
            {
                Console.WriteLine("Deja de presionar el acelerador ");
            }
        }

        public string acelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"No puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += 10;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual} KPH Aguas rapido y furioso, vas muy rapido y ya llegaste al tope";
            }

            Console.WriteLine(mensaje);
            return mensaje;
        }

        public string acelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += CuantosKPH;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Aguas rapido y furioso, vas muy rapido y ya llegaste al tope";
            }
            Console.WriteLine(mensaje);
            return mensaje;
        }


        public string desacelerar(int v)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"Esta bajando la velocidad";
                return mensaje;
            }

            velocidad_actual -= 10;
            if (velocidad_actual >= MINVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = 0;
                mensaje = " ";
            }

            Console.WriteLine(mensaje);
            return mensaje;
        }

        public string frenar()
        {
            string mensaje = "";
            if (Encendido == 10)
            {
                mensaje = $"Pisa el Freno";
                return mensaje;
            }

            velocidad_actual -= 10;
            if (velocidad_actual >= MINVELOCIDAD)
            {
                //mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = 0;
                mensaje = "El Carro esta Frenado";
            }

            Console.WriteLine(mensaje);
            return mensaje;
        }

        public void Bocina()
        {
            if (Encendido == 0)
            {
                Console.WriteLine("Carro encendido, run run run , listo para correr");
                Encendido = 1;
                this.velocidad_actual = 0;
            }
            else
            {
                Console.WriteLine("Toca la bocina");
                Console.WriteLine("PIIIIPIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII ");

            }
        }

        public void ApagarMotor()
        {
            if (Apagado == 0)
            {
                Console.WriteLine("Carro Apagado, Quita las llaves y bajate del carro");
                Apagado = 1;
                this.velocidad_actual = 0;
            }
            else
            {
                Console.WriteLine(" ");
            }


        }
       

    }

}
