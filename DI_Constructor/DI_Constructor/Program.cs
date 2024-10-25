using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Constructor
{
	/*
	whatever comment line are valid for tightly coupled class example and
	same example we are writing using dependancy injection so that we are going to write
	 if we remove comment line code and comment the uncommented line then we get tight coupled example..
	class CurrentAccount
	{
		public void CuttenrAccountDetails()
		{
			Console.WriteLine("Current Account Created...");
		}

	}
	class SavingAccount
	{
		public void SavingAccountDetails()
		{
			Console.WriteLine("Saving Account Created...");
		}

	}
	class Account
	{
		CurrentAccount ca = new CurrentAccount();
		SavingAccount sa = new SavingAccount();

		public void DisplyAccounts()
		{
			ca.CuttenrAccountDetails();
			sa.SavingAccountDetails();
		}
	}
	*/

	// creating interface through which we can call the method of another class 

	public interface IAccount
	{
		//creating abstract method 
		void PrintDetails();
	}

	// Saving account class inherite with interface with abstract method body
	class SavingAccount : IAccount
	{
		public void PrintDetails()
		{
            Console.WriteLine("Saving Account created...");
		}
	}


	// Saving current class inherite with interface with abstract method body
	class CurrentAccount : IAccount
	{
		public void PrintDetails()
		{ 
			Console.WriteLine("Current Account created...");
		}
	}

	// creating account class which we call the method of current and saving method through the interface 
	// so the object for interface inside this account class has been creating inside constructor
	class Account
	{
		// creating IAccount return type variable to store the passing object and to call the interface 
		private IAccount acc;

		// creating constructor where we are initialising the interface object
		public Account(IAccount acc)  // parameterized contructor
		{
			this.acc = acc;
		}
		public void PrintAccounts()
		{
			acc.PrintDetails();
		}

	internal class Program
	{
			static void Main(string[] args)
			{
				//Account acc = new Account();
				//acc.DisplyAccounts();

				// first we are creating the object for passing into the constructor of account i.e 
				// interface type variable that we have to pass to the account class bcoz it accepts interface type parameter
				IAccount ca = new CurrentAccount();

				// Now we are creating the object for account class by passing the interface type variable as argument
				Account a1 = new Account(ca);
				
				// calling the property of interace which we have interface object for current account
				// if we want for saving account we have to create interface type variable.
				a1.PrintAccounts();

				// this is for saving account 
				IAccount sa = new SavingAccount();
				Account a2 = new Account(sa);
				a2.PrintAccounts();
				Console.ReadLine();
			}


		}
	}
}
