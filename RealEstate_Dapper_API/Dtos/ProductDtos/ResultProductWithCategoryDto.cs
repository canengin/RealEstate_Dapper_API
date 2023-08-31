namespace RealEstate_Dapper_API.Dtos.ProductDtos
{
    public class ResultProductWithCategoryDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string CategoryName { get; set; }
        //public int EmployeeID { get; set; }
    }
}
