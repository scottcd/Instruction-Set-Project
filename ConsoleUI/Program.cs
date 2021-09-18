using System;
using InstructionLibrary;

namespace ConsoleUI {
    class Program {
        static void Main(string[] args) {
            /*
             1. feed input
             2. decode hex -> instruction
             3. print instructions
             */

            InstructionTable instruction = (InstructionTable) int.Parse(Console.ReadLine());
            Console.WriteLine(instruction);
        }
    }
}
