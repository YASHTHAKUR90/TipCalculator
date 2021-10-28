using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_Tax_OOPS
{
    class Class1
    {
        //ATTRIBUTES
        private double amount,amount_per_person,total_amount,tip_per_person;
        private int tip_percent, num_of_people;

        //CALCULATE TIP PER PERSON
        public double calculateTpp()
        {
                double temp = (amount * tip_percent) / 100;
                return temp/num_of_people;
        }

        //CALCULATE AMOUNT PER PERSON
        public double calculateApp()
        {
            double temp, temp1;
            temp1 = calculateTpp();
            temp = (amount/num_of_people) + temp1;
            return temp;

        }

        //CALCULATE TOTAL AMOUNT
        public double calculateTotal()
        {
            double temp = calculateApp();
            temp = temp * num_of_people;
            return temp;
        }

        //CONSTRUCTOR
        public Class1(double amount,
                      int tip_percent,
                      int num_of_people)
        {
            this.amount = amount;
            this.tip_percent = tip_percent;
            this.num_of_people = num_of_people;
        }

        //GETTERS
        public double getamount()
        {
            return amount;
        }

        public int gettip_percent()
        {
            return tip_percent;
        }
        public int getnum_of_people()
        {
            return num_of_people;
        }

        //SETTERS

        public void setamount(double amount)
        {
            this.amount = amount;
        }

        public void settip_percent(int tip_percent)
        {
            this.tip_percent = tip_percent;
        }

        public void setnum_of_people(int num_of_people)
        {
            this.num_of_people = num_of_people;
        }



    }
}
