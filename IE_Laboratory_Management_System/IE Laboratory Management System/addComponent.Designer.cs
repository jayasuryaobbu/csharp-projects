namespace WindowsFormsApp1
{
    partial class addComponent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addComponent));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbComName = new System.Windows.Forms.TextBox();
            this.tbComValue = new System.Windows.Forms.TextBox();
            this.lblComName = new System.Windows.Forms.Label();
            this.lblComValue = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddCom = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.dtpLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbComName
            // 
            this.tbComName.Location = new System.Drawing.Point(194, 35);
            this.tbComName.Name = "tbComName";
            this.tbComName.Size = new System.Drawing.Size(221, 20);
            this.tbComName.TabIndex = 1;
            // 
            // tbComValue
            // 
            this.tbComValue.Location = new System.Drawing.Point(194, 78);
            this.tbComValue.Name = "tbComValue";
            this.tbComValue.Size = new System.Drawing.Size(221, 20);
            this.tbComValue.TabIndex = 2;
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComName.Location = new System.Drawing.Point(20, 35);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(135, 17);
            this.lblComName.TabIndex = 5;
            this.lblComName.Text = "Component Name";
            // 
            // lblComValue
            // 
            this.lblComValue.AutoSize = true;
            this.lblComValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComValue.Location = new System.Drawing.Point(106, 78);
            this.lblComValue.Name = "lblComValue";
            this.lblComValue.Size = new System.Drawing.Size(49, 17);
            this.lblComValue.TabIndex = 6;
            this.lblComValue.Text = "Value";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdate.Location = new System.Drawing.Point(59, 166);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(96, 17);
            this.lblLastUpdate.TabIndex = 7;
            this.lblLastUpdate.Text = "Last Update";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(86, 122);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 17);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnAddCom
            // 
            this.btnAddCom.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCom.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAddCom.Location = new System.Drawing.Point(147, 216);
            this.btnAddCom.Name = "btnAddCom";
            this.btnAddCom.Size = new System.Drawing.Size(84, 35);
            this.btnAddCom.TabIndex = 9;
            this.btnAddCom.Text = "Add !!";
            this.btnAddCom.UseVisualStyleBackColor = false;
            this.btnAddCom.Click += new System.EventHandler(this.btnAddCom_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(225, 268);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(261, 13);
            this.lblCredits.TabIndex = 10;
            this.lblCredits.Text = "Desinged and Developed by Jayasurya Obbu";
            // 
            // dtpLastUpdate
            // 
            this.dtpLastUpdate.Location = new System.Drawing.Point(194, 163);
            this.dtpLastUpdate.Name = "dtpLastUpdate";
            this.dtpLastUpdate.Size = new System.Drawing.Size(200, 20);
            this.dtpLastUpdate.TabIndex = 1;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(194, 122);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(59, 20);
            this.nudQuantity.TabIndex = 12;
            // 
            // addComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 285);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.dtpLastUpdate);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.btnAddCom);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblLastUpdate);
            this.Controls.Add(this.lblComValue);
            this.Controls.Add(this.lblComName);
            this.Controls.Add(this.tbComValue);
            this.Controls.Add(this.tbComName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addComponent";
            this.Text = "Add Components";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbComName;
        private System.Windows.Forms.TextBox tbComValue;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.Label lblComValue;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddCom;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.DateTimePicker dtpLastUpdate;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}