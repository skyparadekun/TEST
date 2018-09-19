using System;
class Account
{
    private string _username;
    private string _password;
    private int _money;

    public string username
    {
        set
        {
            _username = value;
        }
        get
        {
            return _username;
        }
    }
    public int money
    {
        get
        {
            return _money;
        }
    }

    public int Withdraw(int amount)
    {
        if (_money >= amount)
        {
            _money -= amount;
            return _money;
        }
        else
        {
            return -1;
        }
    }

    public void Deposit(int amount)
    {
        _money += amount;
    }

    public void transfer(int amount,string username)
    {
        
    }
}