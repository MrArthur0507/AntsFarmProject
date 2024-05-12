using AntsFarm.Models.Entities.Interfaces;
using AntsFarm.Models.Entities.Playground;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.BoardGenerating.Implementation
{
    public class BoardGenerator
    {
        private readonly EntityGenerator _entityGenerator;

        public BoardGenerator(EntityGenerator entityGenerator)
        {
            _entityGenerator = entityGenerator;
        }
        public IBoard GenerateBoard(int size)
        {
            IBoard b = new Board(size);
            IPathFindable[,] board = b.GetBoard();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    board[i, j] = _entityGenerator.GenerateEntity();
                }
            }
            return b;
        }
    }
}
