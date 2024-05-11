using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Entities.NPCs
{
    public class BaseAnt : PathFindableEntity
    {
        public BaseAnt() {
            IsWalkable = true;
            Symbol = 'A';
            Name = "Ant";
        }
    }
}
