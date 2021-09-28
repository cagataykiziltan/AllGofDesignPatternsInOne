using System;

namespace DesignPattern_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Fax fax = new Fax { FaxErrorCode = 4000, ErrorDescription = "Response does not come" };


            IError[] errors = { new DbError{ErrorNumber=100,Description="Connection failed" },
                                new DbError{ErrorNumber=101,Description="Query failed" },
                                new ServiceError{ErrorNumber=300,Description="Authorization failed" },
                                new FaxAdapter(fax)
                              };

            foreach (IError error in errors)
                error.SendMail();

            Console.ReadKey();
        }


    }

    interface IError
    {
        int ErrorNumber { get; set; }

        string Description { get; set; }

        void SendMail();

    }

    public class DbError : IError
    {
        public int ErrorNumber { get; set; }
        public string Description { get; set; }

        public void SendMail()
        {
            Console.WriteLine("{0} {1} -> Db Error sent", ErrorNumber.ToString(), Description);
        }
    }

    public class ServiceError : IError
    {
        public int ErrorNumber { get; set; }
        public string Description { get; set; }

        public void SendMail()
        {
            Console.WriteLine("{0} {1} -> Service Error sent", ErrorNumber.ToString(), Description);
        }
    }

    public class FaxAdapter : IError
    {
        private readonly Fax _fax;

        public FaxAdapter(Fax fax)
        {
            _fax = fax;
        }

        public int ErrorNumber
        {

            get { return _fax.FaxErrorCode; }
            set { _fax.FaxErrorCode = value; }
        }
        public string Description
        {

            get { return _fax.ErrorDescription; }
            set { _fax.ErrorDescription = value; }
        }

        public void SendMail()
        {
            Console.WriteLine("{0} {1} Fax error received ", ErrorNumber.ToString(), Description);
            //_fax.Send();
        }
    }

    public class Fax
    {
        public int FaxErrorCode { get; set; }
        public string ErrorDescription { get; set; }

        public void Send()
        {
            //....
        }

        //Fax al
        public void Get()
        {
            //....
        }

    }
}
