using Consulting.Model.EntityBase;

namespace Consulting.Model
{
    public class Fee: EntityBase<int>
    {
        public double Taxes { get; set; } 
    }
}