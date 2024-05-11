using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Renderer.Interfaces
{
    public interface IBaseRenderer
    {
        public void Render(IBoard board, List<Point> points);
    }
}
