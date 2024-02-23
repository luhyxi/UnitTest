namespace UnitTest
{
    public class PalavrasPorTamanho
    {
        public List<string> SelecionarPalavras(List<string> palavras)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < palavras.Count; i++)
            {
                if (palavras[i].Length >= 10)
                    result.Add(palavras[i]);
            }
            return result;
        }
    }
}
