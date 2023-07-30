﻿namespace GraduationProjectAPI.Model
{
    public class Test
    {
        public int Id { set; get; }
        public string test { set; get; }
        public int IdContent { set; get; }
        public int IdAdmin { set; get; }
        public virtual Content? Content { set; get; }
        public virtual ICollection<Answer>? Answer { set; get; }
    }
}
