using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Find Winner on a Tic Tac Toe Game
    /// </summary>
    public class No1275
    {
        /*
            解体思路：先手的是A，棋子用"X"表示。后手的是B，棋子用"O"表示。
                    从第5步开始，计算棋盘上是否有三个相同的棋子在一条线上。需要判断三个横，三个纵，两个对角线。
                    直到第9步为止，如果没有三点一线的，返回"Draw"
                    
            1 <= moves.length <= 9
            moves[i].length == 2
            0 <= rowi, coli <= 2
            There are no repeated elements on moves.
            moves follow the rules of tic tac toe.
         */
        public string Tictactoe(int[][] moves)
        {

            //定义一个3*3的棋盘
            char[][] checkerBoard = new char[3][];
            for (int i = 0; i < 3; i++)
            {
                checkerBoard[i] = new char[3];
            }

            //moves
            for (int i = 0; i < moves.Length; i++)
            {
                if (i % 2 == 0)
                {
                    //A走
                    checkerBoard[moves[i][0]][moves[i][1]] = 'X';
                }
                else
                {
                    //B走
                    checkerBoard[moves[i][0]][moves[i][1]] = 'O';  //大写字母O，不是零
                }

                //注意加上moves完的情况
                if (i >= 4)
                {
                    char sign = Check(checkerBoard);

                    if (sign == 'X')
                    {
                        return "A";
                    }

                    if (sign == 'O')
                    {
                        return "B";
                    }
                }
            }

            //注意这个判断，如果还有空位，就是Pending
            if (moves.Length < 9)
            {
                return "Pending";
            }

            return "Draw";
        }

        /// <summary>
        /// 判断是否有三点一线的，如果有返回相应字符，没有则返回空格
        /// </summary>
        /// <param name="checkerBoard"></param>
        /// <returns></returns>
        private char Check(char[][] checkerBoard)
        {
            //横
            {
                if (checkerBoard[0][0] == checkerBoard[0][1] && checkerBoard[0][0] == checkerBoard[0][2])
                {
                    return checkerBoard[0][0];
                }

                if (checkerBoard[1][0] == checkerBoard[1][1] && checkerBoard[1][0] == checkerBoard[1][2])
                {
                    return checkerBoard[1][0];
                }

                if (checkerBoard[2][0] == checkerBoard[2][1] && checkerBoard[2][0] == checkerBoard[2][2])
                {
                    return checkerBoard[2][0];
                }
            }

            //纵
            {
                if (checkerBoard[0][0] == checkerBoard[1][0] && checkerBoard[0][0] == checkerBoard[2][0])
                {
                    return checkerBoard[0][0];
                }

                if (checkerBoard[0][1] == checkerBoard[1][1] && checkerBoard[0][1] == checkerBoard[2][1])
                {
                    return checkerBoard[0][1];
                }

                if (checkerBoard[0][2] == checkerBoard[1][2] && checkerBoard[0][2] == checkerBoard[2][2])
                {
                    return checkerBoard[0][2];
                }
            }

            //对角
            {
                if (checkerBoard[0][0] == checkerBoard[1][1] && checkerBoard[0][0] == checkerBoard[2][2])
                {
                    return checkerBoard[0][0];
                }

                if (checkerBoard[2][0] == checkerBoard[1][1] && checkerBoard[2][0] == checkerBoard[0][2])
                {
                    return checkerBoard[2][0];
                }
            }

            return ' ';
        }
    }
}
