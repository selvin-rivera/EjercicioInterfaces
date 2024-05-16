


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
        /// tercer número a ingresar
        /// </summary>
        public double N3;


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

        /// <summary>
        /// Calcula el área de un circulo
        /// </summary>
        /// <returns>Area del corciñp</returns>
        public double AreaCirculo(double N1, double N2)
        {
            return N1 * N2 * 3.14159;
        }

        /// <summary>
        /// Calcula la longitud de un circulo
        /// </summary>
        /// <returns>Longitud del circulo</returns>
        public double LongitudCirculo(double N1)
        {
            return 2 * N1 * 3.14159;
        }

        /// <summary>
        /// Calcula el volumen de un cubo
        /// </summary>
        /// <returns>Volumen del cubo</returns>
        public double VolumenCubo(double N1, double N2, double N3)
        {
            return N1 * N2 * N3;
        }

        /// <summary>
        /// Muestra el resultado de las operaciones
        /// </summary>
        /// <returns>Captura de resultado de operaciones</returns>
        public void Imprimir()
        {
            Console.WriteLine($"Area del cuadrado: {AreaCuardado(N1, N2)}");
            Console.WriteLine($"Area del triángulo: {AreaTriangulo(N1, N2)}");
            Console.WriteLine($"Area del circulo: {AreaCirculo(N1, N2)}");
            Console.WriteLine($"Longitud del circulo: {LongitudCirculo(N1)}");
            Console.WriteLine($"Volumen del cubo: {VolumenCubo(N1, N2, N3)}");
        }

        
    }
}
