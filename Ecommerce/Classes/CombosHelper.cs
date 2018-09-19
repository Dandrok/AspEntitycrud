using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Classes
{
    public class CombosHelper : IDisposable
    {
        private static EcommerceContext db = new EcommerceContext();




        //ORDENAÇÕES
        public static List<Departaments> GetDepartments() {


            var dep = db.Departaments.ToList();
            dep.Add(new Departaments
            {
                DepartmentId = 0,
                Name = "[ Selecione um Departamento ]"
            });

            return dep = dep.OrderBy(d => d.Name).ToList();

        }

        public static List<City> GetCities()
        {


            var dep = db.Cities.ToList();
            dep.Add(new City
            {
                DepartmentID = 0,
                Name = "[ Selecione uma Cidade ]"
            });

            return dep = dep.OrderBy(d => d.Name).ToList();

        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}