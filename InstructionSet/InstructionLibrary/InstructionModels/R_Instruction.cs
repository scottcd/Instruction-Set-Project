﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary.InstructionModels {
    public class R_Instruction : IInstruction{
        public Opcode Opcode { get; set; }
        public OpcodeType OpcodeType { get; set; }
        public int[] Instruction { get; set; }

        public R_Instruction(int[] hex, Opcode opcode, OpcodeType opcodeType) {
            Opcode = opcode;
            OpcodeType = opcodeType;
            Instruction = hex;
        }
    }
}
