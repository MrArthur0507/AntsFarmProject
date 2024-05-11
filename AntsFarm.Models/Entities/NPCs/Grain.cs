using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Entities.NPCs
{
    public class Grain : PathFindableEntity
    {
        public Grain() {
            IsWalkable = true;
            Symbol = 'G';
            Name = "Grain";

        }
    }
}
