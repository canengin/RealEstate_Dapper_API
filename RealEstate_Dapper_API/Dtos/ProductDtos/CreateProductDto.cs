namespace RealEstate_Dapper_API.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string City { get; set; }
        public string Distinct { get; set; }
        public int ProductCategory { get; set; }
        public int EmployeeID { get; set; }
    }
}
