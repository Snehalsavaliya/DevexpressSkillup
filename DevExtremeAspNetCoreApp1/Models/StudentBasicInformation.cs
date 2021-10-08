using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp1.Models
{
    public class StudentBasicInformation
    {
        public long Id { get; set; }
        public string Ms365Id { get; set; }
        public string EmailAddress { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string LastNameReading { get; set; }
        public string NameReading { get; set; }
        public string Gender { get; set; }
        public string FamilyRegisterSurname { get; set; }
        public string FamilyRegisterName { get; set; }
        public DateTime? Birthday { get; set; }
        public string RomajiSurname { get; set; }
        public string RomajiName { get; set; }
        public short? Regeneration { get; set; }
        public string RecordOutputFirstAndLastName { get; set; }
        public string SurveyReportOutputFirstAndLastName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long CountryOfCitizenship { get; set; }
        public string JuniorHighSchoolImage { get; set; }
        public string HighSchoolImage { get; set; }
        public bool PrintOnInstructionManual { get; set; }
        public bool PrintOnSurveyReport { get; set; }

        public int SchoolRegistrationNumber { get; set; }
        public int HomePhoneNumber { get; set; }

        public int PostalCode { get; set; }
        public string Remarks { get; set; }
        public AddressInformationModel AddressInformation { get; set; }
        public StudentSchoolCommonInformation StudentSchoolCommonInformation { get; set; }
    }
}
