namespace CA_W12_Ave
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxteam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxteam
            // 
            this.comboBoxteam.FormattingEnabled = true;
            this.comboBoxteam.Location = new System.Drawing.Point(96, 75);
            this.comboBoxteam.Name = "comboBoxteam";
            this.comboBoxteam.Size = new System.Drawing.Size(193, 28);
            this.comboBoxteam.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(908, 319);
            this.dataGridView1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem,
            this.editPlayerToolStripMenuItem,
            this.removePlayerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // removePlayerToolStripMenuItem
            // 
            this.removePlayerToolStripMenuItem.Name = "removePlayerToolStripMenuItem";
            this.removePlayerToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.removePlayerToolStripMenuItem.Text = "Remove Player";
            // 
            // editPlayerToolStripMenuItem
            // 
            this.editPlayerToolStripMenuItem.Name = "editPlayerToolStripMenuItem";
            this.editPlayerToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.editPlayerToolStripMenuItem.Text = "Edit Manager";
            this.editPlayerToolStripMenuItem.Click += new System.EventHandler(this.editPlayerToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 534);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxteam);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Delete Player";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxteam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPlayerToolStripMenuItem;
    }
}