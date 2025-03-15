namespace LibraryLINQ
{
    public class Item
    {
        public string Article { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Supplier { get; set; }
        public DateOnly ProductionDate {  get; set; }

        public Item(string article, string title, string color,
            double price, string supplier, DateOnly productionDate)
        {
            this.Article = article;
            this.Title = title;
            this.Color = color;
            this.Price = price;
            this.Supplier = supplier;
            this.ProductionDate = productionDate;
        }

        public override string ToString()
        {
            return "Артикул:" + Article + ", наименоваени:" + Title + ", цвет:" + Color +
                ", стоимость:" + Price + ", поставщик:"
                + Supplier + ", дата производства:" + ProductionDate;
        }

    }
}
