using Parcial1._1_AP1.Entidades;
using Parrcial1_AP.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1._1_AP1.BLL
{
    public class EvaluacionBLL
    {
       public static bool Guardar(Evaluacion evaluar)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.evaluar.Add(evaluar) != null)
                    paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Evaluacion evaluar)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(evaluar).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();

            }
            return paso;

        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.evaluar.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);


            }

            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static Evaluacion Buscar(int id)
        {
            Contexto db = new Contexto();
            Evaluacion estudiante = new Evaluacion();
            try
            {
                estudiante = db.evaluar.Find(id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                db.Dispose();
            }
            return estudiante;

        }
        public static List<Evaluacion> GetList(Expression<Func<Evaluacion, bool>> estudiante)
        {
            List<Evaluacion> Lista = new List<Evaluacion>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.evaluar.Where(estudiante).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
