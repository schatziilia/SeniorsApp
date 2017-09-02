using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seniorsApp
{
    public class infoClass
    {
        private String Name;
        private String SurName;
        private String age;
        private String address;
        private String phonehome;
        private String phonerel;
        private String illness;

        public infoClass()
        {
            this.Name = "Δεν έχει εισαχθεί";
            this.SurName = "Δεν έχει εισαχθεί";
            this.age = "Δεν έχει εισαχθεί";
            this.address = "Δεν έχει εισαχθεί";
            this.phonehome = "Δεν έχει εισαχθεί";
            this.phonerel = "Δεν έχει εισαχθεί";
            this.illness = "Δεν έχει εισαχθεί";



        }

       
        public String name
        {
            set
            {
                Name = value;
            }

            get
            {
                return Name;
            }

        }

       
        public String surname
       {
           set
           {
               SurName = value;
           }

           get
           {
               return SurName;
           }
       }
       
       public String Age
       {
           set
           {
               age = value;
           }

           get
           {
               return age;
           }
       }

       
       public String Address
       {

           set
           {
               address = value;
           }

           get
           {
               return address;
           }
       }

      
       public String PhoneHome
       {

           set
           {
               phonehome = value;
           }

           get
           {
               return phonehome;
           }
       }

      
       public String PhoneRel
       {

           set
           {
               phonerel = value;
           }

           get
           {
               return phonerel;
           }
       }


       
       public String Illness
       {

           set
           {
               illness = value;
           }

           get
           {
               return illness;
           }
       }


       public void infofunction()
       {

       }

        public infoClass(String name)
    {

        }

    }
}
