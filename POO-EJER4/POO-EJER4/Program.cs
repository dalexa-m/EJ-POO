using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EJER4
{
    class Vehiculo
    {
      
        string marca;
        string modelo;
        int km;
        decimal precio;
        int annio;

        //contructor con sus propiedades
        //
        public Vehiculo() { }
        public Vehiculo(string marca, string modelo, int km, decimal precio, int annio)
        {

            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
            this.Annio = annio;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Annio { get => annio; set => annio = value; }

        public override string ToString()
        {
            return "Modelo: " + modelo + "\n " + "Marca: " + marca + "\n" + "Kilometraje: " + km + "\n" + " Precio: " + precio + "Año: " + annio;
        }

        public virtual Decimal CalPrecio()
        {
            return precio;
        }


    }

    class Auto : Vehiculo
    {
        bool airbag;

        public Auto(string marca, string modelo, int km, decimal precio, int annio, bool airbag)
        : base(marca, modelo, km, precio, annio)
        {
            this.airbag = airbag;
        }

        public bool Airbag { get => airbag; set => airbag = value; }

        public override decimal CalPrecio()
        {
            if (airbag)
            {
                return base.CalPrecio() + 200;
            }
            else
            {
                return base.CalPrecio();
            }

        }
        public override string ToString()
        {
            return "Modelo: " + Modelo + "\n " + "Marca: " + Marca + "\n" + "Kilometraje: " + Km + "\n" + " Precio: " + CalPrecio() + "Año: " + Annio;
        }


    }

    class Moto : Vehiculo
    {
        bool sidecar;
        public Moto(string marca, string modelo, int km, decimal precio, int annio, bool sidecar)
        : base(marca, modelo, km, precio, annio)
        {
            this.sidecar = sidecar;
        }
        public bool Sidecar { get => sidecar; set => sidecar = value; }

        public override decimal CalPrecio()
        {
            if (sidecar)
            {
                return base.CalPrecio() + 50;
            }
            else
            {
                return base.CalPrecio();
            }

        }
        public override string ToString()
        {
            return "Modelo: " + Modelo + "\n " + "Marca: " + Marca + "\n" + "Kilometraje: " + Km + "\n" + " Precio: " + CalPrecio()+"\n"+" Año: " + Annio;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo veh = new Vehiculo("Toyota ", " Corola", 5000, 12000, 2017);
            Console.WriteLine("Vehiculo: "+veh);
            Console.WriteLine("------");
            Auto auto = new Auto("Ford", " Mustang", 3000, 20000, 2019, true);
            Console.WriteLine("Auto: "+auto);
            Console.WriteLine("------");
            Moto moto = new Moto("Yamaha", " YZF-R6", 2000, 50000, 2022, false);
            Console.WriteLine("Moto: "+moto);


            Console.ReadKey();
        }
    }
}
