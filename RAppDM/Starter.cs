using System;
using System.Windows.Forms;

namespace RAppDM
{
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
        }

        private void Starter_Load(object sender, EventArgs e)
        {
            SplshScrn sc = new SplshScrn();
            sc.ShowDialog();
        }
    }
}
