using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Nnn.ApplicationCore.Entities.Properties;
using Microsoft.Nnn.ApplicationCore.Interfaces;
using Microsoft.Nnn.ApplicationCore.Services.PropertyService.Dto;

namespace Microsoft.Nnn.ApplicationCore.Services.PropertyService
{
    public class PropertyAppService:IPropertyAppService
    {
        private readonly IAsyncRepository<Property> _propertyRepository;

        public PropertyAppService(IAsyncRepository<Property> propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
        
        public async Task<Property> CreateProperty(string name)
        {
            var proper = await _propertyRepository.AddAsync(new Property {Name = name});
            return proper;
        }

        public async Task<bool> DeleteProperty(long id)
        {
            var proper = await _propertyRepository.GetByIdAsync(id);
            proper.IsDeleted = false;
            await _propertyRepository.UpdateAsync(proper);
            return true;
        }

        public async Task<List<PropertyDto>> GetAll()
        {
            var result = await _propertyRepository.GetAll().Where(x => x.IsDeleted == false)
                .Select(x => new PropertyDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync();
            return result;
        }
    }
}