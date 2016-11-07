using System;

namespace T4Sample
{
    public partial class Company
    {
        partial void ValidateName(); 
        private String _Name;
        public String Name { 
            get { return _Name;  } 
            set {
                ValidateName();
                _Name = value; 
            } 
        }

        partial void ValidateShares(); 
        private Int64 _Shares;
        public Int64 Shares { 
            get { return _Shares;  } 
            set {
                ValidateShares();
                _Shares = value; 
            } 
        }

        partial void ValidateMarketCap(); 
        private Decimal _MarketCap;
        public Decimal MarketCap { 
            get { return _MarketCap;  } 
            set {
                ValidateMarketCap();
                _MarketCap = value; 
            } 
        }

    }
    public partial class Client
    {
        partial void ValidateName(); 
        private String _Name;
        public String Name { 
            get { return _Name;  } 
            set {
                ValidateName();
                _Name = value; 
            } 
        }

        partial void ValidateStatus(); 
        private Int32 _Status;
        public Int32 Status { 
            get { return _Status;  } 
            set {
                ValidateStatus();
                _Status = value; 
            } 
        }

    }
}