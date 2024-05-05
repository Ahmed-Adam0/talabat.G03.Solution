using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace talabat.DAL.Entities
{
    public  class product:baseentite
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public decimal price { get; set; }

        public string pictureurl { get; set; }
        public productBrand productBrand { get; set; }//nevigation proprity

        public int productBrandId { get; set; }
        public producttype  producttype   { get; set; }//nevigation proprity

        public int producttypeid { get; set; }

    }
}
