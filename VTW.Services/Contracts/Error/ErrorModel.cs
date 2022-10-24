using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.API.Services.Contracts.Error
{
    public class ErrorModel
    {
        public string FieldName { get; set; }
        public string Message { get; set; }
    }
}
