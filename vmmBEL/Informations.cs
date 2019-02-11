using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vmmBLL
{
    public class Informations
    {


        public string items { get; set; }
        public string name { get; set; }
        public string userType { get; set; }
        public string refManagrtName { get; set; }
        public string messName{ get; set; }
        public DateTime dob { get; set; }
        public string bloodGroup { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string oldPass { get; set; }
        public int phone { get; set; }
        public byte[] pic = null;
        public int ID { get; set; }
        //public  image { get; set; }

        public DateTime dateFromMeal { get; set; }
        public DateTime dateFromBazar { get; set; }
        public DateTime dateToMeal{ get; set; }

        public string newAdminName { get; set; }
        public string newAdminUsername { get; set; }

        public int newAdminId{ get; set; }

        public string logInUserName { get; set; }
        public string logInPassword {get; set; }

    }

    public class Bazar {
        public int id;

        public string items { get; set; }
        public string quantity { get; set; }
        public float amount { get; set; }
        public DateTime date { get; set; }
        public int userID { get; set; } //foreign key
        public string userName { get; set; }
        public string refManager { get; set; }
    }

    public class BookMeal {
        public string userName { get; set; }
        public  int id { get; set; }
        public DateTime  date { get; set; }
        public int  memberId { get; set; }//foreign key
        public string name { get; set; }
        public float breakfast { get; set; }
        public int lunch { get; set; }
        public int dinner { get; set; }

        public string refManager { get; set; }
        public float TotalMeal { get; set; }

        public float mealPerDay { get; set; }
    }
}
