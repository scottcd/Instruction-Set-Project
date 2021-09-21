using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary.InstructionModels {
    public class H_Instruction : IInstruction {
        public InstructionTable Opcode { get; set; }
        public int[] Instruction { get; set; }

        public H_Instruction(int[] hex) {
            Opcode = (InstructionTable)hex[0];
            Instruction = hex;
        }
    }
}
