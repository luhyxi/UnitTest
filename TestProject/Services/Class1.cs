using UnitTest;

namespace TestProject.Services
{
    public class TestesHotPotato
    {

        [Theory]
        [InlineData(10)]

        // 
        public void Retorna_Lista_Com_Pelo_Menos_Um_Perdedor(int jogadores)
        {
            // Arrange
            var QueueInicial = new Queue<string>();

            // Act
            HotPotatoGame.Play(jogadores, QueueInicial);


            // Assert


        }


    }
}
