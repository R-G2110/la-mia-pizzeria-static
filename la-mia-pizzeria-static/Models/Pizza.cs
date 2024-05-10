namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

        public Pizza(string nome, string descrizione, string fotoUrl, decimal prezzo)
        {
            this.Name = nome;
            this.Description = descrizione;
            this.ImageUrl = fotoUrl;
            this.Price = prezzo;
        }
    }

}
