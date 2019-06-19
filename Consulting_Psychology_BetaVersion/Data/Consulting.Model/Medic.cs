using System;
using System.Collections.Generic;
using Consulting.Model.EntityBase;

namespace Consulting.Model
{
    public class Medic : EntityBase<int>
    {
        public Medic()
        {
            this.Patients = new List<Client>();
        }

        public FullName Name { get; set; }

        public string Specialization { get; set; }

        //имам предвид стаж
        public DateTime Internship { get; set; }

        public List<Client> Patients { get; set; }


    }
}