namespace StartWithVisualStudio.Models
{
    public class OrderInfo
    {
        int _orderID;
        private string _customerId;
        string _country;
        string _customerName;
        string _shippingCity;

        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }

        public string CustomerID
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string ShipCity
        {
            get { return _shippingCity; }
            set { _shippingCity = value; }
        }

        public OrderInfo(int orderId, string customerName, string country, string customerId, string shipCity)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
        }
    }
}
