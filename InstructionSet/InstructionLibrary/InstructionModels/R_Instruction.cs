using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary.InstructionModels {
    public class R_Instruction : IInstruction{
        public Opcodes Opcode { get; set; }
        public OpcodeType OpcodeType { get; set; }
        public Registers DestinationRegister { get; set; }
        public Registers SourceRegister1 { get; set; }
        public Registers SourceRegister2 { get; set; }

        public int[] Instruction { get; set; }

        public R_Instruction(int[] hex, Opcodes opcode, OpcodeType opcodeType) {
            Opcode = opcode;
            OpcodeType = opcodeType;
            DestinationRegister = (Registers)hex[1];
            SourceRegister1 = (Registers)hex[2];
            SourceRegister2 = (Registers)hex[3];
            Instruction = hex;
        }
        public override string ToString() {
            return $"{Opcode}\t{DestinationRegister}\t{SourceRegister1}\t{SourceRegister2}";
        }
    }
}
