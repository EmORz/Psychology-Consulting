using Consulting.Model.EntityBase;
using Consulting.Model.Enums;

namespace Consulting.Model
{
    public class Products : EntityBase<int>
    {
        public Products()
        {
            IsNeedRecipe = false;
            Medic = new Medic();
        }
        public CategoryProducts CategoryProducts { get; set; }

        public string Name { get; set; }

        public bool IsNeedRecipe { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public Medic Medic { get; set; }


        
    }
}