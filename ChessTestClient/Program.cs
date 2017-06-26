using SWMSP.Hiring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ChessBoard _chessBoard = new ChessBoard();
            int width = ChessBoard.MaxBoardWidth;
            int height = ChessBoard.MaxBoardHeight;
            Pawn _pawn1 = new Pawn(PieceColor.Black);
            Pawn _pawn2 = new Pawn(PieceColor.Black);
            Pawn _pawn3 = new Pawn(PieceColor.White);
            Pawn _pawn4 = new Pawn(PieceColor.White);


            Console.WriteLine("Press [Enter] to see initial board state.");
            Console.ReadLine();
            _chessBoard.PiecesInitialState();
          
            Console.WriteLine("Press [Enter] to position a Black pwan.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter an integer value for the x-coordinate of first black pawn and then press [Enter] to continue: ");
            int  xCoor = Convert.ToInt32(  Console.ReadLine());
            Console.WriteLine("Please enter an integer value for the y-coordinate of first black pawn and then press [Enter] to continue: ");
            int yCoor = Convert.ToInt32(Console.ReadLine());
            _chessBoard.Add(_pawn1, xCoor, yCoor, PieceColor.Black);

            Console.WriteLine("Please enter an integer value for the x-coordinate of second black pawn and then press [Enter] to continue: ");
             xCoor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an integer value for the y-coordinate of second black pawn and then press [Enter] to continue: ");
             yCoor = Convert.ToInt32(Console.ReadLine());
            _chessBoard.Add(_pawn2, xCoor, yCoor, PieceColor.Black);

            Console.WriteLine("Please enter an integer value for the x-coordinate of first white pawn and then press [Enter] to continue: ");
             xCoor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an integer value for the y-coordinate of first white pawn and then press [Enter] to continue: ");
            yCoor = Convert.ToInt32(Console.ReadLine());
            _chessBoard.Add(_pawn3, xCoor, yCoor, PieceColor.White);

            Console.WriteLine("Please enter an integer value for the x-coordinate of second white pawn and then press [Enter] to continue: ");
            xCoor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an integer value for the y-coordinate of second white pawn and then press [Enter] to continue: ");
            yCoor = Convert.ToInt32(Console.ReadLine());
            _chessBoard.Add(_pawn4, xCoor, yCoor, PieceColor.White);


            Console.WriteLine("Press [Enter] to see your pawns current information.");
            Console.Clear();
           
            Console.WriteLine("\n**************\n " + _pawn1 + "\n****************\n" + _pawn2 + "\n***************\n" + _pawn3 +"\n****************\n" +  _pawn4);
            Console.WriteLine("Press [Enter] to see updated board state.");
            Console.ReadLine();
           
            _chessBoard.PiecesUpdateState();
            Console.WriteLine("Let make some movement on the chess board with pawns.\n Press [Enter] to continue.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine( "\n Pawn 1  information before move \n\n" + _pawn1 );
            Console.WriteLine("\n Enter your destination x-coordinate as integer and Press [Enter] to continue.");
            xCoor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter your destination y-coordinate as integer and Press [Enter] to continue.");
            yCoor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press [Enter] to move to ({0},{1}) on the board.", xCoor, yCoor);
            Console.ReadLine();
            _pawn1.Move(MovementType.Move, xCoor, yCoor);
            Console.WriteLine("\n Pawn 1  information atfer move.  Press [Enter] to continue. \n\n" + _pawn1);
            Console.ReadLine();


            Console.WriteLine("\n Pawn 2  information before move \n\n" + _pawn2);
            Console.WriteLine("\n Enter your destination x-coordinate as integer and Press [Enter] to continue.");
            xCoor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter your destination y-coordinate as integer and Press [Enter] to continue.");
            yCoor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press [Enter] to move to ({0},{1}) on the board.", xCoor, yCoor);
            Console.ReadLine();
            _pawn2.Move(MovementType.Move, xCoor, yCoor);
            Console.WriteLine("\n Pawn 2  information atfer move.  Press [Enter] to continue. \n\n" + _pawn2);
            Console.ReadLine();


            Console.WriteLine("\n Pawn 3  information before move \n\n" + _pawn3);
            Console.WriteLine("\n Enter your destination x-coordinate as integer and Press [Enter] to continue.");
            xCoor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter your destination y-coordinate as integer and Press [Enter] to continue.");
            yCoor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press [Enter] to move to ({0},{1}) on the board.", xCoor, yCoor);
            Console.ReadLine();
            _pawn3.Move(MovementType.Move, xCoor, yCoor);
            Console.WriteLine("\n Pawn 3  information atfer move.  Press [Enter] to continue. \n\n" + _pawn3);
            Console.ReadLine();


            Console.WriteLine("\n Pawn 4  information before move \n\n" + _pawn4);
            Console.WriteLine("\n Enter your destination x-coordinate as integer and Press [Enter] to continue.");
            xCoor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter your destination y-coordinate as integer and Press [Enter] to continue.");
            yCoor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press [Enter] to move to ({0},{1}) on the board.", xCoor, yCoor);
            Console.ReadLine();
            _pawn4.Move(MovementType.Move, xCoor, yCoor);
            Console.WriteLine("\n Pawn 4  information atfer move.  Press [Enter] to continue. \n\n" + _pawn4);



            Console.WriteLine("  Press [Enter] key to Exit.");
            Console.ReadLine();
        }
    }
}
