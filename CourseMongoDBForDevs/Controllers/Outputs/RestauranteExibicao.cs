namespace CourseMongoDBForDevs.Api.Controllers.Outputs
{
    /// <summary>
    /// The restaurante exibicao.
    /// </summary>
    public class RestauranteExibicao
    {
        /// <summary>
        /// Gets or Sets the id.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets the nome.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Gets or Sets the cozinha.
        /// </summary>
        public int Cozinha { get; set; }
        /// <summary>
        /// Gets or Sets the endereco.
        /// </summary>
        public EnderecoExibicao Endereco { get; set; }
    }
}
