using AutoMapper;
using EstateMaximum.Data.Data;
using EstateMaximum.Models.Apartments;
using EstateMaximum.Models.Houses;
using EstateMaximum.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Models.Configuration
{
    public class MappingConfiguration : Profile
    {

        public MappingConfiguration()
        {
            CreateMap<HouseEntity, HouseCreate>().ReverseMap();
            CreateMap<HouseEntity, HouseEdit>().ReverseMap();
            CreateMap<HouseEntity, HouseListItems>().ReverseMap();
            CreateMap<HouseEntity, HouseDetail>().ReverseMap();


            CreateMap<ApartmentEntity, ApartmentCreate>().ReverseMap();
            CreateMap<ApartmentEntity, ApartmentDetail>().ReverseMap();
            CreateMap<ApartmentEntity, ApartmentEdit>().ReverseMap();
            CreateMap<ApartmentEntity, ApartmentListItem>().ReverseMap();


        }
    }
}
