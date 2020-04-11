using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickbookIntegration.Models
{
    public class RequestViewModel
    {
        public string ReportName = "TransactionList";
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public SelectList Department { get; set; }
        public string SelectedDepartment { get; set; }

        public SelectList SourceAccountType { get; set; }
        public string SelectedSourceAccountType { get; set; }

        public static IEnumerable<SelectListItem> GetDepartmentSelectItem()
        {
            yield return new SelectListItem { Text = "Amazon", Value = "Amazon" };
        }

        public static IEnumerable<SelectListItem> GetSourceAccountTypeSelectItem()
        {
            yield return new SelectListItem { Text = "Cost Of Goods Sold", Value = "CostOfGoodsSold" };
        }
    }
}