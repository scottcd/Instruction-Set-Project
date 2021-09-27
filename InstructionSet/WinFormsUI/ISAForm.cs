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
using InstructionLibrary.Interfaces;
using InstructionLibrary.Models;
using InstructionLibrary.Models.Instructions;


namespace WinFormsUI {
    public partial class ISAForm : Form {
        protected MachineState state;

        private int currentInstruction = 0;
        protected List<IInstruction> instructions;

        public ISAForm() {
            InitializeComponent();

            //state = new MachineState();

            inputBox.Text = "1A EE 4A A1 2A AA A3 5F 1A EE 4A A1 2A AA A3 5F 1A EE 4A A1 2A AA A3 5F 00";
            //var instructionValues = ISADecoder.ParseToInt(inputBox.Text);
            //instructions = ISADecoder.DecodeHex(instructionValues);
            
            //string output = "";
            //foreach (var instruction in instructions) {
            //    state.CurrentInstruction = instruction;
            //    //ExecuteInstruction.SwitchSelect(instruction, state);
            //    output += $"{instruction}\n";
            //}

            //outputBox.Text = output;
            stateBox.Text = $"{state}";
        }

        //simple event to prevent step through if the code hasn't been compiled
        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = false;
            NextButton.FlatStyle = FlatStyle.System;
        }//end inputBox_TextChanged(object, EventArgs)

        private void CompileButton_Click(object sender, EventArgs e) {
            state = new MachineState();
            var instructionValues = InstructionLibrary.Decoder.ParseToInt(inputBox.Text);
            instructions = InstructionLibrary.Decoder.DecodeHex(instructionValues);
            string output = "";
            foreach (var instruction in instructions) {
                state.CurrentInstruction = instruction;
                //ExecuteInstruction.SwitchSelect(instruction, state);
                output += $"{instruction}\n";
            }

            outputBox.Text = output;
            stateBox.Text = $"{state}";
            NextButton.Enabled = true;
            NextButton.FlatStyle = FlatStyle.Popup;
            currentInstruction = 0;
        }

        //event that executes the next step of the compiled code
        //gets the current instruction from the instructions list then
        //updates the form accordingly.
        private void RunButton_Click(object sender, EventArgs e) {
            state = new MachineState();
            foreach (var instruction in instructions) {
                state.CurrentInstruction = instruction;
                Executor.SwitchSelect(instruction, state);
            }

            stateBox.Text = $"{state}";


            //disable the NextButton and reset currentInstruction
            NextButton.Enabled = false;
            NextButton.FlatStyle = FlatStyle.Popup;
            currentInstruction = 0;
        }//end NExtButton_Click(object, EventArgs)

        //event that executes the next step of the compiled code
        //gets the current instruction from the instructions list then
        //updates the form accordingly.
        private void NextButton_Click(object sender, EventArgs e)
        {
            state.CurrentInstruction = instructions[currentInstruction];
            Executor.SwitchSelect(instructions[currentInstruction], state);

            stateBox.Text = $"{state}";

            //prevents step through if the end
            //of the instructions list has been reached.
            currentInstruction++;
            if (currentInstruction >= instructions.Count) 
            {
                NextButton.Enabled = false;
                NextButton.FlatStyle = FlatStyle.System;
            }//end if()
        }//end NExtButton_Click(object, EventArgs)
    
    }
}
