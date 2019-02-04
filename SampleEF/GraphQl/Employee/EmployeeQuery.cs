using Alpha.GraphQl.Types;
using EFCoreCodeFirstSample.Models;
using EFCoreCodeFirstSample.Models.Repository;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alpha.GraphQl
{
    public class EmployeeQuery: ObjectGraphType
    {
        public EmployeeQuery(IDataRepository<Employee> dataRepository)
        {
            Field<ListGraphType<EmployeeType>>(
                "employees",
                resolve: context => dataRepository.GetAll()
            );
        }
    }
}
