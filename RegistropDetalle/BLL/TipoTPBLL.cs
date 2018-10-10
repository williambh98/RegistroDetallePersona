using RegistropDetalle.DAL;
using RegistropDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistropDetalle.BLL
{
     class TipoTPBLL
    {
        public static bool Guardar(TipoDeTelefono t)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Tipo.Add(t) != null)
                {
                    paso = contexto.SaveChanges() > 0;
                }

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static List<TipoDeTelefono> GetList(Expression<Func<TipoDeTelefono,bool>>expression)
        {
            List<TipoDeTelefono> tipTl = new List<TipoDeTelefono>();
            Contexto contexto = new Contexto();

            try
            {
                tipTl = contexto.Tipo.Where(expression).ToList();
            }catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return tipTl;

        }


    }
}
