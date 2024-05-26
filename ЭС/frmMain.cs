using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ЭС
{
    public partial class frmMain : Form
    {
        ExpertSystem tempES = null;
        string tempFile = "";
        /// <summary>
        /// Сохранена ли текущая система
        /// </summary>
        public bool saved = true;

        frmRules fr = null;
        frmDomains fd = null;
        frmVariables fv = null;

        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Создание новой ЭС
        /// </summary>
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (tempES != null)
                        FinishES();
                    tempES = new ExpertSystem();
                    tempFile = saveFileDialog1.FileName;
                    if (File.Exists(tempFile))
                        File.Delete(tempFile);
                    File.Create(tempFile);
                    StartES();
                    saved = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FinishES();
            }
        }


        /// <summary>
        /// Скрывает на форме возможность доступа к закрытой ЭС
        /// </summary>
        private void FinishES()
        {
            try
            {
                this.Text = "Экспертная система";
                консультацияToolStripMenuItem.Enabled = false;
                сохранитьToolStripMenuItem.Enabled = false;
                сохранитьКакToolStripMenuItem.Enabled = false;
                закрытьToolStripMenuItem.Enabled = false;
                пускToolStripMenuItem1.Enabled = false;
                цельToolStripMenuItem1.Enabled = false;
                объяснениеToolStripMenuItem.Enabled = false;
                editControl.Visible = false;

                if (fr != null) 
                {
                    fr.Close();
                    fd.Close();
                    fv.Close();
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Готовит форму к работе с загруженной ЭС
        /// </summary>
        private void StartES()
        {
            this.Text = "Экспертная система - " + tempFile.Substring(tempFile.LastIndexOf('\\') + 1);
            консультацияToolStripMenuItem.Enabled = true;
            сохранитьToolStripMenuItem.Enabled = true;
            сохранитьКакToolStripMenuItem.Enabled = true;
            закрытьToolStripMenuItem.Enabled = true;
            пускToolStripMenuItem1.Enabled = true;
            цельToolStripMenuItem1.Enabled = true;
            объяснениеToolStripMenuItem.Enabled = true;
            editControl.Visible = true;

            fr = new frmRules(tempES, editControl, this);
            fr.TopLevel = false;
            fr.Show();
            editПравила.Controls.Add(fr);

            fd = new frmDomains(tempES, editControl, this);
            fd.TopLevel = false;
            fd.Show();
            editДомены.Controls.Add(fd);

            fv = new frmVariables(tempES, editControl, this);
            fv.TopLevel = false;
            fv.Show();
            editПеременные.Controls.Add(fv);
        }

        /// <summary>
        /// Сохраняет экспертную систему в указанный файл
        /// </summary>
        /// <param name="file">Имя файла для сохранения</param>
        private void SaveES(string file)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenWrite(file);
                bf.Serialize(fs, tempES);
                fs.Close();
                MessageBox.Show("Экспертная система успешно сохранена!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Кнопка "Выход"
        /// </summary>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Кнопка "Сохранить"
        /// </summary>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveES(tempFile);
        }


        /// <summary>
        /// Кнопка "Открыть"
        /// </summary>
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (tempES != null)
                        FinishES();
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream fs = File.OpenRead(openFileDialog1.FileName);
                    tempES = (ExpertSystem)bf.Deserialize(fs);
                    fs.Close();
                    tempFile = openFileDialog1.FileName;
                    StartES();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FinishES();
            }
        }

        private void цельToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGoal fg = new frmGoal(tempES, this);
            fg.ShowDialog();
        }


        private void пускToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartConsult();
        }


        /// <summary>
        /// Запуск консультации
        /// </summary>
        public void StartConsult()
        {
            try
            {
                if (tempES.Goal != null)
                {
                    Fact f = tempES.GoConsult();
                    if (f.Truly == Rightly.Unknown)
                        MessageBox.Show("Не удалось установить истину!");
                    else
                        MessageBox.Show(f.ToString());
                }
            }
            catch (DomainException de)
            {
                MessageBox.Show("Не удалось сделать вывод! Причина: " + de.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка!" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void объяснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tempES.WorkedRules == null || tempES.WorkedRules.Count <= 0)
            {
                MessageBox.Show("Нет данных");
                return;
            }
            else
            {
                frmExplain fe = new frmExplain(tempES);
                fe.ShowDialog();
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempES = null;
            FinishES();
            saved = true;   
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                DialogResult dr = MessageBox.Show("Сохранить перед выходом?", "Выход", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dr)
                {
                    case DialogResult.Yes:
                        SaveES(tempFile);
                        goto case DialogResult.No;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break; ;
                }
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveES(saveFileDialog1.FileName);
                tempFile = saveFileDialog1.FileName;
                StartES();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }
    }
}
