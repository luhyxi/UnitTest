namespace UnitTest;


public interface IRandomizer
{
    int Next(int minValue, int maxValue);
}

public class NativeRandomizer : IRandomizer
{
    Random rnd = new Random();
    public int Next(int minValue, int maxValue)
        => rnd.Next(minValue, maxValue);
}


public class OperacoesFilas
{

    public static int BatataQuente(int numJogadores)
        => BatataQuente(new NativeRandomizer(), numJogadores);

    public static int BatataQuente(IRandomizer randomizer, int numJogadores)
    {
        if (numJogadores <= 1)
            throw new ArgumentOutOfRangeException(nameof(numJogadores),
                "Numero de jogadores deve ser positivo e maior que um");

        var FilaJogadores = new Queue<int>();

        // Coloca os Jogadores em seus postos
        for (var i = 1; i <= numJogadores; i++) FilaJogadores.Enqueue(i);

        // Jogo
        while (FilaJogadores.Count > 1)
        {
            var passes = randomizer.Next(1, 100);

            // Passar a batata dentre jogadores
            for (var i = 0; i < passes; i++)
            {
                var jogadorRecente = FilaJogadores.Dequeue();
                FilaJogadores.Enqueue(jogadorRecente);
            }

            // Eliminar jogador
            var jogadorEliminado = FilaJogadores.Dequeue();
            Console.WriteLine($"Jogador {jogadorEliminado} foi eliminado.");

        }

        // Último jogador restante
        return FilaJogadores.Dequeue();
    }


}