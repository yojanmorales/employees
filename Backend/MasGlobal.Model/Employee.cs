﻿namespace MasGlobal.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public string RoleId { get; set; }

        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
    }
}
