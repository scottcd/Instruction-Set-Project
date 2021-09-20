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

namespace WinFormsUI {
    public partial class ISAForm : Form {
        public ISAForm() {
            InitializeComponent();
            
            inputBox.Text = "1A EE 4A A1 2A AA A3 5F 00";
            var instructionValues = ISADecoder.ParseToInt(inputBox.Text);

            string output = "";
            for (int i = 0; i < instructionValues.Length; i++) {
                output += $"{(InstructionTable)instructionValues[i]} {instructionValues[i]} \n";
            }

            outputBox.Text = output;
        }

    }
}
