namespace WoodPelletsLib
{
    public class WoodPellet
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Quality { get; set; }

        public WoodPellet(int id, string brand, double price, int quality)
        {
            Id = id;
            Brand = brand;
            Price = price;
            Quality = quality;
        }

        public WoodPellet()
        {
        }

        public void ValidateId()
        {
            if (Id < 0)
            {
                throw new System.ArgumentException("Id must be greater than 0");
            }
        }

        public void ValidateBrand()
        {
            if (string.IsNullOrEmpty(Brand))
            {
                throw new System.ArgumentException("Brand must not be empty");
            }
            if (Brand.Length < 2)
            {
                throw new System.ArgumentException("Brand must be longer than 2 characters");
            }
        }
        public void ValidatePrice()
        {
            if (Price < 0)
            {
                throw new System.ArgumentException("Price must be greater than 0");
            }
        }

        public void ValidateQuality()
        {
            if (Quality < 1 || Quality > 5)
            {
                throw new System.ArgumentException("Quality must be between 1 and 5");
            }
        }

        public void Validate()
        {
            ValidateId();
            ValidateBrand();
            ValidatePrice();
            ValidateQuality();
        }
    }
}
