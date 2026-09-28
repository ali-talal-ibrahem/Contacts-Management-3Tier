using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


// ============================================================================
// Note: The UI design and visual layout for this Form were generated with 
// the assistance of Artificial Intelligence (AI).
// ملاحظة: تم إنجاز وتصميم واجهة المستخدم هذه بمساعدة الذكاء الاصطناعي (AI).
// ============================================================================


namespace WindowsFormContacts_Management_Presentation
{
    public partial class StartFormScreen : Form
    {
        [DllImport("GDI32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,    
            int nTopRect,     
            int nRightRect,   
            int nBottomRect,  
            int nWidthEllipse,
            int nHeightEllipse
        );

        public StartFormScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void StartFormScreen_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }
    }
}