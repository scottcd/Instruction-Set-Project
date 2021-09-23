using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary.InstructionModels {
    public interface IInstruction {
        public Opcode Opcode { get; set; }
        public int[] Instruction { get; set; }
        public OpcodeType OpcodeType { get; set; }
    }
}
