using System;
using System.Collections.Generic;

namespace ModelTier
{
    public   class Certification
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Expire_Date { get; set; }
        public string Description { get; set; }
        public int ApplicantID { get; set; }
        public byte Active { get; set; }
        public virtual Applicant Applicant { get; set; }
    }
}
