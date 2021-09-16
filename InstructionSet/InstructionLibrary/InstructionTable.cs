using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary {
    public enum InstructionTable {
        add =   0b000,
        sub =   0b0001,
        and =   0b0010,
        or =    0b0011,
        nor =   0b0100,
        xor =   0b1110,



        R_Type = add | sub | and | or | nor | xor,
        I_Type = add | sub,
        J_Type = add | sub
    }
}
