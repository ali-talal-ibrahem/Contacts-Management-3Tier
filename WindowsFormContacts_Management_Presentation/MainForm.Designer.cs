using System.Drawing;

namespace WindowsFormContacts_Management_Presentation
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvAllContacts = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Title2 = new System.Windows.Forms.Label();
            this.lbl_Title3 = new System.Windows.Forms.Label();
            this.lbl_CountContacts = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllContacts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllContacts
            // 
            this.dgvAllContacts.AllowUserToAddRows = false;
            this.dgvAllContacts.AllowUserToDeleteRows = false;
            this.dgvAllContacts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvAllContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAllContacts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.dgvAllContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllContacts.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllContacts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvAllContacts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAllContacts.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvAllContacts.Location = new System.Drawing.Point(0, 110);
            this.dgvAllContacts.Name = "dgvAllContacts";
            this.dgvAllContacts.ReadOnly = true;
            this.dgvAllContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllContacts.Size = new System.Drawing.Size(1083, 388);
            this.dgvAllContacts.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Cairo Black", 20F);
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.lbl_Title.Location = new System.Drawing.Point(3, 4);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(369, 50);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Contacts Managment System";
            // 
            // lbl_Title2
            // 
            this.lbl_Title2.AutoSize = true;
            this.lbl_Title2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title2.Font = new System.Drawing.Font("Cairo Black", 12F);
            this.lbl_Title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(68)))));
            this.lbl_Title2.Location = new System.Drawing.Point(9, 47);
            this.lbl_Title2.Name = "lbl_Title2";
            this.lbl_Title2.Size = new System.Drawing.Size(218, 30);
            this.lbl_Title2.TabIndex = 2;
            this.lbl_Title2.Text = "ADO.NET | 3-Tier Architecture";
            // 
            // lbl_Title3
            // 
            this.lbl_Title3.AutoSize = true;
            this.lbl_Title3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title3.Font = new System.Drawing.Font("Cairo Black", 12F);
            this.lbl_Title3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.lbl_Title3.Location = new System.Drawing.Point(9, 72);
            this.lbl_Title3.Name = "lbl_Title3";
            this.lbl_Title3.Size = new System.Drawing.Size(147, 30);
            this.lbl_Title3.TabIndex = 3;
            this.lbl_Title3.Text = "Number Contacts : ";
            // 
            // lbl_CountContacts
            // 
            this.lbl_CountContacts.AutoSize = true;
            this.lbl_CountContacts.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CountContacts.Font = new System.Drawing.Font("Anton", 10F);
            this.lbl_CountContacts.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_CountContacts.Location = new System.Drawing.Point(149, 78);
            this.lbl_CountContacts.Name = "lbl_CountContacts";
            this.lbl_CountContacts.Size = new System.Drawing.Size(31, 21);
            this.lbl_CountContacts.TabIndex = 4;
            this.lbl_CountContacts.Text = "000";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 54);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::WindowsFormContacts_Management_Presentation.Properties.Resources.UserEdit_40958;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::WindowsFormContacts_Management_Presentation.Properties.Resources.delete_delete_exit_1577;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(1083, 498);
            this.Controls.Add(this.lbl_CountContacts);
            this.Controls.Add(this.lbl_Title3);
            this.Controls.Add(this.lbl_Title2);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.dgvAllContacts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts Managment System - Main Page";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllContacts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllContacts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Title2;
        private System.Windows.Forms.Label lbl_Title3;
        private System.Windows.Forms.Label lbl_CountContacts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

