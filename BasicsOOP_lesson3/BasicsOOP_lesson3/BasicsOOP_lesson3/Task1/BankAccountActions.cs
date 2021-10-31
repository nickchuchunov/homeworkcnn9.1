using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson3
{

    /*1. В класс банковский счет, созданный в упражнениях, добавить метод, который переводит деньги с одного счета на другой. 
     * У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.*/
    class BankAccountActions
    {

        private static long _AccountNameActions = 155455245555;
        private decimal _RemainsActions = 32546465;
        private string _TypeBankAccount = "active";
        public long AccountNameActions { get { return _AccountNameActions; } set { _AccountNameActions = value; } }
        public decimal? RemainsActions { get { return _RemainsActions; } set { _RemainsActions = (decimal)value; } }
        public string TypeBankAccountActions { get { return _TypeBankAccount; } set { _TypeBankAccount = value; } }

            public void TaceOff(long _AccountNameActions, decimal summ) //  метод снятия со счета первый пораметр имя счета 2 параметр сумма.
            {
                bool _TopUp = decimal.TryParse(summ.ToString(), out decimal number);

                if (_TopUp & _AccountNameActions == AccountNameActions)
                {
                    RemainsActions = RemainsActions - number;
                    Console.WriteLine("Денежные средства переведены, на счете {0} денежных средств", RemainsActions);
                    Console.ReadLine();
                }
                else { Console.WriteLine("не правильные данные для перевода денежных средств"); }
            }
     }
 }


