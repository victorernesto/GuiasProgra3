using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaDeSemana7
{
    internal class ClsCalzado
    {
        //public string marca;
        //public double talla;
        public double precioTotal;
        public string infoCalzados;
        public string nombre;
        public int opcion;

        public string z1,z2,z3;

        public string []array = new string[0];

        int op;

        public void informacion(/*string Marca, double Talla,int Descuento*/)
        {
            Console.WriteLine("EN QUE TIENDA DESEA COMPRAR");
            Console.WriteLine("1-NIKE");
            Console.WriteLine("2-ADIDAS");
            Console.WriteLine("3-PUMA");
            Console.WriteLine("4-JORDAN");
            opcion=int.Parse( Console.ReadLine());

            switch(opcion)
            {
                
                case 1:

                    z1 = "MARCA: nike dunk low TALLA: 8.5 PRECIO: $100 DESCUENTO: 50%";
                    z2 = "MARCA: nike dunk high TALLA: 9.0 PRECIO: $200 DESCUENTO 10%";
                    z3 = "MARCA: nike air max 97 TALLA: 8.5 PRECIO: $150 DESCUENTO 30%";

                    Console.WriteLine($"que estilo de zapatos desea \n1-{z1} \n2-{z2} \n3-{z3} ");
                    op=int.Parse( Console.ReadLine());
                    if(opcion==1)
                    {
                        Console.WriteLine("Cual es su nombre");
                       nombre= Console.ReadLine();
                        precioTotal = 100.00*0.5;
                        Console.WriteLine($"el usuario {nombre} compro los zapatos {z1} \nPrecio total {precioTotal} ");
                    }
                    break;
                case 2:

                    z1 = "MARCA: breaknet TALLA: 8.5 PRECIO: $100 DESCUENTO: 50%";
                    z2 = "MARCA: hoops 3.0 TALLA: 9.0 PRECIO: $200 DESCUENTO 10%";
                    z3 = "MARCA: duramo sl TALLA: 8.5 PRECIO: $150 DESCUENTO 30%";

                    Console.WriteLine($"que estilo de zapatos desea \n1-{z1} \n2-{z2} \n3-{z3} ");
                    op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.WriteLine("Cual es su nombre");
                        nombre = Console.ReadLine();
                        precioTotal = 100.00 * 0.1;
                        Console.WriteLine($"el usuario {nombre} compro los zapatos {z1} \nPrecio total {precioTotal} ");
                    }
                    else if (op == 2)
                    {
                        Console.WriteLine("Cual es su nombre");
                        nombre = Console.ReadLine();
                        precioTotal = 200.00 * 0.1;
                        Console.WriteLine($"el usuario {nombre} compro los zapatos {z2} \nPrecio total {precioTotal} ");
                    }
                    else if(op == 3)
                    {
                        Console.WriteLine("Cual es su nombre");
                        nombre = Console.ReadLine();
                        precioTotal = 150.00 * 0.3;
                        Console.WriteLine($"el usuario {nombre} compro los zapatos {z3} \nPrecio total {precioTotal} ");
                    }
                    break;
                case 3:

                    z1 = "MARCA: air jordan 2 retro low TALLA: 8.5 PRECIO: $100 DESCUENTO: 50%";
                    z2 = "MARCA: high og TALLA: 9.0 PRECIO: $200 DESCUENTO 10%";
                    z3 = "MARCA: ari jordan 13 retro TALLA: 8.5 PRECIO: $150 DESCUENTO 30%";

                    Console.WriteLine($"que estilo de zapatos desea \n1-{z1} \n2-{z2} \n3-{z3} ");
                    op = int.Parse(Console.ReadLine());
                    if (opcion == 2)
                    {
                        Console.WriteLine("Cual es su nombre");
                        nombre = Console.ReadLine();
                        precioTotal = 150.00 * 0.3;
                        Console.WriteLine($"el usuario {nombre} compro los zapatos {z2} \nPrecio total {precioTotal} ");
                    }
                    break;
            }
        }

             

    }
}
