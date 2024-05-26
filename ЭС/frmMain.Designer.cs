namespace ЭС
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консультацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цельToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.объяснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.editControl = new System.Windows.Forms.TabControl();
            this.editДомены = new System.Windows.Forms.TabPage();
            this.editПеременные = new System.Windows.Forms.TabPage();
            this.editПравила = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.editControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.консультацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Enabled = false;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Enabled = false;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // консультацияToolStripMenuItem
            // 
            this.консультацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цельToolStripMenuItem1,
            this.пускToolStripMenuItem1,
            this.объяснениеToolStripMenuItem});
            this.консультацияToolStripMenuItem.Enabled = false;
            this.консультацияToolStripMenuItem.Name = "консультацияToolStripMenuItem";
            this.консультацияToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.консультацияToolStripMenuItem.Text = "Консультация";
            // 
            // цельToolStripMenuItem1
            // 
            this.цельToolStripMenuItem1.Enabled = false;
            this.цельToolStripMenuItem1.Name = "цельToolStripMenuItem1";
            this.цельToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.цельToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.цельToolStripMenuItem1.Text = "Цель";
            this.цельToolStripMenuItem1.Click += new System.EventHandler(this.цельToolStripMenuItem1_Click);
            // 
            // пускToolStripMenuItem1
            // 
            this.пускToolStripMenuItem1.Enabled = false;
            this.пускToolStripMenuItem1.Name = "пускToolStripMenuItem1";
            this.пускToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.пускToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.пускToolStripMenuItem1.Text = "Пуск";
            this.пускToolStripMenuItem1.Click += new System.EventHandler(this.пускToolStripMenuItem1_Click);
            // 
            // объяснениеToolStripMenuItem
            // 
            this.объяснениеToolStripMenuItem.Enabled = false;
            this.объяснениеToolStripMenuItem.Name = "объяснениеToolStripMenuItem";
            this.объяснениеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.объяснениеToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.объяснениеToolStripMenuItem.Text = "Объяснение";
            this.объяснениеToolStripMenuItem.Click += new System.EventHandler(this.объяснениеToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.es";
            this.saveFileDialog1.Filter = "Файлы экспертной системы|*.es|Все файлы|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.es";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файлы экспертной системы|*.es|Все файлы|*.*";
            // 
            // editControl
            // 
            this.editControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editControl.Controls.Add(this.editДомены);
            this.editControl.Controls.Add(this.editПеременные);
            this.editControl.Controls.Add(this.editПравила);
            this.editControl.Location = new System.Drawing.Point(0, 28);
            this.editControl.Name = "editControl";
            this.editControl.SelectedIndex = 0;
            this.editControl.Size = new System.Drawing.Size(804, 572);
            this.editControl.TabIndex = 1;
            this.editControl.Visible = false;
            // 
            // editДомены
            // 
            this.editДомены.Location = new System.Drawing.Point(4, 22);
            this.editДомены.Name = "editДомены";
            this.editДомены.Padding = new System.Windows.Forms.Padding(3);
            this.editДомены.Size = new System.Drawing.Size(796, 546);
            this.editДомены.TabIndex = 0;
            this.editДомены.Text = "Домены";
            this.editДомены.UseVisualStyleBackColor = true;
            // 
            // editПеременные
            // 
            this.editПеременные.Location = new System.Drawing.Point(4, 22);
            this.editПеременные.Name = "editПеременные";
            this.editПеременные.Padding = new System.Windows.Forms.Padding(3);
            this.editПеременные.Size = new System.Drawing.Size(796, 546);
            this.editПеременные.TabIndex = 1;
            this.editПеременные.Text = "Переменные";
            this.editПеременные.UseVisualStyleBackColor = true;
            // 
            // editПравила
            // 
            this.editПравила.Location = new System.Drawing.Point(4, 22);
            this.editПравила.Name = "editПравила";
            this.editПравила.Size = new System.Drawing.Size(796, 546);
            this.editПравила.TabIndex = 2;
            this.editПравила.Text = "Правила";
            this.editПравила.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 600);
            this.Controls.Add(this.editControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(820, 639);
            this.MinimumSize = new System.Drawing.Size(820, 639);
            this.Name = "frmMain";
            this.Text = "Экспертная система";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.editControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem консультацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цельToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem объяснениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.TabControl editControl;
        private System.Windows.Forms.TabPage editДомены;
        private System.Windows.Forms.TabPage editПеременные;
        private System.Windows.Forms.TabPage editПравила;
    }
}

