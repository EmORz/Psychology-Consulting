using Consulting.Model.EntityBase;

namespace Consulting.Model
{
    public class Diagnoses : EntityBase<int> 
    {
        //Todo its not ok
        //International Classification of Diseases (ICD) => in bulgarian translation MKB
        
        public string MKB { get; set; }

        public string FullNameOfDesseas { get; set; }

        public string Description { get; set; }
    }
}