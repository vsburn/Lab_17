using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_lab
{
    #region Задача
    /* Создать класс для моделирования счета в банке. 
    * Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
    * Класс должен быть объявлен как обобщенный. 
    * Универсальный параметр T должен определять тип номера счета. 
    * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
    * Создать  несколько экземпляров класса, параметризированного различными типам. 
    * Заполнить его поля и вывести информацию об экземпляре класса на печать. */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Account<string> account1 = new Account<string>();
            account1.SetBalance(201.0);
            account1.SetFullName("Jeff Bezos");
            account1.SetId("001");
            Account<int> account2 = new Account<int>();
            account2.SetBalance(190.5);
            account2.SetFullName("Elon Musk");
            account2.SetId(2);
            Account<short> account3 = new Account<short>();
            account3.SetBalance(134.5);
            account3.SetFullName("Mark Zuckerberg");
            account3.SetId(3);
            Console.WriteLine($"Имя: {account1.GetFullName(),15} Баланс: ${account1.GetBalance(),5} млрд Номер счета: {account1.GetId(),5}.");
            Console.WriteLine($"Имя: {account2.GetFullName(),15} Баланс: ${account2.GetBalance(),5} млрд Номер счета: {account2.GetId(),5}.");
            Console.WriteLine($"Имя: {account3.GetFullName(),15} Баланс: ${account3.GetBalance(),5} млрд Номер счета: {account3.GetId(),5}.");
            Console.ReadKey();

        }
    }
    class Account<T>
    {
        private T id;
        private double balance;
        private string fullName;
        public void SetId(T value)
        {
            id = value;
        }
        public T GetId()
        {
            return id;
        }
        public void SetBalance(double value)
        {
            balance = value;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void SetFullName(string value)
        {
            fullName = value;
        }
        public string GetFullName()
        {
            return fullName;
        }
    }
}
