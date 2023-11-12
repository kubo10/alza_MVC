using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Alza_WebAPI.FilterExtension
{
    //Based on : https://cloudkasten.net/how-to-multiple-api-versions-in-one-codebase/
    public class ApiDefaultValues : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var apiDescriptionModel = context.ApiDescription;
            operation.Deprecated |= apiDescriptionModel.IsDeprecated();
            if (operation.Parameters == null)
            {
                return;
            }
            foreach (var parameter in operation.Parameters)
            {
                var description = apiDescriptionModel.ParameterDescriptions.First(param => param.Name == parameter.Name);

                if (parameter.Description == null)
                {
                    parameter.Description = description.ModelMetadata?.Description;
                }
                if (parameter.Schema.Default != null)
                {
                    parameter.Schema.Default = new OpenApiString(description?.DefaultValue?.ToString());
                }

                parameter.Required |= description.IsRequired;
            }
        }
    }
}
