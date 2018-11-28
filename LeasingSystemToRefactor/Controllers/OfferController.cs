using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeasingSystemToRefactor.Equipment;
using LeasingSystemToRefactor.Parser;
using LeasingSystemToRefactor.Repositories;
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
        private OfferRepository offerRepository;
        public OfferController()
        {
            offerRepository = new OfferRepository();
        }
        [HttpGet]
        public string GetOfferCsv(int Id)
        {
            var offer = offerRepository.GetActive().FirstOrDefault(x => x.Id == Id);
            SerializerFactory serializerFactory = new SerializerFactory();
            return serializerFactory.GetSerializer(SerializerType.CsvTab).Parse(offer);
            //return offerRepository.GetActive().FirstOrDefault(x => x.Id == Id).GetOfferCSV("\t");
        }
        [HttpGet]
        public string GetOfferJson(int Id)
        {
            var offer = offerRepository.GetActive().FirstOrDefault(x => x.Id == Id);
            SerializerFactory serializerFactory = new SerializerFactory();
            return serializerFactory.GetSerializer(SerializerType.Json).Parse(offer);
        }
        [HttpGet]
        public string GetOfferXml(int Id)
        {
            var offer = offerRepository.GetActive().FirstOrDefault(x => x.Id == Id);
            SerializerFactory serializerFactory = new SerializerFactory();
            return serializerFactory.GetSerializer(SerializerType.Xml).Parse(offer);
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