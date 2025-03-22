using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities;

public class Blog : BaseEntity<long>
{
    public Blog()
    {
        Title = string.Empty;
        Content = string.Empty;
        Comments = [];
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public List<Comment> Comments { get; set; }
}
