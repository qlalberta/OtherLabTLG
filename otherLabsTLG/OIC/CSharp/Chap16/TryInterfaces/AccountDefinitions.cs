// AccountDefinitions.cs - Step 6

interface IAccount
{/// <summary>
/// 
/// </summary>
/// <param name="amount"></param>
	void Deposit(decimal amount);
	void Withdraw(decimal amount);
	decimal Balance {get;}
	string Owner {get; set;}
	int Id {get;}
}

interface IStatement
{ /// <summary>
/// 
/// </summary>
/// <returns></returns>
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