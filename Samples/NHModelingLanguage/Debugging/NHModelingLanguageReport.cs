using System;

namespace T4Sample
{
    public partial class User 
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

        partial void ValidateAge(); 
        private Int32 _Age;
        public Int32 Age { 
            get { return _Age;  } 
            set {
                ValidateAge();
                _Age = value; 
            } 
        }

    }
    public partial class Manager : User
    {
    }
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

    }
}
