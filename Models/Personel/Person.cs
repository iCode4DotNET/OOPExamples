using System;
using System.Collections.Generic;
using SadrTools.Extension;
namespace Models.Personel
{
    /// <summary>
    /// کلاسی برای موجودیت اشخاص
    /// </summary>
    public class Person
    {

        #region [ Ctor ] 


        // Constructor سازنده کلاس
        // متدی است هم نام اسم کلاس 
        // متد هیچی بر نمیگردنه - حتی void  هم نیست
        // مقدار دهی به پراپرتی های کلاس
        // زمان ایجاد آبجکت خود به خود فراخوانی میشود



        /// <summary>
        ///  سازنده پیش فرض کلاس و معمولا ورودی هم ندارد
        /// </summary>
        public Person()
        {
            ID = int.MinValue;
            BirthDate = DateTime.Now;
            FirstName = "DEFAULT_NAME";
            LastName = "DEFAULT_FAMILY";
            SSN = "0000000000";
            Gender = true;
            Grade = 20.00;

            Emails = new List<Email>();
            Telephones = new List<Telephone>();

        }

        public Person(int id) : this()
        {
            ID = id;
        }

        public Person(int id, string firstName) : this()
        {
            ID = id;
            FirstName = firstName;
        }

        public Person(int id, string firstName, string lastName) : this()
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(int id, string firstName, string lastName, DateTime birthDate) : this()
        {
            ID = id;
            BirthDate = birthDate;
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(int id, string firstName, string lastName, DateTime birthDate, string ssn) : this()
        {
            ID = id;
            BirthDate = birthDate;
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
        } 
        #endregion

        #region [ Fields ]

        private string _firstName;
        private string _lastName;
        private double _grade;
        private string _ssn;

        #endregion

        #region [ Property ]

        public int ID { get; set; }


        /// <summary>
        /// نام
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value.Length < 3 ? "DEFAULT_NAME" : value;
            }
        }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public double Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
        public string SSN
        {
            get { return _ssn; }
            set
            {
                //_ssn = _ssn.Length == 10 ? value : "0000000000";

                _ssn = value.Length == 10 ? value : throw new System.Exception("کد ملی باید حتما 10 رقمی باشد");

            }
        }

        public DateTime BirthDate { get; set; }

        public bool Gender { get; set; }

        /// <summary>
        /// لیستی از اطلاعات تماس هر شخص
        /// </summary>
        public List<Telephone> Telephones { get; set; } 
      
        /// <summary>
        /// لیستی از ایمیل آدرس های هر شخص
        /// </summary>
        public List<Email> Emails { get; set; }

        #endregion

        #region [ Read Only Property ]

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string TitleEn
        {
            get
            {
                return Gender ? "Mr. " : "Ms. ";
            }
        }

        public string TitleFa
        {
            get
            {
                return Gender ? "آقا" : "خانم";
            }
        }

        public byte Age
        {
            get
            {
                return (byte)(DateTime.Now.Year - BirthDate.Year);
            }
        }


        public string PersianBirthDate
        {
            get
            {
                return BirthDate.ToPersianDate();
            }

        }
        #endregion

        #region [ Method ]
        public string GetInformation()
        {
            return $"{ID}\n{FirstName}\n{LastName}\n{BirthDate}\n{SSN}\n\n\n";
        }

       


        public override string ToString()
        {
            var result = $"ID = {ID} " +
                   $"Full Name = {TitleEn}{FullName} " +
                   $"Birth Date = {BirthDate.ToPersianDate()} " +
                   $"Age = {Age}\n";

            foreach (var item in Emails)
            {
                result += item;
            }

            foreach (var item in Telephones)
            {
                result += item;
            }


            return result ;
        }
        #endregion

    }
}