using System;

public class Product 
{
    private int _id;
    private string _productName;
    private int _price;
    private int _quantity;

    public Product(int id, string productName, int price, int quantity)
    {
        _id = id;
        _productName = productName;
        _price = price;
        _quantity = quantity;
    }

    public int TotalCostForQuantity()
    {
        return _price * _quantity;
    }

    public string GetProductInfo()
    {
        return $"ID: {_id}, Product: {_productName}, Price: {_price}, Quantity: {_quantity}, Total: {TotalCostForQuantity()}";
    }

}