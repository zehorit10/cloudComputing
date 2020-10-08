using BL.BE;
using System.Collections.Generic;

namespace Zehorit.Models
{
    public class MedicinesModel
    {
        public List<Medication> Medicines { get; set; }
        public MedicinesModel()
        {
            Medicines = new List<Medication>
            {
                new Medication {Id=111,Name="abc",Maker="zehorit", GenericName="abb",ActiveIngredients="hjk",Properties="hhk",ImageUrl=@"\images\1.jpg" }
            };
        }
    }
}