namespace Bloknot
{
    partial class Bloknot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bloknot));
            this.textBox = new System.Windows.Forms.TextBox();
            this.zagruzit = new System.Windows.Forms.Button();
            this.sohranit = new System.Windows.Forms.Button();
            this.m1azm = new System.Windows.Forms.Label();
            this.svyaz = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 13);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(448, 396);
            this.textBox.TabIndex = 0;
            // 
            // zagruzit
            // 
            this.zagruzit.Location = new System.Drawing.Point(13, 415);
            this.zagruzit.Name = "zagruzit";
            this.zagruzit.Size = new System.Drawing.Size(75, 23);
            this.zagruzit.TabIndex = 1;
            this.zagruzit.Text = "загрузить";
            this.zagruzit.UseVisualStyleBackColor = true;
            this.zagruzit.Click += new System.EventHandler(this.zagruzit_Click);
            // 
            // sohranit
            // 
            this.sohranit.Location = new System.Drawing.Point(386, 415);
            this.sohranit.Name = "sohranit";
            this.sohranit.Size = new System.Drawing.Size(75, 23);
            this.sohranit.TabIndex = 2;
            this.sohranit.Text = "сохранить";
            this.sohranit.UseVisualStyleBackColor = true;
            this.sohranit.Click += new System.EventHandler(this.sohranit_Click);
            // 
            // m1azm
            // 
            this.m1azm.AutoSize = true;
            this.m1azm.Location = new System.Drawing.Point(94, 420);
            this.m1azm.Name = "m1azm";
            this.m1azm.Size = new System.Drawing.Size(40, 13);
            this.m1azm.TabIndex = 3;
            this.m1azm.Text = "m1azm";
            // 
            // svyaz
            // 
            this.svyaz.AutoSize = true;
            this.svyaz.Location = new System.Drawing.Point(343, 420);
            this.svyaz.Name = "svyaz";
            this.svyaz.Size = new System.Drawing.Size(37, 13);
            this.svyaz.TabIndex = 4;
            this.svyaz.TabStop = true;
            this.svyaz.Text = "связь";
            this.svyaz.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.svyaz_LinkClicked);
            // 
            // Bloknot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.svyaz);
            this.Controls.Add(this.m1azm);
            this.Controls.Add(this.sohranit);
            this.Controls.Add(this.zagruzit);
            this.Controls.Add(this.textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bloknot";
            this.Text = "блокнот";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button zagruzit;
        private System.Windows.Forms.Button sohranit;
        private System.Windows.Forms.Label m1azm;
        private System.Windows.Forms.LinkLabel svyaz;
    }
}

