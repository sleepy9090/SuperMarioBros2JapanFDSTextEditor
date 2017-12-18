using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperMarioBros2JapanFDSTextEditor
{
    class Backend
    {
        int textFlag = 0;

        public Backend()
        {

        }

        public void getText(string path, TextBox texboxname, int length, int offset)
        {
            string romCodeString = "";
            string smb2JFDSAsciiOut = "";
            string tempHexString = "";
            int x = 0;
            using (FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read))
            {

                fileStream.Seek(offset, SeekOrigin.Begin);

                while (x < length)
                {
                    romCodeString = fileStream.ReadByte().ToString("X");

                    //if length is single digit add a 0 ( 1 now is 01)
                    if (romCodeString.Length == 1)
                    {
                        romCodeString = "0" + romCodeString;
                    }
                    tempHexString = romCodeString;

                    decodeROMText(tempHexString);

                    if (textFlag == 0)
                    {
                        smb2JFDSAsciiOut += decodeROMText(tempHexString);
                    }
                    x++;

                    texboxname.Text = smb2JFDSAsciiOut;
                }
            }
        }

        public void updateROMText(string absoluteFilename, int length, TextBox textBox, int offset)
        {

            string newDDString = textBox.Text;

            newDDString = newDDString.PadRight(length);
            string hexReturn = "";
            string tempascii = "";
            string[] newDDStringArray = new string[length];
            byte[] newDDStringByteArray = new byte[length];
            int[] ddDecimal = new int[length];
            string[] ddFinal = new string[length];
            string[] dds = new string[length];

            int x = 0;
            while (x < length)
            {
                newDDStringArray[x] = newDDString[x].ToString();
                tempascii = newDDStringArray[x];
                hexReturn += encodeROMText(tempascii);
                x++;
            }

            int i = 0;
            int j = 0;
            while (i < length)
            {
                dds[i] = hexReturn[j].ToString() + hexReturn[j + 1].ToString();
                i++;
                j += 2;
            }

            int q = 0;
            while (q < length)
            {
                ddDecimal[q] = int.Parse(dds[q], System.Globalization.NumberStyles.HexNumber);
                ddFinal[q] = ddDecimal[q].ToString();
                newDDStringByteArray[q] = byte.Parse(ddFinal[q]);
                q++;
            }

            using (FileStream fileStream = new FileStream(@absoluteFilename, FileMode.Open, FileAccess.Write))
            {
                fileStream.Seek(offset, SeekOrigin.Begin);
                q = 0;
                while (q < length)
                {
                    fileStream.WriteByte(newDDStringByteArray[q]);
                    q++;
                }
            }
        }

        private string decodeROMText(String tempHexString)
        {
            string smb2JFDSAscii = "";
            textFlag = 0;

            switch (tempHexString)
            {
                case "24":
                    smb2JFDSAscii += " ";
                    break;
                case "28":
                    smb2JFDSAscii += "-";
                    break;
                case "2B":
                    smb2JFDSAscii += "!";
                    break;
                case "00":
                    smb2JFDSAscii += "0";
                    break;
                case "01":
                    smb2JFDSAscii += "1";
                    break;
                case "02":
                    smb2JFDSAscii += "2";
                    break;
                case "03":
                    smb2JFDSAscii += "3";
                    break;
                case "04":
                    smb2JFDSAscii += "4";
                    break;
                case "05":
                    smb2JFDSAscii += "5";
                    break;
                case "06":
                    smb2JFDSAscii += "6";
                    break;
                case "07":
                    smb2JFDSAscii += "7";
                    break;
                case "08":
                    smb2JFDSAscii += "8";
                    break;
                case "09":
                    smb2JFDSAscii += "9";
                    break;
                case "0A":
                    smb2JFDSAscii += "A";
                    break;
                case "0B":
                    smb2JFDSAscii += "B";
                    break;
                case "0C":
                    smb2JFDSAscii += "C";
                    break;
                case "0D":
                    smb2JFDSAscii += "D";
                    break;
                case "0E":
                    smb2JFDSAscii += "E";
                    break;
                case "0F":
                    smb2JFDSAscii += "F";
                    break;
                case "10":
                    smb2JFDSAscii += "G";
                    break;
                case "11":
                    smb2JFDSAscii += "H";
                    break;
                case "12":
                    smb2JFDSAscii += "I";
                    break;
                case "13":
                    smb2JFDSAscii += "J";
                    break;
                case "14":
                    smb2JFDSAscii += "K";
                    break;
                case "15":
                    smb2JFDSAscii += "L";
                    break;
                case "16":
                    smb2JFDSAscii += "M";
                    break;
                case "17":
                    smb2JFDSAscii += "N";
                    break;
                case "18":
                    smb2JFDSAscii += "O";
                    break;
                case "19":
                    smb2JFDSAscii += "P";
                    break;
                case "1A":
                    smb2JFDSAscii += "Q";
                    break;
                case "1B":
                    smb2JFDSAscii += "R";
                    break;
                case "1C":
                    smb2JFDSAscii += "S";
                    break;
                case "1D":
                    smb2JFDSAscii += "T";
                    break;
                case "1E":
                    smb2JFDSAscii += "U";
                    break;
                case "1F":
                    smb2JFDSAscii += "V";
                    break;
                case "20":
                    smb2JFDSAscii += "W";
                    break;
                case "21":
                    smb2JFDSAscii += "X";
                    break;
                case "22":
                    smb2JFDSAscii += "Y";
                    break;
                case "23":
                    smb2JFDSAscii += "Z";
                    break;
                //case "AF":
                case "27":
                    smb2JFDSAscii += ".";
                    break;
                case "F2":
                    smb2JFDSAscii += "'";
                    break;
                default:
                    smb2JFDSAscii += " ";
                    textFlag = 1;
                    break;
            }

            return smb2JFDSAscii;
        }

        private string encodeROMText(string tempascii)
        {
            string smbjFDSHex = "";
            tempascii = tempascii.ToUpper();

            switch (tempascii)
            {
                case " ":
                    smbjFDSHex += "24";
                    break;
                case "'":
                    smbjFDSHex += "F2";
                    break;
                case ".":
                    smbjFDSHex += "27";
                    break;
                case "-":
                    smbjFDSHex += "28";
                    break;
                case "!":
                    smbjFDSHex += "2B";
                    break;
                case "0":
                    smbjFDSHex += "00";
                    break;
                case "1":
                    smbjFDSHex += "01";
                    break;
                case "2":
                    smbjFDSHex += "02";
                    break;
                case "3":
                    smbjFDSHex += "03";
                    break;
                case "4":
                    smbjFDSHex += "04";
                    break;
                case "5":
                    smbjFDSHex += "05";
                    break;
                case "6":
                    smbjFDSHex += "06";
                    break;
                case "7":
                    smbjFDSHex += "07";
                    break;
                case "8":
                    smbjFDSHex += "08";
                    break;
                case "9":
                    smbjFDSHex += "09";
                    break;
                case "A":
                    smbjFDSHex += "0A";
                    break;
                case "B":
                    smbjFDSHex += "0B";
                    break;
                case "C":
                    smbjFDSHex += "0C";
                    break;
                case "D":
                    smbjFDSHex += "0D";
                    break;
                case "E":
                    smbjFDSHex += "0E";
                    break;
                case "F":
                    smbjFDSHex += "0F";
                    break;
                case "G":
                    smbjFDSHex += "10";
                    break;
                case "H":
                    smbjFDSHex += "11";
                    break;
                case "I":
                    smbjFDSHex += "12";
                    break;
                case "J":
                    smbjFDSHex += "13";
                    break;
                case "K":
                    smbjFDSHex += "14";
                    break;
                case "L":
                    smbjFDSHex += "15";
                    break;
                case "M":
                    smbjFDSHex += "16";
                    break;
                case "N":
                    smbjFDSHex += "17";
                    break;
                case "O":
                    smbjFDSHex += "18";
                    break;
                case "P":
                    smbjFDSHex += "19";
                    break;
                case "Q":
                    smbjFDSHex += "1A";
                    break;
                case "R":
                    smbjFDSHex += "1B";
                    break;
                case "S":
                    smbjFDSHex += "1C";
                    break;
                case "T":
                    smbjFDSHex += "1D";
                    break;
                case "U":
                    smbjFDSHex += "1E";
                    break;
                case "V":
                    smbjFDSHex += "1F";
                    break;
                case "W":
                    smbjFDSHex += "20";
                    break;
                case "X":
                    smbjFDSHex += "21";
                    break;
                case "Y":
                    smbjFDSHex += "22";
                    break;
                case "Z":
                    smbjFDSHex += "23";
                    break;
                default: // space if not matches found
                    smbjFDSHex += "24";
                    break;
            }

            return smbjFDSHex;
        }
    }
}
