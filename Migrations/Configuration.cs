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
                new Department() { ID = 1, NAME = "Бухгалтерия" },
                new Department() { ID = 2, NAME = "Склад" },
                new Department() { ID = 3, NAME = "Гараж" },
                new Department() { ID = 4, NAME = "Кадры" }
                );
            context.Employees.AddOrUpdate(x => x.ID,
                new Employee() { FIRSTNAME = "Иван", LASTNAME = "Иванов", Midllename = "Иванович", DepartmentId = 1 },
                new Employee() { FIRSTNAME = "Иван", LASTNAME = "Петров", Midllename = "Петрович", DepartmentId = 2 },
                new Employee() { FIRSTNAME = "Пётр", LASTNAME = "Иванов", Midllename = "Романовия", DepartmentId = 3 },
                new Employee() { FIRSTNAME = "Сергей", LASTNAME = "Иванов", Midllename = "Сергеевич", DepartmentId = 4 },
                new Employee() { FIRSTNAME = "Андрей", LASTNAME = "Андреев", Midllename = "Романович", DepartmentId = 1 },
               new Employee() { FIRSTNAME = "Игорь", LASTNAME = "Комаров", Midllename = "Иванович", DepartmentId = 2 }
                );
        }
    }
}
