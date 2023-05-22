namespace CA_W12_Ave
{
    partial class Form2
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
            this.dgv_manager = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_edit = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_manager
            // 
            this.dgv_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manager.Location = new System.Drawing.Point(29, 365);
            this.dgv_manager.Name = "dgv_manager";
            this.dgv_manager.RowHeadersWidth = 62;
            this.dgv_manager.RowTemplate.Height = 28;
            this.dgv_manager.Size = new System.Drawing.Size(917, 295);
            this.dgv_manager.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team :";
            // 
            // comboBox_team
            // 
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(91, 53);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(193, 28);
            this.comboBox_team.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 674);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem,
            this.removePlayerToolStripMenuItem,
            this.editPlayerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 33);
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
            this.removePlayerToolStripMenuItem.Click += new System.EventHandler(this.removePlayerToolStripMenuItem_Click);
            // 
            // editPlayerToolStripMenuItem
            // 
            this.editPlayerToolStripMenuItem.Name = "editPlayerToolStripMenuItem";
            this.editPlayerToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.editPlayerToolStripMenuItem.Text = "Edit Player";
            this.editPlayerToolStripMenuItem.Click += new System.EventHandler(this.editPlayerToolStripMenuItem_Click);
            // 
            // dgv_edit
            // 
            this.dgv_edit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_edit.Location = new System.Drawing.Point(29, 104);
            this.dgv_edit.Name = "dgv_edit";
            this.dgv_edit.RowHeadersWidth = 62;
            this.dgv_edit.RowTemplate.Height = 28;
            this.dgv_edit.Size = new System.Drawing.Size(917, 206);
            this.dgv_edit.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Free Manager";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_edit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_team);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_manager);
            this.Name = "Form2";
            this.Text = "Edit Manager";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_manager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPlayerToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_edit;
        private System.Windows.Forms.Label label2;
    }
}