using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalysis1.Forms.Extensions
{
    public static class ChildFormExtension
    {
        public static void OpenChildForm(this Form parentForm, Form childForm, Panel panel)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            childForm.ControlToFront();
            childForm.Show();
        }

        public static void ControlToFront(this Control control)
        {
            control.BringToFront();
            foreach (Control c in control.Controls)
            {
                c.BringToFront();
            }
        }
    }
}
