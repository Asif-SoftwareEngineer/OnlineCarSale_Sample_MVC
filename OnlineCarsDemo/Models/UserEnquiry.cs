using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineCarsDemo.Models
{
    public class UserEnquiry
    {
        private Int32 m_Car_ID;
        private string m_Name;
        private string m_Email;

        [Required]
        public Int32 ID
        {
            get
            {
                return m_Car_ID;
            }
            set
            {
                m_Car_ID = value;
            }
        }


        [Required(ErrorMessage = "Please enter your first name.")]
        [StringLength(20)]
        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }

        [Required(ErrorMessage = "Please enter your email address")]
        [StringLength(30)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email
        {
            get
            {
                return m_Email;
            }
            set
            {
                m_Email = value;
            }
        }

    }
}