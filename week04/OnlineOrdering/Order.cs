class Order
{
    private List<Product> _cart;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _cart = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _cart.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;

        foreach (Product product in _cart)
        {
            total += product.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";

        foreach (Product product in _cart)
        {
            label += $"{product.GetName()} - ID: {product.GetProductId()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL\n" +
               $"{_customer.GetName()}\n" +
               $"{_customer.GetAddress().GetFullAddress()}";
    }
}