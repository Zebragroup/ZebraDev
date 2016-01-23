using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZebraModelLayer.Model;
using ZebraModelLayer.DAL;

namespace ZebraDevWeb.Helper
{
    interface IDepartmentClient
    {
        void Add(Department t);
        IEnumerable<Department> GetDepartments();
        Department GetDepartmentsById(int id);
        void Delete(int id);
        void Update(int id);

    }
}
