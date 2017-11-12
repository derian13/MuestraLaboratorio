﻿using AccesoaDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoaDatos.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MYPROYECT") { }
        public DbSet<MuestraDeLaboratorio> MuestrasDeLaboratorio { get; set; }
    }
}
