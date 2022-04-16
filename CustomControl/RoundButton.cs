using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsAudio
{
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
          GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width-1, ClientSize.Height-1);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
