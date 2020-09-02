using System;
using System.Collections.Generic;

namespace HOSPITAL_MANAGEMENT
{
    abstract class Staff
    {
        string Name;
        int Contact;
        string Address;
    public void PersonalInfo(string Name, int Contact, string Address)
        {
            this.Name = Name;
            this.Contact = Contact;
            this.Address = Address; 

            Console.WriteLine(Name);
            Console.WriteLine(Contact);
            Console.WriteLine(Address);

        }
    }

    class Doctor : Staff
    {
        string specialization;
        int TotalPatients;

        //Aggregation relationship between Doctor and Patient as Doctor have many patient but a patient have only one Doctor 
        
        public List<Patient> Patients = new List<Patient>();
        public Nurse nurse; 




    }

    class Nurse : Staff
    {

        public Doctor doctor; 

        
    } 

    class Pharmacist:Staff
    {

    }

    class LabAssistant:Staff
    {
        public List<Test> tests = new List<Test>();
    }

    class Patient

    {
        string Name;
        int ID;
        string Address;
        int Contact;
        string Problem;



        public List<HealthIssue> HealthIssues = new List<HealthIssue>();
        public List<Pharmacist> pharmacists = new List<Pharmacist>();
    }


    class HealthIssue
    {
        public Treatment treatment; 

    }

    class Treatment
    {
        public HealthIssue healthissue; 
    }

    class Test
    {

    }
}


