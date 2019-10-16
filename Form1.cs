using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katam_Tracker {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            p1Kracko.BackColor = Color.FromArgb(128, 0, 0, 0);
            p1KG.BackColor = Color.FromArgb(128, 0, 0, 0);
            p1Gobbler.BackColor = Color.FromArgb(128, 0, 0, 0);
            p1Moley.BackColor = Color.FromArgb(128, 0, 0, 0);
            p1Dmk.BackColor = Color.FromArgb(128, 0, 0, 0);
            p1MT.BackColor = Color.FromArgb(128, 0, 0, 0);
            p1Wiz.BackColor = Color.FromArgb(128, 0, 0, 0);
            p1Hand.BackColor = Color.FromArgb(128, 0, 0, 0);
            p2Kracko.BackColor = Color.FromArgb(128, 0, 0, 0);
            p2KG.BackColor = Color.FromArgb(128, 0, 0, 0);
            p2Gobbler.BackColor = Color.FromArgb(128, 0, 0, 0);
            p2Moley.BackColor = Color.FromArgb(128, 0, 0, 0);
            p2Dmk.BackColor = Color.FromArgb(128, 0, 0, 0);
            p2MT.BackColor = Color.FromArgb(128, 0, 0, 0);
            p2Wiz.BackColor = Color.FromArgb(128, 0, 0, 0);
            p2Hand.BackColor = Color.FromArgb(128, 0, 0, 0);
        }

        // Player 1
        private void p1Kracko_Click(object sender, EventArgs e) {
            if (p1Kracko.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p1Kracko.BackColor = Color.FromArgb(128, 0, 0, 0);
            } else {
                p1Kracko.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p1KG_Click(object sender, EventArgs e) {
            if (p1KG.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p1KG.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p1KG.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p1Gobbler_Click(object sender, EventArgs e) {
            if (p1Gobbler.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p1Gobbler.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p1Gobbler.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p1Moley_Click(object sender, EventArgs e) {
            if (p1Moley.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p1Moley.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p1Moley.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p1Dmk_Click(object sender, EventArgs e) {
            if (p1Dmk.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p1Dmk.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p1Dmk.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p1MT_Click(object sender, EventArgs e) {
            if (p1MT.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p1MT.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p1MT.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p1Wiz_Click(object sender, EventArgs e) {
            if (p1Wiz.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p1Wiz.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p1Wiz.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p1Hand_Click_1(object sender, EventArgs e) {
            if (p1Hand.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p1Hand.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p1Hand.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        // Player 2
        private void p2Kracko_Click(object sender, EventArgs e) {
            if (p2Kracko.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p2Kracko.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p2Kracko.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p2KG_Click(object sender, EventArgs e) {
            if (p2KG.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p2KG.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p2KG.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p2Gobbler_Click(object sender, EventArgs e) {
            if (p2Gobbler.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p2Gobbler.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p2Gobbler.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p2Moley_Click(object sender, EventArgs e) {
            if (p2Moley.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p2Moley.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p2Moley.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p2Dmk_Click(object sender, EventArgs e) {
            if (p2Dmk.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p2Dmk.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p2Dmk.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p2MT_Click(object sender, EventArgs e) {
            if (p2MT.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p2MT.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p2MT.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p2Wiz_Click(object sender, EventArgs e) {
            if (p2Wiz.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p2Wiz.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p2Wiz.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        private void p2Hand_Click(object sender, EventArgs e) {
            if (p2Hand.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                p2Hand.BackColor = Color.FromArgb(128, 0, 0, 0);
            }
            else {
                p2Hand.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
    }
}