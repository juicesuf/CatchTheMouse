using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class MouseMove
    {
        static private Random _random = new Random();
        static private MouseMove[] _allMoves; 
        
        internal int DeltaX
        {
            get;
        }

        internal int DeltaY
        {
            get;
        }

        static MouseMove()
        {
            _allMoves = new MouseMove[]
            {
                new MouseMove(-1, -1), 
                new MouseMove(-1,  0), 
                new MouseMove(-1,  1), 
                new MouseMove( 0, -1), 
                new MouseMove( 0,  1), 
                new MouseMove( 1, -1), 
                new MouseMove( 1,  0), 
                new MouseMove( 1,  1), 
            };
        }

        public MouseMove(int deltaX, int deltaY)
        {
            DeltaX = deltaX;
            DeltaY = deltaY;
        }

        static internal MouseMove GetMove()
        {
            return _allMoves[_random.Next(_allMoves.Length)];
        }


    }
}
