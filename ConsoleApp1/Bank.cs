using System.ComponentModel.Design;

public class Bank
{
    public BankAccount[] banksAccounts;

    public Bank()
    {
        banksAccounts = new BankAccount[0];
    }
    public BankAccount GetBankAccountbyOwner(string name)
    {
        BankAccount bankAccount = null;
        for (int i = 0; i < banksAccounts.Length; i++)
        {
            if (banksAccounts[i].OwnerName == name)
            {
                bankAccount = banksAccounts[i];
                break;
                
            }
            
        }
        if (bankAccount==null)
        {
            Console.WriteLine("Bele acc yoxdu");
        }
        return bankAccount;
    }
    public void Add(BankAccount bankAccount)
    {

        Array.Resize(ref banksAccounts, banksAccounts.Length + 1);
        banksAccounts[banksAccounts.Length - 1] = bankAccount;

    }
    public void GetBankAccountsCount()
    {
      
            Console.WriteLine(banksAccounts.Length);
        
    }
    public void DeleteBankAccount(string name)
    {
        BankAccount[] bankAccount = new BankAccount[banksAccounts.Length-1];
        for (int i = 0; i < banksAccounts.Length; i++)
        {
            if (banksAccounts[i].OwnerName==name)
            {
                banksAccounts[i] = null;
            }
        }

        int j = 0;
        for (int i = 0; i < banksAccounts.Length; i++)
        {
            if (banksAccounts[i]!=null)
            {
                bankAccount[j] = banksAccounts[i];
            }
        }
        banksAccounts = bankAccount;
    }

}






