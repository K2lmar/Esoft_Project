namespace Esoft_Project
{
    partial class FormRealtor
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewRealtor = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Имя = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Отчество = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Фамилия = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Комиссий = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDealShare = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxDealShare = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(394, 431);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(79, 31);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(491, 431);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(79, 31);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(585, 431);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(15);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(79, 31);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewRealtor
            // 
            this.listViewRealtor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Имя,
            this.Отчество,
            this.Фамилия,
            this.Комиссий});
            this.listViewRealtor.FullRowSelect = true;
            this.listViewRealtor.GridLines = true;
            this.listViewRealtor.HideSelection = false;
            this.listViewRealtor.Location = new System.Drawing.Point(172, 103);
            this.listViewRealtor.Margin = new System.Windows.Forms.Padding(15);
            this.listViewRealtor.MultiSelect = false;
            this.listViewRealtor.Name = "listViewRealtor";
            this.listViewRealtor.Size = new System.Drawing.Size(488, 322);
            this.listViewRealtor.TabIndex = 3;
            this.listViewRealtor.UseCompatibleStateImageBehavior = false;
            this.listViewRealtor.View = System.Windows.Forms.View.Details;
            this.listViewRealtor.SelectedIndexChanged += new System.EventHandler(this.listViewRealtor_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 36;
            // 
            // Имя
            // 
            this.Имя.Text = "Имя";
            this.Имя.Width = 59;
            // 
            // Отчество
            // 
            this.Отчество.Text = "Отчество";
            this.Отчество.Width = 78;
            // 
            // Фамилия
            // 
            this.Фамилия.Text = "Фамилия";
            this.Фамилия.Width = 76;
            // 
            // Комиссий
            // 
            this.Комиссий.Text = "Доля комиссий";
            this.Комиссий.Width = 96;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(7, 103);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(7, 152);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 5;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(7, 200);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelDealShare
            // 
            this.labelDealShare.AutoSize = true;
            this.labelDealShare.Location = new System.Drawing.Point(7, 249);
            this.labelDealShare.Name = "labelDealShare";
            this.labelDealShare.Size = new System.Drawing.Size(87, 13);
            this.labelDealShare.TabIndex = 7;
            this.labelDealShare.Text = "Доля комиссий";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(10, 119);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(154, 20);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(10, 168);
            this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(154, 20);
            this.textBoxMiddleName.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(10, 216);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(154, 20);
            this.textBoxLastName.TabIndex = 10;
            // 
            // textBoxDealShare
            // 
            this.textBoxDealShare.Location = new System.Drawing.Point(10, 265);
            this.textBoxDealShare.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxDealShare.Name = "textBoxDealShare";
            this.textBoxDealShare.Size = new System.Drawing.Size(154, 20);
            this.textBoxDealShare.TabIndex = 11;
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(2, 1);
            this.Logo.Margin = new System.Windows.Forms.Padding(15);
            this.Logo.Name = "Logo";
            this.Logo.Padding = new System.Windows.Forms.Padding(10);
            this.Logo.Size = new System.Drawing.Size(666, 91);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 12;
            this.Logo.TabStop = false;
            // 
            // FormRealtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 466);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.textBoxDealShare);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelDealShare);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.listViewRealtor);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormRealtor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Риелторы";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewRealtor;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDealShare;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxDealShare;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Имя;
        private System.Windows.Forms.ColumnHeader Отчество;
        private System.Windows.Forms.ColumnHeader Фамилия;
        private System.Windows.Forms.ColumnHeader Комиссий;
        private System.Windows.Forms.PictureBox Logo;
    }
}