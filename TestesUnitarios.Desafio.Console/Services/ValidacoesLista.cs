namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista) //Remove negatives
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero) //Finds a specific number
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero) //Multiplies by a specific number
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        public int RetornarMaiorNumeroLista(List<int> lista) //Returns the highest value in the list
        {
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)//Returns the lowest value in the list
        {
            return lista.Min();
        }
    }
}
