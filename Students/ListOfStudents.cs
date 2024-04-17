using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Vosh_7
{
    internal class ListOfStudents
    {
        public List<Student> students;
        public ListOfStudents()
        {
            students = new List<Student>();
        }
        public int Count
        { get { return students.Count; } }
        public void Clear()
        {
            students.Clear();
        }
        public void Add(Student student)
        {
            students.Add(student);
        }
        public void Remove(int i)
        {
            students.RemoveRange(i, 1);
        }
        public void Edit(int i, Student x)
        {
            students[i] = x;
        }
        public void Read(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            if (Path.GetExtension(fileName) == ".txt")
            {
                StreamReader sr = new StreamReader(fileName);
                while(!sr.EndOfStream)
                {
                    Student x = new Student(sr);
                    students.Add(x);
                }
                sr.Close();
            }
            else if (ext == ".bin")
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                students = (List<Student>)binaryFormatter.Deserialize(fs);
                fs.Close();
            }
            else if (ext == ".xml")
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                students = serializer.Deserialize(fs) as List<Student>;
                fs.Close();
            }
        }
        public void Write(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            if (Path.GetExtension(fileName) == ".txt")
            {
                StreamWriter sw = new StreamWriter(fileName);
                foreach (Student x in students)
                    sw.Write(x);
                sw.Close();
            }
            else if (ext == ".bin")
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, students);
                fs.Close();
            }
            else if (ext == ".xml")
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
                xmlSerializer.Serialize(fs, students);
                fs.Close();
            }
        }
        public string[] Task()
        {
            HashSet<string>[] subjects = new HashSet<string>[4];
            for (int i = 0; i < 4; ++i)
                subjects[i] = new HashSet<string>();
            foreach (Student i in students)
                for (int j = 0; j < 2 * i.course; ++j)
                    for (int k = 0; k < 5; ++k)
                        subjects[i.course - 1].Add(i.sessions[j].exams[k].subject);
            string[] result = new string[4];
            for (int i = 0; i < 4; ++i)
            {
                foreach (string j in subjects[i])
                    result[i] += j + ", ";
                if (subjects[i].Count != 0)
                    result[i] = result[i].Substring(0, result[i].Length - 2);
                result[i] += (i != 3 ? "\n" : "");
            }
            return result;
        }
        public void Display(ListBox lb)
        {
            students.Sort((x, y) => String.Compare(x.Title(), y.Title()));
            foreach (Student x in students)
                lb.Items.Add(x.Title());
        }
    }
}