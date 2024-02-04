using System;

namespace CourseMongoDBForDevs.Api.Domain.Entities.Enums
{
    /// <summary>
    /// The E cozinha.
    /// </summary>
    public enum ECozinha
    {
        Brasileira = 1, 
        Italiana = 2, 
        Arabe = 3, 
        Japonesa = 4, 
        FastFood = 5,
    }

    /// <summary>
    /// The E cozinha helper.
    /// </summary>
    public static class ECozinhaHelper
    {
        /// <summary>
        /// Converters the de inteiro.
        /// </summary>
        /// <param name="valor">The valor.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns>ECozinha</returns>
        public static ECozinha ConverterDeInteiro(int valor)
        {
            if (Enum.TryParse(valor.ToString(), out ECozinha cozinha))
                return cozinha;

            throw new ArgumentOutOfRangeException("cozinha");
        }
    }
}
