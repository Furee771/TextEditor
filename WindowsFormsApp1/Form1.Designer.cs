namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьCtrlcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постановкиЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.граматикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диагностикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.листингToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЛитературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.пускToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьCtrlcToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.ввыToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.правкаToolStripMenuItem.Text = "правка";
            // 
            // пускToolStripMenuItem
            // 
            this.пускToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.содержаниеToolStripMenuItem,
            this.постановкиЗадачиToolStripMenuItem,
            this.граматикаToolStripMenuItem,
            this.классивToolStripMenuItem,
            this.диагностикаToolStripMenuItem,
            this.алгоритомToolStripMenuItem,
            this.листингToolStripMenuItem,
            this.списокЛитературыToolStripMenuItem});
            this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            this.пускToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.пускToolStripMenuItem.Text = "текст";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.справкаToolStripMenuItem.Text = "пуск";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(800, 208);
            this.textBox1.TabIndex = 1;
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.создатьToolStripMenuItem.Text = "cоздать     Ctrl+N";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.открытьToolStripMenuItem.Text = "открыть     Ctrl+O";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.закрытьToolStripMenuItem.Text = " закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.сохранитьToolStripMenuItem.Text = "сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.сохранитьКакToolStripMenuItem.Text = "сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.выходToolStripMenuItem.Text = "выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // копироватьCtrlcToolStripMenuItem
            // 
            this.копироватьCtrlcToolStripMenuItem.Name = "копироватьCtrlcToolStripMenuItem";
            this.копироватьCtrlcToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.копироватьCtrlcToolStripMenuItem.Text = "копировать  Ctrl+C";
            this.копироватьCtrlcToolStripMenuItem.Click += new System.EventHandler(this.копироватьCtrlcToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.вставитьToolStripMenuItem.Text = "вставить  Ctrl+V";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // ввыToolStripMenuItem
            // 
            this.ввыToolStripMenuItem.Name = "ввыToolStripMenuItem";
            this.ввыToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ввыToolStripMenuItem.Text = " выразить Ctrl+X";
            this.ввыToolStripMenuItem.Click += new System.EventHandler(this.ввыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.справкаToolStripMenuItem1.Text = "справка";
            // 
            // содержаниеToolStripMenuItem
            // 
            this.содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
            this.содержаниеToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.содержаниеToolStripMenuItem.Text = "содержание";
            // 
            // постановкиЗадачиToolStripMenuItem
            // 
            this.постановкиЗадачиToolStripMenuItem.Name = "постановкиЗадачиToolStripMenuItem";
            this.постановкиЗадачиToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.постановкиЗадачиToolStripMenuItem.Text = "постановки задачи";
            // 
            // граматикаToolStripMenuItem
            // 
            this.граматикаToolStripMenuItem.Name = "граматикаToolStripMenuItem";
            this.граматикаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.граматикаToolStripMenuItem.Text = "граматика";
            // 
            // классивToolStripMenuItem
            // 
            this.классивToolStripMenuItem.Name = "классивToolStripMenuItem";
            this.классивToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.классивToolStripMenuItem.Text = "классификация";
            // 
            // диагностикаToolStripMenuItem
            // 
            this.диагностикаToolStripMenuItem.Name = "диагностикаToolStripMenuItem";
            this.диагностикаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.диагностикаToolStripMenuItem.Text = "диагностика";
            // 
            // алгоритомToolStripMenuItem
            // 
            this.алгоритомToolStripMenuItem.Name = "алгоритомToolStripMenuItem";
            this.алгоритомToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.алгоритомToolStripMenuItem.Text = "алгоритм анализа";
            // 
            // листингToolStripMenuItem
            // 
            this.листингToolStripMenuItem.Name = "листингToolStripMenuItem";
            this.листингToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.листингToolStripMenuItem.Text = "листинг";
            // 
            // списокЛитературыToolStripMenuItem
            // 
            this.списокЛитературыToolStripMenuItem.Name = "списокЛитературыToolStripMenuItem";
            this.списокЛитературыToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.списокЛитературыToolStripMenuItem.Text = "список литературы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Обработчик";
            // 
            // button2
            // 
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.Снимок2;
            this.button2.Location = new System.Drawing.Point(428, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.Снимок;
            this.button1.Location = new System.Drawing.Point(398, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Текстоваый редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьCtrlcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввыToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem содержаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постановкиЗадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem граматикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диагностикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem листингToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЛитературыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

