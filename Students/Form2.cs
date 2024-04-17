using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vosh_7
{
    public partial class Form2 : Form
    {
        public Student student;
        TextBox[] textBoxSubjects;
        ComboBox[] comboBoxMarks;
        public Form2()
        {
            student = new Student();
            InitializeComponent();
        }
        public Form2(Student x)
        {
            student = new Student(x);
            InitializeComponent();
        }
        //при загрузке отображаем поля локального student
        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxSubjects = new TextBox[] { textBoxSubject1, textBoxSubject2, textBoxSubject3, textBoxSubject4, textBoxSubject5 };
            comboBoxMarks = new ComboBox[] { comboBoxMark1, comboBoxMark2, comboBoxMark3, comboBoxMark4, comboBoxMark5 };

            textBoxFIO.Text = student.FIO;
            comboBoxCourse.SelectedIndex = student.course - 1;
            textBoxGroup.Text = student.group.ToString();
            comboBoxForm.SelectedIndex = student.form ? 1 : 0;
            comboBoxSessions.SelectedIndex = 0;

            buttonOk.Enabled = student.Check();

            textBoxFIO.TextChanged += new EventHandler(textBoxFIO_TextChanged) + new EventHandler(check);
            comboBoxCourse.SelectedIndexChanged += new EventHandler(check);
            textBoxGroup.TextChanged += new EventHandler(this.textBoxGroup_TextChanged) + new EventHandler(check);
            comboBoxForm.SelectedIndexChanged += new EventHandler(this.comboBoxForm_SelectedIndexChanged);
            for(int i = 0; i < 5; ++i)
            {
                textBoxSubjects[i].TextChanged += new EventHandler(this.textBoxSubject_TextChanged) + new EventHandler(check);
                comboBoxMarks[i].SelectedIndexChanged += new EventHandler(this.comboBoxMark_SelectedIndexChanged);
            }
        }
        //для контроля активации и деактивации кнопки Ok
        private void check(object sender, EventArgs e)
        {
            buttonOk.Enabled = student.Check();
        }
        //для выбора сессии
        private void comboBoxSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBoxSessions.SelectedIndex;
            if (i != -1)
            {
                for (int j = 0; j < 5; ++j)
                {
                    textBoxSubjects[j].Text = student.sessions[i].exams[j].subject;
                    comboBoxMarks[j].SelectedIndex = student.sessions[i].exams[j].mark - 2;
                }
                panelSession.Enabled = true;
            }
            else
            {
                for (int j = 0; j < 5; ++j)
                {
                    textBoxSubjects[j].Clear();
                    comboBoxMarks[j].SelectedIndex = -1;
                }
                panelSession.Enabled = false;
            }
        }
        //изменение названия предмета
        private void textBoxSubject_TextChanged(object sender, EventArgs e)
        {
            TextBox tmp = (TextBox)sender;
            student.sessions[comboBoxSessions.SelectedIndex].exams[tmp.Name.Last() - '1'].subject = tmp.Text.Trim();
        }
        //изменение оценки
        private void comboBoxMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox tmp = (ComboBox)sender;
            int i = tmp.Name.Last() - '1';
            student.sessions[comboBoxSessions.SelectedIndex].exams[i].mark = tmp.SelectedIndex + 2;
        }
        //изменение формы обучения
        private void comboBoxForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            student.form = comboBoxForm.SelectedIndex != 0;
        }
        //изменение группы
        private void textBoxGroup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                student.group = Int32.Parse(textBoxGroup.Text);
            }
            catch
            {
                student.group = 0;
            }
        }
        //изменение курса
        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            student.course = comboBoxCourse.SelectedIndex + 1;
            comboBoxSessions.Items.Clear();
            for (int i = 0; i < 2 * student.course; ++i)
                comboBoxSessions.Items.Add("Сессия №" + (i + 1));
            comboBoxSessions.SelectedIndex = 0;
        }
        //изменение ФИО
        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            student.FIO = textBoxFIO.Text.Trim();
        }
        //кнопка Ok
        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        //кнопка отмены
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}