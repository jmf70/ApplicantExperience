using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelTier
{
    public   class Applicant
    {

        public Applicant()
        {
            //because when we want to create a new applicant 
            //we have to initilize the collections
            //so we can add items into them.
            Certifications = new List<Certification>();
            Skills = new List<Skill>();
        
        }
       
        [Key]
        public int ApplicantID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Tel_No { get; set; }
        public string Mobile_No { get; set; }
        public string Visa_Type { get; set; }
        public string LinkedIn_URL { get; set; }
        public string Objective { get; set; }
        public byte Active { get; set; }
        public virtual ICollection<Certification> Certifications { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
