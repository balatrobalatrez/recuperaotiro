using System;
using System.Collections.Generic;
using System.Text;
using recuperatorio.Data;
using recuperatorio.Repositories;
using Microsoft.EntityFrameworkCore;
using recuperatorio.Models;

namespace recuperatorio.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AplicationDbContext _context;

        public GenericRepository()
        {
            _context = new AplicationDbContext();
            _context.Database.EnsureCreated();

        }

        public void Agregar(T entidad)
        {
            _context.Set<T>().Add(entidad);
            _context.SaveChanges();
        }

        public List<T> ObtenerTodos()
        {
            return _context.Set<T>().ToList();
        }


    }
}





      