using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatientLibrary
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public interface IPatient
    {
       
        string name { get; set; }
        string address { get; set; }
         List<PatientProblem> problems { get; set; }
        string email { get; set; }
        bool Validate();
         string guid { get; set; }
    }

    public class PatientDTO
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }

        public virtual string address { get; set; }

        public virtual string email { get; set; }

        public virtual List<PatientProblem> problems { get; set; }
        public virtual string guid { get; set; }


    }
    public class Patient : PatientDTO,IPatient
    {
        public override int id { get; set; }
        
        [Required(ErrorMessage ="Name required")]
        public override string name { get; set; }

        [Required(ErrorMessage ="Address required")]
        public override string address { get; set; }
        public override List<PatientProblem> problems { get; set; }
        public override string guid { get; set; }
        
        [Required(ErrorMessage ="Email required")]
        public override string email { get; set; }
        public Patient()
        {
            this.problems = new List<PatientProblem>();
            this.guid = Guid.NewGuid().ToString();
        }
        public virtual bool Validate()
        {
            if (name.Length == 0)
            {
                throw new Exception("name is needed");
            }
            return true;
        }

    }
    public class PatientWithAddressCheck : Patient , IPatient
    {
        public override bool Validate()
        {
            if (name.Length == 0)
            {
                throw new Exception("name is needed");
            }
            if (address.Length == 0)
            {
                throw new Exception("address is needed");
            }
            return true;
        }
    }
    public class PatientProblem
    {
        public int id { get; set; }
        public string problem { get; set; }
        public List<Treatment> treatments { get; set; }
        public PatientProblem()
        {
            this.treatments = new List<Treatment>();
        }
       
    }

    public class  Treatment 
    {
        public int id { get; set; }
        public string medicineName { get; set; }
        public string numberOfTimesInDay { get; set; }
    }

}
