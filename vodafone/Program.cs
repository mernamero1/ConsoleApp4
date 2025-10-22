namespace vodafone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new("1", "01002", "merna");
            Account account2 = new("2", "01000", "Ahmed");
            Account account3 = new("3", "010", "aya");

            //var res = account1.changepass("1", "01002", "123"); 

            //if(res)                                                                                                                          
            //    Console.WriteLine("change pass ok");
            //else
            //    Console.WriteLine("not okay");



            ////  Console.WriteLine(ress is null ? "invalid pass" : "ok");
            //decimal amount = 1000;
            //var r = account1.deposit("01002", "0000", amount);
            //if (!r)
            //    Console.WriteLine("invalid pass & num");
            //else Console.WriteLine($"done {amount} ");


            //int am = 500;
            //var re = account1.widthdraw("01002", "123", am);
            //if (!re)
            //    Console.WriteLine("invalid");
            //else
            //    Console.WriteLine($"width ok , {am}");


            //bool fi = account1.transefer("01002", "0000", 100, account2);
            //if (!fi)
            //    Console.WriteLine("process not done");
            //else
            //    Console.WriteLine("process done");

            //decimal? ress = account1.getbalance("0000");
            //if (ress is null)
            //    Console.WriteLine("invalid pass");
            //else
            //    Console.WriteLine($"ok {ress}");

            //Console.WriteLine(account2.balance);
            account1.setname("mero");
            Console.WriteLine(account1.getname());
            Savingaccount s = new(Guid.NewGuid().ToString().Substring(0, 7), 
                "0100"
                , "merna", "000");        
        }
    }
}