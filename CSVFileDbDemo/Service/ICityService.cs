using CSVFileDbDemo.Model;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace CSVFileDbDemo.Service
{
    public class ICityService
    {


        private AppDbContext _context;

            public ICityService(AppDbContext context)
            {
                _context = context;
            }
            public void LoadFile(Cities cities)
            {
            string filePath = @"cities.csv";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Cities>();
                foreach (var record in records)
                {

                    var _citysRecord = new Cities();

                    _citysRecord.id = record.id;
                    _citysRecord.city = record.city;
                    _citysRecord.city_ascii = record.city_ascii;
                    _citysRecord.lat = record.lat;
                    _citysRecord.lng = record.lng;
                    _citysRecord.country = record.country;
                    _citysRecord.iso2 = record.iso2;
                    _citysRecord.iso3 = record.iso3;
                    _citysRecord.admin_name = record.admin_name;
                    _citysRecord.capital = record.capital;
                    _citysRecord.population = record.population;



                    _context.cities.Add(_citysRecord);
                }
                _context.SaveChanges();
            }
        

            
            

                

                    
                
            }
        }
    }

    


