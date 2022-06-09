using System;
using System.Collections.Generic;

namespace ChatBox.Model
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
