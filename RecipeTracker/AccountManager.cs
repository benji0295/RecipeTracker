using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RecipeTracker
{
    public class AccountManager
    {
        public static List<Account> Accounts = new List<Account>();

        private static string filePath = "accounts.json";

        static AccountManager()
        {
            LoadAccounts();
        }
        public static void LoadAccounts()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                Accounts = JsonConvert.DeserializeObject<List<Account>>(json) ?? new List<Account>();
            }
            else
            {
                Accounts = new List<Account>();
            }
        }
        public static void SaveAccounts()
        {
            if (File.Exists(filePath))
            {
                File.Copy(filePath, filePath + ".bak", true);
            }

            string json = JsonConvert.SerializeObject(Accounts, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        public static Account ValidateLogin(string username, string password)
        {
            return Accounts.FirstOrDefault(account => account.Username == username && account.Password == password);
        }
        public static void AddAccount(Account account)
        {
            LoadAccounts();

            Accounts.Add(account);
            SaveAccounts();
        }
        public static bool AccountExists(string username)
        {
            return Accounts.Any(account => account.Username == username);
        }
    }
}
