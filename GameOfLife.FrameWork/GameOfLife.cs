
 namespace GameOfLife.Framework{

    public class GameOfLife
    {
        public GameOfLife()
        {
        }

        public Cell.State SetACellWithLive(){

            var cell = new Cell();
            cell.nowState = Cell.State.Live;

            return cell.nowState;

        }

    }

 }