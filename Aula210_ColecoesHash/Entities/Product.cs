/* >>> CLASSE PRODUCT - TIPO REFERENCIA <<< */
namespace Aula210_ColecoesHash.Entities
{
    class Product // Tipo Referencia
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Implementacao do GetHashCode
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode(); 
        }

        // Implementacao do Equals
        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }
            Product other = obj as Product; // Downcasting
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
