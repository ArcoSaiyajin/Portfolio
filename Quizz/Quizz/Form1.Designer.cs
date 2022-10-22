namespace Quizz
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Question_label = new System.Windows.Forms.Label();
            this.A1_button = new System.Windows.Forms.Button();
            this.A2_button = new System.Windows.Forms.Button();
            this.A3_button = new System.Windows.Forms.Button();
            this.A4_button = new System.Windows.Forms.Button();
            this.Quiz1_button = new System.Windows.Forms.Button();
            this.Quiz2_button = new System.Windows.Forms.Button();
            this.Quiz3_button = new System.Windows.Forms.Button();
            this.Score_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Question_label
            // 
            this.Question_label.AutoSize = true;
            this.Question_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Question_label.Location = new System.Drawing.Point(106, 63);
            this.Question_label.Name = "Question_label";
            this.Question_label.Size = new System.Drawing.Size(29, 31);
            this.Question_label.TabIndex = 0;
            this.Question_label.Text = "1";
            // 
            // A1_button
            // 
            this.A1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A1_button.Location = new System.Drawing.Point(262, 141);
            this.A1_button.Name = "A1_button";
            this.A1_button.Size = new System.Drawing.Size(320, 39);
            this.A1_button.TabIndex = 1;
            this.A1_button.Text = "1";
            this.A1_button.UseVisualStyleBackColor = true;
            this.A1_button.Click += new System.EventHandler(this.A1_button_Click);
            // 
            // A2_button
            // 
            this.A2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A2_button.Location = new System.Drawing.Point(262, 186);
            this.A2_button.Name = "A2_button";
            this.A2_button.Size = new System.Drawing.Size(320, 39);
            this.A2_button.TabIndex = 2;
            this.A2_button.Text = "1";
            this.A2_button.UseVisualStyleBackColor = true;
            this.A2_button.Click += new System.EventHandler(this.A2_button_Click);
            // 
            // A3_button
            // 
            this.A3_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A3_button.Location = new System.Drawing.Point(262, 231);
            this.A3_button.Name = "A3_button";
            this.A3_button.Size = new System.Drawing.Size(320, 39);
            this.A3_button.TabIndex = 3;
            this.A3_button.Text = "1";
            this.A3_button.UseVisualStyleBackColor = true;
            this.A3_button.Click += new System.EventHandler(this.A3_button_Click);
            // 
            // A4_button
            // 
            this.A4_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A4_button.Location = new System.Drawing.Point(262, 276);
            this.A4_button.Name = "A4_button";
            this.A4_button.Size = new System.Drawing.Size(320, 39);
            this.A4_button.TabIndex = 4;
            this.A4_button.Text = "1";
            this.A4_button.UseVisualStyleBackColor = true;
            this.A4_button.Click += new System.EventHandler(this.A4_button_Click);
            // 
            // Quiz1_button
            // 
            this.Quiz1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Quiz1_button.Location = new System.Drawing.Point(2, 214);
            this.Quiz1_button.Name = "Quiz1_button";
            this.Quiz1_button.Size = new System.Drawing.Size(133, 32);
            this.Quiz1_button.TabIndex = 5;
            this.Quiz1_button.Text = "AJ";
            this.Quiz1_button.UseVisualStyleBackColor = true;
            this.Quiz1_button.Click += new System.EventHandler(this.Quiz1_button_Click);
            // 
            // Quiz2_button
            // 
            this.Quiz2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Quiz2_button.Location = new System.Drawing.Point(2, 252);
            this.Quiz2_button.Name = "Quiz2_button";
            this.Quiz2_button.Size = new System.Drawing.Size(133, 32);
            this.Quiz2_button.TabIndex = 9;
            this.Quiz2_button.Text = "IT";
            this.Quiz2_button.UseVisualStyleBackColor = true;
            this.Quiz2_button.Click += new System.EventHandler(this.Quiz2_button_Click);
            // 
            // Quiz3_button
            // 
            this.Quiz3_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Quiz3_button.Location = new System.Drawing.Point(2, 294);
            this.Quiz3_button.Name = "Quiz3_button";
            this.Quiz3_button.Size = new System.Drawing.Size(133, 32);
            this.Quiz3_button.TabIndex = 10;
            this.Quiz3_button.Text = "Zm";
            this.Quiz3_button.UseVisualStyleBackColor = true;
            this.Quiz3_button.Click += new System.EventHandler(this.Quiz3_button_Click);
            // 
            // Score_label
            // 
            this.Score_label.AutoSize = true;
            this.Score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score_label.Location = new System.Drawing.Point(12, 9);
            this.Score_label.Name = "Score_label";
            this.Score_label.Size = new System.Drawing.Size(0, 31);
            this.Score_label.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 338);
            this.Controls.Add(this.Score_label);
            this.Controls.Add(this.Quiz3_button);
            this.Controls.Add(this.Quiz2_button);
            this.Controls.Add(this.Quiz1_button);
            this.Controls.Add(this.A4_button);
            this.Controls.Add(this.A3_button);
            this.Controls.Add(this.A2_button);
            this.Controls.Add(this.A1_button);
            this.Controls.Add(this.Question_label);
            this.Name = "Form1";
            this.Text = "Quizz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question_label;
        private System.Windows.Forms.Button A1_button;
        private System.Windows.Forms.Button A2_button;
        private System.Windows.Forms.Button A3_button;
        private System.Windows.Forms.Button A4_button;
        private System.Windows.Forms.Button Quiz1_button;
        private System.Windows.Forms.Button Quiz2_button;
        private System.Windows.Forms.Button Quiz3_button;
        private System.Windows.Forms.Label Score_label;
    }
}

