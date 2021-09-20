using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary {
    public class InstructionModel {
        public int[] Instruction{ get; set; }
        public InstructionModel() {
            Instruction = new int[4];
        }
    }
}
