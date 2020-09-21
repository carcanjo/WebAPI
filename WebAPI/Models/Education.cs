using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserServices.Models.Enuns
{
    public class Education 
    {
        public int Id { get; set; }
        public string Educations { get; set; }
        public Education() {}

        public Education(int id, string educations)
        {
            Id = id;
            Educations = educations;
        }
    }
}
