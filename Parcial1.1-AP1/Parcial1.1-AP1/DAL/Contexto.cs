using Parcial1._1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrcial1_AP.DAL
{
    public class Contexto : DbContext
    {  
            public DbSet<Evaluacion> evaluar { get; set; }
            public Contexto() : base("ConStr")
            {

            }
    }
    
}

