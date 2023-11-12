using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Alza_WebAPI.FilterExtension
{    
    //Based on : https://cloudkasten.net/how-to-multiple-api-versions-in-one-codebase/
    public class ConfigureApiDocumentationOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public ConfigureApiDocumentationOptions(IApiVersionDescriptionProvider provider)
        {
            _provider = provider;
        }

        public void Configure(SwaggerGenOptions options)
        {
            foreach ( var description in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
            }
        }

        private static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new OpenApiInfo()
            {
                Title = "AlzaWebAPI",
                Version = description.ApiVersion.ToString(),
            };
            if(description.IsDeprecated)
            {
                info.Description += "Deprecated version";
            }
            return info;
        }
    }
}
