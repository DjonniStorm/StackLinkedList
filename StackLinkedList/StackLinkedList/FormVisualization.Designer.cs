namespace StackLinkedList
{
    partial class FormVisualization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualization));
            pictureBox = new PictureBox();
            menuStrip = new MenuStrip();
            ToolStripMenuItem = new ToolStripMenuItem();
            InfoToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            LoadToolStripMenuItem = new ToolStripMenuItem();
            labelOperationName = new Label();
            labelValue = new Label();
            labelTools = new Label();
            buttonPush = new Button();
            buttonPop = new Button();
            buttonPeek = new Button();
            buttonIsEmpty = new Button();
            buttonStepForward = new Button();
            buttonStepBack = new Button();
            panelTools = new Panel();
            labelStepWork = new Label();
            labelOperation = new Label();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip.SuspendLayout();
            panelTools.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 31);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(654, 419);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 31);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { InfoToolStripMenuItem, saveToolStripMenuItem, LoadToolStripMenuItem });
            ToolStripMenuItem.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(68, 27);
            ToolStripMenuItem.Text = "Меню";
            // 
            // InfoToolStripMenuItem
            // 
            InfoToolStripMenuItem.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            InfoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Q";
            InfoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            InfoToolStripMenuItem.Size = new Size(220, 24);
            InfoToolStripMenuItem.Text = "Информация";
            InfoToolStripMenuItem.ToolTipText = "Информация о работе и об АТД\r\n";
            InfoToolStripMenuItem.Click += InfoMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(220, 24);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.ToolTipText = "Сохранить текущее состояние работы в .txt файл";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // LoadToolStripMenuItem
            // 
            LoadToolStripMenuItem.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            LoadToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + L";
            LoadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            LoadToolStripMenuItem.Size = new Size(220, 24);
            LoadToolStripMenuItem.Text = "Загрузить";
            LoadToolStripMenuItem.ToolTipText = "Загрузить состояние работы из файла";
            LoadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // labelOperationName
            // 
            labelOperationName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelOperationName.AutoSize = true;
            labelOperationName.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelOperationName.Location = new Point(536, 36);
            labelOperationName.Name = "labelOperationName";
            labelOperationName.Size = new Size(15, 23);
            labelOperationName.TabIndex = 3;
            labelOperationName.Text = " ";
            // 
            // labelValue
            // 
            labelValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelValue.AutoSize = true;
            labelValue.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelValue.Location = new Point(388, 59);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(17, 22);
            labelValue.TabIndex = 4;
            labelValue.Text = " ";
            // 
            // labelTools
            // 
            labelTools.AutoSize = true;
            labelTools.Font = new Font("Comic Sans MS", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTools.Location = new Point(6, 5);
            labelTools.Name = "labelTools";
            labelTools.Size = new Size(130, 25);
            labelTools.TabIndex = 0;
            labelTools.Text = "Инструменты:";
            // 
            // buttonPush
            // 
            buttonPush.BackColor = Color.PaleTurquoise;
            buttonPush.FlatStyle = FlatStyle.Popup;
            buttonPush.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonPush.Location = new Point(3, 80);
            buttonPush.Name = "buttonPush";
            buttonPush.Size = new Size(140, 31);
            buttonPush.TabIndex = 1;
            buttonPush.Text = "Push";
            buttonPush.UseVisualStyleBackColor = false;
            buttonPush.Click += ButtonPush_Click;
            // 
            // buttonPop
            // 
            buttonPop.BackColor = Color.PaleTurquoise;
            buttonPop.FlatStyle = FlatStyle.Popup;
            buttonPop.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonPop.Location = new Point(3, 117);
            buttonPop.Name = "buttonPop";
            buttonPop.Size = new Size(140, 31);
            buttonPop.TabIndex = 2;
            buttonPop.Text = "Pop";
            buttonPop.UseVisualStyleBackColor = false;
            buttonPop.Click += ButtonPop_Click;
            // 
            // buttonPeek
            // 
            buttonPeek.BackColor = Color.PaleTurquoise;
            buttonPeek.FlatStyle = FlatStyle.Popup;
            buttonPeek.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonPeek.Location = new Point(3, 154);
            buttonPeek.Name = "buttonPeek";
            buttonPeek.Size = new Size(140, 31);
            buttonPeek.TabIndex = 3;
            buttonPeek.Text = "Peek";
            buttonPeek.UseVisualStyleBackColor = false;
            buttonPeek.Click += ButtonPeek_Click;
            // 
            // buttonIsEmpty
            // 
            buttonIsEmpty.BackColor = Color.PaleTurquoise;
            buttonIsEmpty.FlatStyle = FlatStyle.Popup;
            buttonIsEmpty.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonIsEmpty.Location = new Point(3, 191);
            buttonIsEmpty.Name = "buttonIsEmpty";
            buttonIsEmpty.Size = new Size(140, 31);
            buttonIsEmpty.TabIndex = 5;
            buttonIsEmpty.Text = "IsEmpty";
            buttonIsEmpty.UseVisualStyleBackColor = false;
            buttonIsEmpty.Click += ButtonIsEmpty_Click;
            // 
            // buttonStepForward
            // 
            buttonStepForward.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonStepForward.BackgroundImage = Properties.Resources.Arrow_Up;
            buttonStepForward.BackgroundImageLayout = ImageLayout.Zoom;
            buttonStepForward.FlatStyle = FlatStyle.Flat;
            buttonStepForward.Location = new Point(40, 268);
            buttonStepForward.Name = "buttonStepForward";
            buttonStepForward.Size = new Size(73, 67);
            buttonStepForward.TabIndex = 6;
            buttonStepForward.UseVisualStyleBackColor = true;
            buttonStepForward.Click += ButtonStepForward_Click;
            // 
            // buttonStepBack
            // 
            buttonStepBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonStepBack.BackgroundImage = Properties.Resources.Arrow_Down;
            buttonStepBack.BackgroundImageLayout = ImageLayout.Zoom;
            buttonStepBack.FlatStyle = FlatStyle.Flat;
            buttonStepBack.Location = new Point(40, 341);
            buttonStepBack.Name = "buttonStepBack";
            buttonStepBack.Size = new Size(73, 67);
            buttonStepBack.TabIndex = 7;
            buttonStepBack.UseVisualStyleBackColor = true;
            buttonStepBack.Click += ButtonStepBack_Click;
            // 
            // panelTools
            // 
            panelTools.BackColor = Color.PowderBlue;
            panelTools.Controls.Add(labelStepWork);
            panelTools.Controls.Add(buttonStepBack);
            panelTools.Controls.Add(buttonStepForward);
            panelTools.Controls.Add(buttonIsEmpty);
            panelTools.Controls.Add(buttonPeek);
            panelTools.Controls.Add(buttonPop);
            panelTools.Controls.Add(buttonPush);
            panelTools.Controls.Add(labelTools);
            panelTools.Dock = DockStyle.Right;
            panelTools.Location = new Point(654, 31);
            panelTools.Name = "panelTools";
            panelTools.Size = new Size(146, 419);
            panelTools.TabIndex = 0;
            panelTools.Tag = "";
            // 
            // labelStepWork
            // 
            labelStepWork.AutoSize = true;
            labelStepWork.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelStepWork.Location = new Point(21, 242);
            labelStepWork.Name = "labelStepWork";
            labelStepWork.Size = new Size(115, 23);
            labelStepWork.TabIndex = 8;
            labelStepWork.Text = "Шаг работы:";
            // 
            // labelOperation
            // 
            labelOperation.AutoSize = true;
            labelOperation.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelOperation.Location = new Point(352, 36);
            labelOperation.Name = "labelOperation";
            labelOperation.Size = new Size(164, 23);
            labelOperation.TabIndex = 5;
            labelOperation.Text = "Текущая операция:";
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "stackData";
            saveFileDialog.Filter = "txt file | * .txt";
            saveFileDialog.Title = "Сохранение";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "stackData";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            // 
            // FormVisualization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(labelOperation);
            Controls.Add(labelValue);
            Controls.Add(labelOperationName);
            Controls.Add(pictureBox);
            Controls.Add(panelTools);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(796, 486);
            Name = "FormVisualization";
            Text = "Стек на односвязном списке";
            KeyDown += FormKeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panelTools.ResumeLayout(false);
            panelTools.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem InfoToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private Label labelOperationName;
        private Label labelValue;
        private Label labelTools;
        private Button buttonPush;
        private Button buttonPop;
        private Button buttonPeek;
        private Button buttonIsEmpty;
        private Button buttonStepForward;
        private Button buttonStepBack;
        private Panel panelTools;
        private Label labelStepWork;
        private Label labelOperation;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
    }
}