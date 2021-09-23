using System;
using System.Collections.Generic;
using InstructionLibrary;
using InstructionLibrary.InstructionModels;

namespace ConsoleUI {
    public class Driver {
        public static void Main(string[] args) {
            Console.WriteLine("Input (AS BINARY STREAM):\n\n");
            string hexString = Console.ReadLine();
            
            var instructionValues = ISADecoder.ParseToInt(hexString);

            List<IInstruction> instructions = ISADecoder.DecodeHex(instructionValues);

            string output = "";
            foreach (var instruction in instructions) {
                if (instruction is H_Instruction) {
                    output += $"{instruction}\n";
                }
                else {
                    output += $"{instruction}\n";
                }
            }
            Console.WriteLine(output);
        }
    }
}
