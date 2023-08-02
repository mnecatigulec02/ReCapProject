using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:IEntities
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public int ColorID { get; set; }        
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
        public string CarName { get; set; }
    }
}
