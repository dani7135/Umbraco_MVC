using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary2
{
    class ApiContext :DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    }
}
