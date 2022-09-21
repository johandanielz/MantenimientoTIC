using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dominio;
using persistencia;

namespace presentacion.Pages
{
    public class RevisionModel : PageModel
    {
        private readonly IRepositorioRevision repositorioRevision;

        public IEnumerable<Revision> revision {get;set;}

        public RevisionModel(IRepositorioRevision repositorioRevision)
        {
            this.repositorioRevision = repositorioRevision;
        }

        public void OnGet()
        {
            revision = repositorioRevision.GetAll();
        }
    }
}
