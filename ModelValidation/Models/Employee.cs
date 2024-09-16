using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    //Enum Validation
    public class Employee
    {
        public string Name { get; set; }
        [EnumDataType(typeof(JobRole), ErrorMessage = "Role Must be manager, developer or tester")]
        public JobRole Role { get; set; }
    }
    public enum JobRole
    {
        developer,
        manager,
        tester
    }
}
