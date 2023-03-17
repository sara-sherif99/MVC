using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tickets.DAL.Models;

namespace Tickets.DAL.Context
{
    public class TicketsContext: DbContext
    {
        public DbSet<Ticket> Tickets => Set<Ticket>();
        public DbSet<Developer> Developers => Set<Developer>();
        public DbSet<Department> Departments => Set<Department>();
        public TicketsContext(DbContextOptions<TicketsContext> options)
        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region 
            var tickets = JsonSerializer.Deserialize<List<Ticket>>("""[{"Id":1,"Title":"in","Description":"Harum hic impedit dolore voluptate placeat.","Severity":1,"DeptId":"8c975e5d-6ec1-4930-8d46-f3ddd2ee076b"},{"Id":2,"Title":"id","Description":"Rerum totam est quo possimus sunt sunt ad.","Severity":0,"DeptId":"8c975e5d-6ec1-4930-8d46-f3ddd2ee076b"},{"Id":3,"Title":"dicta","Description":"Id cumque explicabo beatae.","Severity":1,"DeptId":"b3617127-2b58-438b-b5cc-ac3c3d9e5a21"},{"Id":4,"Title":"eius","Description":"Consectetur beatae dolorem voluptates occaecati.","Severity":0,"DeptId":"8c975e5d-6ec1-4930-8d46-f3ddd2ee076b"},{"Id":5,"Title":"assumenda","Description":"Nulla est doloribus ut non aspernatur vero dolores.","Severity":2,"DeptId":"8c975e5d-6ec1-4930-8d46-f3ddd2ee076b"}]""") ?? new();
            var developers = JsonSerializer.Deserialize<List<Developer>>("""[{"Id":"0b731ee0-a2a0-4120-8211-76b161f64535","FirstName":"Freddie","LastName":"Johnson"},{"Id":"6001109e-314f-46dd-be5c-9703a1a4fb51","FirstName":"Sophia","LastName":"O\u0027Keefe"},{"Id":"dd56d068-ef7b-4226-91eb-35fb10aa2d6d","FirstName":"Angela","LastName":"McClure"},{"Id":"1c1bf402-5fe3-497a-9c57-475ff7ce1487","FirstName":"Jamie","LastName":"Berge"},{"Id":"d9d44861-081b-4c33-a415-c3146b38aa5d","FirstName":"Geoffrey","LastName":"Abbott"}]""") ?? new();
            var departments = JsonSerializer.Deserialize<List<Department>>("""[{"Id":"b3617127-2b58-438b-b5cc-ac3c3d9e5a21","Name":"Automotive \u0026 Baby"},{"Id":"5346da07-28c3-452a-815b-7b2731ff6146","Name":"Beauty \u0026 Health"},{"Id":"8c975e5d-6ec1-4930-8d46-f3ddd2ee076b","Name":"Electronics"}]""") ?? new();

            #endregion

            modelBuilder.Entity<Developer>().HasData(developers);
            modelBuilder.Entity<Department>().HasData(departments);
            modelBuilder.Entity<Ticket>().HasData(tickets);
        }


    }
}
