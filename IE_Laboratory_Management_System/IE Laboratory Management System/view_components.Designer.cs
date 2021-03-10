namespace WindowsFormsApp1
{
    partial class view_components
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_components));
            this.dgvViewComponents = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbComName = new System.Windows.Forms.TextBox();
            this.lblComName = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.dtpLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewComponents)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewComponents
            // 
            this.dgvViewComponents.AllowUserToAddRows = false;
            this.dgvViewComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewComponents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvViewComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewComponents.Location = new System.Drawing.Point(235, 12);
            this.dgvViewComponents.Name = "dgvViewComponents";
            this.dgvViewComponents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewComponents.Size = new System.Drawing.Size(553, 175);
            this.dgvViewComponents.TabIndex = 0;
            this.dgvViewComponents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewComponents_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbComName);
            this.panel1.Controls.Add(this.lblComName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 175);
            this.panel1.TabIndex = 2;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(3, 13);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(170, 17);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Search Components !!!";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSearch.Location = new System.Drawing.Point(6, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbComName
            // 
            this.tbComName.Location = new System.Drawing.Point(6, 80);
            this.tbComName.Name = "tbComName";
            this.tbComName.Size = new System.Drawing.Size(191, 20);
            this.tbComName.TabIndex = 1;
            this.tbComName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbComName_KeyUp);
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComName.Location = new System.Drawing.Point(3, 53);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(177, 13);
            this.lblComName.TabIndex = 0;
            this.lblComName.Text = "Enter the Name of Component";
            // 
            // lblCredits
            // 
            this.lblCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(460, 428);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(335, 17);
            this.lblCredits.TabIndex = 3;
            this.lblCredits.Text = "Designed and Developed by Jayasurya Obbu";
            // 
            // pnlEdit
            // 
            this.pnlEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEdit.Controls.Add(this.label1);
            this.pnlEdit.Controls.Add(this.dtpLastUpdate);
            this.pnlEdit.Controls.Add(this.btnUpdate);
            this.pnlEdit.Controls.Add(this.tbQuantity);
            this.pnlEdit.Controls.Add(this.tbValue);
            this.pnlEdit.Controls.Add(this.tbName);
            this.pnlEdit.Controls.Add(this.lblLastUpdate);
            this.pnlEdit.Controls.Add(this.lblQuantity);
            this.pnlEdit.Controls.Add(this.lblValue);
            this.pnlEdit.Controls.Add(this.lblName);
            this.pnlEdit.Location = new System.Drawing.Point(235, 212);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(553, 198);
            this.pnlEdit.TabIndex = 4;
            this.pnlEdit.Visible = false;
            // 
            // dtpLastUpdate
            // 
            this.dtpLastUpdate.Location = new System.Drawing.Point(377, 105);
            this.dtpLastUpdate.Name = "dtpLastUpdate";
            this.dtpLastUpdate.Size = new System.Drawing.Size(138, 20);
            this.dtpLastUpdate.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnUpdate.Location = new System.Drawing.Point(228, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(354, 50);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(161, 20);
            this.tbQuantity.TabIndex = 6;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(94, 105);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(168, 20);
            this.tbValue.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(94, 50);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(168, 20);
            this.tbName.TabIndex = 4;
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdate.Location = new System.Drawing.Point(283, 108);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(76, 13);
            this.lblLastUpdate.TabIndex = 3;
            this.lblLastUpdate.Text = "Last Update";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(283, 53);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(54, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(37, 108);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(39, 13);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Value";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(37, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Edit and Update Components";
            // 
            // view_components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvViewComponents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "view_components";
            this.Text = "View and Edit Components";
            this.Load += new System.EventHandler(this.view_components_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewComponents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewComponents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbComName;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.DateTimePicker dtpLastUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
    }
}