using System;
using System.Collections.Generic;
using InstructionLibrary;
using InstructionLibrary.InstructionModels;

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
            
            
            List <IInstruction> instructions = new List<IInstruction>();
            int[] instruction;


            for (int i = 0; i < instructionValues.Length - 1; i++) {
                if (instructionValues[i] == 0) {
                    instruction = new int[1] { instructionValues[i] };
                    // get the next digit
                    instructions.Add(new H_Instruction(instruction));
                }
                if (instructionValues[i] == 10) {
                    // get the next 4 digits
                    instruction = new int[4] {
                        instructionValues[i],
                        instructionValues[i++],
                        instructionValues[i++],
                        instructionValues[i++]
                    };
                    instructions.Add(new R_Instruction(instruction));
                }
                if (instructionValues[i] == 9) {
                    // get the next 4 digits
                    instruction = new int[4] { 
                        instructionValues[i], 
                        instructionValues[i++], 
                        instructionValues[i++], 
                        instructionValues[i++] 
                    };

                    instructions.Add(new I_Instruction(instruction));
                }
                //output += $"{(InstructionTable)instructionValues[i]} {instructionValues[i]} \n";
            }

            foreach (var item in instructions) {
                Console.Write($"{item.Opcode} ");
            }

            //Console.WriteLine(output);
        }
    }
}
