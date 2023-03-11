using Microsoft.AspNetCore.Mvc;
using lab1.Models;
using System.Net;

namespace lab1.Controllers
{
    public enum Status
    {
        list,
        table
    }
    public class Data
    {
        public Car? car { get; set; }
        public Status? status { get; set; }
    }
    public class CarsController : Controller
    {
        public IActionResult GetAll()
        {
            var cars= Car.GetCars();
            return View(cars);
        }
        public IActionResult GetDetails(string carModel, Status? status)
        {
            var car = Car.GetCars().FirstOrDefault(c=>c.Model==carModel);
            Data data= new Data();
            data.car = car;
            data.status = status;
            return View(data);
        }
    }
}
