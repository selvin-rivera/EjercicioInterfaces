

using EjercicioInterfaces;

//Creando Objeto
Operacion operacion = new Operacion();

//pedir al usuario que ingrese los datos necesarios para mostrar los resultados
Console.WriteLine("Ingrese primer número : ");
operacion.N1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo número : ");
operacion.N2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese tercer número : ");
operacion.N3 = double.Parse(Console.ReadLine());
operacion.Imprimir();