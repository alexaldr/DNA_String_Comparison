﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                            MessageBox.Show("Sequência carregada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void rTxtComparisonResult1_HScroll(object sender, EventArgs e)
        {

        }

        private void btnDNAComparison_Click(object sender, EventArgs e)
        {
            int count = 0;
            Cursor.Current = Cursors.WaitCursor;
            MessageBox.Show("Aguarde o término da comparação!\n\nO programa pode apresentar lentidão no processo.\n\n\nClique em OK para continuar!", "Aguarde!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dna01.Length == dna02.Length)
            {
                for (int i = 0; i < dna01.Length; i++)
                {
                    if (dna01[i] != dna02[i])
                    {
                        count++;
                        rTxtComparisonResult1.AppendText($"{dna01[i]}", Color.Red);
                        rTxtComparisonResult2.AppendText($"{dna02[i]}", Color.Red);
                    }
                    else
                    {
                        rTxtComparisonResult1.AppendText($"{dna01[i]}", Color.Gray);
                        rTxtComparisonResult2.AppendText($"{dna02[i]}", Color.Gray);
                    }
                }
                lblResult.Text = $"As sequências possuem {count} base(s) diferente(s)!\n\nHá xx subsequências iguais com mais de xx bases.";
                Cursor.Current = Cursors.Arrow;
            }
            else
            {
                MessageBox.Show("Operação cancelada!\nAs sequências de DNA possuem comprimentos diferentes!", "Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            /*
            // Hold the index and the discrepancy
            var mismatches = new Dictionary<int, (char, char)>();

            // The same length is assumed in both String sequences
            for (int i = 0; i < sequence1.Length; i++)
            {
                if (Char.ToUpper(sequence1[i]) != Char.ToUpper(sequence2[i]))
                {
                    Console.WriteLine(i);

                    mismatches[i] = (sequence1[i], sequence2[i]);
                }
            }

            foreach (var mismatch in mismatches)
            {
                var (char1, char2) = mismatch.Value;
                Console.WriteLine("Index: {0} \tSequence 1 {1} \tSequence 2 {2}", mismatch.Key, char1, char2);
            }
            */


        }
    }

    //Extension To append text in different colors
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}