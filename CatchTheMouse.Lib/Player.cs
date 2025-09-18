using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public abstract class Player
    {
        static private Random random = new Random();

        protected PlayingArea _playingArea;

        public Position Position
        {
            get;
        }

        protected Player(PlayingArea playingArea)
        {
            _playingArea = playingArea;
        }

        public void Move(Position position)
        {
            if (!_playingArea.IsValid(position))
            {
                Position.X = position.X;
                Position.Y = Position.Y;
            }
        }

        public virtual Position Move()
        {
            Position.X = random.Next(0, _playingArea.Width);
            Position.Y = random.Next(0, _playingArea.Height);
            return Position;
        }
    }
}
