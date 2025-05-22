using modul8_2311104057;
using System;

class Program
{
    static void Main()
    {
        var config = BankTransferConfig.LoadConfig();
        string lang = config.lang;

        // input amount
        Console.WriteLine(lang == "en" ?
            "Please insert the amount of money to transfer:" :
            "Masukkan jumlah uang yang akan di-transfer:");

        int amount = int.Parse(Console.ReadLine()!);
        int fee = (amount <= config.transfer.threshold) ?
            config.transfer.low_fee : config.transfer.high_fee;

        int total = amount + fee;

        // tampilkan biaya
        if (lang == "en")
        {
            Console.WriteLine($"Transfer fee = {fee}");
            Console.WriteLine($"Total amount = {total}");
        }
        else
        {
            Console.WriteLine($"Biaya transfer = {fee}");
            Console.WriteLine($"Total biaya = {total}");
        }

        // tampilkan metode transfer
        Console.WriteLine(lang == "en" ? "Select transfer method:" : "Pilih metode transfer:");
        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        Console.ReadLine(); // pilih metode (tidak digunakan lebih lanjut)

        // konfirmasi
        string confirmationWord = lang == "en" ? config.confirmation.en : config.confirmation.id;
        Console.WriteLine(lang == "en" ?
            $"Please type \"{confirmationWord}\" to confirm the transaction:" :
            $"Ketik \"{confirmationWord}\" untuk mengkonfirmasi transaksi:");

        string inputConfirm = Console.ReadLine()!;
        if (inputConfirm == confirmationWord)
        {
            Console.WriteLine(lang == "en" ? "The transfer is completed" : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(lang == "en" ? "Transfer is cancelled" : "Transfer dibatalkan");
        }
    }
}
