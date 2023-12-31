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

namespace Encryptor
{
    public partial class Form1 : Form
    {
        byte[] abc;
        byte[,] table;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //Create hash table

            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);

            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                }

        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Multiselect = false;

            if (File.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = File.FileName;
            }
        }

        private void rbEncrypt_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Check input values and display error messages
            if (!File.Exists(txtPath.Text))
            {
                MessageBox.Show("File does not exist!");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password!");
                return;
            }

            // Get file content and key for encrypt/decrypt
            try
            {
                byte[] fileContent = File.ReadAllBytes(txtPath.Text);
                byte[] tmpPassword = Encoding.ASCII.GetBytes(txtPassword.Text);
                byte[] keys = new byte[fileContent.Length];

                for (int i = 0; i < fileContent.Length; i++)
                    keys[i] = tmpPassword [i % tmpPassword.Length];

                // Encrypt
                byte[] result = new byte[fileContent.Length];

                if (rbEncrypt.Checked)
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                           if(abc[j]==key)
                            {
                                keyIndex = j;
                                break;
                            }
                        result[i] = table[valueIndex, keyIndex];
                    }
                }

                // Decrypt
                else if (rbDecrypt.Checked)
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (table[keyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        result[i] = abc[valueIndex];
                    }
                }

                // Save result to new file with the same extension
                String file = Path.GetExtension(txtPath.Text);
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Files (*" + file + ") | *" + file;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(save.FileName, result);
                }
            }
            catch
            {
                MessageBox.Show("The file is already open, please close the file and try again.");
                return;
                }

        }
    }
}

