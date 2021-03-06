﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWHousing.Entities.ViewModels
{
    /// <summary>
    /// View model for payments
    /// </summary>
    public class IList<PaymentViewModel> //iList of payments within
    {
        string sql = "SELECT Firstname, Lastname FROM student AS A INNER JOIN payments AS B A.StudentID = B.StudentID;"; //may not need aliases
        public PaymentVieweModel StudentID { get; set; }
        //join in data code to join student table with payment table, dapper multiplemapping
        public PaymentViewModel PaymentAmount { get; set; }
        public DateTime RequestDate { get; set; } //don't need
    }
}
