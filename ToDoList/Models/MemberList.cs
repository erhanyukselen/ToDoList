using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class MemberList
    {
        public List<Member> all = new List<Member>();

        public MemberList()
        {
            all.Add(new Member(1, "Erhan Ali Yükselen"));
            all.Add(new Member(2, "Ayberk Kalyoncu"));
            all.Add(new Member(3, "Faruk Erol"));
            all.Add(new Member(4, "Fikri Sınar"));
        }

    }
}