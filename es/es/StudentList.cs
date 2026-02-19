using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace es
{
    public class StudentList
    {
        public Node Header { get; private set; }
        public Node Tail { get; private set; }

        public StudentList()
        {
            Header = null;
            Tail = null;
        }

        public void Insert(Student student)
        {
            Node newNode = new Node(student);

            if (Header == null)
            {
                Header = newNode;
                Tail = newNode;
                return;
            }

            // Insert sorted by CodiceIdentificativo
            Node current = Header;
            while (current != null && string.Compare(current.Data.CodiceIdentificativo, student.CodiceIdentificativo) < 0)
            {
                current = current.NextNodePtr;
            }

            if (current == Header) // Insert at front
            {
                newNode.NextNodePtr = Header;
                Header.PrevNodePtr = newNode;
                Header = newNode;
            }
            else if (current == null) // Insert at end
            {
                newNode.PrevNodePtr = Tail;
                Tail.NextNodePtr = newNode;
                Tail = newNode;
            }
            else // Insert in middle
            {
                newNode.NextNodePtr = current;
                newNode.PrevNodePtr = current.PrevNodePtr;
                current.PrevNodePtr.NextNodePtr = newNode;
                current.PrevNodePtr = newNode;
            }
        }

        public Student Search(string id)
        {
            Node current = Header;
            while (current != null)
            {
                if (current.Data.CodiceIdentificativo == id)
                    return current.Data;
                current = current.NextNodePtr;
            }
            return null;
        }

        public bool Remove(string id)
        {
            Node current = Header;
            while (current != null)
            {
                if (current.Data.CodiceIdentificativo == id)
                {
                    if (current == Header && current == Tail)
                    {
                        Header = null;
                        Tail = null;
                    }
                    else if (current == Header)
                    {
                        Header = current.NextNodePtr;
                        Header.PrevNodePtr = null;
                    }
                    else if (current == Tail)
                    {
                        Tail = current.PrevNodePtr;
                        Tail.NextNodePtr = null;
                    }
                    else
                    {
                        current.PrevNodePtr.NextNodePtr = current.NextNodePtr;
                        current.NextNodePtr.PrevNodePtr = current.PrevNodePtr;
                    }
                    return true;
                }
                current = current.NextNodePtr;
            }
            return false;
        }

        public bool Update(string id, Student newData)
        {
            Node current = Header;
            while (current != null)
            {
                if (current.Data.CodiceIdentificativo == id)
                {
                    if (id != newData.CodiceIdentificativo)
                    {
                        Remove(id);
                        Insert(newData);
                    }
                    else
                    {
                        current.Data.Nome = newData.Nome;
                        current.Data.Cognome = newData.Cognome;
                        current.Data.Classe = newData.Classe;
                    }
                    return true;
                }
                current = current.NextNodePtr;
            }
            return false;
        }

        public List<Student> GetAllAscending()
        {
            List<Student> list = new List<Student>();
            Node current = Header;
            while (current != null)
            {
                list.Add(current.Data);
                current = current.NextNodePtr;
            }
            return list;
        }

        public List<Student> GetAllDescending()
        {
            List<Student> list = new List<Student>();
            Node current = Tail;
            while (current != null)
            {
                list.Add(current.Data);
                current = current.PrevNodePtr;
            }
            return list;
        }

        public void SaveToFile(string filename)
        {
            try
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string json = serializer.Serialize(GetAllAscending());
                File.WriteAllText(filename, json);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error saving: " + ex.Message);
            }
        }

        public void LoadFromFile(string filename)
        {
            if (!File.Exists(filename)) return;

            try
            {
                string json = File.ReadAllText(filename);
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                List<Student> students = serializer.Deserialize<List<Student>>(json);
                
                Header = null;
                Tail = null;
                if (students != null)
                {
                    foreach (var s in students)
                    {
                        Insert(s);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error loading: " + ex.Message);
            }
        }
    }
}