namespace PriorityStack
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.tbStackNoPr = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbResultNoPr = new System.Windows.Forms.TextBox();
			this.btnResultNoPr = new System.Windows.Forms.Button();
			this.btnAddNoPr = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbElementNoPr = new System.Windows.Forms.TextBox();
			this.btnClearNoPriority = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnClearPr = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tbStackPr = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbResultPr = new System.Windows.Forms.TextBox();
			this.btnResultPr = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tbElementPr = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbPriority = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 29);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(478, 294);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.tbStackNoPr);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.tbResultNoPr);
			this.tabPage1.Controls.Add(this.btnResultNoPr);
			this.tabPage1.Controls.Add(this.btnAddNoPr);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.tbElementNoPr);
			this.tabPage1.Controls.Add(this.btnClearNoPriority);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(470, 268);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Без приоритетов";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Содержимое стека:";
			// 
			// tbStackNoPr
			// 
			this.tbStackNoPr.Location = new System.Drawing.Point(6, 199);
			this.tbStackNoPr.Multiline = true;
			this.tbStackNoPr.Name = "tbStackNoPr";
			this.tbStackNoPr.Size = new System.Drawing.Size(458, 64);
			this.tbStackNoPr.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Извлеченный элемент:";
			// 
			// tbResultNoPr
			// 
			this.tbResultNoPr.Location = new System.Drawing.Point(6, 146);
			this.tbResultNoPr.Name = "tbResultNoPr";
			this.tbResultNoPr.Size = new System.Drawing.Size(100, 20);
			this.tbResultNoPr.TabIndex = 5;
			// 
			// btnResultNoPr
			// 
			this.btnResultNoPr.Location = new System.Drawing.Point(6, 104);
			this.btnResultNoPr.Name = "btnResultNoPr";
			this.btnResultNoPr.Size = new System.Drawing.Size(458, 23);
			this.btnResultNoPr.TabIndex = 4;
			this.btnResultNoPr.Text = "Извлечь элемент";
			this.btnResultNoPr.UseVisualStyleBackColor = true;
			this.btnResultNoPr.Click += new System.EventHandler(this.btnResultNoPr_Click);
			// 
			// btnAddNoPr
			// 
			this.btnAddNoPr.Location = new System.Drawing.Point(6, 75);
			this.btnAddNoPr.Name = "btnAddNoPr";
			this.btnAddNoPr.Size = new System.Drawing.Size(458, 23);
			this.btnAddNoPr.TabIndex = 3;
			this.btnAddNoPr.Text = "Добавить элемент";
			this.btnAddNoPr.UseVisualStyleBackColor = true;
			this.btnAddNoPr.Click += new System.EventHandler(this.btnAddNoPr_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Элемент:";
			// 
			// tbElementNoPr
			// 
			this.tbElementNoPr.Location = new System.Drawing.Point(6, 49);
			this.tbElementNoPr.Name = "tbElementNoPr";
			this.tbElementNoPr.Size = new System.Drawing.Size(100, 20);
			this.tbElementNoPr.TabIndex = 1;
			// 
			// btnClearNoPriority
			// 
			this.btnClearNoPriority.Location = new System.Drawing.Point(6, 6);
			this.btnClearNoPriority.Name = "btnClearNoPriority";
			this.btnClearNoPriority.Size = new System.Drawing.Size(458, 23);
			this.btnClearNoPriority.TabIndex = 0;
			this.btnClearNoPriority.Text = "Очистить стек";
			this.btnClearNoPriority.UseVisualStyleBackColor = true;
			this.btnClearNoPriority.Click += new System.EventHandler(this.btnClearNoPriority_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.tbPriority);
			this.tabPage2.Controls.Add(this.btnClearPr);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.tbStackPr);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.tbResultPr);
			this.tabPage2.Controls.Add(this.btnResultPr);
			this.tabPage2.Controls.Add(this.btnAdd);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.tbElementPr);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(470, 268);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "С приоритетами";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnClearPr
			// 
			this.btnClearPr.Location = new System.Drawing.Point(6, 6);
			this.btnClearPr.Name = "btnClearPr";
			this.btnClearPr.Size = new System.Drawing.Size(458, 23);
			this.btnClearPr.TabIndex = 17;
			this.btnClearPr.Text = "Очистить стек";
			this.btnClearPr.UseVisualStyleBackColor = true;
			this.btnClearPr.Click += new System.EventHandler(this.btnClearPr_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Содержимое стека:";
			// 
			// tbStackPr
			// 
			this.tbStackPr.Location = new System.Drawing.Point(8, 193);
			this.tbStackPr.Multiline = true;
			this.tbStackPr.Name = "tbStackPr";
			this.tbStackPr.Size = new System.Drawing.Size(458, 64);
			this.tbStackPr.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 124);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Извлеченный элемент:";
			// 
			// tbResultPr
			// 
			this.tbResultPr.Location = new System.Drawing.Point(8, 140);
			this.tbResultPr.Name = "tbResultPr";
			this.tbResultPr.Size = new System.Drawing.Size(100, 20);
			this.tbResultPr.TabIndex = 13;
			// 
			// btnResultPr
			// 
			this.btnResultPr.Location = new System.Drawing.Point(8, 98);
			this.btnResultPr.Name = "btnResultPr";
			this.btnResultPr.Size = new System.Drawing.Size(458, 23);
			this.btnResultPr.TabIndex = 12;
			this.btnResultPr.Text = "Извлечь элемент";
			this.btnResultPr.UseVisualStyleBackColor = true;
			this.btnResultPr.Click += new System.EventHandler(this.btnResultPr_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(8, 69);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(458, 23);
			this.btnAdd.TabIndex = 11;
			this.btnAdd.Text = "Добавить элемент";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 29);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Элемент:";
			// 
			// tbElementPr
			// 
			this.tbElementPr.Location = new System.Drawing.Point(8, 43);
			this.tbElementPr.Name = "tbElementPr";
			this.tbElementPr.Size = new System.Drawing.Size(100, 20);
			this.tbElementPr.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(129, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Приоритет:";
			// 
			// tbPriority
			// 
			this.tbPriority.Location = new System.Drawing.Point(129, 43);
			this.tbPriority.Name = "tbPriority";
			this.tbPriority.Size = new System.Drawing.Size(100, 20);
			this.tbPriority.TabIndex = 18;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(502, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.fileToolStripMenuItem.Text = "Файл";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Выход";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.helpToolStripMenuItem.Text = "Справка";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "О программе";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.helpToolStripMenuItem1.Text = "Справка";
			this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 335);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Модель обработки массива типа \"стек\"";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbResultNoPr;
		private System.Windows.Forms.Button btnResultNoPr;
		private System.Windows.Forms.Button btnAddNoPr;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbElementNoPr;
		private System.Windows.Forms.Button btnClearNoPriority;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbStackNoPr;
		private System.Windows.Forms.Button btnClearPr;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbStackPr;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbResultPr;
		private System.Windows.Forms.Button btnResultPr;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbElementPr;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbPriority;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
	}
}

