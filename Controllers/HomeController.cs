using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SchoolProject.Models;
using SchoolProject.Data_Access;
using System.Net.Http;

namespace SchoolProject.Controllers
{
    public class HomeController : Controller
    {
        //HttpClient httpClient;

        //static string "https://opendata.arcgis.com/datasets/a15e8731a17a46aabc452ea607f172c0_0.geojson";

        public AppDbContext dbContext; // linking db context to our controller

        public HomeController(AppDbContext context) //linking our controller to the dbcontext for link commands
        {
            dbContext = context;
            //context.Database.EnsureCreated();
        }

        HttpClient httpClient;

        static string BASE_URL = "https://developer.nps.gov/api/v1/";
        static string API_KEY = "MK0jIRuFSvPvWyoMXcN209Jj16DfwRMOWfB9KCFL"; //Add your API key here inside ""


        public IActionResult Index() //used the commented stuff to make dummy data for the db connection 
        {
            Student testStudent = new Student();
            //testStudent.StudentId = 101;
            testStudent.GPA = 3.97;
            testStudent.SchoolId = 1;
            testStudent.StudentName = "Mark Morey";
            dbContext.Students.Add(testStudent);

            Student testStudent1 = new Student();
            //testStudent.StudentId = 101;
            testStudent1.GPA = 3.09;
            testStudent1.SchoolId = 2;
            testStudent1.StudentName = "Jeremy Maury";
            dbContext.Students.Add(testStudent1);

            Student testStudent2 = new Student();
            //testStudent.StudentId = 101;
            testStudent2.GPA = 3.45;
            testStudent2.SchoolId = 3;
            testStudent2.StudentName = "Qianxi Liu";
            dbContext.Students.Add(testStudent2);


            //dbContext.SaveChanges();

            School testSchool = new School();
            //testSchool.SchoolId = 10001;
            testSchool.SchoolName = "University of South Florida";
            testSchool.State = "Florida";
            testSchool.Street = "4202 E Fowler Ave";
            testSchool.City = "Tampa";
            testSchool.County = "Hillsborough";
            testSchool.ZipCode = 33620;

            dbContext.Schools.Add(testSchool);

            School testSchool1 = new School();
            //testSchool.SchoolId = 10001;
            testSchool1.SchoolName = "University of Central Florida";
            testSchool1.State = "Florida";
            testSchool1.Street = "4000 Central Florida Blvd";
            testSchool1.City = "Orlando";
            testSchool1.County = "Orange";
            testSchool1.ZipCode = 32816;

            dbContext.Schools.Add(testSchool1);

            School testSchool2 = new School();
            //testSchool.SchoolId = 10001;
            testSchool2.SchoolName = "University of Florida";
            testSchool2.State = "Florida";
            testSchool2.Street = "Tigert Hall";
            testSchool2.City = "Gainesville";
            testSchool2.County = "Alachua";
            testSchool2.ZipCode = 32611;

            dbContext.Schools.Add(testSchool2);


            //dbContext.Students.Add(testStudent);
            //dbContext.Schools.Add(testSchool);
            dbContext.SaveChanges();

            return View();

        }

        public IActionResult AboutUs() //displays our aboutUs page
        {
            return View();
        }

        //public IActionResult Privacy() //not using bc was put here by default
        //{
        //    return View();
        //}
        //// was put here by default


        //shows all students, not using because created another controller
        //public IActionResult StudentView()
        //{
        //    var studentData = dbContext.Students.ToList();

        //    return View(studentData);

        //}

        //public IActionResult SchoolView()
        //{
        //    var schoolData = dbContext.Schools.ToList();

        //    return View(schoolData);
        //}



        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }
        // //was put here bvy default



        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
        // //was put here by default
    }
}
