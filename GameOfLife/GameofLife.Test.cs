using GameOfLife.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLife
{
    /*
     * 
     * 
     * PROBLEM:
     * 
     * Game of life is a so called cellular automaton. You can read up all about it at wikipedia.

    Develop an algorithm that takes "one step" in the game of life. The behaviour examples may simply be the rules of the game:
    Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
    Any live cell with more than three live neighbours dies, as if by overcrowding.
    Any live cell with two or three live neighbours lives on to the next generation.
    Any dead cell with exactly three live neighbours becomes a live cell.
    You also have to think of things such as how to represent the board in a test-friendly way,
    and what "value" cells outside the board has. Or maybe the board does not have borders?
     * 
     *
     PTBR PROBLEM:
    Qualquer célula viva com menos de dois vizinhos vivos morre de solidão.
    Qualquer célula viva com mais de três vizinhos vivos morre de superpopulação.
    Qualquer célula morta com exatamente três vizinhos vivos se torna uma célula viva.
    Qualquer célula viva com dois ou três vizinhos vivos continua no mesmo estado para a próxima geração.

    INTERFACE:
    LIVE CELL ARE A DOGE
    DEAD CELL ARE SAD MEME FROG
     * 
     * 
     */

     //baby steps
     //red -> green -> refactor

    [TestClass]
    public class GameofLife
    {

         [TestMethod]
        public void Generate_A_Live_Cell()
        {
            var game = new GameOfLife.Framework.GameOfLife();  
            Assert.AreEqual("Live", game.SetACellWithLive());
           
        }

       
    }
}
