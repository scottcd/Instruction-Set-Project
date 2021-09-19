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
            inputBox.Text = ((int)InstructionTable.addi).ToString("X");
            outputBox.Text = InstructionTable.addi.ToString();
        }

    }
}
