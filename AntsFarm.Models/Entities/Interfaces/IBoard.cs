using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Entities.Interfaces
{
    public interface IBoard
    {
        public IBaseEntity[,] GetBoard();
    }
}
