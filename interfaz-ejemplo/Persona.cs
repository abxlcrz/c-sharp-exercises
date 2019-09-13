using System;

namespace interfaz_ejemplo
{
   abstract  public class Persona
    { 
        public string nombre;
        public string apellido;
        public int id;

        public Persona (string nombre, string apellido, int id){
            this.nombre=nombre;
            this.apellido=apellido;
            this.id=id;
        }
    }

    
}
    public class Estudiante : Persona {
        public string carrera;
        public void Estudiando{
         
        }
     
    }
}