using ApiProjeKampi_WebAPI.DTOs.CategoryDTOs;
using ApiProjeKampi_WebAPI.DTOs.FeatureDTOs;
using ApiProjeKampi_WebAPI.DTOs.MessageDTOs;
using ApiProjeKampi_WebAPI.DTOs.ProductDTOs;
using ApiProjeKampi_WebAPI.Entities;
using AutoMapper;

namespace ApiProjeKampi_WebAPI.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature,ResultFeatureDTO>().ReverseMap();
            CreateMap<Feature,CreateFeatureDTO>().ReverseMap();
            CreateMap<Feature,UpdateFeatureDTO>().ReverseMap();
            CreateMap<Feature,GetByIdFeatureDTO>().ReverseMap();

            CreateMap<Message, ResultMessageDTO>().ReverseMap();
            CreateMap<Message, CreateMessageDTO>().ReverseMap();
            CreateMap<Message, UpdateMessageDTO>().ReverseMap();
            CreateMap<Message, GetByIdMessageDTO>().ReverseMap();

            CreateMap<Product, ResultProductDTO>().ReverseMap();
            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();
            CreateMap<Product, GetByIdProductDTO>().ReverseMap();

            CreateMap<Category, ResultCategoryDTO>().ReverseMap();
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDTO>().ReverseMap();
        }
    }
}
