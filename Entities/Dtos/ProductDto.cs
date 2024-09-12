using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; } //nesne olusturulduktan sonra ilgili nesne uzerinde herhangi bir degisiklik yapilamaz
        [Required(ErrorMessage = "ProductName is required.")]
        public String? ProductName { get; init; } = String.Empty;
        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; init; }
        public String? Summary { get; init; } = String.Empty;
        public String? ImageUrl { get; set; }
        public int? CategoryId { get; init; }
    }
}