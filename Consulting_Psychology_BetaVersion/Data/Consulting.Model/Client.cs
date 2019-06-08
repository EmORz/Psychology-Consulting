using System.Collections.Generic;

namespace Consulting.Model
{
    public class Client
    {
        public Client()
        {
            this.Diagnoseses = new HashSet<Diagnoses>();
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public Diagnoses Diagnose { get; set; }

        public ICollection<Diagnoses> Diagnoseses { get; set; }
    }
}