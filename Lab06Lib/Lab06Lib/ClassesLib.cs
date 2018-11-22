using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Lib
{
    public class Phone
    {
        public string Firm { get; private set; }
        public string Processor { get; private set; }
        public string OperatingSystems { get; private set; }
        public string Model { get; private set; }



        public Phone(string firm, string processor, string operating_systems, string model)
        {
            this.Firm = firm;
            this.Processor = processor;
            this.OperatingSystems = operating_systems;
            this.Model = model;

        }
        private int ram;
        public int Ram
        {
            get { return ram; }
            set
            {
                if (value > 0 && value < 100)
                {
                    ram = value;
                }
                else
                    throw new InvalidRamException();
            }
        }



        public override string ToString()
        {

            return "------------------------------------------------\n" +
            "Дані про телефон\n" +
            "------------------------------------------------\n" +
            "Фірма телефона: " + Firm + "\n" +
            "назва процесора: " + Processor + "\n" +
            "назва операційної системи: " + OperatingSystems + "\n" +
            "кiлькiсть оперативної пам'яті: " + Ram + "\n" +
            "придбати: https://allo.ua/ru/products/mobile/" + Model;

        }
    }



}

