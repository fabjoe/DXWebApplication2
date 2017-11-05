using DevExpress.Web.Mvc;
using NbaPlayersManager2.Infrastructure;
using NbaPlayersManager2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NbaPlayersManager2.Controllers
{
    public class HomeController : Controller
    {
        private readonly PlayerRepo _playerRepo;
        public HomeController()
        {
            _playerRepo = new PlayerRepo();
        }
        public ActionResult Index()
        {
            // DXCOMMENT: Pass a data model for GridView
            
            return View();
        }
        public ActionResult Index2()
        {
            // DXCOMMENT: Pass a data model for GridView
            return View(_playerRepo.GetAll().OrderBy(p=>p.EffMin));
        }

        public ActionResult GridViewPartialView() 
        {
            // DXCOMMENT: Pass a data model for GridView in the PartialView method's second parameter
            return PartialView("GridViewPartialView", _playerRepo.GetAll());
        }


        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            return PartialView("_GridViewPartial", _playerRepo.GetAll());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(NbaPlayersManager2.Models.Player item)
        {
            var model = new object[0];
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to insert the new item in your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUpdate(NbaPlayersManager2.Models.Player item)
        {
            var model = new object[0];
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to update the item in your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialDelete(System.String PlayerID)
        {
            var model = new object[0];
            if (PlayerID != null)
            {
                try
                {
                    // Insert here a code to delete the item from your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewPartial", model);
        }
        public ActionResult CustomClick(string SelectedPlayer)
        {
            return RedirectToAction("PlayerDetail",new { playerId= SelectedPlayer});
        }
        public ActionResult PlayerDetail(string playerId)
        {

            return View(_playerRepo.GetAll().Where(p=>p.PlayerID == playerId).FirstOrDefault());
        }
    }
}

public enum HeaderViewRenderMode { Full, Title }