using System;

namespace SweetnSalty
// //Here’s todays Coding Challenge.
// Week2 - “Fizz/Buzz” by any other name. 
// Print the numbers 1 to 1000 to the console. 
// Print them in groups of 10 per line with a space separating each number.  
// When the number is multiple of three, print “sweet” instead of the number on the console.  
// If the number is a multiple of five, print “salty” (instead of the number) to the console.  
// For numbers which are multiples of three and five, print “sweet’nSalty” to the console (instead of the number).  
// After the numbers have all been printed, print out how many sweet’s, how many salty’s, and how many sweet’nSalty’s. 
//These are three separate groups, so sweet’nSalty does not increment sweet or salty (and vice versa). 
// Include verbose commentary in the source code to tell me what each few lines are doing. 
// The coding Challenge is due by midnight, today, 03.10.21. 
// Push the “compilable” source code to your P0 repo. 
// Good Luck!
{   //Program start
    class Program 
{   //Main start program no program can run without this line:
    static void Main(string[] args)
    {
    //Setting basic parameters
    int StartNumber = 1;
    int EndNumber = 1000; 
    int PrintGroups = 10;
    //Variables are divisble by:
    int NumOne = 3;
    var NumTwo = 5;
    //Counter for measuring word:
    var SweetCounter = 0; 
    var SaltyCounter = 0; 
    var SweetnSaltyCounter = 0;
    //Word to print out: 
    var Sweet = "sweet";
    var Salty = "salty"; 
    var SweetnSalty = "SweetNSalty";
    //The logic binded in a if statement: 
    for (int i = StartNumber; i < EndNumber; i++) 
    {   //As per Catherine if run in the end will not run this part of the code
        if (i % NumOne == 0 && i % NumTwo == 0) {
            Console.Write (SweetnSalty + " ");
            SweetnSaltyCounter += 1; 
        }
        else if(i % NumOne == 0) {
            Console.Write (Sweet + " ");
            SweetCounter += 1; 
        }
        else if (i % NumTwo == 0) {
            Console.Write (Salty + " ");
            SaltyCounter += 1;
        }
        else 
        {
            //used for spacing 
            Console.Write (i + " ");
        }   //Counter of 10 for spacing
        if (i % 10 == 0)
        {
            Console.Write ("\n");
            } 
        } 
        //final print
    Console.Write ("\n");
    Console.WriteLine ("Word " + Sweet + " was counted " + SweetCounter);
    Console.WriteLine ("Word " + Salty + " was counted " + SaltyCounter);
    Console.WriteLine ("Word " + SweetnSalty + " was counted " + SweetnSaltyCounter);   
        }   
    } 
    }

// Special thanks to Sagar, Chelsey, Catherine for helping me debug!!! 
