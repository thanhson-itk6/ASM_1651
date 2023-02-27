using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    public abstract class User
    {
        private int id;
        private string fullName;
        private string phoneNumber;
        private string address;

        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public abstract void showInfo();
    }
}
