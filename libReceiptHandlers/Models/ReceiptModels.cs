
namespace libReceiptHandlers.Models
{
    public enum DepositMethodTypes
    {
        Cash = 0,
        Credit = 1
    }
    public enum RoundingMethodTypes
    {
        RoundUp = 0,
        RoundDown = 1,
        CutOff = 2
    }
    public enum PointAsTypes
    {
        AsCash = 0,
        AsDiscount = 1
    }
    public enum ReceiptDetailTypes
    {
        Normal = 0,
        Return = 1
    }
    public enum ReceiptDetailTaxTypes
    {
        TaxIncluded = 0,
        TaxExcluded = 1,
        TaxFree = 2
    }
    public enum ReceiptDetailSalesTypes
    {
        Sales = 0,
        NotSales = 1
    }
    public enum ReceiptDetailProductTypes
    {
        Item = 0,
        Voucher = 1,
        OptionItem = 2
    }
    public enum ReceiptDetailTaxFreeDivistions
    {
        NotTaxFree = 0,
        TaxFreeNormal = 1,
        TaxFreeExpandable = 2,

    }

    /// <summary>
    /// Receipt
    /// </summary>
    public class ReceiptModel
    {
        public ReceiptModel(string id,
            string transactionType, string terminalTransactionId, DateTime terminalTransactionDateTime,
            string storeId, string terminalId, string staffId,
            decimal subTotal,
            decimal grandTotal
            )
        {
            Id = id;
            TransactionType = transactionType;
            TerminalTransactionId = terminalTransactionId;
            TerminalTransactionDateTime = terminalTransactionDateTime;
            StoreId = storeId;
            TerminalId = terminalId;
            StaffId = staffId;
            SubTotal = subTotal;
            GrandTotal = grandTotal;
        }

        // Id and Type
        public string Id { get; set; }
        public string TransactionType { get; set; }
        public string? CancelType { get; set; }
        public string TerminalTransactionId { get; set; }
        public DateTime TerminalTransactionDateTime { get; set; }

        // Store, Terminal, Staff
        public string StoreId { get; set; }
        public string TerminalId { get; set; }
        public string StaffId { get; set; }

        // Customer
        public string? CustomerId { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerGroup { get; set; }
        public DateTime TimeOfEnter { get; set; }
        public int NumberOfParty { get; set; }
        public string? CustomerMemo { get; set; }

        // Sub Total
        public decimal SubTotal { get; set; }
        public decimal SubTotalDiscountAmount { get; set; }
        public int SubTotalDiscountRate { get; set; }

        // Points
        public string? NameOfPoint { get; set; }
        public int PointsUsed { get; set; }
        public int PointsAdded { get; set; }
        public int TotalPointsAfetr { get; set; }
        public int TotalPointsBefore { get; set; }
        public PointAsTypes PointAs { get; set; }

        // Miles
        public string? NameOfMile { get; set; }
        public int MilesUsed { get; set; }
        public int MilesAdded { get; set; }
        public int MilesPointsAfetr { get; set; }
        public int MilesPointsBefore { get; set; }
        public string? MilesNote { get; set; }

        // Tax
        public int TaxPercentageIfInclude { get; set; }
        public int TaxPercentageIfExclude { get; set; }

        // Round or Not
        public int RoundingPosition { get; set; }
        public int RoundingMethod { get; set; }

        // Otehr Fee
        public decimal ShippingFee { get; set; }
        public decimal ServiceFee { get; set; }
        public decimal OtherFee { get; set; }

        // Grand Total
        public decimal GrandTotal { get; set; }

        // Deposit and Change
        public DepositMethodTypes DespoitMethod { get; set; }
        public decimal Deposit { get; set; }
        public decimal Change { get; set; }

        // Closing
        public bool IsClosed { get; set; }
        public DateTime ClosingDate { get; set; }

        // Memo
        public string? Memo { get; set; }
        public string? Tags { get; set; }
        public string? Barcode { get; set; }

        // Designs
        public string? BackgroundColor { get; set; }
        public string? ForeColor { get; set; }
        public string? HeaderContentHtml { get; set; }
        public string? AfterItemsContentHtml { get; set; }
        public string? AfterGrandTotalContentHtml { get; set; }
        public string? AfterPaymentMethodContentHtml { get; set; }
        public string? FooterContentHtml { get; set; }
    }

    /// <summary>
    /// Items of receipt.
    /// </summary>
    public class ReceiptDetailModel
    {
        public ReceiptDetailModel(string id, string productId, string productName,
            decimal price, decimal salesPrice, int quantity)
        {
            Id = id;
            ProductId = productId;
            ProductName = productName;
            Price = price;
            SalesPrice = salesPrice;
            Quantity = quantity;
        }

        // Ids and Types
        public string Id { get; set; }
        public string? DetailId { get; set; }
        public ReceiptDetailTypes DetailType { get; set; }
        public ReceiptDetailSalesTypes SalesType { get; set; }

        // Product
        public string ProductId { get; set; }
        public string? ProductCode { get; set; }
        public string ProductName { get; set; }

        // Qt, Price and Tax
        public ReceiptDetailTaxTypes TaxCategory { get; set; }
        public decimal Price { get; set; }
        public decimal SalesPrice { get; set; }
        public int Quantity { get; set; }
        public string? TaxDivision { get; set; }
        public ReceiptDetailTaxFreeDivistions TaxFreeDivision { get; set; }
        public decimal TaxFreeAmount { get; set; }

        // Category and Bundle
        public string? CateogyrId { get; set; }
        public string? CategoryName { get; set; }
        public string? ProductBundleGroupId { get; set; }

    }
}
