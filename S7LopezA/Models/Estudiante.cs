using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace S7LopezA.Models
{
    public class Estudiante
    {
        //campos de la tabla estudiante
        [PrimaryKey, AutoIncrement]
        public int Id { set; get; }
        [MaxLength (50)]
        public string Nombre { set; get; }
        [MaxLength (25)]
        public string Usuario { set; get; }
        [MaxLength (25)]
        public string password { set; get; }

        //public date fecha {set;get;}

    }
}
