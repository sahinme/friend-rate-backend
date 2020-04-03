using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Nnn.ApplicationCore.Entities.Properties;
using Microsoft.Nnn.ApplicationCore.Services.PropertyService.Dto;

namespace Microsoft.Nnn.ApplicationCore.Services.PropertyService
{
    public interface IPropertyAppService
    {
        Task<Property> CreateProperty(string name);
        Task<bool> DeleteProperty(long id);
        Task<List<PropertyDto>> GetAll();
    }
}