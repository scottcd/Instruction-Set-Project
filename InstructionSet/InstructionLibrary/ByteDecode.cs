// ***********************************************************************
// Project:         ConsoleUI
// File Name:       Decode.cs
// Description:     Enter
// Course:          CSCI 4727-001 - Operating Systems
// Author:          Michael Arthur, arthurm@etsu.edu
// Created          09-17-2021
// ***********************************************************************
// <copyright>
//     Michael Arthur, Copyright (c) . All rights reserved.
// </copyright>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary
{
    /// <summary>
    /// Class Decode.
    /// </summary>
    public class ByteDecode
    {

        /// <summary>
        /// The byte stream
        /// </summary>
        private ushort[] byteStream;
        /// <summary>
        /// The opcode
        /// </summary>
        private byte opcode = 0;
        /// <summary>
        /// The operand
        /// </summary>
        private short operand = 9;


        /// <summary>
        /// Initializes a new instance of the <see cref="ByteDecode"/> class.
        /// </summary>
        /// <param name="_byteStrem">The byte strem.</param>
        public ByteDecode(ushort[] _byteStrem)
        {

            byteStream = _byteStrem;

            Decoder();
        }

        /*
        byte x = 0x12; //hexadecimal notation for decimal 18 or binary 0001 0010
        byte highNibble = (byte)(x >> 4 & 0xF); // = 0000 0001
        byte lowNibble = (byte)(x & 0xF); // = 0000 0010
        */


        /// <summary>
        /// Decoder.
        /// </summary>
        private void Decoder()
        {
            bool halt = false;
            ushort intruction;

            while(!halt)
            {

                intruction = byteStream[0];
                opcode = (byte)(intruction >> 12 & 0x000f );
                operand = (short)(intruction & 0x0fff);

                halt = true;
            }



        }

    }
}
