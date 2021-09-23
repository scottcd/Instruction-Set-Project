using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExecutionLibrary;
using InstructionLibrary;
using InstructionLibrary.Interfaces;
using InstructionLibrary.Models.Instructions;

namespace WinFormsUI {
    public partial class ISAForm : Form {
        
        
        public ISAForm() {
            InitializeComponent();

            MachineState state = new MachineState();

            inputBox.Text = "1A EE 4A A1 2A AA A3 5F 00";
            var instructionValues = ISADecoder.ParseToInt(inputBox.Text);
            List<IInstruction> instructions = ISADecoder.DecodeHex(instructionValues);
            
            string output = "";
            foreach (var instruction in instructions) {
                state.CurrentInstruction = instruction;
                ExecuteInstruction.SwitchSelect(instruction, state);
                output += $"{instruction}\n";
            }


            outputBox.Text = output;
            stateBox.Text = $"{state}";
        }

    }
}
