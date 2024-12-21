using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
    public class SnakesAndLaddersTask
    {
        private int playerOnePosition = 0;
        private int playerTwoPosition = 0;
        private bool isPlayerOneTurn = true; 
        private bool gameOver = false;

        public string Play(int die1, int die2)
        {
            if (gameOver)
            {
                return "Game over!";
            }

            if (isPlayerOneTurn)
            {
                playerOnePosition = MovePlayer(playerOnePosition, die1, die2);

                if (playerOnePosition == 100)
                {
                    gameOver = true;
                    return "Player 1 Wins!";
                }

                if (die1 == die2)
                {
                    return $"Player 1 is on square {playerOnePosition}";
                }

                isPlayerOneTurn = false;
                return $"Player 1 is on square {playerOnePosition}";
            }
            else
            {
                playerTwoPosition = MovePlayer(playerTwoPosition, die1, die2);

                if (playerTwoPosition == 100)
                {
                    gameOver = true;
                    return "Player 2 Wins!";
                }

                if (die1 == die2)
                {
                    return $"Player 2 is on square {playerTwoPosition}";
                }

                isPlayerOneTurn = true;
                return $"Player 2 is on square {playerTwoPosition}";
            }
        }

        private int MovePlayer(int playerPosition, int die1, int die2)
        {
            playerPosition += die1 + die2;

            if (playerPosition > 100)
            {
                playerPosition = 100 - (playerPosition - 100);
            }

            playerPosition = Board(playerPosition);

            return playerPosition;
        }

        private static int Board(int playerPosition)
        {
            switch (playerPosition)
            {
                case 2:
                    {
                        playerPosition = 38;
                        break;
                    }
                case 7:
                    {
                        playerPosition = 14;
                        break;
                    }
                case 8:
                    {
                        playerPosition = 31;
                        break;
                    }
                case 15:
                    {
                        playerPosition = 26;
                        break;
                    }
                case 16:
                    {
                        playerPosition = 6;
                        break;
                    }
                case 21:
                    {
                        playerPosition = 42;
                        break;
                    }
                case 28:
                    {
                        playerPosition = 84;
                        break;
                    }
                case 36:
                    {
                        playerPosition = 44;
                        break;
                    }
                case 46:
                    {
                        playerPosition = 25;
                        break;
                    }
                case 49:
                    {
                        playerPosition = 11;
                        break;
                    }
                case 51:
                    {
                        playerPosition = 67;
                        break;
                    }
                case 62:
                    {
                        playerPosition = 19;
                        break;
                    }
                case 64:
                    {
                        playerPosition = 60;
                        break;
                    }
                case 71:
                    {
                        playerPosition = 91;
                        break;
                    }
                case 74:
                    {
                        playerPosition = 53;
                        break;
                    }
                case 78:
                    {
                        playerPosition = 98;
                        break;
                    }
                case 87:
                    {
                        playerPosition = 94;
                        break;
                    }
                case 89:
                    {
                        playerPosition = 68;
                        break;
                    }
                case 92:
                    {
                        playerPosition = 88;
                        break;
                    }
                case 95:
                    {
                        playerPosition = 75;
                        break;
                    }
                case 99:
                    {
                        playerPosition = 80;
                        break;
                    }
            }

            return playerPosition;
        }
    }
}
//https://www.codewars.com/kata/587136ba2eefcb92a9000027/train/csharp