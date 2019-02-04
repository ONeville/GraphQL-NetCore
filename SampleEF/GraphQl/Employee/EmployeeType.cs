using EFCoreCodeFirstSample.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alpha.GraphQl.Types
{
    public class EmployeeType: ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Field(t => t.EmployeeId);
            Field(t => t.FirstName);
            Field(t => t.LastName);
            Field(t => t.DateOfBirth);
            Field(t => t.Email);
            Field(t => t.PhoneNumber);
        }
    }
}
