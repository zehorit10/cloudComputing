using BL.BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReadWriteMedicines
    {
        public bool InsertMedication(string name, string maker, string genericName, string activeIngredients, string properties, string imageUrl)
        {
            bool Result = true;

            MedicinesContext Db = new MedicinesContext();

            Db.Medicines.Add(new Medication { Name = name, Maker = maker, GenericName = genericName, ActiveIngredients = activeIngredients, Properties = properties, ImageUrl = imageUrl });

            Db.SaveChanges();

            return Result;

        }

    }

    public class MedicinesContext : DbContext
    {
        public MedicinesContext() : base()
        {


        }

        public DbSet<Medication> Medicines { get; set; }
    }
}
