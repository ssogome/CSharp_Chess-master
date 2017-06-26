using System;

namespace SWMSP.Hiring
{
    public class Pawn: IPawn
    {
        private ChessBoard _chessBoard;
        private int _xCoordinate;
        private int _yCoordinate;
        private PieceColor _pieceColor;
        
        public ChessBoard ChessBoard
        {
            get { return _chessBoard; }
            set { _chessBoard = value; }
        }

        public int XCoordinate
        {
            get { return _xCoordinate; }
            set { _xCoordinate = value; }
        }
        
        public int YCoordinate
        {
            get { return _yCoordinate; }
            set { _yCoordinate = value; }
        }

        public PieceColor PieceColor
        {
            get { return _pieceColor; }
           // private set { _pieceColor = value; }
             set { _pieceColor = value; }
        }

        public Pawn(PieceColor pieceColor)
        {
            _pieceColor = pieceColor;
        }
        //New Code
        public Pawn(int xCoordinate, int yCoordinate, PieceColor pieceColor)
        {
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
            _pieceColor = pieceColor;
        }

        public void Move(MovementType movementType, int newX, int newY)
        {           
            //Make sure pawn holds a legal position first
            if (_xCoordinate == -1 || _yCoordinate == -1)
            {
                Console.WriteLine("You cannot make a move because you do NOT hold a legal position!");
                return;
            }         
            switch (_pieceColor)
            {
                case 0:
                    switch (movementType)
                    {
                        case 0:
                            if (newX == _xCoordinate && newY == _yCoordinate - 1)
                            {                               
                                _yCoordinate -= 1;                              
                            }                                                                              
                            break;
                        case (MovementType)1:
                            if(newX == _xCoordinate-1 && newY == _yCoordinate - 1)
                            {
                                Console.WriteLine(" CAPTURE MOVEMENT FOR BLACK PAWN NOT IMPLEMENTED IN THIS EXERCISE.");
                            }                            
                            break;
                        default:
                            break;
                    }
                    break;
                case (PieceColor)1:
                    switch (movementType)
                    {
                        case 0:
                            if (newX == _xCoordinate && newY == _yCoordinate + 1)
                                _yCoordinate += 1;
                            break;
                        case (MovementType)1:
                            if (newX == _xCoordinate + 1 && newY == _yCoordinate + 1)
                            {
                                Console.WriteLine(" CAPTURE MOVEMENT FOR WHITE PAWN NOT IMPLEMENTED IN THIS EXERCISE.");
                            }                               
                            break;
                        default:
                            break;
                    }
                    break;
                
            }
        
        }
        
        public override string ToString()
        {
            return CurrentPositionAsString();
        }

        protected string CurrentPositionAsString()
        {
            return string.Format("Current X: {1}{0}Current Y: {2}{0}Piece Color: {3}", Environment.NewLine, XCoordinate, YCoordinate, PieceColor);
        }

    }
}
