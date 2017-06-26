using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWMSP.Hiring
{
    public interface IPawn
    {
         void Move(MovementType movementType, int newX, int newY);
    }
}
