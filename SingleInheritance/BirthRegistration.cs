using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class BirthRegistration
    {
        private static int s_birthRegistrationID = 0;
        public int BirthRegistrationID {get;}
        public string Name{set;get;}
        public string FatherName{set;get;}
        public DateTime BirthDate{set;get;}
        public DateTime RegistrationDate{set;get;}
        public string Gender{set; get;}
        public BirthRegistration(){
            s_birthRegistrationID++;
            BirthRegistrationID = s_birthRegistrationID;
        }
        public BirthRegistration( string name, string fathername, DateTime birthDate, DateTime registrationDate, string gender){
            s_birthRegistrationID++;
            BirthRegistrationID = s_birthRegistrationID;
            Name = name;
            FatherName = fathername;
            BirthDate = birthDate;
            RegistrationDate = registrationDate;
            Gender = gender;
        }
        // reusable constructor
        public BirthRegistration(int birthRegistrationID, string name, string fathername, DateTime birthDate, DateTime registrationDate, string gender){
            BirthRegistrationID = birthRegistrationID;
            Name = name;
            FatherName = fathername;
            BirthDate = birthDate;
            RegistrationDate = registrationDate;
            Gender = gender;
        }
        
        public string DisplayBirthDetails(){
            return $"BirthRegistrationID: {BirthRegistrationID}, Name: {Name}, FatherName: {FatherName}, BirthDate: {BirthDate.ToString("dd/MM/yyyy")}, RegistrationDate: {RegistrationDate.ToString("dd/MM/yyyy")}, Gender: {Gender}";
        }
    }
}