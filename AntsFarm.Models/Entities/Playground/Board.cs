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
        public IPathFindable[,] board;


        public Board()
        {

        }
        public Board(int boardSize)
        {
            board = new PathFindableEntity[boardSize, boardSize];

            

        }

        public Board(PathFindableEntity[,] input)
        {
            board = input;
        }

        public IPathFindable[,] GetBoard()
        {
            return board;
        }
        
    }
}
