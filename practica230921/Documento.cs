using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica230921
{
    class Documento
    {

        //definir miembros
        // propiedades 

      public string _documentoId { get; set; }
      public string _titulo { get; set; }
      public string _descripcion { get; set; }


        

        //propiedades autoimplementadas
       public string _fechacreacion { get;  set; }
       public string _contenido { get; set; }

        //metodo constructor
        public Documento(string documentoId, string titulo, string descripcion, string fechacreacion, string contenido ) //metodo constructor vacio
        {
            _documentoId = documentoId;
            _titulo = titulo;
            _descripcion = descripcion;
            _fechacreacion = fechacreacion;
            _contenido = contenido;
        }

        public string ObtenerDatos()
        {
            return "Id de Documento: " + _documentoId + " Titulo: "   +  _titulo   +   " Descripcion : "
                +   _descripcion +   " Fecha Creacion :  " +    _fechacreacion  +  "Contenido :  " +  _contenido ;

        }
    }

       
    }

