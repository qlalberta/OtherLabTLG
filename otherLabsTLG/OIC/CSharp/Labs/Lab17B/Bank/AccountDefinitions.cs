// AccountDefinitions.cs - Step 7

interface IAccount
{
	void Deposit(decimal amount);
	void Withdraw(decimal amount);
	decimal Balance {get;}
	string Owner {get; set;}
	int Id {get;}
}

interface IStatement
{
	string FormatBalance();
	string GetStatement();
	int Transactions {get;}
	void Post();
	void MonthEnd();
	string Prompt {get;}
}

interface IChecking
{
	decimal Fee {get;}
}

interface ISavings
{
	decimal Interest {get;}
	decimal Rate {get; set;}
}