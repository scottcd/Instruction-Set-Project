using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary.InstructionModels {
    public class R_Instruction : IInstruction{
        public Opcodes Opcode { get; set; }
        public OpcodeType OpcodeType { get; set; }
        public int[] Instruction { get; set; }

        public R_Instruction(int[] hex, Opcodes opcode, OpcodeType opcodeType) {
            Opcode = opcode;
            OpcodeType = opcodeType;
            Instruction = hex;
        }
    }
}
