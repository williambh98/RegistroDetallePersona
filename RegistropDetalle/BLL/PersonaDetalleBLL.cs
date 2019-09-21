using RegistropDetalle.DAL;
using RegistropDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistropDetalle.BLL
{
    public class PersonaDetalleBLL
    {
        public static bool Guardar(PersonaDetalle Persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.PersonaD.Add(Persona) != null)
                    paso = contexto.SaveChanges() > 0;

            }catch(Exception)
            {
                throw;
            }

            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(PersonaDetalle persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                //var Anterior = contexto.PersonaD.Find(persona.PersonaId);
                var Anterior = Buscar(persona.PersonaId);
                foreach (var item in Anterior.Telefonos.ToList())
                {
                    if (!persona.Telefonos.Exists(d => d.Id == item.Id))
                        contexto.Entry(item).State = EntityState.Deleted;
                }
                foreach(var item in persona.Telefonos)
                {
                    if(item.Id==0)
                        contexto.Entry(item).State = EntityState.Added;
                    else
                        contexto.Entry(item).State = EntityState.Modified;
                }
                contexto.Entry(persona).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {contexto.Dispose(); }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.PersonaD.Find(id);
                contexto.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;

                paso = (contexto.SaveChanges() > 0);
            }catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static PersonaDetalle Buscar(int id)
        {
            Contexto contexto = new Contexto();
            PersonaDetalle persona = new PersonaDetalle();

            try
            {
                persona = contexto.PersonaD.Find(id);
                if(persona!=null)
                    persona.Telefonos.Count();
            }catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return persona;
        }

        public static List<PersonaDetalle> GetList (Expression<Func<PersonaDetalle, bool>> expression)
        {
            List<PersonaDetalle> Lista = new List<PersonaDetalle>();
            Contexto contexto = new Contexto();
            try
            {
                Lista = contexto.PersonaD.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }

    }
}
