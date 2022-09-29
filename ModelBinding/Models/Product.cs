using System.ComponentModel.DataAnnotations;

namespace ModelBinding.Models
{
    /// <summary>
    /// Represents a product for sale.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Name of the product
        /// </summary>
        [Required(ErrorMessage = "Enter Name of Product.")]
        [Display(Name = "Title")] // Rename label on view
        public string Title { get; set; }

        /// <summary>
        /// The retail price.
        /// </summary>
        [Range(0, double.MaxValue, ErrorMessage = "Price must be 0 or greater.")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        /// <summary>
        /// The number of units in stock.
        /// </summary>
        [Range(0, double.MaxValue, ErrorMessage = "Quantity must be 0 or greater.")]
        public int Qty { get; set; }
    }
}
