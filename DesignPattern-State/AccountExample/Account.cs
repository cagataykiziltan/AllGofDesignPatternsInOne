

namespace StatePattern.HesapExample
{
    public class Account
    {
        private IAccountState _accountState;

        public Account()
        {
            _accountState = new NormalAccount();
        }

        public void PayInterest()
        {
            _accountState.PayInterest();
        }

        public void WithdrawMoney()
        {
            _accountState.WithdrawMoney();
        }

        public void ChangeStatus(IAccountState newACcountState)
        {
            _accountState = newACcountState;
        }
    }
}
