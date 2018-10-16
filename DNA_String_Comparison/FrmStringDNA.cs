using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DNA_String_Comparison
{
    public partial class FrmStringDNA : Form
    {
        private String dna01, dna02;
        private OpenFileDialog openFileDialog;
        public FrmStringDNA()
        {
            InitializeComponent();
        }

        private void FileSelect(Label label, ref String dna)
        {
            using (openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;
                //openFileDialog.DefaultExt = "*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader($"{openFileDialog.FileName}"))
                        {
                            // Read the stream to a string
                            dna = sr.ReadToEnd();
                            label.Text = openFileDialog.FileName;
                            //MessageBox.Show("Sequência carregada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show($"{dna.Length}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Falha ao carregar a sequência!\n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //Nothing yet
                    }
                }
                else
                {
                    MessageBox.Show("Operação cancelada pelo usuário!", "Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDNASelect01_Click(object sender, EventArgs e)
        {
            FileSelect(lblDNA01, ref dna01);
        }

        private void btnDNASelect02_Click(object sender, EventArgs e)
        {
            FileSelect(lblDNA02, ref dna02);
        }

        //Code to sync HScroll
        public enum ScrollBarType : uint
        {
            SbHorz = 0,
            SbVert = 1,
            SbCtl = 2,
            SbBoth = 3
        }

        public enum Message : uint
        {
            WM_HSCROLL = 0x0114
        }

        public enum ScrollBarCommands : uint
        {
            SB_THUMBPOSITION = 4
        }
        [DllImport("User32.dll")]
        public extern static int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("User32.dll")]
        public extern static int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        private void rTxtComparisonResult2_HScroll(object sender, EventArgs e)
        {
            int nPos = GetScrollPos(rTxtComparisonResult2.Handle, (int)ScrollBarType.SbHorz);
            nPos <<= 16;
            uint wParam = (uint)ScrollBarCommands.SB_THUMBPOSITION | (uint)nPos;
            SendMessage(rTxtComparisonResult1.Handle, (int)Message.WM_HSCROLL, new IntPtr(wParam), new IntPtr(0));
        }


        private void btnDNAComparison_Click(object sender, EventArgs e)
        {
            rTxtComparisonResult1.Text = "";
            rTxtComparisonResult2.Text = "";
            int count = 0;
            Cursor.Current = Cursors.WaitCursor;
            //MessageBox.Show("Aguarde o término da comparação!\n\nO programa pode apresentar lentidão no processo.\n\n\nClique em OK para continuar!", "Aguarde!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var stopwatch = new Stopwatch();

            Byte[] bArray01 = Encoding.UTF8.GetBytes(dna01);
            Byte[] bArray02 = Encoding.UTF8.GetBytes(dna02);
            

            if (dna01.Length == dna02.Length)
            {
                stopwatch.Start();

                //creating array of differences
                var diff = dna01.Zip(dna02, (a, b) => a == b).ToArray();

                rTxtComparisonResult1.Text = dna01;
                rTxtComparisonResult1.ForeColor = Color.Green;
                rTxtComparisonResult2.Text = dna02;
                rTxtComparisonResult2.ForeColor = Color.Green;
                for(int i = 0; i<dna01.Length; i++)
                {
                    if (diff[i])
                    {
                        rTxtComparisonResult1.Select(i, 1);
                        rTxtComparisonResult1.SelectionColor = Color.Red;
                        rTxtComparisonResult2.Select(i, 1);
                        rTxtComparisonResult2.SelectionColor = Color.Red;
                    }
                }

                stopwatch.Stop();
                lblResult.Text = $"As sequências possuem {count} base(s) diferente(s)!"
                               + $"\n\nHá xx subsequências iguais com mais de xx bases."
                               + $"\n\nA operação demorou {stopwatch.Elapsed.TotalSeconds} segundos para ser concluída!";
                Cursor.Current = Cursors.Arrow;
            }
            else
            {
                MessageBox.Show("Operação cancelada!\nAs sequências de DNA possuem comprimentos diferentes!", "Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
