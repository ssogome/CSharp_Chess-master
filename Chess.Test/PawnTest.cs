using NUnit.Framework;
using SWMSP.Hiring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Test
{
    [TestFixture]
    public class PawnTest
    {
        private ChessBoard _chessBoard;
        private Pawn _pawn, _whitePawn;
       
     
       [SetUp]
        public void SetUp()
        {
            _chessBoard = new ChessBoard();
            _chessBoard.PiecesInitialState() ;
            _pawn = new Pawn( PieceColor.Black);
            _whitePawn = new Pawn(PieceColor.White);
        }

        [Test]
        public void ChessBoard_Add_Sets_XCoordinate()
        {
            _chessBoard.Add(_pawn, 6, 3, PieceColor.Black);          
            Assert.That(_pawn.XCoordinate, Is.EqualTo(6));

            //New Test for White pawn           
            _chessBoard.Add(_whitePawn, 6, 1, PieceColor.White);
            Assert.That(_whitePawn.XCoordinate, Is.EqualTo(6));
        }
        [Test]
        public void ChessBoard_Add_Sets_YCoordinate()
        {
            _chessBoard.Add(_pawn, 6, 3, PieceColor.Black);           
                Assert.That(_pawn.YCoordinate, Is.EqualTo(3));

            //New Test for White pawn           
            _chessBoard.Add(_whitePawn, 6, 1, PieceColor.White);
            Assert.That(_whitePawn.YCoordinate, Is.EqualTo(1));
        }
        //New test for setting X and Y coordinates
        [Test]
        public void ChessBoard_Add_Sets_X_Y_Coordinates()
        {
            _chessBoard.Add(_pawn, 6, 3, PieceColor.Black);            
                Assert.That(_pawn.XCoordinate, Is.EqualTo(6));
                Assert.That(_pawn.YCoordinate, Is.EqualTo(3));

            //New Test for White pawn           
            _chessBoard.Add(_whitePawn, 6, 1, PieceColor.White);
            Assert.That(_whitePawn.XCoordinate, Is.EqualTo(6));
            Assert.That(_whitePawn.YCoordinate, Is.EqualTo(1));
        }

        [Test]
        public void Pawn_Move_IllegalCoordinates_Left_DoesNotMove()
        {
            _chessBoard.Add(_pawn, 6, 3, PieceColor.Black);          
                _pawn.Move(MovementType.Move, 4, 3);
                Assert.That(_pawn.XCoordinate, Is.EqualTo(6));
                Assert.That(_pawn.YCoordinate, Is.EqualTo(3));

            //New Test for white pawn               
            _chessBoard.Add(_whitePawn, 6, 1, PieceColor.White);
            _whitePawn.Move(MovementType.Move, 4, 1);
            Assert.That(_whitePawn.XCoordinate, Is.EqualTo(6));
            Assert.That(_whitePawn.YCoordinate, Is.EqualTo(1));
        }
        [Test]
        public void Pawn_Move_IllegalCoordinates_Right_DoesNotMove()
        {
            _chessBoard.Add(_pawn, 6, 3, PieceColor.Black);           
                _pawn.Move(MovementType.Move, 7, 3);
                Assert.That(_pawn.XCoordinate, Is.EqualTo(6));
                Assert.That(_pawn.YCoordinate, Is.EqualTo(3));

            //New Test for white pawn               
            _chessBoard.Add(_whitePawn, 6, 1, PieceColor.White);
            _whitePawn.Move(MovementType.Move, 7, 1);
            Assert.That(_whitePawn.XCoordinate, Is.EqualTo(6));
            Assert.That(_whitePawn.YCoordinate, Is.EqualTo(1));
        }
        [Test]
        public void Pawn_Move_LegalCoordinates_Forward_UpdatesCoordinates()
        {
            _chessBoard.Add(_pawn, 6, 3, PieceColor.Black);           
                _pawn.Move(MovementType.Move, 6, 2);
                Assert.That(_pawn.XCoordinate, Is.EqualTo(6));
                Assert.That(_pawn.YCoordinate, Is.EqualTo(2));

            //New Test for white pawn               
            _chessBoard.Add(_whitePawn, 6, 1, PieceColor.White);
            _whitePawn.Move(MovementType.Move, 6,2);
            Assert.That(_whitePawn.XCoordinate, Is.EqualTo(6));
            Assert.That(_whitePawn.YCoordinate, Is.EqualTo(2));
        }

        //New code for testing authorization to move
        [Test]
        public void Pawn_Move_IsAllowedToMove()
        {
            _chessBoard.Add(_whitePawn, 6, -1, PieceColor.White);
            _chessBoard.Add(_pawn, -1, 3, PieceColor.Black);
            _whitePawn.Move(MovementType.Move, 6, 0);
            _pawn.Move(MovementType.Move, -1, 2);
            Assert.That(_whitePawn.XCoordinate, Is.EqualTo(-1));
            Assert.That(_whitePawn.YCoordinate, Is.EqualTo(-1));
            Assert.That(_pawn.XCoordinate, Is.EqualTo(-1));
            Assert.That(_pawn.YCoordinate, Is.EqualTo(-1));
        }

        //New Tests for forward diagonal moves
        [Test]
        public void Pawn_Move_IllegalCoordinates_ForwardWrongSideDiagonal()
        {
            _chessBoard.Add(_pawn, 6, 3, PieceColor.Black);
            _pawn.Move(MovementType.Move, 7, 2);
            Assert.That(_pawn.XCoordinate, Is.EqualTo(6));
            Assert.That(_pawn.YCoordinate, Is.EqualTo(3));

            //New Test for white pawn               
            _chessBoard.Add(_whitePawn, 6, 1, PieceColor.White);
            _whitePawn.Move(MovementType.Move, 5, 2);
            Assert.That(_whitePawn.XCoordinate, Is.EqualTo(6));
            Assert.That(_whitePawn.YCoordinate, Is.EqualTo(1));
        }

        //New Tests for pawn backward moves
        [Test]
        public void Pawn_Move_IllegalCoordinates_Back_DoesNotMove()
        {
            _chessBoard.Add(_pawn, 6, 3, PieceColor.Black);
            _pawn.Move(MovementType.Move, 6, 4);
            Assert.That(_pawn.XCoordinate, Is.EqualTo(6));
            Assert.That(_pawn.YCoordinate, Is.EqualTo(3));

            //New Test for white pawn               
            _chessBoard.Add(_whitePawn, 6, 1, PieceColor.White);
            _whitePawn.Move(MovementType.Move, 6, 0);
            Assert.That(_whitePawn.XCoordinate, Is.EqualTo(6));
            Assert.That(_whitePawn.YCoordinate, Is.EqualTo(1));
        }
        [Test]
        public void Pawn_Move_IllegalCoordinates_Back_LeftDiagonal_DoesNotMove()
        {
            _chessBoard.Add(_pawn, 6, 3, PieceColor.Black);
            _pawn.Move(MovementType.Move, 5, 4);
            Assert.That(_pawn.XCoordinate, Is.EqualTo(6));
            Assert.That(_pawn.YCoordinate, Is.EqualTo(3));

            //New Test for white pawn               
            _chessBoard.Add(_whitePawn, 6, 1, PieceColor.White);
            _whitePawn.Move(MovementType.Move, 5, 0);
            Assert.That(_whitePawn.XCoordinate, Is.EqualTo(6));
            Assert.That(_whitePawn.YCoordinate, Is.EqualTo(1));
        }
        [Test]
        public void Pawn_Move_IllegalCoordinates_Back_RightDiagonal_DoesNotMove()
        {
            _chessBoard.Add(_pawn, 6, 3, PieceColor.Black);
            _pawn.Move(MovementType.Move, 7, 2);
            Assert.That(_pawn.XCoordinate, Is.EqualTo(6));
            Assert.That(_pawn.YCoordinate, Is.EqualTo(3));

            //New Test for white pawn               
            _chessBoard.Add(_whitePawn, 6, 1, PieceColor.White);
            _whitePawn.Move(MovementType.Move, 7, 0);
            Assert.That(_whitePawn.XCoordinate, Is.EqualTo(6));
            Assert.That(_whitePawn.YCoordinate, Is.EqualTo(1));
        }


        //Dispose of objects       
        [TearDown]
        public void TearDown()
        {
            _chessBoard = null;
            _pawn = null;
        }
    }
}
