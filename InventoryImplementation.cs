namespace OopsPrograms.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class InventoryM : InventoryData.Inventory
    {
        public int Sum { get; set; }
    }
    public class FoodItemsM : InventoryData.FoodItems
    {
        public int TotalPrice;
        public override string ToString()
        {
            return string.Format("name:\t{0}\nPrice per KG:\t{1}\nWeight:\t{2}\nTotalPrice:\t{3}", this.Name, this.Price, this.Weight, this.TotalPrice);
        }
    }
    public class InventoryImplementation
    {

    }
}
