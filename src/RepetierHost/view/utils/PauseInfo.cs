﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RepetierHost.model;
using RepetierHost;

namespace RepetierHost.view.utils
{
    public partial class PauseInfo : Form
    {
        private static PauseInfo form=null;
        private static float x, y, z,e,f;
        private static bool relative;
        public static void ShowPause(string info) {
            if (form == null)
            {
                form = new PauseInfo();
            }
            form.labelInfo.Text = info;
            GCodeAnalyzer a = Main.conn.analyzer;
            x = a.x;
            y = a.y;
            z = a.z;
            e = a.e;
            f = a.f;
            relative = a.relative;

            if (form.Visible == false)
                form.Show();
        }
        public PauseInfo()
        {
            InitializeComponent();
        }

        private void buttonContinuePrinting_Click(object sender, EventArgs e)
        {
            Hide();
            GCodeAnalyzer a = Main.conn.analyzer;
            PrinterConnection c = Main.conn;
            c.injectManualCommand("G90");
            c.injectManualCommand("G1 X"+x.ToString(GCode.format)+" Y"+y.ToString(GCode.format)+" Z"+z.ToString(GCode.format)+" F"+c.travelFeedRate.ToString(GCode.format));
            c.injectManualCommand("G1 Z"+z.ToString(GCode.format)+" F"+c.maxZFeedRate.ToString(GCode.format));
            c.injectManualCommand("G92 E" + PauseInfo.e.ToString(GCode.format));
            if (a.relative != relative)
            {
                c.injectManualCommand(relative ? "G91" : "G90");
            }
            c.injectManualCommand("G1 F" + f.ToString(GCode.format)); // Reset old speed
            Main.conn.paused = false;
        }
    }
}
