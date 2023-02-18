using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Guia2
{
    internal class Program
    {
        static void Main(string[] args)
        {   //variables para el array de el cliente
            string Nombre, Apellido, Sexo;
            int Edad;

            //variables para el array de el cliente
            string NombreV, ApellidoV, SexoV;
            int EdadV;

            Cliente[] cliente = new Cliente[1];
            Vendedor[] vendedor= new Vendedor[1];

            int salirBucle = 0;

            while (salirBucle!=1)
            {
                Console.WriteLine("INGRESE LOS DATOS DEL CLIENTE");
                Console.WriteLine("Nombre");
                Nombre = Console.ReadLine();
                Console.WriteLine("Apellido");
                Apellido = Console.ReadLine();
                Console.WriteLine("Edad");
                Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Sexo");
                Sexo = Console.ReadLine();
                if (Edad < 18)
                {
                    Console.WriteLine("No se vende a menores de edad, ingrese nueva mente los datos");
                }
                else
                {

                    cliente[0] = new Cliente(Nombre, Apellido, Edad, Sexo);
                    
                }

                Console.WriteLine("INGRESE LOS DATOS DEL VENDEDOR");
                Console.WriteLine("Nombre");
                NombreV = Console.ReadLine();
                Console.WriteLine("Apellido");
                ApellidoV = Console.ReadLine();
                Console.WriteLine("Edad");
                EdadV = int.Parse(Console.ReadLine());
                Console.WriteLine("Sexo");
                SexoV = Console.ReadLine();
                if (EdadV < 18)
                {
                    Console.WriteLine("No puede aver un vendedor menor de edad");
                }
                else
                {

                    vendedor[0] = new Vendedor(NombreV, ApellidoV, EdadV, SexoV);
                    salirBucle++;
                }

            }

            for (int i = 0; i < cliente.Length; i++)
            {
               
                int opcion = 0;


                Console.WriteLine("ELIJA UN NUMERO DE BEBIDA");
                //bebidas calientes
                Console.WriteLine("1-Cafe");
                Console.WriteLine("2-te");
                //bebidas gaseosas
                Console.WriteLine("3-coca cola");
                Console.WriteLine("4-te helado");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("El siguiente cliente pidio un cafe de tipo BEBIDAS CALIENTES");
                        Console.Write(cliente[i].datos());
                        Console.WriteLine("Y fue vendidio por el vendedor");
                        Console.WriteLine(vendedor[i].datos());

                        break;

                    case 2:

                        Console.WriteLine("El siguiente cliente pidio un te de tipo BEBIDAS CALIENTES");
                        Console.Write(cliente[i].datos());
                        Console.WriteLine("Y fue vendidio por el vendedor");
                        Console.WriteLine(vendedor[i].datos());
                        break;

                    case 3:

                        Console.WriteLine("El siguiente cliente pidio una coca cola de tipo BEBIDAS GASEOSAS");
                        Console.Write(cliente[i].datos());
                        Console.WriteLine("Y fue vendidio por el vendedor");
                        Console.WriteLine(vendedor[i].datos());
                        break;

                    case 4:

                        Console.WriteLine("El siguiente cliente pidio un te helado de tipo BEBIDAS GASEOSAS");
                        Console.Write(cliente[i].datos());
                        Console.WriteLine("Y fue vendidio por el vendedor");
                        Console.WriteLine(vendedor[i].datos());
                        break;
                }

            }


            Console.ReadKey();
        }

    }
}


public abstract class ClienteDato
{
   public  string nombre { get; set; }
    public string apellido { get; set; }
    public  int edad { get; set; }

    public string sexo { get; set; }

    public abstract string datos();
}

public class Vendedor : ClienteDato
{
    public Vendedor(string nombre, string apellido, int edad, string sexo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.sexo = sexo;
    }

    public override string datos()
    {
        string informacionV = $"Los datos del vendedor son: {this.nombre} {this.apellido} {this.edad} {this.sexo} \n ";
        return informacionV;
    }
}



public class Cliente : ClienteDato
{

    public Cliente(string nombre, string apellido,int edad,string sexo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.sexo = sexo;
    }


    public override string datos()
    {
        string datos = $"Los datos del cliente son: {this.nombre} {this.apellido} {this.edad} {this.sexo} \n";
        return datos;
    }
}

public interface Bevidas
{
     string nombre { get;}
     string tipo { get; }

    string informacion(); 
}

public class informacionBevida : Bevidas
{
    public string nombre => throw new NotImplementedException();

    public string tipo => throw new NotImplementedException();

    public string informacion()
    {
        string datos = $"El nombre de esta bebida es {this.nombre} y es de tipo {this.tipo} ";
        return datos;
    }
}