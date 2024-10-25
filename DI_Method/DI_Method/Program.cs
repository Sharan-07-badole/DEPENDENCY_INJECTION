using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Method
{
	public interface IAccount
	{
		void AccountDetails();
	}

	class SavingAccount : IAccount
	{
		public void AccountDetails()
		{
			Console.WriteLine("Saving Acoount Details...");
		}
	}

	class CurrentAccount : IAccount
	{
		public void AccountDetails()
		{
            Console.WriteLine("Current Account Details...");
		}
	}

	class Account
	{
		public void DisplayAccount(IAccount account)
		{
			account.AccountDetails();
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Account ca = new Account();
			ca.DisplayAccount(new CurrentAccount());

			Account sa = new Account();
			sa.DisplayAccount(new SavingAccount());

			Console.ReadLine();
		}
	}
}
