using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace museum_server_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuseumController 
    {
        //static List<Museum> giverList = new List<Museum>(){

        //    new Museum("8:30",0, false) ,
        //    new Museum("8:40",24, false) ,
        //    new Museum("8:50",11, false) ,
            
            //};
        public MuseumController()
        {

        }
        [Route("GetMuseum")]
        [HttpGet]
        public Museum[] GetList()
        {
            string jsonFilePath = Path.Combine("Data", "MuseumDb.json");

            string jsonData = File.ReadAllText(jsonFilePath);

            Museum[] data = JsonConvert.DeserializeObject<Museum[]>(jsonData);
            return data;
        }
    
    }
}
