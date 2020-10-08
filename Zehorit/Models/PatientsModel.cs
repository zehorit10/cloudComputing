using BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zehorit.Models
{
    public class PatientsModel
    {
        public List<Patient> Patients { get; set; }
        public PatientsModel()
        {
            Patients = new List<Patient>
            {
                new Patient { Id=333, FirstName="Ori", LastName="chalili", CardId="333", CellPhone="054-9219058", ImageUrlDP=@"\images\333.jpg", Address="הפורצים 5", Age=11 , MedicalHistory="abcde", DrugsList="a , b,c,d", Chronic="123" },
                new Patient { Id=444, FirstName="Hodaya", LastName="Cohen", CardId="444",CellPhone="050-9219058", ImageUrlDP=@"\images\444.jpg", Address="הפורצים 3", Age=20, MedicalHistory="abcde", DrugsList="a , b", Chronic="122223"}

            };
        }

    }
}