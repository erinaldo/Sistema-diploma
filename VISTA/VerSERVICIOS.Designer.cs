﻿namespace VISTA
{
    partial class VerSERVICIOS
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
            this.CbPlan = new System.Windows.Forms.ComboBox();
            this.ChkListServicios = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plan:";
            // 
            // CbPlan
            // 
            this.CbPlan.FormattingEnabled = true;
            this.CbPlan.Location = new System.Drawing.Point(49, 6);
            this.CbPlan.Name = "CbPlan";
            this.CbPlan.Size = new System.Drawing.Size(158, 21);
            this.CbPlan.TabIndex = 4;
            this.CbPlan.SelectedIndexChanged += new System.EventHandler(this.VerSERVICIOS_Load);
            // 
            // ChkListServicios
            // 
            this.ChkListServicios.FormattingEnabled = true;
            this.ChkListServicios.Location = new System.Drawing.Point(12, 33);
            this.ChkListServicios.Name = "ChkListServicios";
            this.ChkListServicios.Size = new System.Drawing.Size(421, 214);
            this.ChkListServicios.TabIndex = 6;
            this.ChkListServicios.SelectedIndexChanged += new System.EventHandler(this.VerSERVICIOS_Load);
            // 
            // VerSERVICIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 259);
            this.Controls.Add(this.ChkListServicios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbPlan);
            this.Name = "VerSERVICIOS";
            this.Text = "VerSERVICIOS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VerSERVICIOS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbPlan;
        private System.Windows.Forms.CheckedListBox ChkListServicios;

    }
}