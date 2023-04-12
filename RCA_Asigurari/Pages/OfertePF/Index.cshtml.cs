using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RCA_Asigurari.Data;
using RCA_Asigurari.Migrations;
using RCA_Asigurari.Models;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace RCA_Asigurari.Pages.OfertePF
{
    public class IndexModel : PageModel
    {
        private readonly RCA_Asigurari.Data.RCA_AsigurariContext _context;
        private readonly string ADMIN_EMAIL = "admin@gmail.com";

        public IndexModel(RCA_Asigurari.Data.RCA_AsigurariContext context)
        {
            _context = context;
        }

        public IList<OfertaPF> OfertaPF { get; set; } = default!;
        public String CurrentFilter { get; set; }


      

        public async Task OnGetAsync(string searchString)
        {
           

            CurrentFilter = searchString;

            if (_context.OfertaPF != null)
            {
                var userEmail = User.Identity.Name;
                var ofertePF = _context.OfertaPF
                    .Include(o => o.CategorieVehicul)
                    .Include(o => o.Client)
                    .Include(o => o.TipCombustibil).AsNoTracking();

                if (userEmail != ADMIN_EMAIL)
                { ofertePF = ofertePF.Where(ofertapersfizica => ofertapersfizica.Client.Email == userEmail); }

                OfertaPF = await ofertePF.ToListAsync();

               
            }
            //if (!String.IsNullOrEmpty(searchString))
            //{
               
            //    ofertePF = ofertePF.Where(s => s.Client.NumeProprietar.Contains(searchString)

            //   || s.NrInmatriculare.Contains(searchString)
            //   || s.NumarIdentificare.Contains(searchString)
            //   || s.Marca.Contains(searchString)
            //   || s.CategorieVehicul.CategoriaVehicul.Contains(searchString)
            //   || s.TipCombustibil.TipulCombustibil.Contains(searchString)
            //   || s.SerieCIV.Contains(searchString)
            ////   || s.AnFabricatie.Contains(searchString)
            //   || s.Model.Contains(searchString)
            //   || s.NumarIdentificare.Contains(searchString));


            //}

        }
        public async Task<IActionResult> OnPostAsync()
        {
            // Obțineți lista de obiecte OfertaPF din baza de date
            var ofertePF = await _context.OfertaPF
                .Include(o => o.CategorieVehicul)
                .Include(o => o.Client)
                .Include(o => o.TipCombustibil)
                .ToListAsync();

            // Pentru fiecare obiect din lista, generați un fișier PDF separat
            foreach (var oferta in ofertePF)
            {
                // Generați PDF-ul folosind metoda GeneratePdfFromObjectData() pentru obiectul curent
                GeneratePdfFromObjectData(oferta);

                // Așteptați un moment pentru a evita suprasolicitarea serverului
                await Task.Delay(1000);
            }

            // Returnați un redirect către pagina curentă
            return RedirectToPage();
        }

        public void GeneratePdfFromObjectData(OfertaPF oferta)
        {
            // Creați un nou document MigraDoc
            Document document = new Document();

            // Adăugați o nouă secțiune la document
            Section section = document.AddSection();

            // Adăugați o nouă tabelă la secțiune
            MigraDoc.DocumentObjectModel.Tables.Table table = section.AddTable();

            // Adăugați coloane la tabelă
            table.AddColumn(Unit.FromCentimeter(2));
            table.AddColumn(Unit.FromCentimeter(5));
            table.AddColumn(Unit.FromCentimeter(3));

            // Adăugați antete la tabelă
            Row headerRow = table.AddRow();
            headerRow.Cells[0].AddParagraph("ID");
            headerRow.Cells[1].AddParagraph("Pret");
            headerRow.Cells[2].AddParagraph("Masa");

            // Adăugați rânduri de date la tabel
            Row dataRow = table.AddRow();
            dataRow.Cells[0].AddParagraph(oferta.CNP.ToString());
            dataRow.Cells[1].AddParagraph(oferta.SerieCI.ToString());
            dataRow.Cells[2].AddParagraph(oferta.Pret.ToString());

            // Creați un nou procesor de documente PDF
            PdfDocumentRenderer renderer = new PdfDocumentRenderer();

            // Setează documentul MigraDoc pentru a fi randat
            renderer.Document = document;

            // Randează documentul într-un fișier PDF
            renderer.RenderDocument();
            string fileName = "Oferta_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + oferta.ID.ToString() + ".pdf";
            renderer.Save(fileName);
        }





    }
}

