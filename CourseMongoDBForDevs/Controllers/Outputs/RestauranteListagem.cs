namespace CourseMongoDBForDevs.Api.Controllers.Outputs
{
    /// <summary>
    /// The restaurante listagem.
    /// </summary>
    public class RestauranteListagem
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
        /// Gets or Sets the cidade.
        /// </summary>
        public string Cidade { get; set; }
    }
}
