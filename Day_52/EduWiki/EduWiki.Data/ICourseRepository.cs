using EduWiki.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EduWiki.Data
{
    public interface ICourseRepository
    {
        void SetModifiedState(Course entity);
    }
}
