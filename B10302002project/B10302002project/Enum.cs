using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10302002project
{
    public enum TurnPhase
    {
        Initial,
        Walk,
        Dice,
        End
    }
    public enum PlayerState
    {
        請按骰子,
        Normal,
        SpeedUp,
        SpeedDown,
        Stop,
        Backward
    }
    public enum ItemType
    {
        Potion = 1,
        None = 999
    }
}
