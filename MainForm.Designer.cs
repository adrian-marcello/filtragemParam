namespace filtragemParam
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            debugBox = new GroupBox();
            startButton = new Button();
            ruleList = new ListBox();
            addRuleButton = new Button();
            treeView1 = new TreeView();
            selectN = new ComboBox();
            selectOp = new ComboBox();
            numValor = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            // 
            // debugBox
            // 
            debugBox.Location = new Point(330, 23);
            debugBox.Name = "debugBox";
            debugBox.Size = new Size(250, 344);
            debugBox.TabIndex = 0;
            debugBox.TabStop = false;
            // 
            // startButton
            // 
            startButton.Location = new Point(112, 225);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 63);
            startButton.TabIndex = 1;
            startButton.Text = "Iniciar Módulo";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // ruleList
            // 
            ruleList.FormattingEnabled = true;
            ruleList.Location = new Point(12, 294);
            ruleList.Name = "ruleList";
            ruleList.Size = new Size(264, 244);
            ruleList.TabIndex = 2;
            ruleList.SelectedIndexChanged += ruleList_SelectedIndexChanged;
            // 
            // addRuleButton
            // 
            addRuleButton.Location = new Point(12, 225);
            addRuleButton.Name = "addRuleButton";
            addRuleButton.Size = new Size(94, 63);
            addRuleButton.TabIndex = 3;
            addRuleButton.Text = "Adicionar Regra";
            addRuleButton.UseVisualStyleBackColor = true;
            addRuleButton.Click += addRuleButton_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(614, 23);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(414, 499);
            treeView1.TabIndex = 4;
            // 
            // selectN
            // 
            selectN.DropDownStyle = ComboBoxStyle.DropDownList;
            selectN.FormattingEnabled = true;
            selectN.Items.AddRange(new object[] { "a", "b", "c" });
            selectN.Location = new Point(12, 52);
            selectN.Name = "selectN";
            selectN.Size = new Size(54, 28);
            selectN.TabIndex = 0;
            // 
            // selectOp
            // 
            selectOp.DropDownStyle = ComboBoxStyle.DropDownList;
            selectOp.FormattingEnabled = true;
            selectOp.Items.AddRange(new object[] { "<", "=", ">" });
            selectOp.Location = new Point(12, 86);
            selectOp.Name = "selectOp";
            selectOp.Size = new Size(54, 28);
            selectOp.TabIndex = 5;
            // 
            // numValor
            // 
            numValor.Location = new Point(12, 121);
            numValor.Name = "numValor";
            numValor.Size = new Size(54, 27);
            numValor.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 60);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "Parâmetro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 94);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 8;
            label2.Text = "Operador de Comparação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 128);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 9;
            label3.Text = "Valor Numérico";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(212, 225);
            button1.Name = "button1";
            button1.Size = new Size(64, 63);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 550);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numValor);
            Controls.Add(selectOp);
            Controls.Add(selectN);
            Controls.Add(treeView1);
            Controls.Add(addRuleButton);
            Controls.Add(ruleList);
            Controls.Add(startButton);
            Controls.Add(debugBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Módulo 4 - Filtragem de Parâmetros";
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox debugBox;
        private Button startButton;
        private ListBox ruleList;
        private Button addRuleButton;
        private TreeView treeView1;
        private ComboBox selectN;
        private ComboBox selectOp;
        private NumericUpDown numValor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
