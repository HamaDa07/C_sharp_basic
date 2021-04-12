using System;

namespace Loop_multi_basic
{
    class Loop_multi_basic
    {
        static void Main(string[] args)
        {
            string[] teamA = { "A0", "A1", "A2" };
            string[] teamB = { "B0", "B1", "B2" };
            string[] teamC = { "C0", "C1", "C2" };

            string[][] teams = { teamA, teamB, teamC };
            Console.Write(teams[0][0] + ",");
            Console.Write(teams[0][1] + ",");
            Console.Write(teams[0][1]);
            //A1,A1,A2,
            }
        }
    }
