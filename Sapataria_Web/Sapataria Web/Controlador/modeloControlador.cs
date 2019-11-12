using Microsoft.EntityFrameworkCore;
using Sapataria_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sapataria_Web.Controlador
{
    public class modeloControlador<T> where T : Modelo
    {
        protected readonly SapatariaContext context;
        protected readonly DbSet<T> dbSet;

        public modeloControlador(SapatariaContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
    }
}
