using System;
using System.Collections.Generic;
using System.Text;

namespace EventsExercise
{
    public class WinEventArgs : EventArgs
    {
        public Mark Winner { get; private set; }

        public WinEventArgs(Mark winner)
        {
            Winner = winner;
        }
    }
}
