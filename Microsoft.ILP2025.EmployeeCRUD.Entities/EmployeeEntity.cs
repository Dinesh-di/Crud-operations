﻿namespace Microsoft.ILP2025.EmployeeCRUD.Entities
{
    public class EmployeeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // New properties
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
    
    }
}


