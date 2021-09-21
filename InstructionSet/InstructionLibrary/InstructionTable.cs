using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary {
    public enum InstructionTable {
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

        R_Type = add | sub | and | or | nor | xor,
        I_Type = lw | sw | beq | mul | addi | andi | ori | sll | srl,
        S_Type = stop
    }
}