using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ostosAppi_api.Models
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Store { get; set; }
        public List<ShoppingItem> ShoppingItem { get; set; }
        public bool IsDone { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

    }

    public class ShoppingItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string AmountUnit { get; set; }
        public double? Price { get; set; }
        public bool IsCollected { get; set; }

    }
}
