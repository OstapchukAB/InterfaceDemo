namespace DemoLibrary
{
    public interface IProduct
    {
        bool HasOrderBeenCompleted { get; }
        string Title { get; set; }

        void ShipItem(CustomerModel customer);
    }
}