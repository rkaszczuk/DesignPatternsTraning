using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeasingSystemToRefactor.Equipment;
using LeasingSystemToRefactor.Vehicles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LeasingSystemToRefactor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        [HttpGet]
        public string GetOfferCsv(int Id)
        {
            return ObjectDbContext.Offers.Where(x=>x.IsActive && x.IsCompleted).FirstOrDefault(x => x.Id == Id).GetOfferCSV("\t");
        }
        [HttpGet]
        public string GetOfferJson(int Id)
        {            
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            return ObjectDbContext.Offers.Where(x => x.IsActive && x.IsCompleted).FirstOrDefault(x => x.Id == Id).GetOfferJson(jsonSerializerSettings);
        }
        [HttpGet]
        public string GetOfferXml(int Id)
        {
            return ObjectDbContext.Offers.Where(x => x.IsActive && x.IsCompleted).FirstOrDefault(x => x.Id == Id).GetOfferXml();
        }
        [HttpPost]
        public Offer CreateOffer(int vehicleId, int equipmentPackageId, string ccy, int numberOfMonths, decimal ownContribution)
        {
            var offer = new Offer();
            offer.Vehicle = ObjectDbContext.Vehicles.FirstOrDefault(x => x.Id == vehicleId);
            offer.EquipmentPackage = ObjectDbContext.EquipmentPackages.FirstOrDefault(x => x.Id == equipmentPackageId);
            offer.Ccy = ccy;
            offer.NumberOfMonths = numberOfMonths;
            offer.OwnContribution = ownContribution;
            offer.CalculatePayments();
            return offer;
        }
    }
}