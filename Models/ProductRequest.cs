using Microsoft.AspNetCore.Mvc;

namespace ASP4.Models

{
    public class ProductRequest
    {
        [FromQuery(Name = "limit")]
        public int Limit { get; set; } = 15;

        [FromQuery(Name = "offset")]
        public int Offset { get; set; }
    }
}