using System;
using System.Collections.Generic;
using System.Text;

namespace EduWiki.Domain.Model
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
