using System;
using System.Collections.Generic;
using Consulting.Model.EntityBase;

namespace Consulting.Model
{
    public class Client : EntityBase<int>
    {
        public Client()
        {
            this.Diagnoseses = new HashSet<Diagnoses>();
            this.Fees = new HashSet<Fee>();
        }

        public FullName FullName { get; set; }

        public string Address { get; set; }

        public Diagnoses Diagnose { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public Fee Fee { get; set; }

        public ICollection<Fee> Fees { get; set; }

        public ICollection<Diagnoses> Diagnoseses { get; set; }
    }
}