using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    [NotMapped]
    public class HttpClientHelper
    {
        public static readonly HttpClient HttpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7018/")
        };
    }
}
