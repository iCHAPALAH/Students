using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vosh_7
{
    public partial class Form1 : Form
    {
        private static readonly string programName = "Студент v0.5";
        private string fileName;
        private bool unsavedChanges;
        private ListOfStudents listOfStudents;
        public Form1()
        {
            fileName = "";
            Text = "Безымянный – " + programName;
            unsavedChanges = false;
            listOfStudents = new ListOfStudents();
            InitializeComponent();
        }
        //очистка формы
        void clearForm()
        {
            fileName = "";
            Text = "Безымянный – " + programName;
            unsavedChanges = false;
            listOfStudents.Clear();
            listBox1.ClearSelected();
            listBox1.Items.Clear();
        }
        //сохранение изменений при работе с сущействующим файлом
        private void save()
        {
            listOfStudents.Write(fileName);
            Text = Text.Substring(1);
            unsavedChanges = false;
        }
        //сохранить как
        private bool saveAs()
        {
            if (saveAsFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveAsFileDialog.FileName;
                Text = fileName.Substring(fileName.LastIndexOf('\\') + 1) + " – " + programName;
                File.Create(fileName).Close();
                listOfStudents.Write(fileName);
                return true;
            }
            return false;
        }
        //предупреждение о несохраненных изменениях
        private bool unsavedDialog()
        {
            if (unsavedChanges)
                switch (MessageBox.Show("Вы хотите сохранить изменения в файле \"" + Text.Split(' ')[0].Substring(1) + "\"?", programName, MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Cancel:
                        return false;
                    case DialogResult.Yes:
                        if (String.IsNullOrEmpty(fileName))
                            return saveAs();
                        save();
                        break;
                }
            return true;
        }
        //Создание файла
        private void сreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unsavedDialog() && createFileDialog.ShowDialog() == DialogResult.OK)
            {
                clearForm();
                fileName = createFileDialog.FileName;
                Text = fileName.Substring(fileName.LastIndexOf('\\') + 1) + " – " + programName;
                File.Create(fileName).Close();
            }
        }
        //открытие файла и считывание данных из него
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unsavedDialog() && openFileDialog.ShowDialog() == DialogResult.OK)
            {
                clearForm();
                fileName = openFileDialog.FileName;
                Text = fileName.Substring(fileName.LastIndexOf('\\') + 1) + " – " + programName;
                listOfStudents.Read(fileName);
                listOfStudents.Display(listBox1);
            }
        }
        //закрытие файла
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(unsavedDialog())
                clearForm();
        }
        //действия при закрытии формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!unsavedDialog())
                e.Cancel = true;
        }
        //действия при нажатии на кнопку сохранить
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fileName))
                saveAs();
            else if (unsavedChanges)
                save();
        }
        //действия при нажатии на кнопку сохранить как
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }
        //действия при изменении выбранного студента
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = deleteButton.Enabled = listBox1.SelectedIndex != -1;
        }
        //служебный метод для следующих трёх
        private void changes()
        {
            listBox1.ClearSelected();
            listBox1.Items.Clear();
            listOfStudents.Display(listBox1);
            unsavedChanges = true;
            if (Text[0] != '*')
                Text = "*" + Text;
        }
        //добавить студента
        private void addButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2() { Text = "Добавить" };
            if (form.ShowDialog() == DialogResult.OK)
            {
                listOfStudents.Add(form.student);
                changes();
            }
            form.Close();
        }
        //изменить студента
        private void editButton_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            Form2 form = new Form2(listOfStudents.students[i]) { Text = "Изменить" };
            if (form.ShowDialog() == DialogResult.OK)
            {
                listOfStudents.Edit(i, form.student);
                changes();
            }
            form.Close();
        }
        //удалить студента
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            listOfStudents.Remove(i);
            changes();
        }
        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listOfStudents.Count == 0)
                MessageBox.Show("Список студентов пуст", "Задание");
            else
            {
                string message = "";
                string[] subjects = listOfStudents.Task();
                for (int i = 0; i < 4; ++i)
                    message += (i + 1) + " курс: " + subjects[i];
                MessageBox.Show(message, "Задание");
            }
        }
    }
}