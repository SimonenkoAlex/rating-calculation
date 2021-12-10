namespace WFAUniversityRanking
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
            this.tBFirstname = new System.Windows.Forms.TextBox();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelSecondname = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.tBSecondname = new System.Windows.Forms.TextBox();
            this.tBPatronymic = new System.Windows.Forms.TextBox();
            this.rTBOutput = new System.Windows.Forms.RichTextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBFirstname
            // 
            this.tBFirstname.Location = new System.Drawing.Point(115, 12);
            this.tBFirstname.Name = "tBFirstname";
            this.tBFirstname.Size = new System.Drawing.Size(173, 20);
            this.tBFirstname.TabIndex = 0;
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstname.Location = new System.Drawing.Point(12, 9);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(97, 23);
            this.labelFirstname.TabIndex = 1;
            this.labelFirstname.Text = "Фамилия";
            // 
            // labelSecondname
            // 
            this.labelSecondname.AutoSize = true;
            this.labelSecondname.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondname.Location = new System.Drawing.Point(12, 46);
            this.labelSecondname.Name = "labelSecondname";
            this.labelSecondname.Size = new System.Drawing.Size(48, 23);
            this.labelSecondname.TabIndex = 1;
            this.labelSecondname.Text = "Имя";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(12, 80);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(99, 23);
            this.labelPatronymic.TabIndex = 1;
            this.labelPatronymic.Text = "Отчество";
            // 
            // tBSecondname
            // 
            this.tBSecondname.Location = new System.Drawing.Point(115, 46);
            this.tBSecondname.Name = "tBSecondname";
            this.tBSecondname.Size = new System.Drawing.Size(173, 20);
            this.tBSecondname.TabIndex = 0;
            // 
            // tBPatronymic
            // 
            this.tBPatronymic.Location = new System.Drawing.Point(115, 80);
            this.tBPatronymic.Name = "tBPatronymic";
            this.tBPatronymic.Size = new System.Drawing.Size(173, 20);
            this.tBPatronymic.TabIndex = 0;
            // 
            // rTBOutput
            // 
            this.rTBOutput.Enabled = false;
            this.rTBOutput.Location = new System.Drawing.Point(294, 12);
            this.rTBOutput.Name = "rTBOutput";
            this.rTBOutput.Size = new System.Drawing.Size(250, 90);
            this.rTBOutput.TabIndex = 2;
            this.rTBOutput.Text = "";
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResult.Location = new System.Drawing.Point(163, 106);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(125, 25);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "Сохранить";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 139);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.rTBOutput);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelSecondname);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.tBPatronymic);
            this.Controls.Add(this.tBSecondname);
            this.Controls.Add(this.tBFirstname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBFirstname;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelSecondname;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox tBSecondname;
        private System.Windows.Forms.TextBox tBPatronymic;
        private System.Windows.Forms.RichTextBox rTBOutput;
        private System.Windows.Forms.Button btnResult;
    }
}

