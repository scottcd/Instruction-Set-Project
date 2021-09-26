﻿using System;
using InstructionLibrary;

namespace ConsoleUI {
    class Program {
        static void Main(string[] args) {
            /*
             1. feed input
             2. decode hex -> instruction
             3. print instructions
             */
            ushort[] bytes = { 9145, 4512, 21, 78 };

            Decode dc = new Decode(bytes);

            Console.WriteLine(InstructionTable.add);
        }
    }
}