using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;

namespace Trek.Models
{
    public class ParticipantModel
    {
        public string UserId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "*Required")]
        public string Fname { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "*Required")]
        public string Lname { get; set; }

        [DisplayName("Ward")]
        [Required(ErrorMessage = "*Required")]
        [Integer(ErrorMessage = "Needs to be a number!")]
        public string Ward { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "*Required")]
        public string Gender { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is required")]
        [Integer(ErrorMessage = "This needs to be a number!")]
        [Range(12,99)]
        public string Age { get; set; }

        public string BirthDate { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string ParentGaurdian { get; set; }
        public string ParentPhone { get; set; }
        public string Considerations { get; set; }
        public string MedicalInsruance { get; set; }
        public string PolicyNumber { get; set; }
        public string CampoutArrangments { get; set; }

        // public ParticipantModel(string userId, string fname, string lname, string ward, string gender, string age, string birthdate, string address1,
        //    string address2, string phone, string parentGaurdian, string parentPhone, string considerations, string medicalInsurance, string policyNumber, string campoutArrangements)
        //{
        //    UserId = userId;
        //    Fname = fname;
        //    Lname = lname;
        //    Ward = ward;
        //    Gender = gender;
        //    Age = age;
        //    BirthDate = birthdate;
        //    Address1 = address1;
        //    Address2 = address2;
        //    Phone = phone;
        //    ParentGaurdian = parentGaurdian;
        //    ParentPhone = parentPhone;
        //    Considerations = considerations;
        //    MedicalInsruance = medicalInsurance;
        //    PolicyNumber = policyNumber;
        //    CampoutArrangments = campoutArrangements;
        //}
        public ParticipantModel()
        {
            
        }
    }
}