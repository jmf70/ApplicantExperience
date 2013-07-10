using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data;
using ModelTier;
namespace ApplicantExperience
{
    class Program
    {
        static void Main(string[] args)
        {

         

            //create new Certification
            var newCertification = new Certification();
            newCertification.Active = 1;
            newCertification.Description = "MCP";
            newCertification.Expire_Date = null;
            newCertification.id = 1;
            newCertification.Name = "Microsoft Profissional";
            newCertification.Title = "Microsoft Web Development ASP.NET";

            //create new skill
            var newSkill1 = new Skill();
            newSkill1.Active = 1;
            newSkill1.Description = "C#";
            newSkill1.id = 1;

            var newSkill2 = new Skill();
            newSkill2.Active = 1;
            newSkill2.Description = "MVC";
            newSkill2.id = 1;


            //create new applicant
            var newApplicant = new Applicant();

            newApplicant.Active = 1;
            newApplicant.ApplicantID = 1;
            newApplicant.Certifications.Add(newCertification);
            newApplicant.Email = "master_khalil@yahoo.com";
            newApplicant.First_Name = "Khaleel";
            newApplicant.Last_Name = "Esbaitah";
            newApplicant.LinkedIn_URL = "http://www.linkedin.com/pub/khaleel-esbaitah/1b/703/913";
            newApplicant.Mobile_No = "34234234";
            newApplicant.Objective = "To Join an organisation where I can emphasise my strength ";
            newApplicant.Skills.Add(newSkill1);
            newApplicant.Skills.Add(newSkill2);
            newApplicant.Tel_No = "1234567";
            newApplicant.Visa_Type = "PR";


            //add new applicant to applicants entity
            //using UOW facade
            IMyExperienceUow uow = new MyExperienceUow();
        
           uow.Applicants.Add(newApplicant);
           // commit all changes to DB
           uow.Commit();



           var result= uow.Applicants.GetAll();
         
        }
    }
}
