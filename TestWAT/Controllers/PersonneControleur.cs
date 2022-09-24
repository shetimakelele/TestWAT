using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TestWAT.Models;

namespace TestWAT.Controllers
{
    public class PersonneControleur : Controller
    {
        // recupere entities pour le controleur en entier

        #region champs privés
        public readonly AppDbContext _dbcontext = null;
        #endregion

        #region Constructeurs
        public PersonneControleur(AppDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        #endregion

        public IActionResult PersonneList()
        {
            //on recupere notre liste

            var query = from item in this._dbcontext.Personnes.OrderBy(p => p.Nom)
                        select item;

            return View(query.ToList());
        }
    }
}
