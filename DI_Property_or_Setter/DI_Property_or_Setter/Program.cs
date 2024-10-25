using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DI_Property_or_Setter
{
	public interface IAcocunt
	{ 
		void PrintDetails();
	}
	class CurrentAccount : IAcocunt
	{
		public void PrintDetails()
		{
            Console.WriteLine("Deatils of Current Account...");	
		}
	}
	class SavingAccount : IAcocunt
	{
		public void PrintDetails() 
		{
			Console.WriteLine("Details of Saving Account...");
		}
	}

	class Account
	{
        public IAcocunt account { get; set; }

		public void PrintAccount()
		{
			account.PrintDetails();
		}
    }
	internal class Program
	{
		static void Main(string[] args)
		{

			Account sa = new Account();
			sa.account = new SavingAccount();
			sa.PrintAccount();

			Account ca = new Account();
			ca.account = new CurrentAccount();
			ca.PrintAccount();

			Console.ReadLine();
		}
	}
}
