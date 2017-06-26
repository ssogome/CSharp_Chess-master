using System;


namespace SWMSP.Hiring
{
    public class ChessBoard: IChessBoard
    {
      
        public static readonly int MaxBoardWidth = 7;
        public static readonly int MaxBoardHeight = 7;
        private Pawn[,] pieces;

       

        public ChessBoard ()
        {
            pieces = new Pawn[MaxBoardWidth, MaxBoardHeight];            
        }
        //Initialize the state of each cell: occupied by a given pawn color or free
        public void PiecesInitialState()
        {            
            for(var i = 0; i < MaxBoardHeight; i++)
            {
                for(var j = 0; j < MaxBoardWidth; j++)
                {                   
                    Pawn emptyPawn = new Pawn( -1, -1, PieceColor.Empty);
                   
                    pieces[j, i] = emptyPawn;
                    Console.Write(" ({0},{1},{2}) ", pieces[j, i].XCoordinate, pieces[j, i].YCoordinate, pieces[j,i].PieceColor);
                }
                Console.WriteLine("\n******************************************************************************************************\n");
            }
        }
        //Get the current cell state
        public void PiecesUpdateState()
        {
            for (var i = 0; i < MaxBoardHeight; i++)
            {
                for (var j = 0; j < MaxBoardWidth; j++)
                {
                    Console.Write(" ({0},{1},{2}) ", pieces[j, i].XCoordinate, pieces[j, i].YCoordinate, pieces[j, i].PieceColor);
                }
                Console.WriteLine("\n***************************************************************************************************************\n");
            }
        }      
        
          
        public void Add(Pawn pawn, int xCoordinate, int yCoordinate, PieceColor pieceColor)
        {           
            if (xCoordinate < 0 || xCoordinate > 6 || yCoordinate < 0 || yCoordinate > 6)
            {
                pawn.XCoordinate = -1;
                pawn.YCoordinate = -1;

                Console.WriteLine("This pawn can NOT be added to the board.");
                return;
            }
            switch (pieceColor)
                    {
                        case 0:
                            if (0 <= xCoordinate && xCoordinate < 7 )
                            {
                                pawn.PieceColor = pieceColor;
                                pawn.XCoordinate = xCoordinate;
                                pawn.YCoordinate = yCoordinate;
                                if (pieces[xCoordinate, yCoordinate].PieceColor == pieceColor && pieces[xCoordinate, yCoordinate].XCoordinate == xCoordinate && pieces[xCoordinate, yCoordinate].YCoordinate == yCoordinate)
                                {
                                    pawn.XCoordinate = -1;
                                    pawn.YCoordinate = -1;
                                }
                                else pieces[xCoordinate, yCoordinate] = pawn;                             
                            }                  
                            else
                            {
                                pawn.XCoordinate = -1;
                                pawn.YCoordinate = -1;                                
                            }                   
                            break;
                        case (PieceColor)1:
                           if (0 <= xCoordinate && xCoordinate < 7)
                           {
                                pawn.PieceColor = pieceColor;
                                pawn.XCoordinate = xCoordinate;
                                pawn.YCoordinate = yCoordinate;
                                if (pieces[xCoordinate, yCoordinate].PieceColor == pieceColor && pieces[xCoordinate, yCoordinate].XCoordinate == xCoordinate && pieces[xCoordinate, yCoordinate].YCoordinate == yCoordinate)
                                {
                                    pawn.XCoordinate = -1;
                                    pawn.YCoordinate = -1;
                                }
                                else pieces[xCoordinate, yCoordinate] = pawn;
                            }
                            else
                            {
                                pawn.XCoordinate = -1;
                                pawn.YCoordinate = -1;
                            }
                                break;
                    }                     
        }

        public bool IsLegalBoardPosition(int xCoordinate, int yCoordinate)
        {           
            if ((0<= xCoordinate && xCoordinate <= MaxBoardWidth) &&( 0 <= yCoordinate && yCoordinate <= MaxBoardHeight)) return true;
            else return false;
        }

    }
}
