using InstructionLibrary.Interfaces;
using InstructionLibrary.Models;
using InstructionLibrary.Models.Instructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionLibrary {
    public static class ExecuteInstruction {
        public static void SwitchSelect(IInstruction instruction, MachineState state) {
            switch (instruction.Opcode) {
                case Opcodes.add:
                    Add((R_Instruction)instruction, state);
                    break;
                default:
                    //Add((R_Instruction)instruction, state);
                    break;
            }
        }
        public static void Add(R_Instruction instruction, MachineState state) {
            int destRegister = (int)instruction.DestinationRegister;
            int sourceRegister1 = (int)instruction.SourceRegister1;
            int sourceRegister2 = (int)instruction.SourceRegister2;

            state.MachineRegisters[(Registers)destRegister] =    state.MachineRegisters[(Registers)sourceRegister1]
                                                              +  state.MachineRegisters[(Registers)sourceRegister2];
        }
    }
}
