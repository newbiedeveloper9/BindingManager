using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingManager
{
    public static class ThreadHelperClass
    {
        delegate void SetTextCallback(Form f, TextBox ctrl, string[] lines);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetText(Form form, TextBox ctrl, string[] lines)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                var d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, lines });
            }
            else
            {
                ctrl.Lines = lines;
            }
        }
    }
}
