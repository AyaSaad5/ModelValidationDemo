namespace ModelValidation.Models
{
    public class StoreRequestModel
    {
        public string? StoreName { get; set; }
        public string? Address { get; set; }
        public string? ContacNo { get; set; }
        public string? Email { get; set; }
        public string? RegistrationNo { get; set; }
        public List<int> categoryIds { get; set; }
    }
}
