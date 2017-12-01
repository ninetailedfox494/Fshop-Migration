﻿using AutoMapper;
using FShop.Entities.Models;
using FShop.Web.Models;

namespace FShop.WebApi.Mappings
{
    public class AutoMapperConfiguration
    {
        //step 5
        //sử dụng automapper mapping view model
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<ProductTag, ProductTagViewModel>();
                cfg.CreateMap<Footer, FooterViewModel>();
                cfg.CreateMap<Slide, SlideViewModel>();
                cfg.CreateMap<Page, PageViewModel>();
                cfg.CreateMap<ContactDetail, ContactDetailViewModel>();
                //cfg.CreateMap<ApplicationGroup, ApplicationGroupViewModel>();
                //cfg.CreateMap<ApplicationRole, ApplicationRoleViewModel>();
                //cfg.CreateMap<ApplicationUser, ApplicationUserViewModel>();
            });

        }
        
    }
}