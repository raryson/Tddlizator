using System;

namespace GameOfLife.Framework{

    public class Cell{

        public Cell()
        {
            
        }
        public State nowState { get; set;}
        public enum State { Live, Dead }

    }
}