namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int Id { get; set; }

        public string Link { get; set; }

        public double? PriceNow { get; set; }

        public double? DesiredPrice { get; set; }

        public int? UserId { get; set; }
    }
}
