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
            foreach (var item in instructions) {
                if (item is H_Instruction) {
                    output += $"{item.Opcode}\n";
                }
                else {
                    output += $"{item.Opcode} {item.Instruction[1]} {item.Instruction[2]} {item.Instruction[3]}\n";
                }
            }
            Console.WriteLine(output);
        }
    }
}
