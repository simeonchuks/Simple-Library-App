using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models.Branch;
using LibraryData;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BranchController : Controller
    {
        private IBranch _branch;

        public BranchController(IBranch branch)
        {
            _branch = branch;
        }

        public IActionResult Index()
        {
            var branches = _branch.GetAll().Select(branch => new BranchDetailModel
            {
                Id = branch.Id,
                BranchName = branch.Name,
                IsOpen = _branch.IsBranchOpen(branch.Id),
                NumberOfAssets = _branch.GetAssets(branch.Id).Count(),
                NumberOfPatrons = _branch.GetPatrons(branch.Id).Count()
            });

            //Create a view Model to return to the Index View
            var model = new BranchIndexModel()
            {
                Branches = branches
            };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            //Get the Branches
            var branch = _branch.Get(id);

            //Retrun the DetailModel
            var model = new BranchDetailModel
            {
                Id = branch.Id,
                BranchName = branch.Name,
                Address = branch.Address,
                Telephone = branch.Telephone,
                BranchOpenedDate = branch.OpenDate.ToString("yyy-MM-dd"),
                NumberOfAssets = _branch.GetAssets(id).Count(),
                NumberOfPatrons = _branch.GetPatrons(id).Count(),
                TotalAssetValue = _branch.GetAssets(id).Sum(a => a.Cost),
                ImageUrl = branch.ImageUrl,
                HoursOpen = _branch.GetBranchHours(id)
            };

            return View(model);
        }
    }
}