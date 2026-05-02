using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400132
{
    internal class Config
    {
        public string lang {get; set;}
        public Transfer transfer { get; set;}
        public List<string> methods { get; set;}
        public Confirmation confirmation {get; set;}
        public Config() 
        {
            
        }
        public Config(string lang, Transfer transfer, List<string> methods, Confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }
    }

    public class Transfer
    {
        public double thresshold { get; set; }
        public double low_fee { get; set; }
        public double high_fee { get; set; }
        
        public Transfer()
        {

        }

        public Transfer(double thresshold, double low_fee, double high_fee)
        {
            this.thresshold = thresshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
    }
    class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }

        public Confirmation()
        {

        }

        public Confirmation(string en, string id) 
        {
            this.en = en;
            this.id = id;
        }
    }
}
