using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Anagramy
{
   public partial class Anagram : MainWindow, INotifyPropertyChanged
    {
        private bool ispierwsze_slowoValid = true;
        private bool isdrugie_slowoValid = true;

        private string slowo1;
        private string slowo2;

        public Anagram(string slowo1, string slowo2)
        {
            this.slowo1 = slowo1;   
            this.slowo2 = slowo2;   
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public bool IsPierwszeSlowoValid
        {
            get
            {
                return ispierwsze_slowoValid;
            }
            set
            {
                ispierwsze_slowoValid = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Slowo1"));
            }
        }


        public bool IsDrugieSlowoValid
        {
            get { return isdrugie_slowoValid; }
            set
            {
                isdrugie_slowoValid = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Slowo2"));
            }
        }

        


       
           


            public bool Check_click()
        {

            var slowolow = slowo1.ToLower().ToCharArray();
            var slowolow2 =  slowo2.ToLower().ToCharArray();

            Array.Sort(slowolow); 
            Array.Sort(slowolow2);


            if (slowo1.Length != slowo2.Length)
            {
                return false;

            }

            slowo1 = new string(slowolow);
            slowo2 = new string(slowolow2);


            return slowo1 == slowo2;


                


                

        }
        }  
    }


