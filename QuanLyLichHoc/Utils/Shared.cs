using System.Windows.Forms;

namespace QuanLyLichHoc.Utils
{
    internal class Shared
    {
        public static void ShowMainContent(UserControl control, Panel panel)
        {

            // Clear existing controls in the panel
            panel.Controls.Clear();

            // Calculate the center position
            control.Dock = DockStyle.None; // Reset Docking
            control.AutoSize = true; // Ensure the control respects its size

            // Align the control to the center of the parent panel
            control.Left = (panel.Width - control.Width) / 2;
            control.Top = (panel.Height - control.Height) / 2;

            // Add the control to the panel
            panel.Controls.Add(control);

            // Ensure control is resized/repositioned when the panel resizes
            control.Anchor = AnchorStyles.None;

        }
    }
}
