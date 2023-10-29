using SallesWeb.Data;
using SallesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWeb.Services
{
    public class DepartmentService
    {

        private readonly SallesWebContext _context;


        public DepartmentService(SallesWebContext context)
        {
            _context = context;
        }


        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
