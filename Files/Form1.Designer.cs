
namespace Files
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
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbFormat = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbFormat = new System.Windows.Forms.Label();
            this.tbCreateFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Location = new System.Drawing.Point(31, 27);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(397, 238);
            this.lbFiles.TabIndex = 0;
            this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged_1);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(508, 65);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(224, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbSize
            // 
            this.tbSize.Enabled = false;
            this.tbSize.Location = new System.Drawing.Point(508, 165);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(224, 20);
            this.tbSize.TabIndex = 2;
            // 
            // tbFormat
            // 
            this.tbFormat.Enabled = false;
            this.tbFormat.Location = new System.Drawing.Point(508, 112);
            this.tbFormat.Name = "tbFormat";
            this.tbFormat.Size = new System.Drawing.Size(224, 20);
            this.tbFormat.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(441, 68);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(61, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "File name";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSize.Location = new System.Drawing.Point(449, 168);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(53, 13);
            this.lbSize.TabIndex = 5;
            this.lbSize.Text = "File size";
            // 
            // lbFormat
            // 
            this.lbFormat.AutoSize = true;
            this.lbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFormat.Location = new System.Drawing.Point(436, 115);
            this.lbFormat.Name = "lbFormat";
            this.lbFormat.Size = new System.Drawing.Size(66, 13);
            this.lbFormat.TabIndex = 6;
            this.lbFormat.Text = "File format";
            this.lbFormat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbCreateFile
            // 
            this.tbCreateFile.Location = new System.Drawing.Point(196, 330);
            this.tbCreateFile.Name = "tbCreateFile";
            this.tbCreateFile.Size = new System.Drawing.Size(291, 20);
            this.tbCreateFile.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter name and fomat file";
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.Color.OrangeRed;
            this.btCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreate.Location = new System.Drawing.Point(327, 374);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 38);
            this.btCreate.TabIndex = 9;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCreateFile);
            this.Controls.Add(this.lbFormat);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbFormat);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbFormat;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbFormat;
        private System.Windows.Forms.TextBox tbCreateFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCreate;
    }
}

