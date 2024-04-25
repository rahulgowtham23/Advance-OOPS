using System;
using System.Collections.Generic;

namespace DependencyInjection;

class Program 
{
    public static void Main(string[] args)
    {
        CCAccount ccAccount = new CCAccount();
        ccAccount.AccountNumber=123;
        ccAccount.Name="Steve Harrington";
        ccAccount.Balance=500000;

        SBAccount sbAccount = new SBAccount();
        sbAccount.AccountNumber=123;
        sbAccount.Name="Will";
        ccAccount.Balance=100000;

        List<CCAccount> ccList = new List<CCAccount>();
        ccList.Add(ccAccount);

        List<SBAccount> sbList = new List<SBAccount>();
        sbList.Add(sbAccount);

        List<IAccount> accountList = new List<IAccount>();
        
        accountList.Add(ccAccount); 
        accountList.Add(sbAccount);

    }
}