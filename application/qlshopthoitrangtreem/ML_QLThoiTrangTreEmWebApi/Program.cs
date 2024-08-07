﻿using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.ML.Data;
using Microsoft.Extensions.ML;
namespace ML_QLThoiTrangTreEmWebApi
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //Configuration
            WebHost.CreateDefaultBuilder()
          .ConfigureServices(services =>
          {
                    // Register Prediction Engine Pool
                    services.AddPredictionEnginePool<MLModel1.ModelInput, MLModel1.ModelOutput>().FromFile("MLModel1.mlnet");

                    // Add CORS service and configure policy
                    services.AddCors(options =>
                    {
                        options.AddPolicy("AllowSpecificOrigin",
                            builder =>
                            {
                                builder.WithOrigins("http://localhost:8080")
                                        .AllowAnyHeader()
                                        .AllowAnyMethod();
                            });
                    });

          })
          .Configure(options =>
          {
              options.UseRouting();
              // Use CORS with the defined policy
              options.UseCors("AllowSpecificOrigin");

              options.UseEndpoints(routes =>
              {
                        // Define prediction endpoint
                        routes.MapPost("/predict", PredictHandler);
              });
          })
          .Build()
          .Run();
        }

        static async Task PredictHandler(HttpContext http)
        {
            // Deserialize HTTP request JSON body
            var body = http.Request.Body as Stream;
            var input = await JsonSerializer.DeserializeAsync<MLModel1.ModelInput>(body);
            // Predict
            // Get PredictionEnginePool service
            var predictionEnginePool = http.RequestServices.GetRequiredService<PredictionEnginePool<MLModel1.ModelInput, MLModel1.ModelOutput>>();
            MLModel1.ModelOutput prediction = predictionEnginePool.Predict(input);
            // Return prediction as response
            await http.Response.WriteAsJsonAsync(prediction);
        }
    }
}

