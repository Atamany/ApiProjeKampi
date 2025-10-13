using ApiProjeKampi_WebAPI.DTOs.AboutDTOs;
using ApiProjeKampi_WebAPI.DTOs.CategoryDTOs;
using ApiProjeKampi_WebAPI.DTOs.EventDTOs;
using ApiProjeKampi_WebAPI.DTOs.FeatureDTOs;
using ApiProjeKampi_WebAPI.DTOs.MessageDTOs;
using ApiProjeKampi_WebAPI.DTOs.NotificationDTOs;
using ApiProjeKampi_WebAPI.DTOs.ProductDTOs;
using ApiProjeKampi_WebAPI.DTOs.ReservationDTOs;
using ApiProjeKampi_WebAPI.DTOs.ServiceDTOs;
using ApiProjeKampi_WebAPI.DTOs.TestimonialDTOs;
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
            CreateMap<Product, ResultProductWithCategoryDTO>().ForMember(x => x.CategoryName, y => y.MapFrom(z => z.Category.CategoryName)).ReverseMap();

            CreateMap<Category, ResultCategoryDTO>().ReverseMap();
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDTO>().ReverseMap();

            CreateMap<Service, ResultServiceDTO>().ReverseMap();
            CreateMap<Service, CreateServiceDTO>().ReverseMap();
            CreateMap<Service, UpdateServiceDTO>().ReverseMap();
            CreateMap<Service, GetByIdServiceDTO>().ReverseMap();

            CreateMap<Testimonial, ResultTestimonialDTO>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDTO>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDTO>().ReverseMap();
            CreateMap<Testimonial, GetByIdTestimonialDTO>().ReverseMap();

            CreateMap<YummyEvent, ResultEventDTO>().ReverseMap();
            CreateMap<YummyEvent, CreateEventDTO>().ReverseMap();
            CreateMap<YummyEvent, UpdateEventDTO>().ReverseMap();
            CreateMap<YummyEvent, GetByIdEventDTO>().ReverseMap();

            CreateMap<Notification, ResultNotificationDTO>().ReverseMap();
            CreateMap<Notification, CreateNotificationDTO>().ReverseMap();
            CreateMap<Notification, UpdateNotificationDTO>().ReverseMap();
            CreateMap<Notification, GetByIdNotificationDTO>().ReverseMap();

            CreateMap<About, ResultAboutDTO>().ReverseMap();
            CreateMap<About, CreateAboutDTO>().ReverseMap();
            CreateMap<About, UpdateAboutDTO>().ReverseMap();
            CreateMap<About, GetByIdAboutDTO>().ReverseMap();

            CreateMap<Reservation, ResultReservationDTO>().ReverseMap();
            CreateMap<Reservation, CreateReservationDTO>().ReverseMap();
            CreateMap<Reservation, UpdateReservationDTO>().ReverseMap();
            CreateMap<Reservation, GetByIdReservationDTO>().ReverseMap();
        }
    }
}
