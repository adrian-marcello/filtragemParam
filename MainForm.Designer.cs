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
            addRuleButton = new Button();
            selectN = new ComboBox();
            selectOp = new ComboBox();
            numValor = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            stopButton = new Button();
            listBoxIED = new ListBox();
            debugBox = new TextBox();
            groupBox1 = new GroupBox();
            listViewRule = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            cleanRulesButton = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 18);
            startButton.Name = "startButton";
            startButton.Size = new Size(184, 63);
            startButton.TabIndex = 1;
            startButton.Text = "Iniciar Módulo";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // addRuleButton
            // 
            addRuleButton.Location = new Point(12, 153);
            addRuleButton.Name = "addRuleButton";
            addRuleButton.Size = new Size(184, 60);
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
            numValor.Location = new Point(12, 120);
            numValor.Name = "numValor";
            numValor.Size = new Size(54, 27);
            numValor.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 55);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 7;
            label1.Text = "Corrente Parâmetro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 89);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 8;
            label2.Text = "Operador de Comparação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 127);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 9;
            label3.Text = "Valor Numérico";
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
            stopButton.Location = new Point(202, 18);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(139, 63);
            stopButton.TabIndex = 12;
            stopButton.Text = "Parar";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // listBoxIED
            // 
            listBoxIED.FormattingEnabled = true;
            listBoxIED.Location = new Point(641, 12);
            listBoxIED.Name = "listBoxIED";
            listBoxIED.SelectionMode = SelectionMode.None;
            listBoxIED.Size = new Size(265, 504);
            listBoxIED.TabIndex = 0;
            // 
            // debugBox
            // 
            debugBox.Location = new Point(379, 12);
            debugBox.Multiline = true;
            debugBox.Name = "debugBox";
            debugBox.ScrollBars = ScrollBars.Vertical;
            debugBox.Size = new Size(235, 504);
            debugBox.TabIndex = 13;
            debugBox.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewRule);
            groupBox1.Controls.Add(cleanRulesButton);
            groupBox1.Controls.Add(addRuleButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(selectN);
            groupBox1.Controls.Add(selectOp);
            groupBox1.Controls.Add(numValor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 411);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações para criação de regras";
            // 
            // listViewRule
            // 
            listViewRule.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewRule.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewRule.Location = new Point(12, 219);
            listViewRule.Name = "listViewRule";
            listViewRule.ShowGroups = false;
            listViewRule.Size = new Size(329, 181);
            listViewRule.TabIndex = 16;
            listViewRule.UseCompatibleStateImageBehavior = false;
            listViewRule.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Index";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Regra";
            columnHeader2.Width = 120;
            // 
            // cleanRulesButton
            // 
            cleanRulesButton.Location = new Point(202, 153);
            cleanRulesButton.Name = "cleanRulesButton";
            cleanRulesButton.Size = new Size(139, 60);
            cleanRulesButton.TabIndex = 10;
            cleanRulesButton.Text = "Limpar Regras";
            cleanRulesButton.UseVisualStyleBackColor = true;
            cleanRulesButton.Click += cleanRulesButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(startButton);
            groupBox2.Controls.Add(stopButton);
            groupBox2.Location = new Point(12, 429);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 87);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 550);
            Controls.Add(groupBox2);
            Controls.Add(debugBox);
            Controls.Add(groupBox1);
            Controls.Add(listBoxIED);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Módulo 4 - Filtragem de Parâmetros, v1.1";
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button startButton;
        private Button addRuleButton;
        private ComboBox selectN;
        private ComboBox selectOp;
        private NumericUpDown numValor;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private Button stopButton;
        private ListBox listBoxIED;
        private TextBox debugBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView listViewRule;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button cleanRulesButton;
    }
}
