
namespace MusicList
{
    partial class AddEditForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.publishYearLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.publishYearInput = new System.Windows.Forms.NumericUpDown();
            this.priorityInput = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.lengthInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.publishYearInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(43, 37);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(29, 15);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Cím";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(161, 34);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 23);
            this.titleTextBox.TabIndex = 1;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(43, 77);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(43, 15);
            this.artistLabel.TabIndex = 2;
            this.artistLabel.Text = "Előadó";
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(161, 74);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(100, 23);
            this.artistTextBox.TabIndex = 3;
            // 
            // publishYearLabel
            // 
            this.publishYearLabel.AutoSize = true;
            this.publishYearLabel.Location = new System.Drawing.Point(43, 117);
            this.publishYearLabel.Name = "publishYearLabel";
            this.publishYearLabel.Size = new System.Drawing.Size(62, 15);
            this.publishYearLabel.TabIndex = 4;
            this.publishYearLabel.Text = "Kiadás éve";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(43, 154);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(38, 15);
            this.lengthLabel.TabIndex = 5;
            this.lengthLabel.Text = "Hossz";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(43, 194);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(50, 15);
            this.priorityLabel.TabIndex = 6;
            this.priorityLabel.Text = "Prioritás";
            // 
            // publishYearInput
            // 
            this.publishYearInput.Location = new System.Drawing.Point(161, 115);
            this.publishYearInput.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.publishYearInput.Name = "publishYearInput";
            this.publishYearInput.Size = new System.Drawing.Size(120, 23);
            this.publishYearInput.TabIndex = 10;
            // 
            // priorityInput
            // 
            this.priorityInput.Location = new System.Drawing.Point(161, 192);
            this.priorityInput.Name = "priorityInput";
            this.priorityInput.Size = new System.Drawing.Size(120, 23);
            this.priorityInput.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(43, 243);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Hozzáadás";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lengthInput
            // 
            this.lengthInput.Location = new System.Drawing.Point(161, 152);
            this.lengthInput.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(120, 23);
            this.lengthInput.TabIndex = 14;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lengthInput);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.priorityInput);
            this.Controls.Add(this.publishYearInput);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.publishYearLabel);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddEditForm";
            this.Text = "Zene hozzáadás";
            ((System.ComponentModel.ISupportInitialize)(this.publishYearInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Label publishYearLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.NumericUpDown publishYearInput;
        private System.Windows.Forms.NumericUpDown priorityInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown lengthInput;
    }
}