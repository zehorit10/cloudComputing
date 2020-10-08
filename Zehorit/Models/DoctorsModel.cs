using BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zehorit.Models
{
    public class DoctorsModel
    {
        public List<Doctor> Doctors { get; set; }
        public DoctorsModel()
        {
            Doctors = new List<Doctor>
            {
                new Doctor { Id=111, FirstName="Dana", LastName="Cohen", CardId="111", CellPhone="050-3511171", ImageUrlDP=@"\images\111.jpg", Address="הפורצים 19", Specialty="א.א.ג", LicenseNumber=111, LicenseValidity=new DateTime(2012,12,10), DateAdd= DateTime.Now},
                new Doctor { Id=222, FirstName="Zehorit", LastName="Cohen", CardId="222",CellPhone="052-3511171", ImageUrlDP=@"\images\222.jpg", Address="הפורצים 10", Specialty="א.א.ג", LicenseNumber=222, LicenseValidity= new DateTime(2016,12,10), DateAdd=DateTime.Now}

            };
        }

    }
}