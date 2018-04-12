using System;
namespace XamarinLayout.Models
{
    public class Event
    {
        public string Title
        {
            get;
            set;
        }
        public string Location
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        }
        public string Assignment
        {
            get;
            set;
        }
        public string Time
        {
            get;
            set;
        }
        public string Length
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }
    }

    public static class Status
    {
        public static string Assigned = "Assigned";
        public static string Pending = "Pending";
        public static string ApprovalRequired = "Approval Required";
    }
}
