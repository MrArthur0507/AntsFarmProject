using AntsFarm.Models.Entities.Interfaces;
using AntsFarm.Renderer.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Renderer.Implementations
{
    public class Renderer : IBaseRenderer
    {
        public void Render(IBoard board, List<Point> points)
        {
            IBaseEntity[,] playground = board.GetBoard();
            Point prev = points[0];
               

            foreach (var item in points)
            {
                Console.Clear(); 
                playground[item.X, item.Y].Symbol = 'A';
                playground[prev.X, prev.Y].Symbol = '#';
                prev = item;
                for (int i = 0; i < playground.GetLength(0); i++)
                {
                    for (int j = 0; j < playground.GetLength(0); j++)
                    {
                        Console.Write(playground[i, j].Symbol);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(500);
            }

        }
    }
}
