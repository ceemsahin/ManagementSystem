﻿namespace ManagementSystem.WebApi.Models.WorkTask.Response
{
    public class WorkTasksResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Deadline { get; set; }
        public string Status { get; set; }
        public string NameSurname { get; set; }
    }
}
