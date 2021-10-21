namespace OOPWebShop.WebShop
{
    public class Receipt
    {
        private string _receipt;

        public Receipt(string receipt)
        {
            _receipt = receipt;
        }
        public string getReceipt()
        {
            return _receipt;
        }
    }
}