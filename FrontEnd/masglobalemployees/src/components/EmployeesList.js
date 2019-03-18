import React from 'react';
// or less ideally
// Child components

const EmployeesList = ({employees}) => {
    return (
        !employees.length ?
            <p className="alert alert-warning text-center">No employees found.</p>
            :
            <div>
                <div class='table-responsive-md'>
                    <table class="table">
                        <thead>
                        <tr>
                            <th scope="row">ID</th>
                            <th>Name</th>
                            <th>ContractTypeName</th>
                            <th>RoleId</th>
                            <th>RoleName</th>
                            <th>RoleDescription</th>
                            <th>HourlySalary</th>
                            <th>MonthlySalary</th>
                            <th>AnnualSalary</th>
                           
                        </tr>
                        </thead>
                        <tbody>
                        {employees.map(emp =>
                            <tr key={emp.Id}>
                            <td >{emp.Id}</td>
                                <td>{emp.Name}</td>
                                <td>{emp.ContractTypeName}</td>
                                <td>{emp.RoleId}</td>
                                <td>{emp.RoleName}</td>
                                <td>{emp.RoleDescription}</td>
                                <td>{emp.HourlySalary}</td>
                                <td>{emp.MonthlySalary}</td>
                                <td>{emp.AnnualSalary}</td>
                               
                            </tr>
                        )}
                        </tbody>
                    </table>
                </div>
               
            </div>
    )
};

export default EmployeesList;