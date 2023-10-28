using SallesWeb.Data;
using SallesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SallesWeb.Services
{
    public class SellerService
    {

        private readonly SallesWebContext _context;

        public SellerService(SallesWebContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }




        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }


        public Seller FindById(int id)
        {
            return _context.Sellers.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);


        }

        public void Delete(int id)
        {
            var obj = _context.Sellers.Find(id);
            _context.Sellers.Remove(obj);
            _context.SaveChanges();
        }




    }
}
