using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConstrutores
{
    internal class BankAccount
    {
        private string _accountNumber;
        private string _accountOwner;
        public double Value { get; private set; }

        public BankAccount(string accountNumb, string accountOwn)
        {
            this._accountNumber = accountNumb;
            this._accountOwner = accountOwn;
        }
        public BankAccount(string accountNumb, string accountOwn, double value):this(accountNumb, accountOwn)
        {
            this.Value = value;
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
        }


        public string AccountOwner
        {
            get => _accountOwner;
            set
            {
                _accountOwner = value;
            }
        }

        public void addValue(double value)
        {
            this.Value += value;
        }

        public void removeValue(double value)
        {
            if(this.Value < value) {
                Console.WriteLine("Valor insuficiente");
            }
            else
            {
                this.Value -= (value+5);
            }
        }





        public override string ToString()
        {
            return "Conta " + _accountNumber + ", Titular: " + _accountOwner + ", Saldo: " + Value;
        }
    }
}
