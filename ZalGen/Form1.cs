using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static System.Environment;

namespace Zalgen
{
    public partial class Form1 : Form
    {
        private readonly char[] _downChars =
        {
            '\u0316', '\u0317', '\u0318', '\u0319', '\u031C', '\u031D', '\u031E', '\u031F', '\u0320', '\u0321',
            '\u0322', '\u0323', '\u0324', '\u0325', '\u0326', '\u0327',
            '\u0328', '\u0329', '\u032A', '\u032B', '\u032C', '\u032D', '\u032E', '\u032F', '\u0330', '\u0331',
            '\u0332', '\u0333', '\u0339', '\u033A', '\u033B', '\u033C', '\u0345', '\u0347',
            '\u0348', '\u0349', '\u034D', '\u034E', '\u0353', '\u0354', '\u0355', '\u0356', '\u0359', '\u035A',
            '\u035C', '\u035F', '\u0362', '\u1DFF', '\u0656', '\u065F'
        };

        private readonly char[] _midChars =
        {
            '\u0730', '\u073F', '\u0743', '\u074A', '\u0F18', '\u0F19', '\u0F35', '\u0F37', '\u0F72', '\u0F73',
            '\u0F7A', '\u0F81', '\u0F84', '\uFC5E', '\uFC62', '\u0334',
            '\u0335', '\u0336', '\u0337', '\u0338', '\u05C7', '\u0610', '\u061A', '\u06D6', '\u06ED', '\u0711'
        };

        private readonly char[] _upChars =
        {
            '\u0300', '\u0301', '\u0301', '\u0302', '\u0303', '\u0304', '\u0305', '\u0306', '\u0307', '\u0308',
            '\u0309', '\u030A', '\u030B', '\u030C', '\u030D', '\u030E',
            '\u030F', '\u0310', '\u0311', '\u0312', '\u0313', '\u0314', '\u0315', '\u031A', '\u031B', '\u033D',
            '\u033E', '\u033F', '\u0340', '\u0341', '\u0342', '\u0343', '\u0344', '\u0346',
            '\u034A', '\u034B', '\u034C', '\u0350', '\u0351', '\u0352', '\u0357', '\u0358', '\u035B', '\u035D',
            '\u035E', '\u0360', '\u0361', '\u0363', '\u0364', '\u0365', '\u0366', '\u0367',
            '\u0368', '\u0369', '\u036A', '\u036B', '\u036C', '\u036D', '\u036E', '\u036F', '\u1DC0', '\uFE20',
            '\u0483', '\u0486', '\u0670'
        };

        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(() => MessageBox.Show("...to your clipboard")).Start();
            string[] f = text.Text.Replace("\r\n", "\r").ToCharArray().Select(s => s.ToString()).ToArray();
            Random rnd = new Random();
            if (fuck_up.Checked)
                for (int i = 0; i < f.Length; i++)
                for (int j = 0; j < strengthBar.Value; j++)
                    f[i] = _upChars[rnd.Next(_upChars.Length)] + f[i];
            if (fuck_mid.Checked)
                for (int i = 0; i < f.Length; i++)
                    if (rnd.Next(strengthBar.Value) > 4)
                        f[i] = _midChars[rnd.Next(_midChars.Length)] + f[i];
            if (fuck_down.Checked)
                for (int i = 0; i < f.Length; i++)
                for (int j = 0; j < strengthBar.Value; j++)
                    f[i] = _downChars[rnd.Next(_downChars.Length)] + f[i];
            Clipboard.SetText(string.Join("", f).Replace("\r", "\r\n"));
        }

        private void refSheet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Going up: {string.Join(", ", _upChars.Select(s => $"a{s}"))}{NewLine}{NewLine}Middle: {string.Join(", ", _midChars.Select(s => $"a{s}"))}{NewLine}{NewLine}Going down: {string.Join(", ", _downChars.Select(s => $"a{s}"))}");
        }
    }
}