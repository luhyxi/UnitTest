using UnitTest;

namespace TestProject.Services
{
    public class TestesHotPotato
    {

        [Theory]
        [InlineData(10)]
        public void Retorna_ListaComPeloMenos_UmPerdedor(int jogadores)
        {
            // Arrange + Act
            HotPotatoGame.Play(jogadores);
            
            // Assert
            Assert.Single(HotPotatoGame.Perdedores);
        }

        [Theory]
        [InlineData(10)]
        public void Retorna_ResultadoNao_Nulo(int jogadores)
        {
            // Arrange
            var NewQueue = new Queue<string>();
            
            // Act
            HotPotatoGame.Play(jogadores, NewQueue, true);
            
            // Assert
            Assert.NotNull(NewQueue);
        }

        [Theory]
        [InlineData(10, 9)]
        public void DeveTer_OMesmoNumeroDeJogadoresEsperados(int players, int esperados)
        {
            var playersQueue = new Queue<string>();

            // Act
            HotPotatoGame.Play(players, playersQueue);

            // Assert
            Assert.Equal(esperados, playersQueue.Count);
        }
    }
}
