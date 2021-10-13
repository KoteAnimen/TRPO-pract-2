
namespace TRPO_pract_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_GetAnswer = new System.Windows.Forms.Button();
            this.tbx_AnswerS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_GetAnswerN = new System.Windows.Forms.Button();
            this.tbx_AnswerN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_Y1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_Y0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_X = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.btn_AboutUs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(305, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(224, 26);
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_AboutUs
            // 
            this.btn_AboutUs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.btn_AboutUs.Name = "btn_AboutUs";
            this.btn_AboutUs.Size = new System.Drawing.Size(81, 24);
            this.btn_AboutUs.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(280, 235);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_GetAnswer);
            this.tabPage1.Controls.Add(this.tbx_AnswerS);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nud_X);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(272, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание №1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_GetAnswer
            // 
            this.btn_GetAnswer.Location = new System.Drawing.Point(11, 139);
            this.btn_GetAnswer.Name = "btn_GetAnswer";
            this.btn_GetAnswer.Size = new System.Drawing.Size(246, 43);
            this.btn_GetAnswer.TabIndex = 4;
            this.btn_GetAnswer.Text = "Рассчитать";
            this.btn_GetAnswer.UseVisualStyleBackColor = true;
            this.btn_GetAnswer.Click += new System.EventHandler(this.btn_GetAnswer_Click);
            // 
            // tbx_AnswerS
            // 
            this.tbx_AnswerS.Location = new System.Drawing.Point(11, 99);
            this.tbx_AnswerS.Name = "tbx_AnswerS";
            this.tbx_AnswerS.ReadOnly = true;
            this.tbx_AnswerS.Size = new System.Drawing.Size(246, 34);
            this.tbx_AnswerS.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "S:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_GetAnswerN);
            this.tabPage2.Controls.Add(this.tbx_AnswerN);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbx_Y1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbx_Y0);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(272, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание №2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_GetAnswerN
            // 
            this.btn_GetAnswerN.Location = new System.Drawing.Point(11, 138);
            this.btn_GetAnswerN.Name = "btn_GetAnswerN";
            this.btn_GetAnswerN.Size = new System.Drawing.Size(245, 43);
            this.btn_GetAnswerN.TabIndex = 6;
            this.btn_GetAnswerN.Text = "Рассчитать";
            this.btn_GetAnswerN.UseVisualStyleBackColor = true;
            this.btn_GetAnswerN.Click += new System.EventHandler(this.btn_GetAnswerN_Click);
            // 
            // tbx_AnswerN
            // 
            this.tbx_AnswerN.Location = new System.Drawing.Point(11, 102);
            this.tbx_AnswerN.Name = "tbx_AnswerN";
            this.tbx_AnswerN.ReadOnly = true;
            this.tbx_AnswerN.Size = new System.Drawing.Size(245, 34);
            this.tbx_AnswerN.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ответ:";
            // 
            // tbx_Y1
            // 
            this.tbx_Y1.Location = new System.Drawing.Point(134, 34);
            this.tbx_Y1.Name = "tbx_Y1";
            this.tbx_Y1.Size = new System.Drawing.Size(122, 34);
            this.tbx_Y1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y1";
            // 
            // tbx_Y0
            // 
            this.tbx_Y0.Location = new System.Drawing.Point(11, 34);
            this.tbx_Y0.Name = "tbx_Y0";
            this.tbx_Y0.Size = new System.Drawing.Size(117, 34);
            this.tbx_Y0.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Y0";
            // 
            // nud_X
            // 
            this.nud_X.Location = new System.Drawing.Point(11, 35);
            this.nud_X.Name = "nud_X";
            this.nud_X.Size = new System.Drawing.Size(246, 34);
            this.nud_X.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 273);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТРПО Практическая №2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_Exit;
        private System.Windows.Forms.ToolStripMenuItem btn_AboutUs;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_GetAnswer;
        private System.Windows.Forms.TextBox tbx_AnswerS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_GetAnswerN;
        private System.Windows.Forms.TextBox tbx_AnswerN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_Y1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_Y0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_X;
    }
}

