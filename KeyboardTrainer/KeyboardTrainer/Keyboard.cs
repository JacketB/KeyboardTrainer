using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardTrainer
{
    public partial class Keyboard : UserControl
    {
        public Keyboard()
        {
            InitializeComponent();
        }

        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            Button pressedButton = GetButtonForKey(e.KeyCode);
            if (pressedButton != null)
            {
                pressedButton.BackColor = Color.LightGreen; // Перекрашиваем кнопку при нажатии
            }
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            Button releasedButton = GetButtonForKey(e.KeyCode);
            if (releasedButton != null)
            {
                releasedButton.BackColor = Color.White; // Возвращаем исходный цвет кнопки
            }
        }

        private Button GetButtonForKey(Keys key)
        {
            switch (key)
            {
                case Keys.Oemtilde:  // Клавиша Ё
                    return keyYo;
                case Keys.D1:
                    return key1;
                case Keys.D2:
                    return key2;
                case Keys.D3:
                    return key3;
                case Keys.D4:
                    return key4;
                case Keys.D5:
                    return key5;
                case Keys.D6:
                    return key6;
                case Keys.D7:
                    return key7;
                case Keys.D8:
                    return key8;
                case Keys.D9:
                    return key9;
                case Keys.D0:
                    return key0;
                case Keys.OemMinus:  // Клавиша "-"
                    return keyMinus;
                case Keys.Oemplus:   // Клавиша "="
                    return keyPlus;
                case Keys.Back:      // Клавиша "Backspace"
                    return keyBackspace;
                case Keys.Q:         // Клавиша "Q"
                    return keyQ;
                case Keys.W:         // Клавиша "W"
                    return keyW;
                case Keys.E:         // Клавиша "E"
                    return keyE;
                case Keys.R:         // Клавиша "R"
                    return keyR;
                case Keys.T:         // Клавиша "T"
                    return keyT;
                case Keys.Y:         // Клавиша "Y"
                    return keyY;
                case Keys.U:         // Клавиша "U"
                    return keyU;
                case Keys.I:         // Клавиша "I"
                    return keyI;
                case Keys.O:         // Клавиша "O"
                    return keyO;
                case Keys.P:         // Клавиша "P"
                    return keyP;
                case Keys.OemOpenBrackets:  // Клавиша "["
                    return keyBraceOpen;
                case Keys.OemCloseBrackets: // Клавиша "]"
                    return keyBraceClose;
                case Keys.OemBackslash:     // Клавиша "\"
                    return keyBackslash;
                case Keys.CapsLock:  // Клавиша "Caps Lock"
                    return keyCaps;
                case Keys.A:         // Клавиша "A"
                    return keyA;
                case Keys.S:         // Клавиша "S"
                    return keyS;
                case Keys.D:         // Клавиша "D"
                    return keyD;
                case Keys.F:         // Клавиша "F"
                    return keyF;
                case Keys.G:         // Клавиша "G"
                    return keyG;
                case Keys.H:         // Клавиша "H"
                    return keyH;
                case Keys.J:         // Клавиша "J"
                    return keyJ;
                case Keys.K:         // Клавиша "K"
                    return keyK;
                case Keys.L:         // Клавиша "L"
                    return keyL;
                case Keys.OemSemicolon: // Клавиша ";"
                    return keyColon;
                case Keys.OemQuotes:    // Клавиша "'"
                    return keyQuotes;
                case Keys.OemPipe:      // Клавиша "|"
                    return keyBackslash;
                case Keys.Enter:        // Клавиша "Enter"
                    return keyEnter;
                case Keys.ShiftKey:
                    return Shift;
                case Keys.Z:
                    return keyZ;
                case Keys.X:
                    return keyX;
                case Keys.C:
                    return keyC;
                case Keys.V:
                    return keyV;
                case Keys.N:
                    return keyN;
                case Keys.B:
                    return keyB;
                case Keys.Oemcomma:
                    return keyComma;
                case Keys.M:
                    return keyM;
                case Keys.Oem2: // "/"
                    return keySlash;
                case Keys.OemPeriod: // "."
                    return ketDot;
                case Keys.Space:
                    return keySpace;
                default:
                    return null;
            }
        }

    }
}
