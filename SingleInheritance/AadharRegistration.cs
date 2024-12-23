using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class AadharRegistration : BirthRegistration
    {
        private static int s_aadharRegistrationID = 0;
        public int AadharRegistrationID {get;}
        public string Address{set; get;}

        public AadharRegistration(){
            s_aadharRegistrationID++;
            AadharRegistrationID = s_aadharRegistrationID;
        }
        // pass values all values to reusable constructor in parent class through base, it will assign value to all props except address, aadharID
        public AadharRegistration(int birthRegistrationID, string name, string fathername, DateTime birthDate, DateTime registrationDate, string gender, string address) : base( birthRegistrationID,  name,  fathername,  birthDate,  registrationDate,  gender){
            s_aadharRegistrationID++;
            AadharRegistrationID = s_aadharRegistrationID;
            Address = address;
        }
        public string DisplayAadharDetails(){
            return $"AadharRegistrationID: {AadharRegistrationID}, {DisplayBirthDetails()}, Address: {Address}";
        }
    }
}