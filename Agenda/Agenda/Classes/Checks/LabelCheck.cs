using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Classes.Checks
{
    internal class LabelCheck
    {
        public static void AdjustFontSizeToFit(Label label)
        {
            float fontSize = label.Font.Size;

            using (Graphics g = label.CreateGraphics())
            {
                Size labelSize = label.ClientSize;
                SizeF textSize;

                while (fontSize > 1)
                {
                    using (Font font = new Font(label.Font.FontFamily, fontSize))
                    {
                        textSize = g.MeasureString(label.Text, font, labelSize.Width);

                        if (textSize.Height <= labelSize.Height)
                        {
                            label.Font = font;
                            break;
                        }

                        fontSize -= 1;
                    }
                }
            }
        }
    }
}
