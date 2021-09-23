using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstructionLibrary;
using InstructionLibrary.InstructionModels;

namespace WinFormsUI {
    public partial class ISAForm : Form {
        public ISAForm() {
            InitializeComponent();
            
            inputBox.Text = "1A EE 4A A1 2A AA A3 5F 00";
            var instructionValues = ISADecoder.ParseToInt(inputBox.Text);
            List<IInstruction> instructions = ISADecoder.DecodeHex(instructionValues);
            
            string output = "";
            foreach (var item in instructions) {
                if (item is H_Instruction) {
                    output += $"{item.Opcode}\n";
                }
                else {
                    output += $"{item.Opcode} {item.Instruction[1]} {item.Instruction[2]} {item.Instruction[3]}\n";
                }
            }

            outputBox.Text = output;
        }

    }
}
