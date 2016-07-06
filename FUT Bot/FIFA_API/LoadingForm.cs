using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUT_Bot {
    public partial class LoadingForm : Form {
        public delegate bool IsEnd();
        IsEnd isEnd = null;

        Timer timer = new Timer();
        int licznik = 0;
        bool czyPrzod = true;

        Color colPocz = Color.FromArgb(61, 0, 245);
        Color colKon = Color.FromArgb(184, 245, 0);

        public LoadingForm(string wiad, IsEnd isEnd = null) {
            InitializeComponent();
            tLad.Text = wiad;
            timer.Interval = 10;
            timer.Tick += timerTick;
            timer.Enabled = true;
            this.isEnd = isEnd;
        }

        private void timerTick(object sender, EventArgs e) {
            if (czyPrzod) licznik++;
            else licznik--;
            if (licznik == 100) czyPrzod = false;
            else if (licznik == 0) czyPrzod = true;
            tLad.BackColor = Color.FromArgb(colPocz.R + (int)(licznik / 100.0 * (colKon.R - colPocz.R)), colPocz.G + (int)(licznik / 100.0 * (colKon.G - colPocz.G)), colPocz.B + (int)(licznik / 100.0 * (colKon.B - colPocz.B)));
            if (isEnd != null && isEnd()) Dispose();
        }

    }
}
