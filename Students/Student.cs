using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vosh_7
{
    [Serializable]
    public class Exam
    {
        public string subject;
        public int mark;
        public Exam()
        {
            subject = "";
            mark = 2;
        }
        public Exam(StreamReader sr)
        {
            string line = sr.ReadLine();
            string[] words = line.Split(' ');
            subject = words[0];
            mark = Int32.Parse(words[1]);
        }
        public Exam(Exam x)
        {
            subject = x.subject;
            mark = x.mark;
        }
        public override string ToString()
        {
            return subject + ' ' + mark + '\n';
        }
    }

    [Serializable]
    public class Session
    {
        public Exam[] exams;
        public Session()
        {
            exams = new Exam[5];
            for (int i = 0; i < 5; ++i)
                exams[i] = new Exam();
        }
        public Session(StreamReader sr)
        {
            exams = new Exam[5];
            for (int i = 0; i < 5; ++i)
                exams[i] = new Exam(sr);
        }
        public Session(Session x)
        {
            exams = new Exam[5];
            for (int i = 0; i < 5; ++i)
                exams[i] = new Exam(x.exams[i]);
        }
        public override string ToString()
        {
            string result = "";
            for(int i = 0; i < 5; ++i)
                result += exams[i];
            return result;
        }
    }

    [Serializable]
    public class Student
    {
        public string FIO;
        public int course, group;
        public bool form;
        public Session[] sessions;
        public Student()
        {
            FIO = "";
            course = 1;
            group = 0;
            form = false;
            sessions = new Session[8];
            for(int i = 0; i < 8; ++i)
                sessions[i] = new Session();
        }
        public Student(StreamReader sr)
        {
            FIO = sr.ReadLine().Trim();
            string line = sr.ReadLine();
            string[] words = line.Split(' ');
            course = Int32.Parse(words[0]);
            group = Int32.Parse(words[1]);
            form = bool.Parse(sr.ReadLine());
            sessions = new Session[8];
            for (int i = 0; i < 8; ++i)
                if (i < 2 * course)
                    sessions[i] = new Session(sr);
                else
                    sessions[i] = new Session();
        }
        public Student(Student x)
        {
            FIO = x.FIO;
            course = x.course;
            group = x.group;
            form = x.form;
            sessions = new Session[8];
            for (int i = 0; i < 8; ++i)
                sessions[i] = new Session(x.sessions[i]);
        }
        public string Title()
        {
            return FIO + " (" + course + " курс, " + group + " группа)";
        }
        public bool Check()
        {
            if (String.IsNullOrEmpty(FIO))
                return false;
            if (group <= 0)
                return false;
            for (int i = 0; i < 2 * course; ++i)
                for (int j = 0; j < 5; ++j)
                    if (String.IsNullOrEmpty(sessions[i].exams[j].subject))
                        return false;
            return true;
        }
        public override string ToString()
        {
            string result = FIO + '\n' + course + ' ' + group + '\n' + form + '\n';
            for (int i = 0; i < 2 * course; ++i)
                    result += sessions[i];
            return result;
        }
    }
}