
namespace WindowsFormsApp2511.Forms
{
    partial class SpecialtyForm
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
            this.changeSpecialtyButton = new System.Windows.Forms.Button();
            this.addSpecialtyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpecialtiesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSpecialtiesGridView
            // 
            this.dataSpecialtiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSpecialtiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumb,
            this.codeColumb,
            this.nameColumb});
            this.dataSpecialtiesGridView.Location = new System.Drawing.Point(12, 12);
            this.dataSpecialtiesGridView.Name = "dataSpecialtiesGridView";
            this.dataSpecialtiesGridView.Size = new System.Drawing.Size(398, 237);
            this.dataSpecialtiesGridView.TabIndex = 0;
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
            this.codeColumb.DataPropertyName = "Code";
            this.codeColumb.HeaderText = "Шифр";
            this.codeColumb.Name = "codeColumb";
            // 
            // nameColumb
            // 
            this.nameColumb.DataPropertyName = "Name";
            this.nameColumb.HeaderText = "Название";
            this.nameColumb.Name = "nameColumb";
            // 
            // changeSpecialtyButton
            // 
            this.changeSpecialtyButton.Location = new System.Drawing.Point(93, 255);
            this.changeSpecialtyButton.Name = "changeSpecialtyButton";
            this.changeSpecialtyButton.Size = new System.Drawing.Size(75, 23);
            this.changeSpecialtyButton.TabIndex = 5;
            this.changeSpecialtyButton.Text = "Изменить";
            this.changeSpecialtyButton.UseVisualStyleBackColor = true;
            // 
            // addSpecialtyButton
            // 
            this.addSpecialtyButton.Location = new System.Drawing.Point(12, 255);
            this.addSpecialtyButton.Name = "addSpecialtyButton";
            this.addSpecialtyButton.Size = new System.Drawing.Size(75, 23);
            this.addSpecialtyButton.TabIndex = 4;
            this.addSpecialtyButton.Text = "Добавить";
            this.addSpecialtyButton.UseVisualStyleBackColor = true;
            // 
            // SpecialtiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 393);
            this.Controls.Add(this.changeSpecialtyButton);
            this.Controls.Add(this.addSpecialtyButton);
            this.Controls.Add(this.dataSpecialtiesGridView);
            this.Name = "SpecialtiesForm";
            this.Text = "Специальности";
            ((System.ComponentModel.ISupportInitialize)(this.dataSpecialtiesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSpecialtiesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumb;
        private System.Windows.Forms.Button changeSpecialtyButton;
        private System.Windows.Forms.Button addSpecialtyButton;
    }
}