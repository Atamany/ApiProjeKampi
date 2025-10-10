using ApiProjeKampi_WebAPI.Entities;
using FluentValidation;

namespace ApiProjeKampi_WebAPI.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez!");
            RuleFor(p => p.ProductName).MinimumLength(2).WithMessage("Ürün adı en az 2 karakter olmalıdır!");
            RuleFor(p => p.ProductName).MaximumLength(50).WithMessage("Ürün adı en fazla 50 karakter olmalıdır!");

            RuleFor(p => p.ProductDescription).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez!");
            RuleFor(p => p.ProductDescription).MinimumLength(5).WithMessage("Ürün açıklaması en az 5 karakter olmalıdır!");
            RuleFor(p => p.ProductDescription).MaximumLength(500).WithMessage("Ürün açıklaması en fazla 500 karakter olmalıdır!");

            RuleFor(p => p.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez!");
            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Ürün fiyatı 0'dan büyük olmalıdır!");
            RuleFor(p => p.Price).LessThan(10000).WithMessage("Ürün fiyatı 10.000'den küçük olmalıdır!");

            RuleFor(p => p.ImageUrl).NotEmpty().WithMessage("Ürün görseli boş geçilemez!");
        }
    }
}
