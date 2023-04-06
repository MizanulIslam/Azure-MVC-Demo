using System.ComponentModel.DataAnnotations;

namespace Azure_MVC_Demo.Models
{
    public class Company
    {
        [Key]
        public String CompanyId
        {
            get;
            set;
        }


        public String Name
        {
            get;
            set;
        }

        public String BusinessID { get; set; }
    }
}
