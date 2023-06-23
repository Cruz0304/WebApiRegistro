using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;
using WebApiRegistro.Models;

namespace WebApiRegistro.Controllers
{
    public class RegistroController : ApiController
    {
        RegistrosEntities db=new RegistrosEntities();
        [HttpPost]
        public bool Insertar(RegistroEntity registros)
        {
            bool result = false;
            try
            {
                Registros newRegistros = (new Registros
                {
                    NombreCompania=registros.NombreCompania,
                    Cedula = registros.Cedula,
                    Correo = registros.Correo,
                    Id = registros.Id,
                    Nombre = registros.Nombre,
                    telefono = registros.telefono,
                    Titulo = registros.Titulo
                });
                db.Registros.Add(newRegistros);
                db.SaveChanges();
                
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        [HttpGet]
        public List<Registros> GetAll()
        {
            List<Registros> obj = new List<Registros>();
            var datos = db.Registros.ToList();
            foreach (var registro in datos)
            {
                obj.Add(new Registros
                {
                    Cedula= registro.Cedula,
                    Correo= registro.Correo,
                    Id = registro.Id,
                    Nombre= registro.Nombre,
                    NombreCompania= registro.NombreCompania,
                    telefono = registro.telefono,
                    Titulo = registro.Titulo                                                            
                });
            }
            return obj;
        }
    }
}
