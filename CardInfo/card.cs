using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardInfo
{
   public class card : icard
    {
        public bool cardvalidate(int cardno)
        {
            cardInfoEntities db = new cardInfoEntities();
            
                var data = db.CardInfoes.Where(x => x.cardno == cardno).SingleOrDefault();
            if (data == null)
            {
                throw new ArgumentException("Invalid cardno");
            }
            else
             
                    return true;
           
        }

        public bool cvvValidate(int cvv)
        {
            cardInfoEntities db = new cardInfoEntities();
            
                var data = db.CardInfoes.Where(x => x.cvvno == cvv).SingleOrDefault();
                if (data == null)
                {
                    throw new ArgumentException("Invalid cvv");
                }
                else
                    return true;
            
        }

        public bool expValidate(DateTime transactdate)
        {
            cardInfoEntities db = new cardInfoEntities();
            var data = db.CardInfoes.Where(x => x.expdate > transactdate).SingleOrDefault();
            if (data == null)
            {
                throw new ArgumentException("Invalid date");
            }
            else
                return true;
        }

        public int transaction(int transactamt)
        {

            cardInfoEntities db = new cardInfoEntities();
            CardInfo ci = new CardInfo();
            var bal = ci.balance;
            var data = db.CardInfoes.Where(x => x.balance > transactamt);
            if (data == null)
            {
                throw new ArgumentException("Balance too low");
            }
            else
            {
                var olddata = db.CardInfoes.Where(x => x.balance > transactamt).SingleOrDefault();
                ci.balance = ci.balance - transactamt;
                olddata.balance = ci.balance;
                Console.WriteLine("Balance sufficient for the transanction .Balance now is: " + ci.balance);
                var res = db.SaveChanges();
                return Convert.ToInt16(ci.balance);
            }
        }
    }
}
