using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities;

public class Comment : BaseEntity<long>
{
    public Comment()
    {
        Content = string.Empty;
    }

    public string Content { get; set; }
    public long BlogId { get; set; }
    public long? ParentId { get; set; }
}
