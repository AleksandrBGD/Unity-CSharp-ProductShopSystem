using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class PersistentData
{
    // После компиляции загрузка и сохранения возможны по пути - "/Resources/Data.BGD"
    private const string PATH = "/ShopRefactoring/Good/Resources/Data.BGD";

    public bool DataFileExists => File.Exists(Application.dataPath + PATH);

    public void Save(Customer customer)
    {
        var data = GetCustomerData(customer);

        var stream = new FileStream(Application.dataPath + PATH, FileMode.OpenOrCreate);
        var formatter = new BinaryFormatter();

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public CustomerDataSerializable Load()
    {
        var stream = new FileStream(Application.dataPath + PATH, FileMode.Open);
        var formatter = new BinaryFormatter();

        var data = formatter.Deserialize(stream) as CustomerDataSerializable;
        stream.Close();

        return data;
    }

    private CustomerDataSerializable GetCustomerData(Customer customer)
    {
        var keys = customer.Purchases.Keys;
        var money = customer.Wallet.Money;

        var data = new CustomerDataSerializable(keys, money);

        return data;
    }
}