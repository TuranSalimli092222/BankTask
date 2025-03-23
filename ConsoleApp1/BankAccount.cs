public class BankAccount
{
    private decimal _balance;
    private readonly int _accountnumber;
    public decimal balance
    {
        get { return _balance; }
    }
    public int AccountNumber => _accountnumber;
    public string OwnerName { get; set; }

    public BankAccount(int accountNumber, string ownerName, decimal balans)
    {
        _accountnumber = accountNumber;
        OwnerName = ownerName;
        if (balans >= 0)
        {
            _balance = balans;
        }
    }
    public void Deposit(decimal Deposidamount)
    {
        if (Deposidamount > 0)
        {
            _balance += Deposidamount;
            Console.WriteLine($"{Deposidamount} AZN ugurla kocuruldu hazirki balans {_balance}\n ");
        }
        else
        {
            Console.WriteLine("deposit menfi olduqundan deposid elave etmek olmur\n ");
        }
    }
    public void Withdraw(decimal amount)
    {
         if (amount < 0)
        {
            Console.WriteLine("menfi elave etmek olmaz");
        }
        else if (_balance >= 0 && _balance >= amount)
        {
            _balance -= amount;
            Console.WriteLine($"balansinizdan {amount} AZN cixildi hazirki balans {_balance} \n ");
        }
        else
        {
            Console.WriteLine("kifayet qeder vesait yoxdu \n ");

        }
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"adiniz {OwnerName},musteri nomreniz {AccountNumber} , balansiniz {_balance} \n ");
    }
    public void TransferFund(BankAccount account,decimal deposit)
    {
        account.Deposit(deposit);
        Console.WriteLine($"{account.OwnerName} {deposit} kocuruldu");
    }

}

