﻿using ManagementSystem.Domain.Models.Args.Department;
using MediatR;

namespace ManagementSystem.Application.Features.Commands.Department
{
    public class CreateDepartmentCommand : CreateDepartmentArgs, IRequest<int>
    {
    }
}
