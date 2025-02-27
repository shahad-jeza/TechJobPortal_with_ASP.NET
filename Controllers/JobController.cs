using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TechJobPortal.Models;

namespace TechJobPortal.Controllers
{
    public class JobController : Controller
    {
        private static List<JobListing> jobListings = new List<JobListing>
        {
            new JobListing { Id = 1, Title = "Software Engineer", CompanyName = "ELM", Location = "Ryiadh", JobType = JobType.FullTime, PostedDate = DateTime.Now },
            new JobListing { Id = 2, Title = "Data Analyst", CompanyName = "SDAIA", Location = "Neom", JobType = JobType.Remote, PostedDate = DateTime.Now },
            new JobListing { Id = 1, Title = "senior dev", CompanyName = "SCAI", Location = "Jeddah", JobType = JobType.FullTime, PostedDate = DateTime.Now },
            new JobListing { Id = 2, Title = "Quality assurance engnieer", CompanyName = "san hospital", Location = "San Francisco", JobType = JobType.Remote, PostedDate = DateTime.Now },
            new JobListing { Id = 1, Title = "Mobil develper", CompanyName = "ELM", Location = "Thawl", JobType = JobType.FullTime, PostedDate = DateTime.Now },
            new JobListing { Id = 2, Title = "web developer", CompanyName = "Data Inc.", Location = "San Francisco", JobType = JobType.Remote, PostedDate = DateTime.Now }
        };

        public IActionResult Index()
        {
            return View(jobListings);
        }

        public IActionResult Details(int id)
        {
            var job = jobListings.FirstOrDefault(j => j.Id == id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }
    }
}
