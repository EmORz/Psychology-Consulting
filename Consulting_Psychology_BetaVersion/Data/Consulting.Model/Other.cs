using System;
using Consulting.Model.EntityBase;

namespace Consulting.Model
{
    public class Other : EntityBase<int>
    {
        public FullName Name { get; set; }

        public string Position { get; set; }

        //имам предвид стаж
        public DateTime Internship { get; set; }

    }
}