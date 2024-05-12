// See https://aka.ms/new-console-template for more information
using AntsFarm.Engine.BoardGenerating.Implementation;
using AntsFarm.Engine.PathFinding.Implementations;
using AntsFarm.Models.Entities;
using AntsFarm.Models.Entities.Interfaces;
using AntsFarm.Models.Entities.Playground;
using AntsFarm.Renderer.Implementations;
using System.Drawing;
using System.Xml.Linq;


Renderer r = new Renderer();


EntityGenerator eg = new EntityGenerator();
BoardGenerator bg = new BoardGenerator(eg);

AStarPathFinder aStar = new AStarPathFinder();
IBoard b = bg.GenerateBoard(20);

List<Point> p = aStar.FindPath(new Point(0, 0), new Point(19, 19), b);



r.Render(b, p);

