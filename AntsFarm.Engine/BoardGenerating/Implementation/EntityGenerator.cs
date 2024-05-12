using AntsFarm.Models.Entities;
using AntsFarm.Models.Entities.Interfaces;
using AntsFarm.Models.Entities.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.BoardGenerating.Implementation
{
    public class EntityGenerator
    {
        private Random random;
        private int grainCount = 0;
        public EntityGenerator()
        {
            random = new Random();
        }
        public IPathFindable GenerateEntity()
        {
            int r = random.Next(0, 10);
            if (r >= 0 && r <= 5)
            {
                return new PathFindableEntity();
            } else if (r > 5 && grainCount < 100) {
                grainCount++;
                return new Grain();
            }
            else
            {
                return new Obstacle();
            }
            
        }
    }
}
