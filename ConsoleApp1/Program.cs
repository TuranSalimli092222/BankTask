using System.ComponentModel.Design;

Bank TURANBank = new Bank();
while (true)
{
BankAccount miri = new BankAccount(9911, "miri", 4600);
BankAccount elsad = new BankAccount(9911, "elsad", 5000);
BankAccount turan = new BankAccount(0909, "turan", 7000);
TURANBank.Add(turan);
TURANBank.Add(elsad);
TURANBank.Add(miri);
Console.WriteLine("Xosh gelmisiniz))");
Console.WriteLine("\n1. Movcud musteri kimi daxil ol \n2. Yeni musteri kimi qeydiyyatdan kec \n3.Bankdaki musterilerin sayi \n4.Accountu sil");
int MainManu = int.Parse(Console.ReadLine());
switch (MainManu)
{
    case 1:
        Console.WriteLine("Istifadeci adiniza daxil olun:");
        string name = Console.ReadLine();
        var profile = TURANBank.GetBankAccountbyOwner(name);

        if (profile is not null)
        {

            bool UserAnswer = true;
            while (UserAnswer)
            {
                Console.WriteLine("menudan istediyin emeliyyati sec:");
                Console.WriteLine("\n 1.DisplayAccountInfo \n 2.Deposit \n 3.Withdraw \n 4.MainManu \n 5.Cart to cart \n 0.QuitAccount ");
                int manu = int.Parse(Console.ReadLine());

                switch (manu)
                {
                    case 1:
                        profile.DisplayAccountInfo();
                        break;
                    case 2:
                        Console.WriteLine("Deposit etmey istediyiniz meblegi daxil edin: ");
                        decimal Depositamount = Convert.ToDecimal(Console.ReadLine());
                        profile.Deposit(Depositamount);
                        break;
                    case 3:
                        Console.WriteLine("Çıxarmaq istediyiniz meblegi daxil edin: ");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());
                        profile.Withdraw(amount);
                        break;
                    case 4:
                        Console.WriteLine("Esas menuyudasiniz.");
                        UserAnswer = false;
                        break;
                    case 5:
                        Console.Write("Gondermey istediyiniz istifadecinin adi : ");
                        string qebuleden = Console.ReadLine();
                        var data = TURANBank.GetBankAccountbyOwner(qebuleden);
                            if (data is null)
                            {
                                Console.WriteLine("Account tapilmadi");
                            }
                            else
                            {
                                Console.Write("Kocurmek istediyiniz meblegi daxil edin : ");
                                decimal kocurulecekmebleg = Convert.ToDecimal(Console.ReadLine());
                                profile.TransferFund(data, kocurulecekmebleg);
                                profile.Withdraw(kocurulecekmebleg);
                            }
                        break;
                    case 0:
                        Console.WriteLine("Proqramı bağlayırıq...");
                        return;

                    default:
                        Console.WriteLine("Uğursuz əməliyyat...");
                        break;

                }
            }

        }
        else
        {
            Console.WriteLine("bele bir musteri yoxdu zehmet olmasa qediyyatdan kecin:");
        }
        break;
    case 2:

        Console.WriteLine("musteri nomresi yaradin .");
        int accountNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("adinizi qeyd edin");
        string ownerName = Console.ReadLine();
        Console.WriteLine("balansinizi qeyd edin");
        decimal balans = Convert.ToDecimal(Console.ReadLine());
        TURANBank.Add(new BankAccount(accountNumber, ownerName, balans));
            Console.WriteLine("elave olundu");

        break;
    case 3:
        TURANBank.GetBankAccountsCount();
        break;
    case 4:
        Console.WriteLine("silmek istediyiniz accountun adini yazin");
        string DeleteName = Console.ReadLine();
        TURANBank.DeleteBankAccount(DeleteName);
            Console.WriteLine($"{DeleteName} silindi");
            break;

    }
}