using FluentAssertions;

namespace GameOfLifeTDD

{
    public class GameOfLifeTest
    {



        [Test]

        public void should_change_state_to_death_when_surronded_three()
        {
            bool[][] initialBoard = new BoardBuilder(4, 4)
            .SetAliveCell(0, 1)
            .SetAliveCell(1, 0)
            .SetAliveCell(1, 1)
            .Build();

            bool[][] expectedBoard = new BoardBuilder(4, 4)
            .SetAliveCell(0, 1)
            .SetAliveCell(0, 0)
            .SetAliveCell(1, 0)
            .SetAliveCell(1, 1)
            .Build();

            

            GameOfLife game = new GameOfLife(initialBoard);
            game.nextGen();

            GameOfLife newBoard = new GameOfLife(expectedBoard);


            Assert.IsTrue(game.Equals(newBoard));




        }


        [Test]

        public void should_change_state_to_death_when_less_than_two_alives_sourround_it()
        {
            bool[][] initialBoard = new BoardBuilder(4, 4)
            .SetAliveCell(1, 0)
            .Build();


            bool[][] expectedBoard = new BoardBuilder(4, 4)
            .Build();

            GameOfLife game = new GameOfLife(initialBoard);
            game.nextGen();

            GameOfLife newBoard = new GameOfLife(expectedBoard);

            Assert.IsTrue(game.Equals(newBoard));
            


        }

        [Test]

        public void should_change_state_to_death_when_more_than_three_alive_sourround_it()
        {

            bool[][] initialBoard = new BoardBuilder(5, 5)
            .SetAliveCell(1, 2)
            .SetAliveCell(2, 1)
            .SetAliveCell(2,2)
            .SetAliveCell(2,3)
            .SetAliveCell(3,2)
            .Build();


            bool[][] expectedBoard = new BoardBuilder(5, 5)
            .SetAliveCell(1, 1)
            .SetAliveCell(1, 2)
            .SetAliveCell(1, 3)
            .SetAliveCell(2, 1)
            .SetAliveCell(2, 3)
            .SetAliveCell(3, 1)
            .SetAliveCell(3, 2)
            .SetAliveCell(3, 3)
            .Build();



            GameOfLife game = new GameOfLife(initialBoard);
            game.nextGen();

            GameOfLife newBoard = new GameOfLife(expectedBoard);

            Assert.IsTrue(game.Equals(newBoard));
        }




    }

    public class BoardBuilder
    {
        private bool[][] board;

        public BoardBuilder(int x, int y)
        {
            board = new bool[x][];
            for (int i = 0; i < x; i++)
            {
                board[i] = new bool[y];
            }

        }

        public BoardBuilder SetAliveCell(int x, int y)
        {
            this.board[x][y] = true;
            return this;
        }

        public bool[][] Build()
        {
            return board;
        }
    }

}