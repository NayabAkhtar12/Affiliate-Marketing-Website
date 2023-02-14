using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Business.Models
{
    public class ResultModel
    {
        public bool IsSuccessful { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }

    }
}
