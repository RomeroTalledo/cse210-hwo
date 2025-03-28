using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetCustomerInfo()
    {
        return $"{_customerName}\n{_address.GetFullAddress()}";
    }

    public bool IsFromUsa()
    {
        return _address.IsFromUsa();
    }

}