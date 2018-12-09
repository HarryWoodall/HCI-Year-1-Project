using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject {

    public class Customer {

        public enum Culture { UK, US, EUR, AUD, POL, UAE, CH, JP }
        private Dictionary<Culture, string> symbol = new Dictionary<Culture, string>();
        private Dictionary<Culture, float> rates = new Dictionary<Culture, float>(); // Google -- 06/12/2018

        private string PIN;
        private Culture culture;
        private string name;
        private int balance;
        private List<string[]> statements = new List<string[]>();
        private List<string> outputs = new List<string>();

        public Customer(string PIN, string name, int balance) {
            this.PIN = PIN;
            this.name = name;
            this.balance = balance;

            symbol.Add(Culture.UK, "£");
            symbol.Add(Culture.US, "$");
            symbol.Add(Culture.EUR, "€");
            symbol.Add(Culture.AUD, "$");
            symbol.Add(Culture.POL, "zł");
            symbol.Add(Culture.UAE, "د.إ");
            symbol.Add(Culture.CH, "¥");
            symbol.Add(Culture.JP, "¥");

            rates.Add(Culture.UK, 1.0f);
            rates.Add(Culture.US, 0.79f);
            rates.Add(Culture.EUR, 0.89f);
            rates.Add(Culture.AUD, 0.57f);
            rates.Add(Culture.POL, 0.21f);
            rates.Add(Culture.UAE, 0.21f);
            rates.Add(Culture.CH, 0.11f);
            rates.Add(Culture.JP, 0.0070f);
        }

        public string getPIN() {
            return PIN;
        }

        public void setPIN(string PIN) {
            this.PIN = PIN;
        }

        public void setCulture(Culture culture) {
            this.culture = culture;
        }

        public Culture GetCulture() {
            return culture;
        }

        public float getRate(Culture culture) {
            return rates[culture];
        }

        public float getRate() {
            return rates[culture];
        }

        public string getSymbol(Culture culture) {
            return symbol[culture];
        }

        public string getSymbol() {
            return symbol[culture];
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

        public void updateFile() {
            try {
                using (StreamReader sr = new StreamReader("../../Assests/Token.txt")) {

                    while (!sr.EndOfStream) {
                        outputs.Add(sr.ReadLine());
                    }
                    sr.Close();
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error");
                Console.WriteLine(ex.Message);
            }

            outputs[1] = PIN;

            try {
                using (StreamWriter sw = new StreamWriter("../../Assests/Token.txt")) {
                    foreach (string item in outputs) {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
