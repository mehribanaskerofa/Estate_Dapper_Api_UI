﻿namespace Estate_UI.Dtos.ProductDTOs
{
    public class CreateProductDto
    {
        public string title { get; set; }
        public decimal price { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string categoryid { get; set; }
        public string coverimage { get; set; }
        public string type { get; set; }
        public string address { get; set; }
    }
}
