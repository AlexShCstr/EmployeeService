namespace EmployeeService.Migrations
{
    using EmployeeService.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeService.Data.EmployeeServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeService.Data.EmployeeServiceContext context)
        {
            context.Departments.AddOrUpdate(x => x.ID,
                new Department() { ID = 1, NAME = "�����������" },
                new Department() { ID = 2, NAME = "�����" },
                new Department() { ID = 3, NAME = "�����" },
                new Department() { ID = 4, NAME = "�����" }
                );
            context.Employees.AddOrUpdate(x => x.ID,
                new Employee() { FIRSTNAME = "����", LASTNAME = "������", Midllename = "��������", DepartmentId = 1 },
                new Employee() { FIRSTNAME = "����", LASTNAME = "������", Midllename = "��������", DepartmentId = 2 },
                new Employee() { FIRSTNAME = "ϸ��", LASTNAME = "������", Midllename = "���������", DepartmentId = 3 },
                new Employee() { FIRSTNAME = "������", LASTNAME = "������", Midllename = "���������", DepartmentId = 4 },
                new Employee() { FIRSTNAME = "������", LASTNAME = "�������", Midllename = "���������", DepartmentId = 1 },
               new Employee() { FIRSTNAME = "�����", LASTNAME = "�������", Midllename = "��������", DepartmentId = 2 }
                );
        }
    }
}
