using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrStaffMaster
    {
        public HrStaffMaster()
        {
            HrAddress = new HashSet<HrAddress>();
            HrPayrollMaster = new HashSet<HrPayrollMaster>();
            HrSalaryPackage = new HashSet<HrSalaryPackage>();
            HrShiftMemberAllocation = new HashSet<HrShiftMemberAllocation>();
            HrMultiStaffTimesheetData = new HashSet<HrMultiStaffTimesheetData>();
        }

        public long StaffId { get; set; }
        public string StaffCode { get; set; }
        public long? CompanyId { get; set; }
        public string FileNo { get; set; }
        public string FirstName { get; set; }
        public long? EnrollNo { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string FamilyName { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public long? ReligionId { get; set; }
        public long? LanguageId { get; set; }
        public long? NationalityId { get; set; }
        public long? BloodGroupId { get; set; }
        public long? MaritalStatusId { get; set; }
        public long? DepartmentId { get; set; }
        public long? DesignationId { get; set; }
        public long? CompanyDesignationId { get; set; }
        public long? QualificationId { get; set; }
        public DateTime? Doj { get; set; }
        public DateTime? LastReJoinDate { get; set; }
        public long ActiveStatusId { get; set; }
        public long? BankId { get; set; }
        public string BankAcNo { get; set; }
        public long? ShiftTypeId { get; set; }
        public long? ShiftId { get; set; }
        public long? SiteId { get; set; }
        public byte[] StaffPhoto { get; set; }
        public string TransType { get; set; }
        public long? WpspersonId { get; set; }
        public string WpsIban { get; set; }
        public long? StaffTypeId { get; set; }
        public long? VisaDesignationId { get; set; }
        public long? VisaCompanyId { get; set; }
        public DateTime? LastWorkingDay { get; set; }
        public long? Ttid { get; set; }
        public long? GradeId { get; set; }
        public long? LevelId { get; set; }
        public string PreviousEmployer { get; set; }
        public double? ExpInYrs { get; set; }
        public long? Qulification1 { get; set; }
        public long? Qulification2 { get; set; }
        public long? Qulification3 { get; set; }
        public string LeaveFreq { get; set; }
        public long? DestFrm { get; set; }
        public long? DestTo { get; set; }
        public long? LocationId { get; set; }
        public long? CardNo { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public DateTime? NormalHr { get; set; }
        public bool? Oteligible { get; set; }
        public long? AgentId { get; set; }
        public long? SuperVisorId { get; set; }
        public string VehicleNo { get; set; }
        public double? PreAlopnBal { get; set; }
        public string PortOfEntry { get; set; }
        public DateTime? DateOfEntry { get; set; }
        public double? NorOtrate { get; set; }
        public double? HolOtrate { get; set; }
        public double? FriOtrate { get; set; }
        public string Otremarks { get; set; }
        public long? CurrencyId { get; set; }
        public long? SponserId { get; set; }
        public long? VisaTypeId { get; set; }
        public long? ContTypeId { get; set; }
        public long? ShiftTypeId1 { get; set; }
        public long? TimePolcyId { get; set; }
        public long? LeavePolcyId { get; set; }
        public long? OverTiPolcyId { get; set; }
        public string ImgStaus { get; set; }
        public string Accommodation { get; set; }
        public string EmpQid { get; set; }
        public string EmpvisaId { get; set; }
        public double? NormalHrFloat { get; set; }
        public long? CostCenterId { get; set; }
        public DateTime? GratStDate { get; set; }
        public long? GrtAmtPolicy { get; set; }
        public long? LeaveSalAmtPolicy { get; set; }
        public bool? DontProcPayroll { get; set; }
        public double? JobCostAmt { get; set; }
        public string Uidno { get; set; }
        public string RoutingCode { get; set; }
        public bool? NotEligForProcAtt { get; set; }
        public long? SubDepId { get; set; }
        public long? CmpId { get; set; }

        public virtual HrBloodGroup BloodGroup { get; set; }
        public virtual HrCompanyMaster Company { get; set; }
        public virtual HrDepartment Department { get; set; }
        public virtual HrDesignation Designation { get; set; }
        public virtual HrLanguage Language { get; set; }
        public virtual HrMaritalStatus MaritalStatus { get; set; }
        public virtual HrNationality Nationality { get; set; }
        public virtual HrQualification Qualification { get; set; }
        public virtual HrVisaCompany VisaCompany { get; set; }
        public virtual HrVisaDesignation VisaDesignation { get; set; }
        public virtual ICollection<HrAddress> HrAddress { get; set; }
        public virtual ICollection<HrPayrollMaster> HrPayrollMaster { get; set; }
        public virtual ICollection<HrSalaryPackage> HrSalaryPackage { get; set; }
        public virtual ICollection<HrShiftMemberAllocation> HrShiftMemberAllocation { get; set; }
        public virtual ICollection<HrMultiStaffTimesheetData> HrMultiStaffTimesheetData { get; set; }
    }
}
