namespace NestedValueObject
{
    using System.ComponentModel.DataAnnotations;

    namespace NestedValueObject
    {
        public class Address
        {
            [Required]
            public string BuildingNumber { get; private set; }
        }
    }
}
