using Sm.Ui.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocService {
    public partial class FStartup : DefWin {
        public FStartup() {
            InitializeComponent();
            CurrentlyAllowToClose = false;
            this.Make_Movable(pictureBox1, panel2, panel3, panel4, label4);
            Load += (s, e) => MaximumSize = Size;
            TCloser.Tick += TCloser_Tick;
            Load += (s, e) => TCloser.Start();
        }

        #region Closer Timer
        private void TCloser_Tick(object sender, EventArgs e) {

            TCloser.Stop();
            CurrentlyAllowToClose = true;
            Close();
        }
        #endregion
    }
}
