namespace RealEstate_Dapper_API.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public string CoverImage { get; set; }
        public string City { get; set; }
        public string Distinct { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int ProductCategory { get; set; }
        public int EmployeeID { get; set; }
    }
}
