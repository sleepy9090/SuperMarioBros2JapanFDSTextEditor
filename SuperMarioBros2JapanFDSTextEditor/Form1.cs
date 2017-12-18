using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperMarioBros2JapanFDSTextEditor
{
    public partial class FormSMB2Main : Form
    {
        public FormSMB2Main()
        {
            InitializeComponent();
        }

        private void buttonOpenROM_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file...";
            ofd.Filter = "fds files (*.fds)|*.fds|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxAbsoluteFilename.Text = ofd.FileName;

                clearTextBoxes();
                readRomText();
            }
        }

        #region ClearTextBoxes
        private void clearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            textBox37.Clear();
            textBox38.Clear();
            textBox39.Clear();
            textBox40.Clear();
            textBox41.Clear();
            textBox42.Clear();
            textBox43.Clear();
            textBox44.Clear();
            textBox45.Clear();
        }
        #endregion

        private void readRomText()
        {
            try
            {
                string absoluteFilename = textBoxAbsoluteFilename.Text;

                Backend backend = new Backend();

                // *** DEBUG - requires a textbox named textBoxDebug, multiline enabled
                // These will most likely kill the program.
                //backend.getText(absoluteFilename, textBoxDebug, 0xFFDC, 0x0); // ROM Size
                //backend.getText(absoluteFilename, textBoxDebug, 0xCCAB, 0x0); // ROM data end

                // Check each chunk one at a time. These will not kill the program.
                // TODO: threading
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0x0); // License text
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0x1000); // Nothing here
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0x2000); // Game text
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0x3000); // No text here
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0x4000); // No text here
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0x5000); // No text here
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0x6000); // No text here
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0x7000); // No text here
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0x8000); // Game Text
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0x9000); // No text here
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0xA000); // No text here
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0xB000); // Ending Text
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0xC000); // No text here

                // Save Data Area, all 0's unless a game save is here
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0xD000); // No text here
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0xE000); // No text here
                //backend.getText(absoluteFilename, textBoxDebug, 0x1000, 0xF000); // No text here
                // *** END DEBUG

                backend.getText(absoluteFilename, textBox1, 0xB, 0x0056);
                backend.getText(absoluteFilename, textBox2, 0x12, 0x0072);
                backend.getText(absoluteFilename, textBox3, 0x3B, 0x00AD);
                backend.getText(absoluteFilename, textBox4, 0x3A, 0x00ED);
                backend.getText(absoluteFilename, textBox5, 0x5, 0x2813);

                backend.getText(absoluteFilename, textBox6, 0x5, 0x281B);
                backend.getText(absoluteFilename, textBox7, 0x4, 0x2822);
                backend.getText(absoluteFilename, textBox8, 0x5, 0x2844);
                backend.getText(absoluteFilename, textBox9, 0x7, 0x2859);
                backend.getText(absoluteFilename, textBox10, 0x9, 0x2864);

                backend.getText(absoluteFilename, textBox11, 0x8, 0x2870);
                backend.getText(absoluteFilename, textBox12, 0x5, 0x287F);
                backend.getText(absoluteFilename, textBox13, 0x15, 0x2888);
                backend.getText(absoluteFilename, textBox14, 0x10, 0x2DDE);
                backend.getText(absoluteFilename, textBox15, 0x16, 0x2DF2);

                backend.getText(absoluteFilename, textBox16, 0xF, 0x2E0B);
                backend.getText(absoluteFilename, textBox17, 0x8, 0x8308);
                backend.getText(absoluteFilename, textBox18, 0x7, 0x8310);
                backend.getText(absoluteFilename, textBox19, 0x9, 0x8317);
                backend.getText(absoluteFilename, textBox20, 0x5, 0x8789);

                backend.getText(absoluteFilename, textBox21, 0x5, 0x878E);
                backend.getText(absoluteFilename, textBox22, 0xD, 0x88D3);
                backend.getText(absoluteFilename, textBox23, 0xA, 0x88E3);
                backend.getText(absoluteFilename, textBox24, 0xA, 0x88F0);
                backend.getText(absoluteFilename, textBox25, 0x4, 0x88FD);

                backend.getText(absoluteFilename, textBox26, 0x5, 0xB26D);
                backend.getText(absoluteFilename, textBox27, 0x5, 0xB272);
                backend.getText(absoluteFilename, textBox28, 0x10, 0xB2B5);
                backend.getText(absoluteFilename, textBox29, 0xE, 0xB2CD);
                backend.getText(absoluteFilename, textBox30, 0x12, 0xB2E3);

                backend.getText(absoluteFilename, textBox31, 0x10, 0xB2F9);
                backend.getText(absoluteFilename, textBox32, 0xD, 0xB30D);
                backend.getText(absoluteFilename, textBox33, 0x13, 0xB31E);
                backend.getText(absoluteFilename, textBox34, 0x14, 0xB335);
                backend.getText(absoluteFilename, textBox35, 0xA, 0xB34D);

                backend.getText(absoluteFilename, textBox36, 0x5, 0xB358);
                backend.getText(absoluteFilename, textBox37, 0x14, 0xB365);
                backend.getText(absoluteFilename, textBox38, 0x18, 0xB39F);
                backend.getText(absoluteFilename, textBox39, 0xA, 0xB3BA);
                backend.getText(absoluteFilename, textBox40, 0x7, 0xB3C5);

                backend.getText(absoluteFilename, textBox41, 0xD, 0xB3D0);
                backend.getText(absoluteFilename, textBox42, 0x16, 0xB3EA);
                backend.getText(absoluteFilename, textBox43, 0xD, 0xB403);
                backend.getText(absoluteFilename, textBox44, 0xD, 0xB413);
                backend.getText(absoluteFilename, textBox45, 0xF, 0xB424);

                enableButtons();
                enableMenuItems();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enableButtons()
        {
            buttonUpdateText.Enabled = true;
        }

        private void enableMenuItems()
        {
            //updateTextToolStripMenuItem.Enabled = true;
        }

        //private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AboutBox1 aboutBox = new AboutBox1();
        //    aboutBox.ShowDialog();
        //}

        //private void openROMToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    buttonOpenROM_Click(sender, e);
        //}

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                string absoluteFilename = textBoxAbsoluteFilename.Text;
                Backend backend = new Backend();

                // If the header text is modified, some sort of copyright protection occurs and the FDS system throws an error 20
                // so forget updating this for now.
                //backend.updateROMText(absoluteFilename, 0xB, textBox1, 0x0056);
                //backend.updateROMText(absoluteFilename, 0x12, textBox2, 0x0072);
                //backend.updateROMText(absoluteFilename, 0x3B, textBox3, 0x00AD);
                //backend.updateROMText(absoluteFilename, 0x3A, textBox4, 0x00ED);

                backend.updateROMText(absoluteFilename, 0x5, textBox5, 0x2813);

                backend.updateROMText(absoluteFilename, 0x5, textBox6, 0x281B);
                backend.updateROMText(absoluteFilename, 0x4, textBox7, 0x2822);
                backend.updateROMText(absoluteFilename, 0x5, textBox8, 0x2844);
                backend.updateROMText(absoluteFilename, 0x7, textBox9, 0x2859);
                backend.updateROMText(absoluteFilename, 0x9, textBox10, 0x2864);

                backend.updateROMText(absoluteFilename, 0x8, textBox11, 0x2870);
                backend.updateROMText(absoluteFilename, 0x5, textBox12, 0x287F);
                backend.updateROMText(absoluteFilename, 0x15, textBox13, 0x2888);
                backend.updateROMText(absoluteFilename, 0x10, textBox14, 0x2DDE);
                backend.updateROMText(absoluteFilename, 0x16, textBox15, 0x2DF2);

                backend.updateROMText(absoluteFilename, 0xF, textBox16, 0x2E0B);
                backend.updateROMText(absoluteFilename, 0x8, textBox17, 0x8308);
                backend.updateROMText(absoluteFilename, 0x7, textBox18, 0x8310);
                backend.updateROMText(absoluteFilename, 0x9, textBox19, 0x8317);
                backend.updateROMText(absoluteFilename, 0x5, textBox20, 0x8789);

                backend.updateROMText(absoluteFilename, 0x5, textBox21, 0x878E);
                backend.updateROMText(absoluteFilename, 0xD, textBox22, 0x88D3);
                backend.updateROMText(absoluteFilename, 0xA, textBox23, 0x88E3);
                backend.updateROMText(absoluteFilename, 0xA, textBox24, 0x88F0);
                backend.updateROMText(absoluteFilename, 0x4, textBox25, 0x88FD);

                backend.updateROMText(absoluteFilename, 0x5, textBox26, 0xB26D);
                backend.updateROMText(absoluteFilename, 0x5, textBox27, 0xB272);
                backend.updateROMText(absoluteFilename, 0x10, textBox28, 0xB2B5);
                backend.updateROMText(absoluteFilename, 0xE, textBox28, 0xB2CD);
                backend.updateROMText(absoluteFilename, 0x12, textBox30, 0xB2E3);

                backend.updateROMText(absoluteFilename, 0x10, textBox31, 0xB2F9);
                backend.updateROMText(absoluteFilename, 0xD, textBox32, 0xB30D);
                backend.updateROMText(absoluteFilename, 0x13, textBox33, 0xB31E);
                backend.updateROMText(absoluteFilename, 0x14, textBox34, 0xB335);
                backend.updateROMText(absoluteFilename, 0xA, textBox35, 0xB34D);

                backend.updateROMText(absoluteFilename, 0x5, textBox36, 0xB358);
                backend.updateROMText(absoluteFilename, 0x14, textBox37, 0xB365);
                backend.updateROMText(absoluteFilename, 0x18, textBox38, 0xB39F);
                backend.updateROMText(absoluteFilename, 0xA, textBox39, 0xB3BA);
                backend.updateROMText(absoluteFilename, 0x7, textBox40, 0xB3C5);

                backend.updateROMText(absoluteFilename, 0xD, textBox41, 0xB3D0);
                backend.updateROMText(absoluteFilename, 0x16, textBox42, 0xB3EA);
                backend.updateROMText(absoluteFilename, 0xD, textBox43, 0xB403);
                backend.updateROMText(absoluteFilename, 0xD, textBox44, 0xB413);
                backend.updateROMText(absoluteFilename, 0xF, textBox45, 0xB424);

                MessageBox.Show("Updated Text!", "Super Mario Bros. 2 Japan FDS Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBox1.MaxLength = 0xB;
            textBox2.MaxLength = 0x12;
            textBox3.MaxLength = 0x3B;
            textBox4.MaxLength = 0x3A;
            textBox5.MaxLength = 0x5;

            textBox6.MaxLength = 0x5;
            textBox7.MaxLength = 0x4;
            textBox8.MaxLength = 0x5;
            textBox9.MaxLength = 0x7;
            textBox10.MaxLength = 0x9;

            textBox11.MaxLength = 0x8;
            textBox12.MaxLength = 0x5;
            textBox13.MaxLength = 0x15;
            textBox14.MaxLength = 0x10;
            textBox15.MaxLength = 0x16;

            textBox16.MaxLength = 0xF;
            textBox17.MaxLength = 0x8;
            textBox18.MaxLength = 0x7;
            textBox19.MaxLength = 0x9;
            textBox20.MaxLength = 0x5;

            textBox21.MaxLength = 0x5;
            textBox22.MaxLength = 0xD;
            textBox23.MaxLength = 0xA;
            textBox24.MaxLength = 0xA;
            textBox25.MaxLength = 0x4;

            textBox26.MaxLength = 0x5;
            textBox27.MaxLength = 0x5;
            textBox28.MaxLength = 0x10;
            textBox29.MaxLength = 0xE;
            textBox30.MaxLength = 0x12;

            textBox31.MaxLength = 0x10;
            textBox32.MaxLength = 0xD;
            textBox33.MaxLength = 0x13;
            textBox34.MaxLength = 0x14;
            textBox35.MaxLength = 0xA;

            textBox36.MaxLength = 0x5;
            textBox37.MaxLength = 0x14;
            textBox38.MaxLength = 0x18;
            textBox39.MaxLength = 0xA;
            textBox40.MaxLength = 0x7;

            textBox41.MaxLength = 0xD;
            textBox42.MaxLength = 0x16;
            textBox43.MaxLength = 0xD;
            textBox44.MaxLength = 0xD;
            textBox45.MaxLength = 0xF;
        }

        private void FormSMB2Main_Load(object sender, EventArgs e)
        {
            setMaxLengthOfTextBoxes();
        }


        //private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void updateTextToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    buttonUpdateText_Click(sender, e);
        //}
    }
}
