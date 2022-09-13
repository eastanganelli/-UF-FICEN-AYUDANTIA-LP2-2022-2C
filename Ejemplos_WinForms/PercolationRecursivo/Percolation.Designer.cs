﻿namespace PercolationRecursivo {
    partial class Percolation {
        #region 
        private SplitContainer splitContainer1;
        private Button BPercolar;
        private Button BGMatriz;
        private PictureBox picPercolation;
        private NumericUpDown NUDTam;
        private Label label2;
        private TrackBar TBProbabilidad;
        private Label label1;
        private StatusStrip statusBar;
        private ToolStripStatusLabel STLPercolacion;
        #endregion


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BPercolar = new System.Windows.Forms.Button();
            this.BGMatriz = new System.Windows.Forms.Button();
            this.NUDTam = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TBProbabilidad = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.picPercolation = new System.Windows.Forms.PictureBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.STLPercolacion = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBProbabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPercolation)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BPercolar);
            this.splitContainer1.Panel1.Controls.Add(this.BGMatriz);
            this.splitContainer1.Panel1.Controls.Add(this.NUDTam);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.TBProbabilidad);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picPercolation);
            this.splitContainer1.Size = new System.Drawing.Size(946, 566);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 0;
            // 
            // BPercolar
            // 
            this.BPercolar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BPercolar.Location = new System.Drawing.Point(0, 121);
            this.BPercolar.Name = "BPercolar";
            this.BPercolar.Size = new System.Drawing.Size(173, 23);
            this.BPercolar.TabIndex = 1;
            this.BPercolar.Text = "Percolar";
            this.BPercolar.UseVisualStyleBackColor = true;
            this.BPercolar.Click += new System.EventHandler(this.BPercolar_Click);
            // 
            // BGMatriz
            // 
            this.BGMatriz.Dock = System.Windows.Forms.DockStyle.Top;
            this.BGMatriz.Location = new System.Drawing.Point(0, 98);
            this.BGMatriz.Name = "BGMatriz";
            this.BGMatriz.Size = new System.Drawing.Size(173, 23);
            this.BGMatriz.TabIndex = 0;
            this.BGMatriz.Text = "Generar Matriz";
            this.BGMatriz.UseVisualStyleBackColor = true;
            this.BGMatriz.Click += new System.EventHandler(this.BGMatriz_Click);
            // 
            // NUDTam
            // 
            this.NUDTam.Dock = System.Windows.Forms.DockStyle.Top;
            this.NUDTam.Location = new System.Drawing.Point(0, 75);
            this.NUDTam.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NUDTam.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDTam.Name = "NUDTam";
            this.NUDTam.Size = new System.Drawing.Size(173, 23);
            this.NUDTam.TabIndex = 5;
            this.NUDTam.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamaño";
            // 
            // TBProbabilidad
            // 
            this.TBProbabilidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBProbabilidad.LargeChange = 1;
            this.TBProbabilidad.Location = new System.Drawing.Point(0, 15);
            this.TBProbabilidad.Minimum = 1;
            this.TBProbabilidad.Name = "TBProbabilidad";
            this.TBProbabilidad.Size = new System.Drawing.Size(173, 45);
            this.TBProbabilidad.TabIndex = 3;
            this.TBProbabilidad.Value = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Probabilidad";
            // 
            // picPercolation
            // 
            this.picPercolation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPercolation.Location = new System.Drawing.Point(0, 0);
            this.picPercolation.Name = "picPercolation";
            this.picPercolation.Size = new System.Drawing.Size(769, 566);
            this.picPercolation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPercolation.TabIndex = 0;
            this.picPercolation.TabStop = false;
            this.picPercolation.Paint += new System.Windows.Forms.PaintEventHandler(this.picPercolation_Paint);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STLPercolacion});
            this.statusBar.Location = new System.Drawing.Point(0, 566);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(946, 26);
            this.statusBar.TabIndex = 7;
            this.statusBar.Text = "Barra de Estado";
            // 
            // STLPercolacion
            // 
            this.STLPercolacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.STLPercolacion.Name = "STLPercolacion";
            this.STLPercolacion.Size = new System.Drawing.Size(74, 21);
            this.STLPercolacion.Text = "                ";
            // 
            // Percolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 592);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusBar);
            this.Name = "Percolation";
            this.Text = "Percolacion Recursiva";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUDTam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBProbabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPercolation)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}