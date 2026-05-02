using Modul9_103022400132;

BankTransferConfig bankTransferConfig = new BankTransferConfig();
double uangTransfer = 0;
double biayaTransfer = 0;

if(bankTransferConfig.config.lang == "en")
{
    Console.WriteLine("Please insert the amount of money to transfer : ");
    uangTransfer = Convert.ToDouble(Console.ReadLine());
} else
{
    Console.WriteLine("Masukan jumlah uang yang akan di-transfer : ");
    uangTransfer = Convert.ToDouble(Console.ReadLine());
}

if(uangTransfer <= bankTransferConfig.config.transfer.thresshold)
{
    Console.WriteLine($"Transfer fee : {bankTransferConfig.config.transfer.low_fee}");
    biayaTransfer = bankTransferConfig.config.transfer.low_fee;
} else
{
    Console.WriteLine($"Transfer fee : {bankTransferConfig.config.transfer.high_fee}");
    biayaTransfer = bankTransferConfig.config.transfer.high_fee;
}
double totalBiaya = uangTransfer + biayaTransfer;

if(bankTransferConfig.config.lang == "en")
{
    Console.WriteLine($"Transfer fee : {biayaTransfer} and {totalBiaya}");
}
else
{
    Console.WriteLine($"Biaya Tranfer : {biayaTransfer} and {totalBiaya}");

}

Console.WriteLine("=>Transfer Fee = ");
Console.WriteLine("=>Amount = ");
Console.WriteLine("=>Select Transfer Method = ");

for(int i = 0; i <= 3; i++)
{
    Console.WriteLine($"{i}. {bankTransferConfig.config.methods[i]}");
}