using Parrcial1_AP.BLL;
using Parrcial1_AP.Entidades;
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
            public DbSet<Estudiantes> estudiante { get; set; }
            public Contexto() : base("ConStr")
            {

            }
    }
    
}
