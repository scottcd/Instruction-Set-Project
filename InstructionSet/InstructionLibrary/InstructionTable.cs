using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary {
    public enum InstructionTable {
        add = 0x01,
        sub = 0x02,
        and = 0x03,
        or = 0x04,
        nor = 0x05,
        xor = 0x0F,
        lw = 0x06,
        sw = 0x07,
        beq = 0x08,
        mul = 0x09,
        addi = 0x0A,
        andi = 0x0B,
        ori = 0x0C,
        sll = 0x0D,
        srl = 0x0E,
        stop = 0x00,

        R_Type = add | sub | and | or | nor | xor,
        I_Type = lw | sw | beq | mul | addi | andi | ori | sll | srl,
        J_Type = stop
    }
}