
namespace WindowsFormsApp2511.Forms
{
    partial class GroupsForm
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
            this.SpecialtyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.changeGroupButton = new System.Windows.Forms.Button();
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
            this.SpecialtyId});
            this.dataSpecialtiesGridView.Location = new System.Drawing.Point(12, 12);
            this.dataSpecialtiesGridView.Name = "dataSpecialtiesGridView";
            this.dataSpecialtiesGridView.Size = new System.Drawing.Size(398, 237);
            this.dataSpecialtiesGridView.TabIndex = 1;
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
            this.codeColumb.HeaderText = "Название";
            this.codeColumb.Name = "codeColumb";
            // 
            // nameColumb
            // 
            this.nameColumb.DataPropertyName = "Year";
            this.nameColumb.HeaderText = "Год";
            this.nameColumb.Name = "nameColumb";
            // 
            // SpecialtyId
            // 
            this.SpecialtyId.DataPropertyName = "SpecialtyId";
            this.SpecialtyId.HeaderText = "SpecialtyId";
            this.SpecialtyId.Name = "SpecialtyId";
            this.SpecialtyId.ReadOnly = true;
            this.SpecialtyId.Visible = false;
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(12, 270);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(75, 23);
            this.addGroupButton.TabIndex = 2;
            this.addGroupButton.Text = "Добавить";
            this.addGroupButton.UseVisualStyleBackColor = true;
            // 
            // changeGroupButton
            // 
            this.changeGroupButton.Location = new System.Drawing.Point(93, 270);
            this.changeGroupButton.Name = "changeGroupButton";
            this.changeGroupButton.Size = new System.Drawing.Size(75, 23);
            this.changeGroupButton.TabIndex = 3;
            this.changeGroupButton.Text = "Изменить";
            this.changeGroupButton.UseVisualStyleBackColor = true;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeGroupButton);
            this.Controls.Add(this.addGroupButton);
            this.Controls.Add(this.dataSpecialtiesGridView);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataSpecialtiesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSpecialtiesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyId;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.Button changeGroupButton;
    }
}