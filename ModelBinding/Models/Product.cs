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
        public string Title { get; set; }

        /// <summary>
        /// The retail price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The number of units in stock.
        /// </summary>
        public int Qty { get; set; }
    }
}
