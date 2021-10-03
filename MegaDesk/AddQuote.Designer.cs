namespace MegaDesk
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            this.drawersInput = new System.Windows.Forms.NumericUpDown();
            this.woodTypes = new System.Windows.Forms.ComboBox();
            this.matTypes = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawerLabel = new System.Windows.Forms.Label();
            this.buildDeskBtn = new System.Windows.Forms.Button();
            this.prodLabel = new System.Windows.Forms.Label();
            this.prod = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 51);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(170, 318);
            this.widthInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.widthInput.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthInput.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(200, 31);
            this.widthInput.TabIndex = 2;
            this.widthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInput.ValueChanged += new System.EventHandler(this.widthInput_ValueChanged);
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(500, 318);
            this.depthInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.depthInput.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthInput.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(200, 31);
            this.depthInput.TabIndex = 3;
            this.depthInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInput.ValueChanged += new System.EventHandler(this.depthInput_ValueChanged);
            // 
            // drawersInput
            // 
            this.drawersInput.Location = new System.Drawing.Point(170, 446);
            this.drawersInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.drawersInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(200, 31);
            this.drawersInput.TabIndex = 4;
            this.drawersInput.ValueChanged += new System.EventHandler(this.drawersInput_ValueChanged);
            // 
            // woodTypes
            // 
            this.woodTypes.FormattingEnabled = true;
            this.woodTypes.IntegralHeight = false;
            this.woodTypes.ItemHeight = 25;
            this.woodTypes.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.woodTypes.Location = new System.Drawing.Point(500, 176);
            this.woodTypes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.woodTypes.Name = "woodTypes";
            this.woodTypes.Size = new System.Drawing.Size(200, 33);
            this.woodTypes.TabIndex = 6;
            this.woodTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.woodTypes.Click += new System.EventHandler(this.woodTypes_Click);
            // 
            // matTypes
            // 
            this.matTypes.AutoSize = true;
            this.matTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matTypes.Location = new System.Drawing.Point(493, 133);
            this.matTypes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.matTypes.Name = "matTypes";
            this.matTypes.Size = new System.Drawing.Size(227, 37);
            this.matTypes.TabIndex = 7;
            this.matTypes.Text = "Material Type: ";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(163, 275);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(118, 37);
            this.widthLabel.TabIndex = 8;
            this.widthLabel.Text = "Width: ";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(493, 275);
            this.depthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(120, 37);
            this.depthLabel.TabIndex = 9;
            this.depthLabel.Text = "Depth: ";
            // 
            // drawerLabel
            // 
            this.drawerLabel.AutoSize = true;
            this.drawerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerLabel.Location = new System.Drawing.Point(163, 403);
            this.drawerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.drawerLabel.Name = "drawerLabel";
            this.drawerLabel.Size = new System.Drawing.Size(305, 37);
            this.drawerLabel.TabIndex = 10;
            this.drawerLabel.Text = "Number of Drawers:";
            // 
            // buildDeskBtn
            // 
            this.buildDeskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildDeskBtn.Location = new System.Drawing.Point(339, 545);
            this.buildDeskBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buildDeskBtn.Name = "buildDeskBtn";
            this.buildDeskBtn.Size = new System.Drawing.Size(227, 79);
            this.buildDeskBtn.TabIndex = 11;
            this.buildDeskBtn.Text = "Submit";
            this.buildDeskBtn.UseVisualStyleBackColor = true;
            this.buildDeskBtn.Click += new System.EventHandler(this.buildDeskBtn_Click);
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodLabel.Location = new System.Drawing.Point(506, 403);
            this.prodLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(240, 37);
            this.prodLabel.TabIndex = 12;
            this.prodLabel.Text = "Production time";
            // 
            // prod
            // 
            this.prod.FormattingEnabled = true;
            this.prod.Items.AddRange(new object[] {
            "14",
            "3",
            "5",
            "7"});
            this.prod.Location = new System.Drawing.Point(513, 446);
            this.prod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(196, 33);
            this.prod.TabIndex = 13;
            this.prod.SelectedIndexChanged += new System.EventHandler(this.prod_SelectedIndexChanged);
            this.prod.Click += new System.EventHandler(this.prod_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(174, 116);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(121, 37);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Name: ";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(170, 159);
            this.nameInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(233, 50);
            this.nameInput.TabIndex = 15;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 669);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.prod);
            this.Controls.Add(this.prodLabel);
            this.Controls.Add(this.buildDeskBtn);
            this.Controls.Add(this.drawerLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.matTypes);
            this.Controls.Add(this.woodTypes);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown depthInput;
        private System.Windows.Forms.NumericUpDown drawersInput;
        private System.Windows.Forms.ComboBox woodTypes;
        private System.Windows.Forms.Label matTypes;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label drawerLabel;
        private System.Windows.Forms.Button buildDeskBtn;
        private System.Windows.Forms.Label prodLabel;
        private System.Windows.Forms.ComboBox prod;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
    }
}