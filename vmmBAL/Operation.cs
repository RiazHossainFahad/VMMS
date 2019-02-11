using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vmmDAL;
using vmmBLL;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace vmmBAL
{
    public class Operation
    {
        public DBConnection db = new DBConnection();
        public Informations info = new Informations();
        public Bazar bazar = new Bazar();
        public BookMeal book = new BookMeal();


        public int insertUser(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO vmmUser1 VALUES ('" + info.name + "','" + info.userType + "','" + info.refManagrtName + "','" + info.messName + "','" + info.dob + "','" + info.bloodGroup + "','" + info.userName + "','" + info.password + "','" + info.phone + "',@pic)";
            cmd.Parameters.Add(new SqlParameter("@pic", info.pic));
            return db.ExeNonQuery(cmd);
        }

        public DataTable Login(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="select * from vmmUser1 where UserName='"+info.userName+"' and Password='"+info.password+"'";
            return db.ExeReader(cmd);
        }

        public DataTable GetId(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Id from vmmUser1 where UserName='" + info.userName +"'";
            return db.ExeReader(cmd);
        }
        public void DeleteInfo(Informations info) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from vmmMealChart where MemberId='" + info.ID + "'and Date='" + info.dateFromMeal + "'";
             db.DeleteExeReader(cmd);

        }
        //23/8

        //public void DeleteInfoEB(Informations info)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "Delete from vmmBazarChart where UserId='" + info.ID + "'and Date='" + info.dateFromMeal + "'";
        //    db.DeleteExeReader(cmd);

        //}

        public int insertRequest(BookMeal bm)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO vmmRequestChart VALUES ('" + bm.userName+ "','" + bm.date+ "'," + bm.breakfast + "," +bm.lunch+ "," + bm.dinner + ",'"+bazar.items+ "','" + bazar.quantity+ "'," + bazar.amount+")";
            return db.ExeNonQuery(cmd);
        }

        public int insertRequest1(Bazar bazar)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO vmmRequestChart VALUES ('" + bazar.userName + "','" + bazar.date + "'," + book.breakfast + "," + book.lunch + "," + book.dinner + ",'" + bazar.items + "','" + bazar.quantity + "'," + bazar.amount + ")";
            return db.ExeNonQuery(cmd);
        }

        public void DeleteInfoEB(Bazar ba)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from vmmBazarChart where UserId='" + ba.id+ "'and Date='" + ba.date + "'";
            db.DeleteExeReader(cmd);

        }

        public DataTable GetItemQuantityPrice(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select items from vmmBazarChart where UserId='" + info.ID + "'and Date='" + info.dateFromMeal + "'";
            return db.ExeReader(cmd);
        }

        public DataTable GetQuantityPrice(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Quantity,Price from vmmBazarChart where UserId='" + info.ID + "'and Date='" + info.dateFromMeal + "'and Items='"+info.items+"'";
            return db.ExeReader(cmd);
        }

        public int UpdateBazar(Bazar ba)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE vmmBazarChart set Quantity= '"+ba.quantity+"',Price=" +ba.amount+ " where UserId='" +ba.id+ "' and Date='" +ba.date+ "' and Items='"+ba.items+"'";
            return db.ExeNonQuery(cmd);

        }


        public int UpdateMealChart(BookMeal bm) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE vmmMealChart set Breakfast=" + bm.breakfast + ",Lunch="+bm.lunch+",Dinner="+bm.dinner+" where MemberId='" +bm.id+ "' and Date='" +bm.date + "'";
            return db.ExeNonQuery(cmd);

        }

        public void DeleteMember(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from vmmUser1 where Id='" + info.ID + "'";
            db.DeleteExeReader(cmd);

        }

        public void DeleteRequestBazar(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from vmmRequestChart where UserName='" + info.userName + "' and date='"+info.dateFromBazar+"'and Items='"+info.items+"'";
            db.DeleteExeReader(cmd);

        }

        public void DeleteRequestMeal(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from vmmRequestChart where UserName='" + info.userName + "' and date='" + info.dateFromMeal + "'";
            db.DeleteExeReader(cmd);

        }

        public DataTable MemberInfoDelete(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Id,userType,Phone,Photo from vmmUser1 where UserName='"+info.userName+"'";
            return db.ExeReader(cmd);
        }

        //15/8


        public DataTable GetBreakLunDin(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Breakfast,Lunch,Dinner from vmmMealChart where MemberId='" + info.ID + "'and Date='"+info.dateFromMeal+"'";
            return db.ExeReader(cmd);
        }


        public int insertBazar(Bazar bazar)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO vmmBazarChart VALUES (" + bazar.userID+",'" + bazar.date + "','" + bazar.userName + "','" + bazar.items + "','" + bazar.quantity + "',"+bazar.amount+",'"+bazar.refManager+"')";
            return db.ExeNonQuery(cmd);
        }


        public DataTable LoadMemberInformation(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Id,Name,DOB,Phone,RefManagerName,MessName from vmmUser1 where RefManagerName='"+info.refManagrtName+"'";
            return db.ExeReader(cmd);
        }

        public int BookMeal(BookMeal book)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO vmmMealChart VALUES ('" + book.date + "'," + book.memberId + ",'" + book.name + "'," + book.breakfast + "," + book.lunch + "," + book.dinner + ",'" + book.refManager + "',"+book.TotalMeal+")";
            return db.ExeNonQuery(cmd);
            
        }

        public DataTable LoadMealHistorySpecificDate(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Date,Name,Breakfast,Lunch,Dinner,TotalMeal FROM vmmMealChart where refManager='" + info.refManagrtName + "'and Date BETWEEN'"+info.dateFromMeal+"'AND '"+info.dateToMeal+"'";
            return db.ExeReader(cmd);
            
        }

        public DataTable LoadMealHistory(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Id,Date,Name,Breakfast,Lunch,Dinner,TotalMeal FROM vmmMealChart where refManager='" + info.refManagrtName + "' and Date >= DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) AND Date < DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE())+1, 0)";
            return db.ExeReader1(cmd);

        }

        public DataTable LoadBazarHistory(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Date,Name,sum(Price) as Total_Price FROM vmmBazarChart where RefManager='" + info.refManagrtName + "' and Date >= DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) AND Date < DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE())+1, 0) group by Name,Date";
            return db.ExeReader1(cmd);

        }


        public DataTable LoadNotification(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from vmmRequestChart";
            return db.ExeReader1(cmd);

        }

        public DataTable LoadBazarHistorySpecificDate(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Date,Name,Items,Quantity,sum(Price) as Total_Price FROM vmmBazarChart where RefManager='" + info.refManagrtName + "'and Date BETWEEN'" + info.dateFromMeal + "'AND '" + info.dateToMeal + "' group by Name,Date,Items,Quantity";
            return db.ExeReader1(cmd);
        }

        public int MemberToManager(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update vmmUser1 set userType='Manager' where UserName='" + info.newAdminUsername + "' and Id=" + info.newAdminId + "";
            return db.ExeNonQuery(cmd);
        }

        public int changePassword(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update vmmUser1 set Password='"+info.password+"' where UserName='" + info.userName + "' and Password=" + info.oldPass + "";
            return db.ExeNonQuery(cmd);
        }

        public int ForgotPassword(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update vmmUser1 set Password='" + info.password + "' where UserName='" + info.userName + "' and Phone=" + info.phone + "";
            return db.ExeNonQuery(cmd);
        }

        public int ManagerToMember(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update vmmUser1 set userType='Member' where UserName='" + info.logInUserName + "'  and Password='" + info.logInPassword+"'";
            return db.ExeNonQuery(cmd);
          
        }

        public int ChangeRerManagerName(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update vmmUser1 set RefManagerName='"+info.newAdminUsername+"' where RefManagerName='"+info.logInUserName+"'";
            return db.ExeNonQuery(cmd);
           
        }

        public DataTable LoadMealHistoryCalculation(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name,sum(TotalMeal) as Total_Meal FROM vmmMealChart where refManager='" + info.refManagrtName + "'and Date >= DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) AND Date < DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE())+1, 0) group by Name";
            return db.ExeReader1(cmd);
        }
    }
}