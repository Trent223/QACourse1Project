using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CodeLouisvilleUnitTestProject;

namespace CodeLouisvilleUnitTestProject
{
    public class Car : Vehicle
    {
        
        private HttpClient _httpClient;  
        
       public int NumberOfPassengers { get; private set; }
        public Car()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://vpic.nhtsa.dot.gov/api");
                               
        }
        public Car(int numberOfTires, double gasTankCapacity, string make, string model, double milesPerGallo)
        {
            NumberOfTires = 4;     
        }
        //public Task<bool> IsValidForMakeAsync()
       // {

        // }
          public async Task<bool> WasModelMadeInYearAsync(int year)

          {
            var model = this.Model; 
            if (year < 1995)
                throw new ArgumentException("No data is available for years before 1995");
            string urlSuffix = $"vehicles/getmodelsformake/make/{Make}/modelyear/{year}?format=json";
            var response = await _httpClient.GetAsync(urlSuffix);
            var content = await  response.Content.ReadAsStringAsync();
            var data =JsonSerializer.Deserialize<GetModelForMake>(content);
            return  data.Results.Any(r => r.Model_Name == Model);
            
            
          }
           public void AddPassengers(int NumberOfPassenger)
            {

            }
            public void RemovePassengers(int NumberOfPassenger)
           {

            }
    }
}
