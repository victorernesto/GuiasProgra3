using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace practicaTres
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MarcaNike[] nike= new MarcaNike[1];

            //variables paqra recolectar datos
            string marca,tipoDeprenda,color;
            int cantidad;
            double precio,total;
            string opcion;

            

                Console.WriteLine("DE QUE MARCA DE PRENDA DESEA AGREGAR");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "nike":
                        
                        marca = "nike";
                        Console.WriteLine("tipo de prenda");
                        tipoDeprenda = Console.ReadLine();
                        Console.WriteLine("color");
                        color = Console.ReadLine();
                        Console.WriteLine("precio");
                        precio = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("cantidad");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        total=precio * cantidad;
                        nike[0] = new MarcaNike(marca, tipoDeprenda, color, precio, cantidad,total);
                        break;

                case "adidas":
                    Console.WriteLine("marca");
                    marca = "adidas";
                    Console.WriteLine("tipo de prenda");
                    tipoDeprenda = Console.ReadLine();
                    Console.WriteLine("color");
                    color = Console.ReadLine();
                    Console.WriteLine("precio");
                    precio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("cantidad");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    total = precio * cantidad;
                    nike[0] = new MarcaNike(marca, tipoDeprenda, color, precio, cantidad,total);
                    break;

                case "gucci":
                    Console.WriteLine("marca");
                    marca = "gucci";
                    Console.WriteLine("tipo de prenda");
                    tipoDeprenda = Console.ReadLine();
                    Console.WriteLine("color");
                    color = Console.ReadLine();
                    Console.WriteLine("precio");
                    precio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("cantidad");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    total = precio * cantidad;
                    nike[0] = new MarcaNike(marca, tipoDeprenda, color, precio, cantidad,total);
                    break;
                }

                for (int i = 0; i < nike.Length; i++)
                {
                    Console.WriteLine(nike[i].informacion());
                }
           
                Console.ReadKey();

        }
    }

}

public abstract class datos
{
   public string marca { get; set; }
    public string tipoDePrenda { get; set; }
    public string color { get; set; }
    public double precio { get; set; }
    public int cantidad { get; set; }

    public double total { get; set; }

    public abstract string informacion();
}

public class MarcaNike : datos
{
  public  MarcaNike(string Marca, string TipoDeprenda, string Color, double Precio, int Cantidad,double total)
    {
        this.marca = Marca;
        this.tipoDePrenda = TipoDeprenda;
        this.color = Color;
        this.precio= Precio;
        this.cantidad= Cantidad;
        this.total= total;

    }

    public override string informacion()
    {
        string informacion=$"El producto agregado es: \n Prenda: {this.tipoDePrenda } \n Marca: {this.marca} \ncolor: {this.color} \nprecio: {this.precio} \ncantidad: {this.cantidad} \nTotal: {this.total} ";
        
        return informacion;
        
    }
}