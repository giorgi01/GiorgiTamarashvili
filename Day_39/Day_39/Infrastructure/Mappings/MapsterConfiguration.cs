using Mapster;
using Microsoft.Extensions.DependencyInjection;
using Day_39.Models.DTO;
using PersonManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_39.Infrastructure.Mappings
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection services)
        {
            TypeAdapterConfig<PersonDTO, PersonServiceModel>
             .NewConfig()
             .Map(dest => dest.City, src => new CityServiceModel { Name = src.City })
             .Map(dest => dest.PersonIdentifier, src => src.Identifier);

            TypeAdapterConfig<PersonServiceModel, PersonDTO>
            .NewConfig()
            .Map(dest => dest.City, src => src.City.Name)
            .Map(dest => dest.Identifier, src => src.PersonIdentifier)
            .Map(dest => dest.Age, src => (DateTime.Today - src.BirthDate).Days / 365);
        }
    }
}
