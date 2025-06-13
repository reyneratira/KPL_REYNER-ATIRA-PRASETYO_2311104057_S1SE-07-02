using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using tpmodul2_2311104057;

class Program
{
    static string filePath = "users.json";

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Aplikasi Login & Registrasi ===");
            Console.Write("1. Registrasi\n2. Login\n3. Keluar\nPilih menu (1/2/3): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Register();
                    break;
                case "2":
                    Login();
                    break;
                case "3":
                    Console.WriteLine("Keluar dari aplikasi.");
                    return;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }

            Console.WriteLine("Tekan Enter untuk melanjutkan...");
            Console.ReadLine();
        }
    }

    static void Register()
    {
        Console.Write("Masukkan username: ");
        string username = Console.ReadLine().Trim();

        if (!IsAsciiLettersOnly(username))
        {
            Console.WriteLine("Username hanya boleh berisi huruf alfabet ASCII.");
            return;
        }

        Console.Write("Masukkan password: ");
        string password = Console.ReadLine();

        // Validasi panjang password
        if (password.Length < 8 || password.Length > 20)
        {
            Console.WriteLine("Password harus 8-20 karakter.");
            return;
        }

        // Validasi password tidak mengandung username
        if (password.ToLower().Contains(username.ToLower()))
        {
            Console.WriteLine("Password tidak boleh mengandung username.");
            return;
        }

        // Validasi minimal 1 karakter unik
        if (!password.Any(c => "!@#$%^&*".Contains(c)))
        {
            Console.WriteLine("Password harus mengandung minimal 1 karakter unik (!@#$%^&*).");
            return;
        }

        string hash = HashPassword(password);

        List<User> users = LoadUsers();
        if (users.Any(u => u.Username == username))
        {
            Console.WriteLine("Username sudah terdaftar.");
            return;
        }

        users.Add(new User { Username = username, PasswordHash = hash });
        SaveUsers(users);

        Console.WriteLine("Registrasi berhasil!");
    }

    static void Login()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine().Trim();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        string hash = HashPassword(password);
        List<User> users = LoadUsers();

        var user = users.FirstOrDefault(u => u.Username == username && u.PasswordHash == hash);

        if (user != null)
            Console.WriteLine($"Login berhasil. Selamat datang, {username}!");
        else
            Console.WriteLine("Login gagal. Username atau password salah.");
    }

    static string HashPassword(string password)
    {
        using SHA256 sha256 = SHA256.Create();
        byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(hashBytes);
    }

    static List<User> LoadUsers()
    {
        if (!File.Exists(filePath))
            return new List<User>();

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
    }

    static void SaveUsers(List<User> users)
    {
        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    static bool IsAsciiLettersOnly(string input)
    {
        return input.All(c => c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
    }
}
