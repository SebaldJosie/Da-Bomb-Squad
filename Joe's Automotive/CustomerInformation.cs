using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joe_s_Automotive
{
    class CustomerInformation
    {
        private string _name, _address, _phoneNumber, _altPhoneNumber, _vehicle;

        public CustomerInformation()
        {
            _name = "";
            _address = "";
            _phoneNumber = "";
            _altPhoneNumber = "";
            _vehicle = "";
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string AltPhoneNumber
        {
            get { return _altPhoneNumber; }
            set { _altPhoneNumber = value; }
        }

        public string Vehicle
        {
            get { return _vehicle; }
            set { _vehicle = value; }
        }
    }
}
