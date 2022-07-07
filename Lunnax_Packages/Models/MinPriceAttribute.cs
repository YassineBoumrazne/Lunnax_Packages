using System.ComponentModel.DataAnnotations;

namespace Lunnax_Packages.Models
{
    internal class MinPriceAttribute : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            bool result = (decimal)value > 0;
            return result;
        }
    }
}