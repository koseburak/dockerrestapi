using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DockerRestApi.Models;

namespace DockerRestApi.Controllers
{

    [Route("api/[controller]/[action]")]
    public  class AppServiceController : Controller{
        public IEnumerable<AppService>  GetAll(){

            return new List<AppService>(){
                new AppService {
                    id = 1001,
                    name = "OneNT-Planlama",
                    description = "OneNT Planlama Servisi"
                },
                new AppService{
                    id = 1002,
                    name = "OneNT-Lokasyon",
                    description = "OneNT Lokasyon Servisi"
                },
                new AppService{
                    id = 1003,
                    name = "OneNT-Kiralama",
                    description = "OneNT Kiralama Servisi"
                },
                new AppService{
                    id = 1004,
                    name = "OneNT-MobilKurulum",
                    description = "OneNT Mobil Kurulum Servisi"
                },
                new AppService{
                    id = 1005,
                    name = "OneNT-SabitKurulum",
                    description = "OneNT Sabit Kurulum Servisi"
                },
                new AppService{
                    id = 1006,
                    name = "OneNT-Ritom",
                    description = "OneNT Ritom Servisi"
                }
            };
            
        }
    
        public IEnumerable<string> Demo(){
            return new List<string>(){ "Planlama", "Mobil Kurulum" };
        }

    }
}