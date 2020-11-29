
namespace WindowsFormsApp2511.Forms
{
    partial class StudentsForm
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
            this.dataSpecialtiesGridView = new System.Windows.Forms.DataGridView();
            this.idColumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeColumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpecialtiesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSpecialtiesGridView
            // 
            this.dataSpecialtiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSpecialtiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumb,
            this.codeColumb,
            this.nameColumb,
            this.GroupId});
            this.dataSpecialtiesGridView.Location = new System.Drawing.Point(12, 12);
            this.dataSpecialtiesGridView.Name = "dataSpecialtiesGridView";
            this.dataSpecialtiesGridView.Size = new System.Drawing.Size(398, 237);
            this.dataSpecialtiesGridView.TabIndex = 2;
            // 
            // idColumb
            // 
            this.idColumb.DataPropertyName = "Id";
            this.idColumb.HeaderText = "Id";
            this.idColumb.Name = "idColumb";
            this.idColumb.ReadOnly = true;
            this.idColumb.Visible = false;
            // 
            // codeColumb
            // 
            this.codeColumb.DataPropertyName = "Name";
            this.codeColumb.HeaderText = "Имя";
            this.codeColumb.Name = "codeColumb";
            // 
            // nameColumb
            // 
            this.nameColumb.DataPropertyName = "Surname";
            this.nameColumb.HeaderText = "Фамилия";
            this.nameColumb.Name = "nameColumb";
            // 
            // GroupId
            // 
            this.GroupId.DataPropertyName = "GroupId";
            this.GroupId.HeaderText = "GroupId";
            this.GroupId.Name = "GroupId";
            this.GroupId.ReadOnly = true;
            this.GroupId.Visible = false;
            // 
            // changeStudentButton
            // 
            this.changeStudentButton.Location = new System.Drawing.Point(93, 255);
            this.changeStudentButton.Name = "changeStudentButton";
            this.changeStudentButton.Size = new System.Drawing.Size(75, 23);
            this.changeStudentButton.TabIndex = 7;
            this.changeStudentButton.Text = "Изменить";
            this.changeStudentButton.UseVisualStyleBackColor = true;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(12, 255);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 6;
            this.addStudentButton.Text = "Добавить";
            this.addStudentButton.UseVisualStyleBackColor = true;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.dataSpecialtiesGridView);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataSpecialtiesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSpecialtiesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.Button changeStudentButton;
        private System.Windows.Forms.Button addStudentButton;
    }
}