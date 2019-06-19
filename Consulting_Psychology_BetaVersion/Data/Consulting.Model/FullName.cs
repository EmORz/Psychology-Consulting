using Consulting.Model.EntityBase;

namespace Consulting.Model
{
    public class FullName : EntityBase<int>
    {
        public string FirstName { get; set; }

        public string Middlename { get; set; }

        public string LastName { get; set; }
    }
}