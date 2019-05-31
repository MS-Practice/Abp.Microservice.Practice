using Abp.Microservice.Practice.Domain.Exceptions;
using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Abp.Microservice.Practice.Domain.Entities
{
    public class Menu : Entity<int>, IAggregateRoot<int>, ISoftDelete
    {
        protected Menu() { }

        //parentId 默认为0，为一级菜单
        public Menu(string name, string url, string icon)
        {
            Name = name;
            Url = url;
            Icon = icon;
            ChildMenus = new List<Menu>();
        }

        public virtual string Name { get; protected set; }
        public virtual string Url { get; protected set; }
        public virtual string Icon { get; protected set; }
        public virtual int ParentID { get; protected set; }
        public List<Menu> ChildMenus { get; protected set; }
        public virtual bool IsDeleted { get; set; }

        public void AddChildMenus(List<Menu> menus)
        {
            if (menus.IsNullOrEmpty())
                throw new DomainArgumentException(nameof(menus));
            ChildMenus.AddIfNotContains(menus);
        }
        public void RemoveChildMenu(Menu m)
        {
            ChildMenus.Remove(m);
        }
        public void Delete()
        {
            IsDeleted = true;
        }

        public void UpdateUrl(string url)
        {
            Url = url;
        }

        public void UpdateName(string name)
        {
            this.Name = name;
        }

        public void UpdateIcon(string icon)
        {
            Icon = icon;
        }
    }
}
