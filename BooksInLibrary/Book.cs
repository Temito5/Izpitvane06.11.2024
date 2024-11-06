using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksInLibrary
{
    public class Book
    {
        private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string avtor;

		public string Avtor
		{
			get { return avtor; }
			set
			{
				if (value.Length < 2)
				{
					throw new ArgumentException("Nqma takuv avtor!");
				}
				else
				{ 
					avtor = value;	
				}
			}
		}
		private string izdatelstvo;

		public string Izdatelstvo
		{
			get { return izdatelstvo; }
			set { izdatelstvo = value; }
		}
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

        public Book(string name)
        {
            this.Name = name;
        }
        public Book(string name,string avtor,string izdatelstvo,int age)
        {
			this.name = name;
			this.avtor = avtor;
			this.izdatelstvo = izdatelstvo;
            this.age = age;	
        }
		public void PrintName()
		{
            Console.WriteLine($"The book name is {this.name} !");
        }
		public void PrintAllOfThem()
		{
            Console.WriteLine($"Imeto na knigata e {this.name} s avtor {this.avtor} na izdanie {this.izdatelstvo} otpechatana prez {age}. ");
        }
    }
}
