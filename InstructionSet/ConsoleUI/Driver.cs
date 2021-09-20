using System;
using InstructionLibrary;

namespace ConsoleUI {
    class Driver {
        static void Main(string[] args) {
            /*
             1. feed input
             2. decode hex -> instruction
             3. print instructions
             */

            Console.WriteLine("Input (AS BINARY STREAM):\n\n");
            string hexString = Console.ReadLine();
            
            var instructionValues = ISADecoder.ParseToInt(hexString);
            
            string output = "";

            for (int i = 0; i < instructionValues.Length; i++) {
                output += $"{(InstructionTable)instructionValues[i]} {instructionValues[i]} \n";
            }
            
            Console.WriteLine(output);
        }
    }
}
