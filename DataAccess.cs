using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabLinq22.Models;

// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.Design
// Install-Package Microsoft.EntityFrameworkCore.Tools
// Scaffold-DbContext "Data Source=magister-v;Initial Catalog=Faculty_UA_22;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -Context FacultyContext -OutputDir Models

namespace LabLinq22
{
    internal class DataAccess
    {
        public FacultyContext context = new FacultyContext();

    }
}
