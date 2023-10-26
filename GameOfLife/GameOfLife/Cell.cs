namespace GameOfLifeTDD
{
    public enum State
    {
        Dead,
        Alive
    }

    internal class Cell
    {



        public State State { get; private set; }


        public int x { get; private set; }
        public int y { get; private set; }

        public Cell(State State, int x, int y)
        {
            this.State = State;
            this.x = x;
            this.y = y;
        }


        public bool isAlive()
        {
            return this.State == State.Alive;
        }



        public override bool Equals(object obj)
        {
            Cell cell = (Cell)obj;
            return this.State == cell.State && this.x == cell.x && this.y == cell.y;
        }


    }
}