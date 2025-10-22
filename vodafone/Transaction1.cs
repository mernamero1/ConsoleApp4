namespace vodafone
{
    class Transaction
    {
        public Transaction(string id, string type, decimal account,
            string senderName, string recieverName, bool status
            , DateTime date, string? reason = null)

        {
            this.id = id;
            this.type = type;
            this.account = account;
            this.senderName = senderName;
            this.recieverName = recieverName;
            this.status = status;

            Date = date;
            this.reason = reason;

        }

        public string id { get; init; }
        public string type { get; init; }
        public decimal account { get; init; }
        public string senderName { get; init; }
        public string recieverName { get; init; }
        public bool status { get; init; }
        public DateTime Date { get; init; }

        public string? reason { get; init; }

    }
}