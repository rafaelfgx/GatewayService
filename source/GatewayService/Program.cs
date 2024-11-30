var builder = WebApplication.CreateBuilder();

builder.Services.AddOcelot(builder.Configuration).AddDelegatingHandler<Handler>(true);
builder.Services.AddResponseCompression();
builder.Services.AddControllers();

var application = builder.Build();

application.UseDeveloperExceptionPage();
application.UseHsts();
application.UseHttpsRedirection();
application.UseResponseCompression();
application.MapControllers();
application.UseOcelot().Wait();

application.Run();
