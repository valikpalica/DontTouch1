namespace Marina
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.відправникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отримувачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВидівДокументівТаЇхКількостіПоВидахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кількістьОпераційЗДокументамиПоДатахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сумарнаКількістьОтриманихДокументівПоОтримувачахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.списокВидівДокументівТаЇхКількостіПоВидахToolStripMenuItem,
            this.кількістьОпераційЗДокументамиПоДатахToolStripMenuItem,
            this.сумарнаКількістьОтриманихДокументівПоОтримувачахToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відправникToolStripMenuItem,
            this.отримувачToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(494, 26);
            this.toolStripMenuItem2.Text = "Алфавітний список всіх  користувачів ";
            // 
            // відправникToolStripMenuItem
            // 
            this.відправникToolStripMenuItem.Name = "відправникToolStripMenuItem";
            this.відправникToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.відправникToolStripMenuItem.Text = "Відправник";
            this.відправникToolStripMenuItem.Click += new System.EventHandler(this.відправникToolStripMenuItem_Click);
            // 
            // отримувачToolStripMenuItem
            // 
            this.отримувачToolStripMenuItem.Name = "отримувачToolStripMenuItem";
            this.отримувачToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.отримувачToolStripMenuItem.Text = "Отримувач";
            this.отримувачToolStripMenuItem.Click += new System.EventHandler(this.отримувачToolStripMenuItem_Click);
            // 
            // списокВидівДокументівТаЇхКількостіПоВидахToolStripMenuItem
            // 
            this.списокВидівДокументівТаЇхКількостіПоВидахToolStripMenuItem.Name = "списокВидівДокументівТаЇхКількостіПоВидахToolStripMenuItem";
            this.списокВидівДокументівТаЇхКількостіПоВидахToolStripMenuItem.Size = new System.Drawing.Size(494, 26);
            this.списокВидівДокументівТаЇхКількостіПоВидахToolStripMenuItem.Text = "Список видів документів та їх кількості по видах";
            this.списокВидівДокументівТаЇхКількостіПоВидахToolStripMenuItem.Click += new System.EventHandler(this.списокВидівДокументівТаЇхКількостіПоВидахToolStripMenuItem_Click);
            // 
            // кількістьОпераційЗДокументамиПоДатахToolStripMenuItem
            // 
            this.кількістьОпераційЗДокументамиПоДатахToolStripMenuItem.Name = "кількістьОпераційЗДокументамиПоДатахToolStripMenuItem";
            this.кількістьОпераційЗДокументамиПоДатахToolStripMenuItem.Size = new System.Drawing.Size(494, 26);
            this.кількістьОпераційЗДокументамиПоДатахToolStripMenuItem.Text = "Кількість операцій з документами по датах";
            this.кількістьОпераційЗДокументамиПоДатахToolStripMenuItem.Click += new System.EventHandler(this.кількістьОпераційЗДокументамиПоДатахToolStripMenuItem_Click);
            // 
            // сумарнаКількістьОтриманихДокументівПоОтримувачахToolStripMenuItem
            // 
            this.сумарнаКількістьОтриманихДокументівПоОтримувачахToolStripMenuItem.Name = "сумарнаКількістьОтриманихДокументівПоОтримувачахToolStripMenuItem";
            this.сумарнаКількістьОтриманихДокументівПоОтримувачахToolStripMenuItem.Size = new System.Drawing.Size(494, 26);
            this.сумарнаКількістьОтриманихДокументівПоОтримувачахToolStripMenuItem.Text = "Сумарна кількість отриманих документів по отримувачах";
            this.сумарнаКількістьОтриманихДокументівПоОтримувачахToolStripMenuItem.Click += new System.EventHandler(this.сумарнаКількістьОтриманихДокументівПоОтримувачахToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.num_doc,
            this.View,
            this.response,
            this.request});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(13, 32);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(881, 221);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // num_doc
            // 
            this.num_doc.HeaderText = "Number Document";
            this.num_doc.MinimumWidth = 6;
            this.num_doc.Name = "num_doc";
            this.num_doc.Width = 125;
            // 
            // View
            // 
            this.View.HeaderText = "view";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.Width = 125;
            // 
            // response
            // 
            this.response.HeaderText = "response";
            this.response.MinimumWidth = 6;
            this.response.Name = "response";
            this.response.Width = 125;
            // 
            // request
            // 
            this.request.HeaderText = "request";
            this.request.MinimumWidth = 6;
            this.request.Name = "request";
            this.request.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 460);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem відправникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отримувачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВидівДокументівТаЇхКількостіПоВидахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кількістьОпераційЗДокументамиПоДатахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сумарнаКількістьОтриманихДокументівПоОтримувачахToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn View;
        private System.Windows.Forms.DataGridViewTextBoxColumn response;
        private System.Windows.Forms.DataGridViewTextBoxColumn request;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

