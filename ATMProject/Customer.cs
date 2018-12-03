using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject {

    public class Customer {

        private string PIN;
        private string name;
        private int balance;
        private List<string[]> statements = new List<string[]>();

        public Customer(string PIN, string name, int balance) {
            this.PIN = PIN;
            this.name = name;
            this.balance = balance;
        }

        public string getPIN() {
            return PIN;
        }

        public void setPIN(string PIN) {
            this.PIN = PIN;
        }

        public string getName() {
            return name;
        }

        public int getBalance() {
            return balance;
        }

        public void setBalance(int balance) {
            this.balance = balance;
        }

        public bool withdraw(int ammount) {
            if (ammount < balance) {
                balance -= ammount;
                return true;
            }
            return false;
        }

        public void addStatement(string[] statement) {
            statements.Add(statement);
        }

        public List<string[]> getStatements() {
            return statements;
        }
    }
}
