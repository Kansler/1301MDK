
namespace WindowsFormsApp2511.Forms
{
    partial class MainForm
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
            this.showSpecialTiesButton = new System.Windows.Forms.Button();
            this.showGroupsButton = new System.Windows.Forms.Button();
            this.showStudentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showSpecialTiesButton
            // 
            this.showSpecialTiesButton.BackColor = System.Drawing.Color.Black;
            this.showSpecialTiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSpecialTiesButton.ForeColor = System.Drawing.Color.White;
            this.showSpecialTiesButton.Location = new System.Drawing.Point(12, 12);
            this.showSpecialTiesButton.Name = "showSpecialTiesButton";
            this.showSpecialTiesButton.Size = new System.Drawing.Size(440, 32);
            this.showSpecialTiesButton.TabIndex = 0;
            this.showSpecialTiesButton.Text = "Список специальностей";
            this.showSpecialTiesButton.UseVisualStyleBackColor = false;
            // 
            // showGroupsButton
            // 
            this.showGroupsButton.BackColor = System.Drawing.Color.Black;
            this.showGroupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showGroupsButton.ForeColor = System.Drawing.Color.White;
            this.showGroupsButton.Location = new System.Drawing.Point(12, 41);
            this.showGroupsButton.Name = "showGroupsButton";
            this.showGroupsButton.Size = new System.Drawing.Size(440, 32);
            this.showGroupsButton.TabIndex = 1;
            this.showGroupsButton.Text = "Список групп";
            this.showGroupsButton.UseVisualStyleBackColor = false;
            // 
            // showStudentsButton
            // 
            this.showStudentsButton.BackColor = System.Drawing.Color.Black;
            this.showStudentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showStudentsButton.ForeColor = System.Drawing.Color.White;
            this.showStudentsButton.Location = new System.Drawing.Point(12, 70);
            this.showStudentsButton.Name = "showStudentsButton";
            this.showStudentsButton.Size = new System.Drawing.Size(440, 32);
            this.showStudentsButton.TabIndex = 2;
            this.showStudentsButton.Text = "Список студентов";
            this.showStudentsButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 425);
            this.Controls.Add(this.showStudentsButton);
            this.Controls.Add(this.showGroupsButton);
            this.Controls.Add(this.showSpecialTiesButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стартовое окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showSpecialTiesButton;
        private System.Windows.Forms.Button showGroupsButton;
        private System.Windows.Forms.Button showStudentsButton;
    }
}

