using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._2
{
    internal class Contact
    {
        //khai bao cac truong
        private int id;
        private string firstname;
        private string lastname;
        private string email;
        private string phone;
        private string address;
        private object get;
        private object set;

        //tao constructor khong tham so
        public Contact()
        {
            
        }
        //tao constructor voi cac tham so
        public Contact(int id, string firstname, string lastname, string email, string phone,string address)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }
        //tao thuoc tinh cho cac truong
       public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public void Display()
        {
            Console.WriteLine("Ma so:" + id);
            Console.WriteLine("Ho va ten:{0} {1}",firstname,lastname);
            Console.WriteLine("Dia chi:"+address);
            Console.WriteLine("Dien thoai:"+phone);
            Console.WriteLine("Email"+ email);
        }
    }
}
