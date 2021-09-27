﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EduWiki.Services.Models
{
    public enum Status
    {
        NotFound = 404,
        AlreadyExists = 409,
        InternalServerError = 500,
        Success = 200
    }
}
