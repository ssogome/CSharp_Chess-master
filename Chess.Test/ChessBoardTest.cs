using NUnit.Framework;
using SWMSP.Hiring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess.Test
{
    

    [TestFixture]
    public class ChessBoardTest
    {
        private ChessBoard _chessBoard;        
        private static readonly Pawn firstPawn = new Pawn(6, 3, PieceColor.Black);
        private static readonly Pawn secondPawn = new Pawn(6, 3, PieceColor.Black);        
        int width, height;
        private  Pawn _pawn, thirdPawn, fourthPawn;
        private static IEnumerable<TestCaseData> ChessBoardData
        {
            get
            {
                yield return new TestCaseData(firstPawn.XCoordinate, 6);
                yield return new TestCaseData(secondPawn.XCoordinate, 6);
                yield return new TestCaseData(firstPawn.YCoordinate, 3);
                yield return new TestCaseData(secondPawn.YCoordinate, 3);
            }
        }

              
        [OneTimeSetUp]
        public void SetUp()
        {
            _chessBoard = new ChessBoard();
            _chessBoard.PiecesInitialState();         
            width = ChessBoard.MaxBoardWidth;
            height = ChessBoard.MaxBoardHeight;
            _pawn = new Pawn(PieceColor.Black);
            thirdPawn = new Pawn(PieceColor.White);
            fourthPawn = new Pawn(PieceColor.White);
                  
        }

        [Test]
        public void Has_MaxBoardWidth_of_7()
        {            
            Assert.That(width, Is.EqualTo(7));
        }
        [Test]
        public void Has_MaxBoardHeight_of_7()
        {
            Assert.That(height, Is.EqualTo(7));
        }
        [Test]
        public void IsLegalBoardPosition_True_X_equals_0_Y_equals_0()
        {
            Assert.That(_chessBoard.IsLegalBoardPosition(0, 0), Is.True);
        }
        [Test]
        public void IsLegalBoardPosition_True_X_equals_5_Y_equals_5()
        {
            Assert.That(_chessBoard.IsLegalBoardPosition(5, 5), Is.True);
        }
        
        [Test]
        public void IsLegalBoardPosition_False_X_equals_11_Y_equals_5()
        {         
            Assert.That(_chessBoard.IsLegalBoardPosition(11, 5), Is.False);
        }
        [Test]
        public void IsLegalBoardPosition_False_X_equals_0_Y_equals_9()
        {           
            Assert.That(_chessBoard.IsLegalBoardPosition(0, 9), Is.False);
        }
        [Test]
        public void IsLegalBoardPosition_False_X_equals_11_Y_equals_0()
        {           
            Assert.That(_chessBoard.IsLegalBoardPosition(11, 0), Is.False);
        }
        [Test]
        public void IsLegalBoardPosition_False_For_Negative_X_Values()
        {           
            Assert.That(_chessBoard.IsLegalBoardPosition(-1, 5), Is.False);
        }
        [Test]
        public void IsLegalBoardPosition_False_For_Negative_Y_Values()
        {           
            Assert.That(_chessBoard.IsLegalBoardPosition(5, -1), Is.False);
        }

        //New Test code for any legal position on the chess board
        [TestCase(5,5,true)]
        [TestCase(0,0,true)]        
        [TestCase(11,5,false)]
        [TestCase(0,9,false)]
        [TestCase(11,0,false)]
        [TestCase(-1,5,false)]
        [TestCase(5,-1,false)]
        public void IsLegalBoardPosition_True(int x, int y, bool result)
        {
            Assert.That(_chessBoard.IsLegalBoardPosition(x, y), Is.EqualTo(result));
        }

        [Test]
        public void Avoids_Duplicate_Positioning()
        {

            _chessBoard.Add(firstPawn, 6, 3, PieceColor.Black);
            _chessBoard.Add(secondPawn, 6, 3, PieceColor.Black);
            Assert.That(firstPawn.XCoordinate, Is.EqualTo(6));
            Assert.That(firstPawn.YCoordinate, Is.EqualTo(3));
            Assert.That(secondPawn.XCoordinate, Is.EqualTo(-1));
            Assert.That(secondPawn.YCoordinate, Is.EqualTo(-1));

            //New Test on White pawn
            _chessBoard.Add(thirdPawn, 1, 3, PieceColor.White);
            _chessBoard.Add(fourthPawn, 1, 3, PieceColor.White);
            Assert.That(thirdPawn.XCoordinate, Is.EqualTo(1));
            Assert.That(thirdPawn.YCoordinate, Is.EqualTo(3));
            Assert.That(fourthPawn.XCoordinate, Is.EqualTo(-1));
            Assert.That(fourthPawn.YCoordinate, Is.EqualTo(-1));
        }

        //New Test to compare Pawn Coordinates      
        [Test, TestCaseSource(nameof(ChessBoardData))]
        public void Should_Compare_Pawn_Coordinate(int actual,int expected)
        {         
            Assert.That(actual, Is.EqualTo(expected));
        }
              

        [Test]
        public void Limits_The_Number_Of_Pawns()
        {
            for (int i = 0; i < 3; i++)
            {
                int row = i / width;
          
                _chessBoard.Add(_pawn, 6 + row,i % width, PieceColor.Black);
                
                if (row < 1 )
                {
                    Assert.That(_pawn.XCoordinate, Is.EqualTo(6 + row));
                    Assert.That(_pawn.YCoordinate, Is.EqualTo(i % width));
                }
                else
                {
                    Assert.That(_pawn.XCoordinate, Is.EqualTo(-1));
                    Assert.That(_pawn.YCoordinate, Is.EqualTo(-1));
                }
            }
        }

       
       [OneTimeTearDown]
        public void TearDown()
        {
            _chessBoard = null;            
            _pawn = null;
        }

    }
}
