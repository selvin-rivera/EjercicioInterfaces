


namespace EjercicioInterfaces
{
    public class Operacion : IOperaciones
    {
        /// <summary>
        /// Primer número a ingresar
        /// </summary>
        public double N1;

        /// <summary>
        /// Segundo número a ingresar
        /// </summary>
        public double N2;


        /// <summary>
        /// Calcula el área del cuadrado
        /// </summary>
        /// <returns>Area del cuadrado</returns>
        public double AreaCuardado(double N1, double N2)
        {
            return N1 * N2;
        }

        /// <summary>
        /// Calcula el área del triángulo
        /// </summary>
        /// <returns>Area del triángulo</returns>
        public double AreaTriangulo(double N1, double N2)
        {
            return N1 * N2 / 2;
        }

       /* public void Imprimir(double N1, double N2)
        {
            Console.WriteLine($"Area del cuadrado: {AreaCuardado(N1, N2)}");
            Console.WriteLine($"Area del triángulo: {AreaTriangulo(N1, N2)}");
        }*/

        public void Imprimir()
        {
            Console.WriteLine($"Area del cuadrado: {AreaCuardado(N1, N2)}");
            Console.WriteLine($"Area del triángulo: {AreaTriangulo(N1, N2)}");
        }
    }
}
