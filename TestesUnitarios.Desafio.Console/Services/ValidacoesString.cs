namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto) //Returns the char quantity
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        public bool ContemCaractere(string texto, string textoProcurado) //Returns if there's the target word in the text
        {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }

        public bool TextoTerminaCom(string texto, string textoProcurado) //Returns if the text ends with a target word
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }
    }
}