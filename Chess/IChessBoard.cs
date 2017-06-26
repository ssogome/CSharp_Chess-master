using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWMSP.Hiring
{
    public interface IChessBoard
    {
         void Add(Pawn pawn, int xCoordinate, int yCoordinate, PieceColor pieceColor);
         bool IsLegalBoardPosition(int xCoordinate, int yCoordinate);
    }
}
