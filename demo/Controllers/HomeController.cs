﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using demo.Models;
using Magicodes.ExporterAndImporter.Attributes;
using Microsoft.Extensions.DependencyInjection;
using MyDemo.Models.Dto;
using MyDemo.Services;
using StackExchange.Redis;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConnectionMultiplexer _redis;
        private readonly IDatabase _db;


        public HomeController(ILogger<HomeController> logger, IConnectionMultiplexer redis)
        {
            _logger = logger;
            _redis = redis;
            _db = _redis.GetDatabase();

        }

        public IActionResult Index()
        {
            _db.StringSet("fullName", "JacobCai");
            var name = _db.StringGet("fullName");

            return View("Index", name);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

    }
}
