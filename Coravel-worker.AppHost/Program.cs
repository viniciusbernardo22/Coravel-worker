var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Coravel_worker>("coravel-worker");

builder.Build().Run();
