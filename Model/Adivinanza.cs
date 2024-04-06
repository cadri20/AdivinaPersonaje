namespace AdivinaPersonaje.Model
{
    public record Adivinanza
    {
        public int Id { get; set; }
        public List<string> Respuestas { get; set; }
        public List<string> Pistas { get; set; }

        public Adivinanza(List<string> respuestas, List<string> pistas)
        {
            Respuestas = respuestas;
            Pistas = pistas;
        }

        public bool EsCorrecta(string respuesta)
        {
            bool esCorrecta = false;
            foreach (var r in Respuestas)
            {
                if (r.Equals(respuesta, StringComparison.OrdinalIgnoreCase))
                {
                    esCorrecta = true;
                    break;
                }
            }

            return esCorrecta;
        }
    }
}
