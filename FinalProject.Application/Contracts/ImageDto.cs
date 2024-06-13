using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Contracts
{
    public class ImageDto
    {
        public IFormFile UploadFile { get; set; }
    }
}
