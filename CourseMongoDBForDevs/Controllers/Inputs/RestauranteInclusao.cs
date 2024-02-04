namespace CourseMongoDBForDevs.Api.Controllers.Inputs
{
    /// <summary>
    /// The restaurante inclusao.
    /// </summary>
    public class RestauranteInclusao
    {
        /// <summary>
        /// Gets or Sets the nome.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Gets or Sets the cozinha.
        /// </summary>
        public int Cozinha { get; set; }
        /// <summary>
        /// Gets or Sets the logradouro.
        /// </summary>
        public string Logradouro { get; set; }
        /// <summary>
        /// Gets or Sets the numero.
        /// </summary>
        public string Numero { get; set; }
        /// <summary>
        /// Gets or Sets the cidade.
        /// </summary>
        public string Cidade { get; set; }
        /// <summary>
        /// Gets or Sets the UF.
        /// </summary>
        public string UF { get; set; }
        /// <summary>
        /// Gets or Sets the cep.
        /// </summary>
        public string Cep { get; set; }
    }
}
