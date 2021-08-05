using Mapster;
using Microsoft.Extensions.DependencyInjection;
using PersonManagement.Models.DTO;
using PersonManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonManagement.Infrastructure.Mappings
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection services)
        {

            //1. სტანდარტული მეპი, ორმხრივი მეპი
            //TypeAdapterConfig<PersonServiceModel, PersonDTO>
            //.NewConfig()
            //.TwoWays();

            //2. როცა არ ემთხვევა ფროფერთის სახელები ერთმანეთს
            //TypeAdapterConfig<PersonDTO, PersonServiceModel>
            //.NewConfig()
            //.TwoWays()
            //.Map(dest => dest.PersonIdentifier, src => src.Identifier);

            //3. 
            TypeAdapterConfig<PersonDTO, PersonServiceModel>
             .NewConfig()
             .Map(dest => dest.City, src => new CityServiceModel { Name = src.City })
             .Map(dest => dest.PersonIdentifier, src => src.Identifier);

            TypeAdapterConfig<PersonServiceModel, PersonDTO>
            .NewConfig()
            .Map(dest => dest.City, src => src.City.Name)
            .Map(dest => dest.Identifier, src => src.PersonIdentifier);


        }
    }
}
