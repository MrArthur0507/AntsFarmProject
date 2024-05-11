using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Entities.Playground
{
    public class Board : IBoard
    {
        public PathFindableEntity[,] board;

        public Board(int boardSize)
        {
            board = new PathFindableEntity[boardSize, boardSize];

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j] = new PathFindableEntity();
                }
            }

        }

        public Board(PathFindableEntity[,] input)
        {
            board = input;
        }

        public IBaseEntity[,] GetBoard()
        {
            return board;
        }
        
    }
}
