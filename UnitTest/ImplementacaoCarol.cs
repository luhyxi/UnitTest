namespace UnitTest
{
    public class HotPotatoGame
    {
        public static int passesUntilExplode = 15;


        // TODO: Implementar formas não destrutivas de fazer tal método:
        public static Queue<string> Play(int numberOfPlayers, Queue<string> playersQueue)
        {
            Console.WriteLine($"Simulando jogo de batata quente com {numberOfPlayers} jogadores.");
            Console.WriteLine($"A batata vai explodir após {passesUntilExplode} passes.");

            return PerformPassesUntilExplode(playersQueue);
        }

        public static Queue<string> Play(int numberOfPlayers)
        {
            var playersQueue = new Queue<string>();

            Console.WriteLine($"Simulando jogo de batata quente com {numberOfPlayers} jogadores.");
            Console.WriteLine($"A batata vai explodir após {passesUntilExplode} passes.");

            return PerformPassesUntilExplode(playersQueue);

        }

        public static Queue<string> InitializePlayersQueue(int numberOfPlayers)
        {
            var playersQueue = new Queue<string>();

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                playersQueue.Enqueue($"Player {i}");
            }

            return playersQueue;
        }

        public static Queue<string> PerformPassesUntilExplode(Queue<string> playersQueue)
        {
            for (int passesCount = 1; passesCount <= passesUntilExplode; passesCount++)
            {
                string currentPlayer = playersQueue.Dequeue();
                Console.WriteLine($"A batata está passando por {currentPlayer} e esse é o passe {passesCount}.");
                playersQueue.Enqueue(currentPlayer);
            }

            string eliminatedPlayer = playersQueue.Dequeue();
            Console.WriteLine($"A batata explodiu! {eliminatedPlayer} está fora do jogo.");

            return playersQueue;
        }
    }
}