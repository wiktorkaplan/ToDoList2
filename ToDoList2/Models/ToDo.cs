using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList2.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public bool IsDone { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}