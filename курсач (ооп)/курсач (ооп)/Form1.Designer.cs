namespace курсач__ооп_
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
            this.newGame = new System.Windows.Forms.Button();
            this.SaveGame = new System.Windows.Forms.Button();
            this.Exite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newGame.Location = new System.Drawing.Point(12, 12);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(106, 360);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "Новая игра";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // SaveGame
            // 
            this.SaveGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveGame.Location = new System.Drawing.Point(252, 12);
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(106, 360);
            this.SaveGame.TabIndex = 1;
            this.SaveGame.Text = "Загрузить игру";
            this.SaveGame.UseVisualStyleBackColor = false;
            this.SaveGame.Click += new System.EventHandler(this.SaveGame_Click);
            // 
            // Exite
            // 
            this.Exite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exite.Location = new System.Drawing.Point(483, 12);
            this.Exite.Name = "Exite";
            this.Exite.Size = new System.Drawing.Size(106, 360);
            this.Exite.TabIndex = 2;
            this.Exite.Text = "Выход";
            this.Exite.UseVisualStyleBackColor = false;
            this.Exite.Click += new System.EventHandler(this.Exite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 384);
            this.Controls.Add(this.Exite);
            this.Controls.Add(this.SaveGame);
            this.Controls.Add(this.newGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button SaveGame;
        private System.Windows.Forms.Button Exite;
    }
}

