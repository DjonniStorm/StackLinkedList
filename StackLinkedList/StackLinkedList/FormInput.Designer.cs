namespace StackLinkedList
{
    partial class FormInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInput));
            numericUpDownInput = new NumericUpDown();
            labelAbout = new Label();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInput).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownInput
            // 
            numericUpDownInput.Anchor = AnchorStyles.Bottom;
            numericUpDownInput.BackColor = Color.PowderBlue;
            numericUpDownInput.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownInput.Location = new Point(12, 66);
            numericUpDownInput.Minimum = new decimal(new int[] { 99, 0, 0, int.MinValue });
            numericUpDownInput.Name = "numericUpDownInput";
            numericUpDownInput.Size = new Size(194, 30);
            numericUpDownInput.TabIndex = 0;
            numericUpDownInput.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // labelAbout
            // 
            labelAbout.Dock = DockStyle.Top;
            labelAbout.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAbout.Location = new Point(0, 0);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(218, 44);
            labelAbout.TabIndex = 1;
            labelAbout.Text = "Введите данные";
            labelAbout.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom;
            buttonAdd.BackColor = Color.PowderBlue;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAdd.Location = new Point(12, 111);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(194, 55);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Вставка нового элемента";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // FormInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(218, 168);
            Controls.Add(buttonAdd);
            Controls.Add(labelAbout);
            Controls.Add(numericUpDownInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(234, 207);
            Name = "FormInput";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ввод данных";
            ((System.ComponentModel.ISupportInitialize)numericUpDownInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numericUpDownInput;
        private Label labelAbout;
        private Button buttonAdd;
    }
}