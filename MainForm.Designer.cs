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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            startButton = new Button();
            ruleList = new ListBox();
            addRuleButton = new Button();
            selectN = new ComboBox();
            selectOp = new ComboBox();
            numValor = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            stopButton = new Button();
            listBoxIED = new ListBox();
            debugBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
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
            ruleList.Size = new Size(264, 224);
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
            // selectN
            // 
            selectN.DropDownStyle = ComboBoxStyle.DropDownList;
            selectN.FormattingEnabled = true;
            selectN.Items.AddRange(new object[] { "a", "b", "c" });
            selectN.Location = new Point(12, 60);
            selectN.Name = "selectN";
            selectN.Size = new Size(54, 28);
            selectN.TabIndex = 0;
            // 
            // selectOp
            // 
            selectOp.DropDownStyle = ComboBoxStyle.DropDownList;
            selectOp.FormattingEnabled = true;
            selectOp.Items.AddRange(new object[] { "<", "=", ">" });
            selectOp.Location = new Point(12, 94);
            selectOp.Name = "selectOp";
            selectOp.Size = new Size(54, 28);
            selectOp.TabIndex = 5;
            // 
            // numValor
            // 
            numValor.Location = new Point(12, 128);
            numValor.Name = "numValor";
            numValor.Size = new Size(54, 27);
            numValor.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 63);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 7;
            label1.Text = "Corrente Parâmetro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 97);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 8;
            label2.Text = "Operador de Comparação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 135);
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
            button1.Location = new Point(250, 495);
            button1.Name = "button1";
            button1.Size = new Size(26, 23);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 23);
            label4.Name = "label4";
            label4.Size = new Size(243, 20);
            label4.TabIndex = 11;
            label4.Text = "Informações para Criação de Regra";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            BottomToolStripPanel.Size = new Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            TopToolStripPanel.Size = new Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            RightToolStripPanel.Size = new Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            LeftToolStripPanel.Size = new Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.Size = new Size(138, 194);
            // 
            // stopButton
            // 
            stopButton.Location = new Point(212, 225);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(64, 63);
            stopButton.TabIndex = 12;
            stopButton.Text = "Parar";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // listBoxIED
            // 
            listBoxIED.FormattingEnabled = true;
            listBoxIED.Location = new Point(620, 34);
            listBoxIED.Name = "listBoxIED";
            listBoxIED.Size = new Size(265, 484);
            listBoxIED.TabIndex = 0;
            // 
            // debugBox
            // 
            debugBox.Location = new Point(355, 34);
            debugBox.Multiline = true;
            debugBox.Name = "debugBox";
            debugBox.ScrollBars = ScrollBars.Vertical;
            debugBox.Size = new Size(235, 484);
            debugBox.TabIndex = 13;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 550);
            Controls.Add(debugBox);
            Controls.Add(listBoxIED);
            Controls.Add(stopButton);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numValor);
            Controls.Add(selectOp);
            Controls.Add(selectN);
            Controls.Add(addRuleButton);
            Controls.Add(ruleList);
            Controls.Add(startButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Módulo 4 - Filtragem de Parâmetros, v0.1";
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button startButton;
        private ListBox ruleList;
        private Button addRuleButton;
        private ComboBox selectN;
        private ComboBox selectOp;
        private NumericUpDown numValor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private System.Windows.Forms.Timer timer;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private Button stopButton;
        private ListBox listBoxIED;
        private TextBox debugBox;
    }
}
