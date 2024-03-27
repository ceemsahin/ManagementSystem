﻿using ManagementSystem.WebApi.Models.WorkTask.Response;

namespace ManagementSystem.Domain.Services.Abstract
{
    public interface IWorkTaskService : IDomainService
    {
        public Task<IList<WorkTasksDto>> GetAllAsync(CancellationToken cancellationToken = default); 
    }
}