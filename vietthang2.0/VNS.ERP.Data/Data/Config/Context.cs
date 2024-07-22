using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace VNS.ERP.Data
{
    public class Contexts
    {
        public static string DBServer = string.Empty;
        //public static UserERP CurrentUser;
        private static VNS.Common.ListBase<MemberFunction> lstMemberFunction = new VNS.Common.ListBase<MemberFunction>();
        public static VNS.Common.ListBase<MemberFunction> MemberFunctions
        {
            get { return lstMemberFunction; }
            set { lstMemberFunction = value; }
        }

        private static ArrayList modules = new ArrayList();
        public static ArrayList Modules
        {
            get { return modules; }
            set { modules = value; }
        }
	
        private static UserERP currentUser;
        public static UserERP CurrentUser
        {
            get { return currentUser; }
            set { 
                currentUser = value;
                if (currentUser != null && !currentUser.IsAdmin)
                {
                    modules = new ModuleBLL().GetByMember(currentUser.MemberID);
                    lstMemberFunction = new MemberFunctionBLL().GetAllForMemberID(currentUser.LoginName);                    
                }
            }
        }

        private static Period workingPeriod;
        public static Period WorkingPeriod
        {
            get { return workingPeriod; }
            set { workingPeriod = value; }
        }
        public static DateTime WorkingStartDate
        {
            get { return workingPeriod.StartDate; }
        }
        public static DateTime WorkingEndDate
        {
            get { return workingPeriod.EndDate; }
        }

        private static DateTime workingDate;
        public static DateTime WorkingDate
        {
            get { return workingDate; }
            set { workingDate = value; }
        }

        private static Period nextPeriod;
        public static Period NextPeriod
        {
            get { return nextPeriod; }
            set { nextPeriod = value; }
        }
	
    }
}
