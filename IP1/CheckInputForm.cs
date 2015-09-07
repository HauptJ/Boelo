using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP1
{
    public class CheckInputForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.tAmount = new System.Windows.Forms.NumericUpDown();
            this.tMemo = new System.Windows.Forms.TextBox();
            this.bAccept = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Memo";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(64, 13);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(233, 20);
            this.tName.TabIndex = 0;
            // 
            // tAmount
            // 
            this.tAmount.DecimalPlaces = 2;
            this.tAmount.Location = new System.Drawing.Point(64, 41);
            this.tAmount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.tAmount.Name = "tAmount";
            this.tAmount.Size = new System.Drawing.Size(233, 20);
            this.tAmount.TabIndex = 1;
            // 
            // tMemo
            // 
            this.tMemo.Location = new System.Drawing.Point(64, 68);
            this.tMemo.Name = "tMemo";
            this.tMemo.Size = new System.Drawing.Size(233, 20);
            this.tMemo.TabIndex = 2;
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(222, 110);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(75, 23);
            this.bAccept.TabIndex = 3;
            this.bAccept.Text = "Accept";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(141, 110);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 4;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // InputForm
            // 
            this.AcceptButton = this.bAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 145);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.tMemo);
            this.Controls.Add(this.tAmount);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputForm";
            this.Text = "Check - Input";
            ((System.ComponentModel.ISupportInitialize)(this.tAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.NumericUpDown tAmount;
        private System.Windows.Forms.TextBox tMemo;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Button bClear;

        #endregion

        private string checkName, checkMemo;
        private double checkAmount;

        public CheckInputForm()
        {
            InitializeComponent();
        }
        
        private void bClear_Click(object sender, EventArgs e)
        {
            // Clears the value boxs
            tName.Text = "";
            tAmount.Value = 0;
            tMemo.Text = "";
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            if(tName.Text.Trim() == "" | tAmount.Value == 0)
            {
                MessageBox.Show("Make sure your check has a Name and Amount.");
                tName.Focus();
            }
            else
            {
                checkName = tName.Text.Trim();
                checkMemo = tMemo.Text;
                checkAmount = System.Convert.ToDouble(tAmount.Value);
                
                this.Close();
            }
        }

        /// To use these I just did something like this 
        /// 
        /// CheckInputForm InForm = new CheckInputForm();
        /// Application.Run(InForm);
        /// MessageBox.Show(InForm.getName());

        public string getName()
        {
            return checkName;
        }

        public string getMemo()
        {
            return checkMemo;
        }

        public double getAmount()
        {
            return checkAmount;
        }
    }
}
