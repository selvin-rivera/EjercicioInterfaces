

using EjercicioInterfaces;

//Creando Objeto
Operacion operacion = new Operacion();
Console.WriteLine("Ingrese primer número : ");
operacion.N1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo número : ");
operacion.N2 = double.Parse(Console.ReadLine());
operacion.Imprimir();