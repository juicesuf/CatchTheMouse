using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class MouseMove
    {
        static private Random random = new Random();
        static private MouseMove[] _allMoves; 
        
        internal int DeltaX
        {
            get;
        }

        internal int DeltaY
        {
            get;
        }

        static public MouseMove()
        {

        }

        public MouseMove(int deltaX, int deltaY)
        {
            DeltaX = deltaX;
            DeltaY = deltaY;
        }

        static internal MouseMove GetMove()
        {

        }


    }
}
