using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlshopthoitrangtreem
{
    static public class HelperST
    {
        public static void removeValueTextBox(List<TextBox> cts)
        {
            foreach(TextBox item in cts)
            {
                item.Text = "";
            }
        }
    }
}
