using System;


class Bank
{
	private Staff[] _staff;
    private Account[] _account;
    private ATM[] _atm;

    static private int _numStaff;
    static private int _numAccount;
    static private int _numAtm;
    private string _name;
    private string _addr;
    private long _money;
    public Bank(string name,string addr)
    {
        _name = name;
        _addr = addr;
        _numAccount = _numAtm = _numStaff = _money = 0;
        _staff = new Staff();
        _account = new Account();
        _atm = new ATM();
    }
    public string name{
        get{
            return _name;
        }
        set{
            _name=value;
        }
    }
    public string addr{
        get{
            return _addr;
        }
        set{
            _addr=value;
        }
    }
    public string money{
        get{
            return _money;
        }
        set{
            _money=value;
        }
    }
    public bool AddAccount(string username,string password)
    {
        Account a = Account(username,password);
        _account[username] = a;
        
    }
}