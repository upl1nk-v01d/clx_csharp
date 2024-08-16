﻿using System.Drawing;

namespace exc05
{
    class Program
    {
        static void Main(string[] args){
            string[,] arrayTeachers = { //created 2 dimensional string array with elements
                {"English III","Ms. Lapan"},
                {"Precalculus","Mrs. Gideon"},
                {"Music Theory","Mr. Davis"},
                {"Biotechnology","Ms. Palmer"},
                {"Principles of Technology I","Ms. Garcia"},
                {"Latin II","Mrs. Barnett"},
                {"AP US History","Ms. Johannessen"},
                {"Business Computer Infomation Systems","Mr. James"}
            };

            int cols = 64; //declared column quantity
            int rightIndent1 = 45; //declared right indent for classes text endpoint
            int rightIndent2 = 63; //declared right indent for teachers text endpoint

            for(int i1=0; i1<arrayTeachers.GetLength(0); i1++){
                if(i1==0){ //outputs as first line if condition is met
                    Console.WriteLine("+-------------------------------------------------------------+");
                }

                for(int i2=0; i2<cols; i2++){
                    if(i2>=(rightIndent1-arrayTeachers[i1,0].Length-1) && i2<rightIndent1-1){
                        Console.Write(arrayTeachers[i1,0][i2-(rightIndent1-arrayTeachers[i1,0].Length-1)]);
                    } else if(i2>=(63-arrayTeachers[i1,1].Length-1) && i2<rightIndent2-1){
                        Console.Write(arrayTeachers[i1,1][i2-(rightIndent2-arrayTeachers[i1,1].Length-1)]);
                    } else if(i2==0 || i2==4 || i2==45 || i2==62){
                        Console.Write("|"); //outputs "|" in relevant column if conditions are met
                    } else if(i2==2){
                        Console.Write(i1+1); //outputs number in second column if condition is met
                    } else {
                        Console.Write(" "); //outputs whitespace if conditions are not met
                    }
                }

                Console.WriteLine(); //outputs carriage return to start new line

                if(i1==arrayTeachers.GetLength(0)-1){
                    //outputs as last line if condition is met by getting last element index of array
                    Console.WriteLine("+-------------------------------------------------------------+");
                }
            }
        }
    }
}