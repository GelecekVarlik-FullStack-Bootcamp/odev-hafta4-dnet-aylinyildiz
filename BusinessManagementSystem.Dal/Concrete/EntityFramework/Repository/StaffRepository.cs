using BusinessManagementSystem.Dal.Abstract;
using BusinessManagementSystem.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Dal.Concrete.EntityFramework.Repository
{
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository
    {
        private readonly DbContext context;

        public StaffRepository(DbContext context) : base(context)
        {
            this.context = context;
        }

        public Staff GetById(int id)
        {
            return dbset.Where(x => x.Id == id).SingleOrDefault();
        }

        public Staff Login(Staff login)
        {
            var staff = dbset.Where(x => x.Email == login.Email && x.Password == login.Password).SingleOrDefault();

            return staff;
        }

        public Staff Register(Staff register)
        {
            var registerStaff = context.Add(register);
            context.SaveChanges();
            return registerStaff.Entity;
        }

    }
}
