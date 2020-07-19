namespace C898_Capstone.Forms
{
    partial class EditItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItemForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.productNumberLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.expirationDate = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.productNumberInput = new System.Windows.Forms.TextBox();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.expirationDateInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // productNumberLabel
            // 
            this.productNumberLabel.AutoSize = true;
            this.productNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNumberLabel.Location = new System.Drawing.Point(12, 56);
            this.productNumberLabel.Name = "productNumberLabel";
            this.productNumberLabel.Size = new System.Drawing.Size(124, 20);
            this.productNumberLabel.TabIndex = 1;
            this.productNumberLabel.Text = "Product Number";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(12, 91);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(12, 128);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(68, 20);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity";
            // 
            // expirationDate
            // 
            this.expirationDate.AutoSize = true;
            this.expirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDate.Location = new System.Drawing.Point(12, 162);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(118, 20);
            this.expirationDate.TabIndex = 4;
            this.expirationDate.Text = "Expiration Date";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 214);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 20);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(233, 214);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(180, 20);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(142, 21);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(271, 20);
            this.nameInput.TabIndex = 8;
            // 
            // productNumberInput
            // 
            this.productNumberInput.Location = new System.Drawing.Point(142, 58);
            this.productNumberInput.Name = "productNumberInput";
            this.productNumberInput.Size = new System.Drawing.Size(271, 20);
            this.productNumberInput.TabIndex = 9;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(142, 93);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(271, 20);
            this.descriptionInput.TabIndex = 10;
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(142, 130);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(271, 20);
            this.quantityInput.TabIndex = 11;
            // 
            // expirationDateInput
            // 
            this.expirationDateInput.Location = new System.Drawing.Point(142, 164);
            this.expirationDateInput.Name = "expirationDateInput";
            this.expirationDateInput.Size = new System.Drawing.Size(271, 20);
            this.expirationDateInput.TabIndex = 12;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 251);
            this.Controls.Add(this.expirationDateInput);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.productNumberInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.expirationDate);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.productNumberLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddItemForm";
            this.Text = "Item Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label productNumberLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label expirationDate;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox productNumberInput;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.TextBox expirationDateInput;
    }
}