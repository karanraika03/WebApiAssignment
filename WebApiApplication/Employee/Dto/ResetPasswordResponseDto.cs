using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiApplication.Employee.Dto;

public class ResetPasswordResponseDto
{
    public string Subject { get; set; }
    public string Email { get; set; }
    public string Body { get; set; }
}
