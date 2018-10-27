using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassifProject.Models;
using ClassifProject.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClassifProject.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;
        public HomeController(ApplicationDbContext context) {
            db = context;
        }

        public IActionResult Index(string code_spec)
        {
            IQueryable<Specialties> specialties = db.Specialties
                                                    .Include(c => c.Classifiers)
                                                    .Include(c => c.EducationLevel)
                                                    .Include(c => c.EnlargedGroups);

            IQueryable<Transcoding> transcodings = null;
            if (code_spec != null) 
            {
                transcodings = db.Transcoding
                                 .Include(c => c.Classifiers_1)
                                 .Include(c => c.Classifiers_2)
                                 .Include(c => c.Specialties_1)
                                 .Include(c => c.Specialties_2)
                                 .Where(c => c.Specialties_2.code_spec == code_spec || c.Specialties_1.code_spec == code_spec);

            }


            List<Classifiers> classifiers = db.Classifiers.ToList();
            List<EducationLevel> educationLevels = db.EducationLevel.ToList();
            List<EnlargedGroups> enlargedGroups = db.EnlargedGroups.ToList();

            ClassifiersInfoViewModel viewModel = new ClassifiersInfoViewModel
            {
                Specialties = specialties.ToList(),
                Classifiers = classifiers,
                EducationLevels = educationLevels,
                EnlargedGroups = enlargedGroups,
                Transcodings = (transcodings != null) ? transcodings.ToList() : null
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }



        //
        //
        // CREATE, EDIT, DELETE CLASSIFIER
        //
        //

        /// <summary>
        /// Creates the classifier.
        /// </summary>
        /// <returns>The classifier.</returns>
        public IActionResult CreateClassifier()
        {
            return View();
        }

        /// <summary>
        /// Creates the classifier.
        /// </summary>
        /// <returns>The classifier.</returns>
        /// <param name="classifiers">Classifiers.</param>
        [HttpPost]
        public async Task<IActionResult> CreateClassifier(Classifiers classifiers)
        {
            db.Classifiers.Add(classifiers);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Edits the classifier.
        /// </summary>
        /// <returns>The classifier.</returns>
        /// <param name="id">Identifier.</param>
        public async Task<IActionResult> EditClassifier(int? id)
        {
            if (id != null)
            {
                Classifiers classifiers = await db.Classifiers.FirstOrDefaultAsync(p => p.id_class == id);
                if (classifiers != null)
                    return View(classifiers);
            }
            return NotFound();
        }

        /// <summary>
        /// Edits the classifier.
        /// </summary>
        /// <returns>The classifier.</returns>
        /// <param name="classifiers">Classifiers.</param>
        [HttpPost]
        public async Task<IActionResult> EditClassifier(Classifiers classifiers)
        {
            db.Classifiers.Update(classifiers);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Confirms the delete classifier.
        /// </summary>
        /// <returns>The delete classifier.</returns>
        /// <param name="id">Identifier.</param>
        [HttpGet]
        [ActionName("DeleteClassifier")]
        public async Task<IActionResult> ConfirmDeleteClassifier(int? id)
        {
            if (id != null)
            {
                Classifiers classifiers = await db.Classifiers.FirstOrDefaultAsync(p => p.id_class == id);
                if (classifiers != null)
                    return View(classifiers);
            }
            return NotFound();
        }

        /// <summary>
        /// Deletes the classifier.
        /// </summary>
        /// <returns>The classifier.</returns>
        /// <param name="id">Identifier.</param>
        [HttpPost]
        public async Task<IActionResult> DeleteClassifier(int? id)
        {
            if (id != null)
            {
                Classifiers classifiers = new Classifiers { id_class = id.Value };
                db.Entry(classifiers).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }



        //
        //
        // CREATE, EDIT, DELETE EDUCATION LEVEL
        //
        //

        /// <summary>
        /// Creates the edu lvl.
        /// </summary>
        /// <returns>The edu lvl.</returns>
        public IActionResult CreateEduLvl()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEduLvl(EducationLevel educationLevel)
        {
            db.EducationLevel.Add(educationLevel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> EditEduLvl(int? id)
        {
            if (id != null)
            {
                EducationLevel educationLevel = await db.EducationLevel.FirstOrDefaultAsync(p => p.id_edulvl == id);
                if (educationLevel != null)
                    return View(educationLevel);
            }
            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> EditEduLvl(EducationLevel educationLevel)
        {
            db.EducationLevel.Update(educationLevel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        [HttpGet]
        [ActionName("DeleteEduLvl")]
        public async Task<IActionResult> ConfirmDeleteEduLvl(int? id)
        {
            if (id != null)
            {
                EducationLevel educationLevel = await db.EducationLevel.FirstOrDefaultAsync(p => p.id_edulvl == id);
                if (educationLevel != null)
                    return View(educationLevel);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEduLvl(int? id)
        {
            if (id != null)
            {
                EducationLevel educationLevel = new EducationLevel { id_edulvl = id.Value };
                db.Entry(educationLevel).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }



        //
        //
        // CREATE, EDIT, DELETE ENLARGED GROUP
        //
        //

        //CreateEnlGroup
        public IActionResult CreateEnlGroup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEnlGroup(EnlargedGroups enlargedGroups)
        {
            db.EnlargedGroups.Add(enlargedGroups);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditEnlGroup(int? id)
        {
            if (id != null)
            {
                EnlargedGroups enlargedGroups = await db.EnlargedGroups.FirstOrDefaultAsync(p => p.id_engr == id);
                if (enlargedGroups != null)
                    return View(enlargedGroups);
            }
            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> EditEnlGroup(EnlargedGroups enlargedGroups)
        {
            db.EnlargedGroups.Update(enlargedGroups);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        [HttpGet]
        [ActionName("DeleteEnlGroup")]
        public async Task<IActionResult> ConfirmDeleteEnlGroup(int? id)
        {
            if (id != null)
            {
                EnlargedGroups enlargedGroups = await db.EnlargedGroups.FirstOrDefaultAsync(p => p.id_engr == id);
                if (enlargedGroups != null)
                    return View(enlargedGroups);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEnlGroup(int? id)
        {
            if (id != null)
            {
                EnlargedGroups enlargedGroups = new EnlargedGroups { id_engr = id.Value };
                db.Entry(enlargedGroups).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }




        //
        //
        // CREATE, EDIT, DELETE SPECIALITY
        //
        //

        public IActionResult CreateSpeciality()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSpeciality(Specialties specialties)
        {
            db.Specialties.Add(specialties);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditSpeciality(int? id)
        {
            if (id != null)
            {
                Specialties specialties = await db.Specialties.FirstOrDefaultAsync(p => p.id_spec == id);
                if (specialties != null)
                    return View(specialties);
            }
            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> EditSpeciality(Specialties specialties)
        {
            db.Specialties.Update(specialties);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        [HttpGet]
        [ActionName("DeleteSpeciality")]
        public async Task<IActionResult> ConfirmDeleteSpeciality(int? id)
        {
            if (id != null)
            {
                Specialties specialties = await db.Specialties.FirstOrDefaultAsync(p => p.id_spec == id);
                if (specialties != null)
                    return View(specialties);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSpeciality(int? id)
        {
            if (id != null)
            {
                Specialties specialties = new Specialties { id_spec = id.Value };
                db.Entry(specialties).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
