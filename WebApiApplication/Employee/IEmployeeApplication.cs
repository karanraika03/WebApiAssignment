﻿using WebApiApplication.Employee.Dto;
namespace WebApiApplication.Employee;
public interface IEmployeeApplication
{
    Task<int> CreateEmployee(CreateEmployeeDto input);
    Task<LoginResponseDto> LoginAsync(LoginDto dto);

    Task<bool> ChangePasswordAsync(int id, ChangePasswordDto dto);

    Task<string> ForgetPasswordAsync(string emailId, string ipAddress);

    Task ResetPassword(ResetPasswordDto input);

}
