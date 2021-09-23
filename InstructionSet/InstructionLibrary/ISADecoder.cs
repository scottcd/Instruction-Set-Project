﻿using InstructionLibrary.InstructionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary {
    public static class ISADecoder {
        /// <summary>
        /// Parses a string input of hex values into 0-16
        /// </summary>
        /// <param name="hexString">User input (string of hex digits)</param>
        /// <returns>An integer array of 4-bit instruction values</returns>
        public static int[] ParseToInt(string hexString) {
            char[] unparsedArray = hexString.ToCharArray()
                                            .Where(c => !Char.IsWhiteSpace(c))
                                            .ToArray();
            int[] parsedHex = new int[unparsedArray.Length];

            for (int i = 0; i < unparsedArray.Length; i++) {
                parsedHex[i] = int.Parse(unparsedArray[i].ToString(), System.Globalization.NumberStyles.HexNumber);
            }

            return parsedHex;
        }

        /// <summary>
        /// Takes 0 - 15 integers as input and translates to instructions
        /// </summary>
        /// <param name="instructionValues">User input parsed as integers</param>
        /// <returns>List of Instruction objects</returns>
        public static List<IInstruction> DecodeHex(int [] instructionValues) {
            List<IInstruction> instructions = new List<IInstruction>();
            int[] instruction;

            for (int i = 0; i < instructionValues.Length - 1; i++) {
                Opcode opcode = (Opcode)instructionValues[i];
                OpcodeType opcodeType = OpcodeTypes.GetType(opcode);

                if (opcodeType == OpcodeType.H_Type) {
                    instruction = new int[1] { instructionValues[i] };
                    // get the next digit
                    instructions.Add(new H_Instruction(instruction, opcode, opcodeType));
                }
                if (opcodeType == OpcodeType.R_Type) {
                    // get the next 4 digits now
                    instruction = new int[4] {
                        instructionValues[i],
                        instructionValues[i++],
                        instructionValues[i++],
                        instructionValues[i++]
                    };
                    instructions.Add(new R_Instruction(instruction, opcode, opcodeType));
                }
                if (opcodeType == OpcodeType.I_Type) {
                    // get the next 4 digits
                    instruction = new int[4] {
                        instructionValues[i],
                        instructionValues[i++],
                        instructionValues[i++],
                        instructionValues[i++]
                    };

                    instructions.Add(new I_Instruction(instruction, opcode, opcodeType));
                }
            }

            return instructions;
        }
    }
}
