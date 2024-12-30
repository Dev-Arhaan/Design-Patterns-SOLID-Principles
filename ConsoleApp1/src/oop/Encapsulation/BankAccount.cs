namespace ConsoleApp1.src.oop {
    public class BankAccount {
        private decimal balance;
        public BankAccount(decimal balance){
            Deposit(balance);
        }

        public void Deposit(decimal amount){
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }
            this.balance += amount;
        }

        public decimal getBalance(){
            return balance;
        }

        public void Withdraw(decimal amount){
            if (amount > balance){
                throw new ArgumentException("Withdraw amount must be less than or equal to balance");
            }

            if (amount <= 0){
                throw new ArgumentException("Withdraw amount should be more than 0");
            }
            this.balance -= amount;
        }
    }
}