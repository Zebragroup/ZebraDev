using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZebraModelLayer.Model;
namespace ZebraDevWeb.Helper
{
    public class DepartmentRestClient : IDepartmentClient
    {

        private DevContext db;
        public DepartmentRestClient()
        {
            db = db ?? new DevContext();
        }

        public void Add(ZebraModelLayer.Model.Department t)
        {
            db.Department.Attach(t);
        }

        public IEnumerable<ZebraModelLayer.Model.Department> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public ZebraModelLayer.Model.Department GetDepartmentsById(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}