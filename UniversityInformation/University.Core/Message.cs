using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University.Core
{
    public class Message
    {
        public static void Info(string message)
        {
            MessageBox.Show(message);
        }
        public static DialogResult Warning(string message)
        {
            return MessageBox.Show(message, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static void Error(string message)
        {
            MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
