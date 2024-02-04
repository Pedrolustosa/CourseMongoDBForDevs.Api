namespace CourseMongoDBForDevs.Api.Controllers.Outputs
{
    /// <summary>
    /// The endereco exibicao.
    /// </summary>
    public class EnderecoExibicao
    {
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
