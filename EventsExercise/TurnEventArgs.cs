using System;
using System.Collections.Generic;
using System.Text;

namespace EventsExercise
{
    public class TurnEventArgs : EventArgs
    {
        public Mark Turn { get; private set; }

        public TurnEventArgs(Mark turn)
        {
            Turn = turn;
        }
    }
}
