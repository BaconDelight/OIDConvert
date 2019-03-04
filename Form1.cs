
//
// This program is async Form wrap around the code from here
//
// OID Conversion
// by Miroslav Stampar
// https://www.codeproject.com/Articles/16468/OID-Conversation
//

using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OIDConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public byte[] OidStringToByteArray(string oid)
        {
            string[] split = oid.Trim(' ', '.').Split('.');
            List<int> retVal = new List<int>();

            for (int a = 0, b = 0, i = 0; i < split.Length; i++)
            {
                if (i == 0)
                    a = int.Parse(split[0]);
                else if (i == 1)
                    retVal.Add(40 * a + int.Parse(split[1]));
                else
                {
                    b = int.Parse(split[i]);

                    if (b < 128)
                        retVal.Add(b);
                    else
                    {
                        retVal.Add(128 + (b / 128));
                        retVal.Add(b % 128);
                    }
                }
            }

            byte[] temp = new byte[retVal.Count];

            for (int i = 0; i < retVal.Count; i++)
                temp[i] = (byte)retVal[i];

            return temp;

        }

        public string OidByteArrayToString(byte[] oid)
        {
            StringBuilder retVal = new StringBuilder();

            for (int i = 0; i < oid.Length; i++)
            {
                if (i == 0)
                {
                    int b = oid[0] % 40;
                    int a = (oid[0] - b) / 40;
                    retVal.AppendFormat("{0}.{1}", a, b);
                }
                else
                {
                    if (oid[i] < 128)
                        retVal.AppendFormat(".{0}", oid[i]);
                    else
                    {
                        retVal.AppendFormat(".{0}",
                           ((oid[i] - 128) * 128) + oid[i + 1]);
                        i++;
                    }
                }
            }

            return retVal.ToString();
        }

        private void ConvertToByteArray_Click(object sender, System.EventArgs e)
        {
            StringBuilder strBody = new StringBuilder();
            textBoxByteArray.Text = "";

            foreach (string Line in textBoxDottedDecimal.Text.Replace("\r\n","\n").Split('\n'))
            {
              string strTemp = Line.Trim();

                if (strTemp.Length != 0)
                {
                    byte[] bytes = OidStringToByteArray(strTemp);

                    if (cbFormat.Checked)
                    {
                        bool first = true;

                        foreach (byte abyte in bytes)
                        {
                            if (first)
                            {
                                first = false;
                                strBody.Append("{ 0x");
                            }
                            else
                            {
                                strBody.Append(", 0x");
                            }

                            strBody.Append(abyte.ToString("X2"));
                        }

                        strBody.Append(" };");

                    }
                    else
                    {
                        foreach (byte abyte in bytes)
                        {
                            strBody.Append(abyte.ToString("X2") + " ");
                        }
                    }

                    strBody.Append("\r\n");
                }
            }

            textBoxByteArray.Text = strBody.ToString();
        }

        private void ConvertToDottedDecimal_Click(object sender, System.EventArgs e)
        {
            StringBuilder strBody = new StringBuilder();
            textBoxDottedDecimal.Text = "";

            foreach (string Line in textBoxByteArray.Text.Replace("\r\n", "\n").Split('\n'))
            {
                string strTemp = Line.Trim().Replace(",", "").Replace("0x", "").Replace("{", "").Replace("}", "").Replace(";","").Trim();

                while (strTemp.IndexOf("  ") >= 0)
                    strTemp = strTemp.Replace("  ", " ").Trim();

                if (strTemp.Length != 0)
                {
                    int count = strTemp.Split(' ').Length;
                    byte[] bytes = new byte[count];

                    int index = 0;

                    foreach (string strByte in strTemp.Split(' '))
                        bytes[index++] = byte.Parse(strByte, System.Globalization.NumberStyles.HexNumber);

                    strBody.Append(OidByteArrayToString(bytes) + "\r\n");
                }
            }

            textBoxDottedDecimal.Text = strBody.ToString();
        }
    }
}
