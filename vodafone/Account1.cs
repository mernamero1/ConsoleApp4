namespace vodafone
{
    class Account(string id, string number, string name, string password = "0000",
        decimal balance = 0, bool status = true)
    {
        string Id = id;
        string number = number;
        string Name = name;
        string password = password;
        public decimal balance = balance;
        bool status = status;
        DateTime date = DateTime.UtcNow;
        List<Transaction> transactions = [];

        public bool changepass(string id, string number, string newpass)
        {
            if (id != this.Id)
                return false;
            if (number != this.number)
                return false;
            password = newpass;
            return true;
        }
        public decimal? getbalance(string pass)
        {
            if (pass != password)
                return null;
            return balance;
        }

        public bool deposit(string num, string pass, decimal amount)
        {
            if (num != number) return false;
            if (pass != password) return false;
            balance += amount;

            transactions.Add(new Transaction(Guid.NewGuid().ToString().Substring(0, 7)
                , "Deposit", amount, "none", "none", true, DateTime.UtcNow));
            return true;
        }
        public bool widthdraw(string num, string pass, decimal amount)
        {

            if (!checking(num, pass))
                return false;
            if (balance < amount)
            {
                transactions.Add(new Transaction(Guid.NewGuid().ToString().Substring(0, 7)
                , "widthdraw", amount, "none", "none", false, DateTime.UtcNow, "Balance not ok"));
                return false;
            }
            double fee = 0.01;
            balance -= amount + (amount * (decimal)fee);
            transactions.Add(new Transaction(Guid.NewGuid().ToString().Substring(0, 7)
                , "widthdraw", amount, "none", "none", true, DateTime.UtcNow));
            return true;

        }
        private bool checking(string num, string pass)
        {
            if (num != number) return false;
            if (pass != password) return false;
            return true;
        }

        public bool transefer(string number, string pass, decimal amount, Account a)
        {
            if (!checking(number, pass))
                return false;
            if (balance < amount)
            {
                transactions.Add(new Transaction(Guid.NewGuid().ToString().Substring(0, 7)
                , "transefer", amount, Name, a.Name, true, DateTime.UtcNow, "balance not ok"));
                return false;
            }
            const double fee = 1;
            balance -= amount;
            //+(amount*(decimal)fee);
            transactions.Add(new Transaction(Guid.NewGuid().ToString().Substring(0, 7)
            , "transefer", amount, Name, a.Name, true, DateTime.UtcNow));

            a.balance += amount;
            a.transactions.Add(new Transaction(Guid.NewGuid().ToString().Substring(0, 7)
                    , "transefer", amount, Name, a.Name, true, DateTime.UtcNow));
            return true;
        }
        public string getname() => Name;
        public void setname(string newname) => Name = newname;

    }
}