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
            new JobListing { Id = 1, Title = "Software Engineer", CompanyName = "ELM", Location = "Ryiadh", JobType = JobType.FullTime, PostedDate =new  DateTime(2025, 1, 10)},
            new JobListing { Id = 2, Title = "Data Analyst", CompanyName = "SDAIA", Location = "Neom", JobType = JobType.Remote, PostedDate = new DateTime(2025, 2, 19) },
            new JobListing { Id = 1, Title = "senior dev", CompanyName = "SCAI", Location = "Jeddah", JobType = JobType.FullTime, PostedDate = new DateTime(2025, 1, 10)},
            new JobListing { Id = 2, Title = "Quality assurance engnieer", CompanyName = "san hospital", Location = "San Francisco", JobType = JobType.Remote, PostedDate = new  DateTime(2025, 1, 5)},
            new JobListing { Id = 1, Title = "Mobil develper", CompanyName = "ELM", Location = "Thawl", JobType = JobType.FullTime, PostedDate = DateTime.Now },
            new JobListing { Id = 2, Title = "web developer", CompanyName = "Data Inc.", Location = "San Francisco", JobType = JobType.Remote, PostedDate = DateTime.Now }
        };
    public IActionResult Index(string sortOrder)
    {
        var sortedJobs = jobListings.AsQueryable();  // Start with all jobs

        // Check sort order and apply sorting
        if (sortOrder == "newest")
        {
            sortedJobs = sortedJobs.OrderByDescending(j => j.PostedDate);
        }
        else if (sortOrder == "oldest")
        {
            sortedJobs = sortedJobs.OrderBy(j => j.PostedDate);
        }

        return View(sortedJobs.ToList());  // Ensure sorted list is passed to the view
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


    // add edit logic for task 9 
        public IActionResult Edit(int id)
    {
        var job = jobListings.FirstOrDefault(j => j.Id == id);
        if (job == null)
        {
            return NotFound();
        }

        return View(job);
    }

    [HttpPost]
    public IActionResult Edit(int id, JobListing updatedJob)
    {
        var job = jobListings.FirstOrDefault(j => j.Id == id);
        if (job == null)
        {
            return NotFound();
        }

        // Update job details
        job.Title = updatedJob.Title;
        job.CompanyName = updatedJob.CompanyName;
        job.Location = updatedJob.Location;
        job.JobType = updatedJob.JobType;
        job.PostedDate = updatedJob.PostedDate;

        return RedirectToAction("Index");
    }

        
    }
}
