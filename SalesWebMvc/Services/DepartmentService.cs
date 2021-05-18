using SalesWebMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {

        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Models.Department> FindAll() 
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
