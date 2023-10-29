using Microsoft.EntityFrameworkCore.Internal;
using SallesWeb.Models;
using SallesWeb.Models.Enums;
using System;

namespace SallesWeb.Data
{
    public class SeedingService
    {

        public SallesWebContext _context { get; set; }

        public SeedingService(SallesWebContext sallesWebContext)
        {
            _context = sallesWebContext;

        }

        public void Seed()
        {

            if (_context.Sellers.Any() || _context.SalesRecord.Any() || _context.Department.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computer");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");


            Seller s1 = new Seller(1, "João", "joão@gmail.com", new DateTime(1989, 2, 25), 1000.00, d1);
            Seller s2 = new Seller(2, "Ricardo", "ricard@gmail.com", new DateTime(1999, 5, 20), 1300.00, d2);
            Seller s3 = new Seller(3, "Erick", "erick@gmail.com", new DateTime(1990, 3, 10), 1200.00, d3);
            Seller s4 = new Seller(4, "Maria", "maria@gmail.com", new DateTime(2000, 10, 15), 1500.00, d1);
            Seller s5 = new Seller(5, "Livia", "livia@gmail.com", new DateTime(1995, 7, 6), 1000.00, d1);
            Seller s6 = new Seller(6, "Pedro", "pedro@gmail.com", new DateTime(1989, 2, 15), 1900.00, d4);
            Seller s7 = new Seller(7, "Renata", "renata@gmail.com", new DateTime(1999, 2, 25), 2000.00, d2);
            Seller s8 = new Seller(8, "Ronaldo", "ronaldo@gmail.com", new DateTime(1990, 2, 25), 1600.00, d3);
            Seller s9 = new Seller(9, "Cecilia", "cecilia@gmail.com", new DateTime(1997, 4, 10), 1700.00, d3);
            Seller s10 = new Seller(10, "Paloma", "paloma@gmail.com", new DateTime(1987, 8, 5), 1500.00, d4);



            SalesRecord sr1 = new SalesRecord(1, new DateTime(2023, 1, 1), 5000.00, SalesStatus.Billed, s2);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2023, 1, 1), 2200.00, SalesStatus.Pending, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2023, 1, 5), 1500.00, SalesStatus.Canceled, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2023, 1, 8), 300.00, SalesStatus.Billed, s5);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2023, 1, 9), 660.00, SalesStatus.Billed, s6);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2023, 1, 15), 880.00, SalesStatus.Pending, s7);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2023, 1, 19), 660.00, SalesStatus.Canceled, s8);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2023, 1, 30), 1000.00, SalesStatus.Canceled, s10);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2023, 1, 24), 3000.00, SalesStatus.Pending, s2);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2023, 2, 1), 6000.00, SalesStatus.Billed, s9);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2023, 2, 3), 1300.00, SalesStatus.Billed, s8);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2023, 2, 5), 350.00, SalesStatus.Canceled, s6);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2023, 2, 9), 5500.00, SalesStatus.Pending, s4);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2023, 2, 20), 1000.00, SalesStatus.Canceled, s2);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2023, 2, 15), 1500.00, SalesStatus.Pending, s2);
            SalesRecord sr16 = new SalesRecord(16, new DateTime(2023, 2, 26), 1990.0, SalesStatus.Billed, s3);
            SalesRecord sr17 = new SalesRecord(17, new DateTime(2023, 2, 27), 5000.00, SalesStatus.Billed, s6);
            SalesRecord sr18 = new SalesRecord(18, new DateTime(2023, 2, 20), 50.00, SalesStatus.Billed, s7);
            SalesRecord sr19 = new SalesRecord(19, new DateTime(2023, 3, 1), 550.00, SalesStatus.Billed, s8);
            SalesRecord sr20 = new SalesRecord(20, new DateTime(2023, 3, 5), 5500.00, SalesStatus.Pending, s9);
            SalesRecord sr21 = new SalesRecord(21, new DateTime(2023, 3, 7), 900.00, SalesStatus.Pending, s10);
            SalesRecord sr22 = new SalesRecord(22, new DateTime(2023, 3, 7), 1200.00, SalesStatus.Pending, s3);
            SalesRecord sr23 = new SalesRecord(23, new DateTime(2023, 3, 9), 1560.00, SalesStatus.Canceled, s2);
            SalesRecord sr24 = new SalesRecord(24, new DateTime(2023, 3, 11), 50.99, SalesStatus.Pending, s2);
            SalesRecord sr25 = new SalesRecord(25, new DateTime(2023, 3, 13), 100.00, SalesStatus.Billed, s6);
            SalesRecord sr26 = new SalesRecord(26, new DateTime(2023, 3, 25), 2250.00, SalesStatus.Billed, s8);
            SalesRecord sr27 = new SalesRecord(27, new DateTime(2023, 3, 30), 105.00, SalesStatus.Billed, s7);
            SalesRecord sr28 = new SalesRecord(28, new DateTime(2023, 3, 19), 1100.00, SalesStatus.Pending, s6);
            SalesRecord sr29 = new SalesRecord(29, new DateTime(2023, 3, 22), 1000.00, SalesStatus.Pending, s8);
            SalesRecord sr30 = new SalesRecord(30, new DateTime(2023, 3, 10), 600.00, SalesStatus.Billed, s7);


            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Sellers.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr7, sr8, sr9, sr10,
                sr11, sr12, sr13, sr14, sr15, sr16, sr17, sr18, sr19, sr20, sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30
                );

            _context.SaveChanges();

        }
    }
}
