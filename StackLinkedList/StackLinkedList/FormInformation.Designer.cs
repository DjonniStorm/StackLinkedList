namespace StackLinkedList
{
    partial class FormInformation
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformation));
            timer = new System.Windows.Forms.Timer(components);
            pictureBoxExampleVisualization = new PictureBox();
            labelName = new Label();
            richTextBoxInfo = new RichTextBox();
            listBoxOperations = new ListBox();
            labelOperation = new Label();
            labelNowOperation = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExampleVisualization).BeginInit();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            // 
            // pictureBoxExampleVisualization
            // 
            pictureBoxExampleVisualization.BackColor = Color.PowderBlue;
            pictureBoxExampleVisualization.Dock = DockStyle.Right;
            pictureBoxExampleVisualization.Location = new Point(435, 0);
            pictureBoxExampleVisualization.Name = "pictureBoxExampleVisualization";
            pictureBoxExampleVisualization.Size = new Size(313, 352);
            pictureBoxExampleVisualization.TabIndex = 0;
            pictureBoxExampleVisualization.TabStop = false;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Top;
            labelName.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(435, 42);
            labelName.TabIndex = 1;
            labelName.Text = "Stack";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBoxInfo
            // 
            richTextBoxInfo.BackColor = Color.PaleTurquoise;
            richTextBoxInfo.Dock = DockStyle.Top;
            richTextBoxInfo.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point);
            richTextBoxInfo.Location = new Point(0, 42);
            richTextBoxInfo.Name = "richTextBoxInfo";
            richTextBoxInfo.ReadOnly = true;
            richTextBoxInfo.ShortcutsEnabled = false;
            richTextBoxInfo.Size = new Size(435, 213);
            richTextBoxInfo.TabIndex = 2;
            richTextBoxInfo.TabStop = false;
            richTextBoxInfo.Text = resources.GetString("richTextBoxInfo.Text");
            // 
            // listBoxOperations
            // 
            listBoxOperations.BackColor = Color.PaleTurquoise;
            listBoxOperations.CausesValidation = false;
            listBoxOperations.Dock = DockStyle.Fill;
            listBoxOperations.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point);
            listBoxOperations.FormattingEnabled = true;
            listBoxOperations.ItemHeight = 23;
            listBoxOperations.Items.AddRange(new object[] { "Push - добавление элемента в стек ", "Pop - удаление элемента из стека", "IsEmpty - проверка, пустой ли стек", "Peek - просмотр вершины стека без удаления" });
            listBoxOperations.Location = new Point(0, 255);
            listBoxOperations.Name = "listBoxOperations";
            listBoxOperations.SelectionMode = SelectionMode.None;
            listBoxOperations.Size = new Size(435, 97);
            listBoxOperations.TabIndex = 3;
            listBoxOperations.TabStop = false;
            listBoxOperations.UseTabStops = false;
            // 
            // labelOperation
            // 
            labelOperation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelOperation.AutoSize = true;
            labelOperation.BackColor = Color.PowderBlue;
            labelOperation.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelOperation.Location = new Point(479, 9);
            labelOperation.Name = "labelOperation";
            labelOperation.Size = new Size(164, 23);
            labelOperation.TabIndex = 4;
            labelOperation.Text = "Текущая операция:";
            // 
            // labelNowOperation
            // 
            labelNowOperation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNowOperation.AutoSize = true;
            labelNowOperation.BackColor = Color.PowderBlue;
            labelNowOperation.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelNowOperation.Location = new Point(661, 9);
            labelNowOperation.Name = "labelNowOperation";
            labelNowOperation.Size = new Size(15, 23);
            labelNowOperation.TabIndex = 5;
            labelNowOperation.Text = " ";
            // 
            // FormInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(748, 352);
            Controls.Add(labelNowOperation);
            Controls.Add(labelOperation);
            Controls.Add(listBoxOperations);
            Controls.Add(richTextBoxInfo);
            Controls.Add(labelName);
            Controls.Add(pictureBoxExampleVisualization);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(750, 391);
            Name = "FormInformation";
            Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)pictureBoxExampleVisualization).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private PictureBox pictureBoxExampleVisualization;
        private Label labelName;
        private RichTextBox richTextBoxInfo;
        private ListBox listBoxOperations;
        private Label labelOperation;
        private Label labelNowOperation;
    }
}