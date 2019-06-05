using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Abp.Microservice.Practice.Menus
{
    public class MenuDto : EntityDto<int>
    {
        public MenuDto(int id, string name, string url, string icon)
        {
            Id = id;
            Name = name;
            Url = url;
            Icon = icon;
            Childs = new List<MenuDto>();
        }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public List<MenuDto> Childs { get; set; }

    }
}