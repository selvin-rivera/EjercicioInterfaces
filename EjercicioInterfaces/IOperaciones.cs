

namespace EjercicioInterfaces
{
    public interface IOperaciones
    {
        /// <summary>
        /// Implementa el proceso de calcular el área del cuadrado
        /// </summary>
        /// <returns>Area del cuadrado</returns>
        public double AreaCuardado(double N1, double N2);

        /// <summary>
        /// Implementa el proceso de calcular el área del triángulo
        /// </summary>
        /// <returns>Area del triángulo</returns>
        public double AreaTriangulo(double N1, double N2);

        // <summary>
        /// Implementa el proceso de calcular el área de un circulo
        /// </summary>
        /// <returns>Area del circulo</returns>
        public double AreaCirculo(double N1, double N2);

        // <summary>
        /// Implementa el proceso de calcular la longitud de un circulo
        /// </summary>
        /// <returns>Longitud del circulo</returns>
        public double LongitudCirculo(double N1);

        /// <summary>
        /// Implementa el proceso de calcular el volumen de un cubo
        /// </summary>
        /// <returns>Volumen de cubo</returns>
        public double VolumenCubo(double N1, double N2, double N3);


    }
}
