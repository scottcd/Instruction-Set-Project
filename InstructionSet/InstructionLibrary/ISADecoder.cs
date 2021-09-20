using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionLibrary {
    public static class ISADecoder {
        /// <summary>
        /// Parses a string input of hex values into 0-16
        /// </summary>
        /// <param name="hexString">User input (string of hex digits)</param>
        /// <returns>An integer array of 4-bit instruction values</returns>
        public static int[] ParseToInt(string hexString) {
            char[] unparsedArray = hexString.ToCharArray()
                                            .Where(c => !Char.IsWhiteSpace(c))
                                            .ToArray();
            int[] parsedHex = new int[unparsedArray.Length];

            for (int i = 0; i < unparsedArray.Length; i++) {
                parsedHex[i] = int.Parse(unparsedArray[i].ToString(), System.Globalization.NumberStyles.HexNumber);
            }

            return parsedHex;
        }
    }
}
