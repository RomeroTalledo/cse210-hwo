using  System;

public class Order 
{
     private Customer _customer;
    private List<Product> _products;

     public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int TotalCost()
    {
        int total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCostForQuantity();
        }
        total += _customer.IsFromUsa() ? 5 : 35; 
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packaging Label:\n";
        foreach (var product in _products)
        {
            label += product.GetProductInfo() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerInfo()}";
    }
}