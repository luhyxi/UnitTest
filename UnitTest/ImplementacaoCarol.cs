namespace UnitTest
{
    public class HotPotatoGame
    {
        public static int PassesUntilExplode = 15;


        public static List<string> Perdedores = new List<string>();

        public static Queue<string> Play(int numberOfPlayers, Queue<string> playersQueue, bool Destrutivo = true)
        {
            InitializePlayersQueue(numberOfPlayers, playersQueue);

            Console.WriteLine($"Simulando jogo de batata quente com {numberOfPlayers} jogadores.");
            Console.WriteLine($"A batata vai explodir após {PassesUntilExplode} passes.");

            return PerformPassesUntilExplode(playersQueue);
        }
        
        public static Queue<string> Play(int numberOfPlayers, Queue<string> playersQueue)
        {
            Queue<string> NewQueue = playersQueue;
                
            InitializePlayersQueue(numberOfPlayers, NewQueue);

            Console.WriteLine($"Simulando jogo de batata quente com {numberOfPlayers} jogadores.");
            Console.WriteLine($"A batata vai explodir após {PassesUntilExplode} passes.");

            return PerformPassesUntilExplode(NewQueue);
        }

        public static Queue<string> Play(int numberOfPlayers)
        {
            var playersQueue = InitializePlayersQueue(numberOfPlayers);
            
            Console.WriteLine($"Simulando jogo de batata quente com {numberOfPlayers} jogadores.");
            Console.WriteLine($"A batata vai explodir após {PassesUntilExplode} passes.");

            return PerformPassesUntilExplode(playersQueue);

        }

        public static void InitializePlayersQueue(int numberOfPlayers, Queue<string> queueToBeAdded)
        {
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                queueToBeAdded.Enqueue($"Player {i}");
            }
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
            for (int passesCount = 1; passesCount <= PassesUntilExplode; passesCount++)
            {
                string currentPlayer = playersQueue.Dequeue();
                Console.WriteLine($"A batata está passando por {currentPlayer} e esse é o passe {passesCount}.");
                playersQueue.Enqueue(currentPlayer);
            }

            string eliminatedPlayer = playersQueue.Dequeue();
            Perdedores.Add(eliminatedPlayer);
            Console.WriteLine($"A batata explodiu! {eliminatedPlayer} está fora do jogo.");
            
            return playersQueue;
        }
    }
}