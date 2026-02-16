using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            // Validasyon işlemi FluentValidation kütüphanesi ile yapılır. FluentValidation, .NET uygulamalarında nesne doğrulama işlemlerini
            // kolaylaştıran bir kütüphanedir. Bu kütüphane,
            // doğrulama kurallarını tanımlamak için akıcı bir API sağlar ve
            // genellikle veri transfer nesneleri (DTO) veya varlıklar üzerinde kullanılır.
            // Bu işlem "lambda" ifadlerle yapılır ve "RuleFor" metodu ile doğrulama kuralları tanımlanır.
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez");
            RuleFor(p => p.ProductName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapınız.");
            RuleFor(p => p.ProductName).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapınız.");

            RuleFor(p => p.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez").GreaterThan(0).WithMessage("Ürün fiyatı negatif " +
                "olamaz.").LessThan(1000).WithMessage("Ürün fiyatı bu kadar yüksek olamaz, giridğiniz x değerini kontrol ediniz.");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez");
        }
    }
}
