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

        private int _documentId;
        private string _titulo;

        private string _descripcion; 
        private int _fechacreacion;
    
        //metodos de propiedades
        // get-- obtiene el valor almacenado en la propiedad
        // set-- asignar
        

        public void setDocumentId(int documentId)
        {
            _documentId = documentId;
        }
        public int getDocumentId()
        {
            return _documentId;
        
      }
        //titulo
        public void setTitulo(string titulo)
        {
            _titulo = titulo;
        }
        public string getTitulo()
        {
            return _titulo;
        }

      

       
    }
}
