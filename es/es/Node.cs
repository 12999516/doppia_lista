using System;

namespace es
{
    public class Node
    {
        public Student Data { get; set; }
        public Node PrevNodePtr { get; set; }
        public Node NextNodePtr { get; set; }

        public Node(Student student)
        {
            Data = student;
            PrevNodePtr = null;
            NextNodePtr = null;
        }
    }
}
