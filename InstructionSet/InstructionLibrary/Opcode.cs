﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary {
    public enum Opcode {
        add = 0x1,
        sub = 0x2,
        and = 0x3,
        or = 0x4,
        nor = 0x5,
        lw = 0x6,
        sw = 0x7,
        beq = 0x8,
        mul = 0x9,
        addi = 0xA,
        andi = 0xB,
        ori = 0xC,
        sll = 0xD,
        srl = 0xE,
        xor = 0xF,
        stop = 0x0,
    }
    public enum OpcodeType { 
        R_Type,
        I_Type,
        H_Type
    }
    public static class OpcodeTypes {
        public static OpcodeType GetType(this Opcode opcode) {
            switch (opcode) {
                case Opcode.stop:
                    return OpcodeType.H_Type;
                case Opcode.add:
                    return OpcodeType.R_Type;
                case Opcode.sub:
                    return OpcodeType.R_Type;
                case Opcode.and:
                    return OpcodeType.R_Type;
                case Opcode.or:
                    return OpcodeType.R_Type;
                case Opcode.nor:
                    return OpcodeType.R_Type;
                case Opcode.xor:
                    return OpcodeType.R_Type;
                default:
                    return OpcodeType.I_Type;
            }
        }
    }
}