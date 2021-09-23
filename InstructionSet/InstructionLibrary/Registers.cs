using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary {
    public enum Registers {
        r0  = 0x0,
        r1  = 0x1,
        r2  = 0x2,
        r3  = 0x3,
        r4  = 0x4,
        r5  = 0x5,
        r6  = 0x6,
        r7  = 0x7,
        r8  = 0x8,
        r9  = 0x9,
        r10 = 0xA,
        r11 = 0xB,
        r12 = 0xC,
        r13 = 0xD,
        r14 = 0xE,
        r15 = 0xF
    }
    public enum RegisterType {
        R_Type,
        I_Type,
        H_Type
    }
    public static class RegisterTypes {
        public static RegisterType GetType(this Registers register) {
            switch (register) {
                case Registers.r0:
                    return RegisterType.H_Type;
                case Registers.r1:
                    return RegisterType.R_Type;
                case Registers.r2:
                    return RegisterType.R_Type;
                case Registers.r3:
                    return RegisterType.R_Type;
                case Registers.r4:
                    return RegisterType.R_Type;
                case Registers.r5:
                    return RegisterType.R_Type;
                case Registers.r6:
                    return RegisterType.R_Type;
                default:
                    return RegisterType.I_Type;
            }
        }
    }
}
