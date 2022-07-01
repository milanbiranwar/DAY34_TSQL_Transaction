create database payrollservice

create procedure spUpdateEmployeeSalary
(
@id int,
@month varchar(255),
@salary int,
@EmpId int
)

as 
begin
Update salary
set EmployeeSalary=@salary
where SalaryId =@id and Month =@month and EmpId=@empId


select e.EmployeeID, e.EmployeeName, e.Department, s.EmployeeSalary, s.Month, s.SalaryId from employee_payroll1 e inner join salary s on e employeeID=s.EmpId
where s.SalaryId=@id

end