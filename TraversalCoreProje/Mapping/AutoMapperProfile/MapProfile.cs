﻿using AutoMapper;
using DTOLayer.DTOs.AnnouncemenetDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncemenetAddDTO, Announcemenet>().ReverseMap();

            CreateMap<AppUserRegisterDTOs, AppUser>().ReverseMap();

            CreateMap<AppUserLoginDTOs, AppUser>().ReverseMap();

            CreateMap<AnnouncemenetListDTO, Announcemenet>().ReverseMap();

            CreateMap<AnnouncemenetUpdateDto, Announcemenet>().ReverseMap();
        }
    }
}
