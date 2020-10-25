using AutoMapper;
using Data.Models;
using FirstApp.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.App_Start
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<ToDo, ToDoDto>().ReverseMap();
        }
    }

}