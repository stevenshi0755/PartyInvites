using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Person OnePerson = new Person("Steven", 38);
            OnePerson.Display();
            OnePerson.SetName("cherry");
            OnePerson.SetAge(7);
            OnePerson.Display();
            OnePerson = new Person();
            OnePerson.Display();
        }
        class Person
        {
            private string name = "张三";
            private int age = 12;
            public void Display()
            {
                Console.WriteLine("name:{0},age:{1}", name, age);
            }
            public void SetName(string PersonName)
            {
                name = PersonName;
            }
            public void SetAge(int PersonAge)
            {
                age = PersonAge;
            }
            public Person(string Name,int Age)
            {
                name = Name;
                age = Age;
            }
            public Person()
            {
                name = "田七";
                age = 28;
            }
        }

    }
}