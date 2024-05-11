using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Entities.NPCs
{
    public class BaseQueen : PathFindableEntity
    {
        public BaseQueen() {
            IsWalkable = true;
            Symbol = 'Q';
            Name = "Queen";

        }
    }
}
