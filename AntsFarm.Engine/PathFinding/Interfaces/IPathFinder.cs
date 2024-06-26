﻿using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.PathFinding.Interfaces
{
    public interface IPathFinder
    {
        public List<Point> FindPath(Point start, Point end, IBoard b);
    }
}
