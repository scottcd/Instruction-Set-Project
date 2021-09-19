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
            int instructionValue = int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            
            ushort[] bytes = { 9145, 4512, 21, 78 };

            ByteDecode dc = new ByteDecode(bytes);
            
            InstructionTable x = (InstructionTable)instructionValue;

            Console.WriteLine($"{x} test");
        }
    }
}
