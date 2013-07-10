using System;
using System.Collections.Generic;

namespace ModelTier
{
    public class Skill
    {
        public int id { get; set; }
        public string Description { get; set; }
        public int ApplicantID { get; set; }
        public byte Active { get; set; }
        public virtual Applicant Applicant { get; set; }
    }
}
