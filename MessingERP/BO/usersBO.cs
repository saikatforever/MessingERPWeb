using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
   public class usersBO
    {
        public String Action { get; set; }
        public Int16 ID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String UserType { get; set; }
        public String FName { get; set; }
        public String MName { get; set; }
        public String LName { get; set; }
        public String Addr { get; set; }
        public String MobileNo { get; set; }
        public String Email { get; set; }
        public String ImgExt { get; set; }
        public Nullable <System.Boolean> IsActive { get; set; }
        public Nullable <System.DateTime>  InsertedOn { get; set; }
        public Nullable <System.Int16> InsertedBy { get; set; }
        public Nullable <System.DateTime> LastUpdatedOn { get; set; }
        public Nullable<System.Int16> LastUpdatedBy { get; set; }

    }
}
