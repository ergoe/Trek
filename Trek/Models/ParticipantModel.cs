using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trek.Models
{
    public class ParticipantModel
    {
        public string UserId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string FamilyId { get; set; }
        public string Role { get; set; }
        public string ClassName { get; set; }
        public string BirthDate { get; set; }
        public string Age { get; set; }

    }
}