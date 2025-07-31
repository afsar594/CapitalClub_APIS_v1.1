using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmpSelf.Core.Domain
{
    public partial class STContext : DbContext
    {
        public STContext()
        {
        }

        public STContext(DbContextOptions<STContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BreakTime> BreakTime { get; set; }
        public virtual DbSet<HrActiveStatus> HrActiveStatus { get; set; }
        public virtual DbSet<HrAddress> HrAddress { get; set; }
        public virtual DbSet<HrAddressType> HrAddressType { get; set; }
        public virtual DbSet<HrAgentMaster> HrAgentMaster { get; set; }
        public virtual DbSet<HrAirTicketDetails> HrAirTicketDetails { get; set; }
        public virtual DbSet<HrAirTicketMaster> HrAirTicketMaster { get; set; }
        public virtual DbSet<HrAirTicketOpenings> HrAirTicketOpenings { get; set; }
        public virtual DbSet<HrAlOpenings> HrAlOpenings { get; set; }
        public virtual DbSet<HrAllotedItems> HrAllotedItems { get; set; }
        public virtual DbSet<HrAllotedProperties> HrAllotedProperties { get; set; }
        public virtual DbSet<HrAssetMaster> HrAssetMaster { get; set; }
        public virtual DbSet<HrAttLog> HrAttLog { get; set; }
        public virtual DbSet<HrAttendaceSheet> HrAttendaceSheet { get; set; }
        public virtual DbSet<HrAttendanceEdit> HrAttendanceEdit { get; set; }
        public virtual DbSet<HrBankMaster> HrBankMaster { get; set; }
        public virtual DbSet<HrBennaOtprint> HrBennaOtprint { get; set; }
        public virtual DbSet<HrBloodGroup> HrBloodGroup { get; set; }
        public virtual DbSet<HrCampMaster> HrCampMaster { get; set; }
        public virtual DbSet<HrChangeDepartment> HrChangeDepartment { get; set; }
        public virtual DbSet<HrChangeDepartmentDet> HrChangeDepartmentDet { get; set; }
        public virtual DbSet<HrChangeDesignation> HrChangeDesignation { get; set; }
        public virtual DbSet<HrChangeDesignationDet> HrChangeDesignationDet { get; set; }
        public virtual DbSet<HrCompanyBankDetails> HrCompanyBankDetails { get; set; }
        public virtual DbSet<HrCompanyCalendarWeekEnd> HrCompanyCalendarWeekEnd { get; set; }
        public virtual DbSet<HrCompanyCalender> HrCompanyCalender { get; set; }
        public virtual DbSet<HrCompanyMaster> HrCompanyMaster { get; set; }
        public virtual DbSet<HrContractType> HrContractType { get; set; }
        public virtual DbSet<HrCourseMaster> HrCourseMaster { get; set; }
        public virtual DbSet<HrCurrencyMaster> HrCurrencyMaster { get; set; }
        public virtual DbSet<HrDailyShift> HrDailyShift { get; set; }
        public virtual DbSet<HrDailyShiftDayoffDetails> HrDailyShiftDayoffDetails { get; set; }
        public virtual DbSet<HrDepartment> HrDepartment { get; set; }
        public virtual DbSet<HrDesignation> HrDesignation { get; set; }
        public virtual DbSet<HrDesignationChange> HrDesignationChange { get; set; }
        public virtual DbSet<HrDocumentImages> HrDocumentImages { get; set; }
        public virtual DbSet<HrDocumentInOutDetails> HrDocumentInOutDetails { get; set; }
        public virtual DbSet<HrDocumentMaster> HrDocumentMaster { get; set; }
        public virtual DbSet<HrDocumentRequest> HrDocumentRequest { get; set; }
        public virtual DbSet<HrDocumentStatusMaster> HrDocumentStatusMaster { get; set; }
        public virtual DbSet<HrDocumentType> HrDocumentType { get; set; }
        public virtual DbSet<HrEmpTimesheetData> HrEmpTimesheetData { get; set; }
        public virtual DbSet<HrEmpTimesheets> HrEmpTimesheets { get; set; }
        public virtual DbSet<HrExcelOtdetails> HrExcelOtdetails { get; set; }
        public virtual DbSet<HrFamilyDetails> HrFamilyDetails { get; set; }
        public virtual DbSet<HrFamilyDetailsproperty> HrFamilyDetailsproperty { get; set; }
        public virtual DbSet<HrFinePenalty> HrFinePenalty { get; set; }
        public virtual DbSet<HrFormCategory> HrFormCategory { get; set; }
        public virtual DbSet<HrFormNames> HrFormNames { get; set; }
        public virtual DbSet<HrGeneralSettings> HrGeneralSettings { get; set; }
        public virtual DbSet<HrGeneralSettings1> HrGeneralSettings1 { get; set; }
        public virtual DbSet<HrGradeMaster> HrGradeMaster { get; set; }
        public virtual DbSet<HrGratAmtPolicyDetails> HrGratAmtPolicyDetails { get; set; }
        public virtual DbSet<HrGratAmtPolicyMaster> HrGratAmtPolicyMaster { get; set; }
        public virtual DbSet<HrGratuityCriteria> HrGratuityCriteria { get; set; }
        public virtual DbSet<HrGratuityMaster> HrGratuityMaster { get; set; }
        public virtual DbSet<HrGroupPermission> HrGroupPermission { get; set; }
        public virtual DbSet<HrIncrRewards> HrIncrRewards { get; set; }
        public virtual DbSet<HrIncrementDetail> HrIncrementDetail { get; set; }
        public virtual DbSet<HrIncrementMaster> HrIncrementMaster { get; set; }
        public virtual DbSet<HrLanguage> HrLanguage { get; set; }
        public virtual DbSet<HrLeaveDataReq> HrLeaveDataReq { get; set; }
        public virtual DbSet<HrLeaveDetails> HrLeaveDetails { get; set; }
        public virtual DbSet<HrLeaveDocumentImages> HrLeaveDocumentImages { get; set; }
        public virtual DbSet<HrLeaveEncashment> HrLeaveEncashment { get; set; }
        public virtual DbSet<HrLeaveMaster> HrLeaveMaster { get; set; }
        public virtual DbSet<HrLeaveMultiStaffDetails> HrLeaveMultiStaffDetails { get; set; }
        public virtual DbSet<HrLeaveMultiStaffMaster> HrLeaveMultiStaffMaster { get; set; }
        public virtual DbSet<HrLeaveSalAmtPolicyDetails> HrLeaveSalAmtPolicyDetails { get; set; }
        public virtual DbSet<HrLeaveSalAmtPolicyMaster> HrLeaveSalAmtPolicyMaster { get; set; }
        public virtual DbSet<HrLeaveSalary> HrLeaveSalary { get; set; }
        public virtual DbSet<HrLeaveType> HrLeaveType { get; set; }
        public virtual DbSet<HrLevelMaster> HrLevelMaster { get; set; }
        public virtual DbSet<HrLoandetails> HrLoandetails { get; set; }
        public virtual DbSet<HrLoanentry> HrLoanentry { get; set; }
        public virtual DbSet<HrLocationComp> HrLocationComp { get; set; }
        public virtual DbSet<HrLocationMaster> HrLocationMaster { get; set; }
        public virtual DbSet<HrMachineMaster> HrMachineMaster { get; set; }
        public virtual DbSet<HrMaritalStatus> HrMaritalStatus { get; set; }
        public virtual DbSet<HrMemberTypes> HrMemberTypes { get; set; }
        public virtual DbSet<HrMemo> HrMemo { get; set; }
        public virtual DbSet<HrMobilization> HrMobilization { get; set; }
        public virtual DbSet<HrMobilizationDetails> HrMobilizationDetails { get; set; }
        public virtual DbSet<HrMonthNameTbl> HrMonthNameTbl { get; set; }
        public virtual DbSet<HrNationality> HrNationality { get; set; }
        public virtual DbSet<HrOptions> HrOptions { get; set; }
        public virtual DbSet<HrOtherExpProperties> HrOtherExpProperties { get; set; }
        public virtual DbSet<HrOtherExpenceMaster> HrOtherExpenceMaster { get; set; }
        public virtual DbSet<HrOvertimeSettings> HrOvertimeSettings { get; set; }
        public virtual DbSet<HrPayrollColumns> HrPayrollColumns { get; set; }
        public virtual DbSet<HrPayrollDetails> HrPayrollDetails { get; set; }
        public virtual DbSet<HrPayrollMaster> HrPayrollMaster { get; set; }
        public virtual DbSet<HrPendingPayroll> HrPendingPayroll { get; set; }
        public virtual DbSet<HrProcessedAttendance> HrProcessedAttendance { get; set; }
        public virtual DbSet<HrProjects> HrProjects { get; set; }
        public virtual DbSet<HrQualification> HrQualification { get; set; }
        public virtual DbSet<HrRelationship> HrRelationship { get; set; }
        public virtual DbSet<HrReligion> HrReligion { get; set; }
        public virtual DbSet<HrSalaryHead> HrSalaryHead { get; set; }
        public virtual DbSet<HrSalaryPackage> HrSalaryPackage { get; set; }
        public virtual DbSet<HrServiceRequest> HrServiceRequest { get; set; }
        public virtual DbSet<HrServiceRequestType> HrServiceRequestType { get; set; }
        public virtual DbSet<HrShiftMemberAllocation> HrShiftMemberAllocation { get; set; }
        public virtual DbSet<HrShiftTypes> HrShiftTypes { get; set; }
        public virtual DbSet<HrShifts> HrShifts { get; set; }
        public virtual DbSet<HrSites> HrSites { get; set; }
        public virtual DbSet<HrSkillDetails> HrSkillDetails { get; set; }
        public virtual DbSet<HrSponser> HrSponser { get; set; }
        public virtual DbSet<HrStaffMaster> HrStaffMaster { get; set; }
        public virtual DbSet<HrStaffType> HrStaffType { get; set; }
        public virtual DbSet<HrSubDepartment> HrSubDepartment { get; set; }
        public virtual DbSet<HrTimeSettings> HrTimeSettings { get; set; }
        public virtual DbSet<HrTimeSheet> HrTimeSheet { get; set; }
        public virtual DbSet<HrTimeSheetBrkUp> HrTimeSheetBrkUp { get; set; }
        public virtual DbSet<HrTimeSheetDetails> HrTimeSheetDetails { get; set; }
        public virtual DbSet<HrTimeSheetDetailsKz> HrTimeSheetDetailsKz { get; set; }
        public virtual DbSet<HrTimeSheetDetailsTime> HrTimeSheetDetailsTime { get; set; }
        public virtual DbSet<HrTimeSheetDetailsTimeBrk> HrTimeSheetDetailsTimeBrk { get; set; }
        public virtual DbSet<HrTimeSheetKz> HrTimeSheetKz { get; set; }
        public virtual DbSet<HrTimeSheetMulStaff> HrTimeSheetMulStaff { get; set; }
        public virtual DbSet<HrTimeSheetMulStaffDetails> HrTimeSheetMulStaffDetails { get; set; }
        public virtual DbSet<HrTimeSheetTime> HrTimeSheetTime { get; set; }
        public virtual DbSet<HrTimeSheetTimeBrk> HrTimeSheetTimeBrk { get; set; }
        public virtual DbSet<HrTimeTable> HrTimeTable { get; set; }
        public virtual DbSet<HrTimeTableDetails> HrTimeTableDetails { get; set; }
        public virtual DbSet<HrTrainingDetails> HrTrainingDetails { get; set; }
        public virtual DbSet<HrUserPermission> HrUserPermission { get; set; }
        public virtual DbSet<HrUserTracking> HrUserTracking { get; set; }
        public virtual DbSet<HrUsers> HrUsers { get; set; }
        public virtual DbSet<HrVehicleMaster> HrVehicleMaster { get; set; }
        public virtual DbSet<HrVisaCompany> HrVisaCompany { get; set; }
        public virtual DbSet<HrVisaDesignation> HrVisaDesignation { get; set; }
        public virtual DbSet<HrVisaType> HrVisaType { get; set; }
        public virtual DbSet<HrWeekDays> HrWeekDays { get; set; }
        public virtual DbSet<HrWorkGroup> HrWorkGroup { get; set; }
        public virtual DbSet<HrWorkGroupPermissions> HrWorkGroupPermissions { get; set; }
        public virtual DbSet<HrWorkPosition> HrWorkPosition { get; set; }
        //=======new tables
        public virtual DbSet<HrMultiStaffTimesheetData> HrMultiStaffTimesheetData { get; set; }
        public virtual DbSet<HrMultiStaffTimesheets> HrMultiStaffTimesheets { get; set; }

        public virtual DbSet<HrLeaveBalance> HrLeaveBalance { get; set; }

        //================
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                ////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                ////                optionsBuilder.UseSqlServer("Server=DESKTOP-AHIKFRV\\SQLEXPRESS;Database=InspireHR05012021;User Id=sa;Password=12;;MultipleActiveResultSets=true;Trusted_Connection=True;");

#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=gpcdubai.securehostplanet.com;Database=InspireEmp;User Id=sa;Password=yXJVrHaQh98TTo;MultipleActiveResultSets=true;Trusted_Connection=False;");

            }
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HrLeaveBalance>(entity =>
            {
                entity.HasKey(e => e.LeaveBalId);

                entity.ToTable("HR_LeaveBalance");

                entity.Property(e => e.LeaveBalId).HasColumnName("LeaveBalID");

                entity.Property(e => e.LeaveBalType).HasMaxLength(50);
            });

            modelBuilder.Entity<BreakTime>(entity =>
            {
                entity.HasKey(e => e.Breakid);

                entity.Property(e => e.Breakid).HasColumnName("breakid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BreakCheckinId).HasColumnName("breakCheckinID");

                entity.Property(e => e.BreakComment)
                    .HasColumnName("breakComment")
                    .HasColumnType("text");

                entity.Property(e => e.BreakEndTime)
                    .HasColumnName("breakEndTime")
                    .HasMaxLength(50);

                entity.Property(e => e.BreakTime1)
                    .HasColumnName("breakTime")
                    .HasMaxLength(50);

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.BreakCheckin)
                    .WithMany(p => p.BreakTime)
                    .HasForeignKey(d => d.BreakCheckinId)
                    .HasConstraintName("FK_BreakTime_HR_AttendaceSheet");
            });

            modelBuilder.Entity<HrActiveStatus>(entity =>
            {
                entity.HasKey(e => e.ActiveStatusId);

                entity.ToTable("HR_ActiveStatus");

                entity.Property(e => e.ActiveStatusId).ValueGeneratedNever();

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.ToTable("HR_Address");

                entity.Property(e => e.AddressId).ValueGeneratedNever();

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HouseName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pobox)
                    .HasColumnName("POBox")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Street)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.HrAddress)
                    .HasForeignKey(d => d.AddressTypeId)
                    .HasConstraintName("FK_Address_AddressType");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.HrAddress)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_Address_StaffMaster");
            });

            modelBuilder.Entity<HrAddressType>(entity =>
            {
                entity.HasKey(e => e.AddressTypeId)
                    .HasName("PK_HR_AddressType_1");

                entity.ToTable("HR_AddressType");

                entity.Property(e => e.AddressTypeId)
                    .HasColumnName("AddressTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrAgentMaster>(entity =>
            {
                entity.HasKey(e => e.AgentId);

                entity.ToTable("HR_AgentMaster");

                entity.Property(e => e.AgentId).ValueGeneratedNever();

                entity.Property(e => e.AgentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrAirTicketDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_AirTicketDetails");

                entity.Property(e => e.Atdid).HasColumnName("ATDID");

                entity.Property(e => e.Atid).HasColumnName("ATID");

                entity.Property(e => e.FamilyId).HasColumnName("FamilyID");

                entity.Property(e => e.Sno).HasColumnName("SNO");

                entity.Property(e => e.Type)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrAirTicketMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_AirTicketMaster");

                entity.Property(e => e.Atid).HasColumnName("ATID");

                entity.Property(e => e.DepDate).HasColumnType("datetime");

                entity.Property(e => e.FlyFromId).HasColumnName("FlyFromID");

                entity.Property(e => e.FlyToId).HasColumnName("FlyToID");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastTicketTaken).HasColumnType("datetime");

                entity.Property(e => e.Lsid).HasColumnName("LSID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RetDate).HasColumnType("datetime");

                entity.Property(e => e.RetFlyFromId).HasColumnName("RetFlyFromID");

                entity.Property(e => e.RetFlyToId).HasColumnName("RetFlyToID");

                entity.Property(e => e.TicketSettDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HrAirTicketOpenings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_AIR_TICKET_OPENINGS");

                entity.Property(e => e.Al).HasColumnName("AL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeaveId).HasColumnName("LeaveID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Staffid).HasColumnName("STAFFID");

                entity.Property(e => e.Uptodate).HasColumnType("date");
            });

            modelBuilder.Entity<HrAlOpenings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_AL_OPENINGS");

                entity.Property(e => e.Al).HasColumnName("AL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeaveId).HasColumnName("LeaveID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Staffid).HasColumnName("STAFFID");

                entity.Property(e => e.Uptodate).HasColumnType("date");
            });

            modelBuilder.Entity<HrAllotedItems>(entity =>
            {
                entity.HasKey(e => e.AllotedItemId);

                entity.ToTable("HR_AllotedItems");

                entity.Property(e => e.AllotedItemId).ValueGeneratedNever();

                entity.Property(e => e.AllotDate).HasColumnType("datetime");

                entity.Property(e => e.AllotedItem)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrAllotedProperties>(entity =>
            {
                entity.ToTable("HR_AllotedProperties");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.BillPayedby)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrAssetMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_AssetMaster");

                entity.Property(e => e.AssetName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrAttLog>(entity =>
            {
                entity.HasKey(e => e.AttLogId);

                entity.ToTable("HR_Att_Log");

                entity.HasIndex(e => new { e.EnrollNo, e.TimeStr })
                    .HasName("Enroll_TimeStr")
                    .IsUnique();

                entity.Property(e => e.AttLogId)
                    .HasColumnName("Att_LogId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BeforeUpdateTimeStr).HasColumnType("datetime");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("createUser");

                entity.Property(e => e.DownloadDate)
                    .HasColumnName("Download_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExLess)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStr).HasColumnType("datetime");

                entity.Property(e => e.TotTime).HasColumnType("datetime");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.HrAttLog)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("FK_Att_Log_MachineMaster");
            });

            modelBuilder.Entity<HrAttendaceSheet>(entity =>
            {
                entity.HasKey(e => e.AttendanceId);

                entity.ToTable("HR_AttendaceSheet");

                entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");

                entity.Property(e => e.AttendanceEmpId).HasColumnName("AttendanceEmpID");

                entity.Property(e => e.CheckOut).HasMaxLength(50);

                entity.Property(e => e.ImageFile).HasColumnType("image");

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.LocationName).HasColumnType("text");

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.PunchDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.HasOne(d => d.AttendanceEmp)
                    .WithMany(p => p.HrAttendaceSheet)
                    .HasForeignKey(d => d.AttendanceEmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HR_AttendaceSheet_HR_Users");

                entity.HasOne(d => d.Project)
                    .WithMany()
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HR_AttendaceSheet_HR_Projects");
            });

            modelBuilder.Entity<HrAttendanceEdit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_AttendanceEdit");

                entity.Property(e => e.ActualInOutTime).HasColumnType("datetime");

                entity.Property(e => e.AttLogId).HasColumnName("AttLogID");

                entity.Property(e => e.CreateUser).HasColumnName("createUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InOutTime).HasColumnType("datetime");

                entity.Property(e => e.PunchDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");
            });

            modelBuilder.Entity<HrBankMaster>(entity =>
            {
                entity.HasKey(e => e.BankId);

                entity.ToTable("HR_BankMaster");

                entity.Property(e => e.BankId).ValueGeneratedNever();

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WpsagentId).HasColumnName("WPSAgentId");
            });

            modelBuilder.Entity<HrBennaOtprint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_BennaOTPrint");

                entity.Property(e => e.DayStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NormalHr)
                    .HasColumnName("NormalHR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalHramt)
                    .HasColumnName("NormalHRAmt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Othr).HasColumnName("OTHr");

                entity.Property(e => e.Othramt)
                    .HasColumnName("OTHRAmt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.TsDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HrBloodGroup>(entity =>
            {
                entity.HasKey(e => e.BloodGroupId);

                entity.ToTable("HR_BloodGroup");

                entity.Property(e => e.BloodGroupId).ValueGeneratedNever();

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrCampMaster>(entity =>
            {
                entity.HasKey(e => e.CmpId)
                    .HasName("PK_HR_Camp");

                entity.ToTable("HR_CampMaster");

                entity.Property(e => e.CmpId).ValueGeneratedNever();

                entity.Property(e => e.Camp)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CmpDate).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");
            });

            modelBuilder.Entity<HrChangeDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Change_Department");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrChangeDepartmentDet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Change_Department_det");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StaffCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrChangeDesignation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Change_Designation");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrChangeDesignationDet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Change_Designation_det");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StaffCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrCompanyBankDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_CompanyBankDetails");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.Cbid)
                    .HasColumnName("CBID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompId).HasColumnName("CompID");
            });

            modelBuilder.Entity<HrCompanyCalendarWeekEnd>(entity =>
            {
                entity.HasKey(e => e.DayId);

                entity.ToTable("HR_CompanyCalendarWeekEnd");

                entity.Property(e => e.DayId)
                    .HasColumnName("DayID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DayNames)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrCompanyCalender>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Company_Calender");

                entity.Property(e => e.DayId).HasColumnName("DAY_ID");

                entity.Property(e => e.Id).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Mdate)
                    .HasColumnName("MDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mday)
                    .HasColumnName("MDay")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mdesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonthId).HasColumnName("MONTH_ID");

                entity.Property(e => e.Mtfrom).HasColumnName("MTFrom");

                entity.Property(e => e.Mtto).HasColumnName("MTTo");

                entity.Property(e => e.StaffTypeId)
                    .HasColumnName("STAFF_TYPE_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.YearId).HasColumnName("YEAR_ID");
            });

            modelBuilder.Entity<HrCompanyMaster>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("HR_CompanyMaster");

                entity.Property(e => e.CompanyId).ValueGeneratedNever();

                entity.Property(e => e.Addr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cell).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyLogo).HasColumnType("image");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Licno)
                    .HasColumnName("LICNO")
                    .HasMaxLength(50);

                entity.Property(e => e.PayerEid)
                    .HasColumnName("PayerEID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayerQid)
                    .HasColumnName("PayerQID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phone1).HasMaxLength(50);

                entity.Property(e => e.Phone2).HasMaxLength(50);

                entity.Property(e => e.Post).HasMaxLength(50);

                entity.Property(e => e.Sifdefault).HasColumnName("SIFDefault");

                entity.Property(e => e.Trnno)
                    .HasColumnName("TRNNo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Website).HasMaxLength(100);

                entity.Property(e => e.WpsemployerBankId).HasColumnName("WPSEmployerBankId");

                entity.Property(e => e.WpsemployerId).HasColumnName("WPSEmployerId");
            });

            modelBuilder.Entity<HrContractType>(entity =>
            {
                entity.HasKey(e => e.ContTypeId);

                entity.ToTable("HR_Contract_Type");

                entity.Property(e => e.ContTypeId).ValueGeneratedNever();

                entity.Property(e => e.ContType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrCourseMaster>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("HR_CourseMaster");

                entity.Property(e => e.CourseId).ValueGeneratedNever();

                entity.Property(e => e.CourseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrCurrencyMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Currency_Master");

                entity.Property(e => e.CurType)
                    .HasColumnName("Cur_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("Currency_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CurrencyName)
                    .HasColumnName("Currency_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyRate)
                    .HasColumnName("Currency_Rate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurrencyRemarks)
                    .HasColumnName("Currency_Remarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencySymbol)
                    .HasColumnName("Currency_Symbol")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<HrDailyShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_DailyShift");

                entity.Property(e => e.BreakInTime).HasColumnType("datetime");

                entity.Property(e => e.BreakOutTime).HasColumnType("datetime");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.NormWorkHr).HasColumnType("datetime");

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.ShiftCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeVariation).HasColumnType("datetime");
            });

            modelBuilder.Entity<HrDailyShiftDayoffDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_DailyShift_Dayoff_Details");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            });

            modelBuilder.Entity<HrDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("HR_Department");

                entity.Property(e => e.DepartmentId).ValueGeneratedNever();

                entity.Property(e => e.DEleted).HasColumnName("dELETED");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrDesignation>(entity =>
            {
                entity.HasKey(e => e.DesignationId);

                entity.ToTable("HR_Designation");

                entity.Property(e => e.DesignationId).ValueGeneratedNever();

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrDesignationChange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_DesignationChange");

                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StaffName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrDocumentImages>(entity =>
            {
                entity.HasKey(e => e.DocImageId);

                entity.ToTable("HR_DocumentImages");

                entity.Property(e => e.DocImageId)
                    .HasColumnName("DocImageID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DocImage).HasColumnType("image");

                entity.Property(e => e.Extension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.HrDocumentImages)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("FK_DocumentImages_DocumentMaster1");
            });

            modelBuilder.Entity<HrDocumentInOutDetails>(entity =>
            {
                entity.ToTable("HR_DocumentInOutDetails");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthorisedStaffId).HasColumnName("AuthorisedStaffID");

                entity.Property(e => e.DocResubDys)
                    .HasColumnName("DOC_RESUB_DYS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.InDate).HasColumnType("datetime");

                entity.Property(e => e.Lcdate)
                    .HasColumnName("LCDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lcno)
                    .HasColumnName("LCNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveId).HasColumnName("LeaveID");

                entity.Property(e => e.OutDate).HasColumnType("datetime");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrDocumentMaster>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("HR_DocumentMaster");

                entity.Property(e => e.DocumentId).ValueGeneratedNever();

                entity.Property(e => e.DocImage).HasColumnType("image");

                entity.Property(e => e.DocName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocStatusId).HasColumnName("DocStatusID");

                entity.Property(e => e.ExpDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.MasterType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OtherId).HasColumnName("OtherID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<HrDocumentRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Document_Request");

                entity.Property(e => e.AppDate).HasColumnType("datetime");

                entity.Property(e => e.AppStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.InOut)
                    .HasColumnName("IN_OUT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Purpose)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrDocumentStatusMaster>(entity =>
            {
                entity.HasKey(e => e.DocStatusId);

                entity.ToTable("HR_DocumentStatusMaster");

                entity.Property(e => e.DocStatusId).ValueGeneratedNever();

                entity.Property(e => e.DocStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrDocumentType>(entity =>
            {
                entity.HasKey(e => e.DocumentTypeId);

                entity.ToTable("HR_DocumentType");

                entity.Property(e => e.DocumentTypeId).ValueGeneratedNever();

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrEmpTimesheetData>(entity =>
            {
                entity.HasKey(e => e.TimesheetDataId);

                entity.ToTable("HR_Emp_TimesheetData");

                entity.Property(e => e.TimesheetDataId).HasColumnName("TimesheetDataID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.TimesheetDataProjectId).HasColumnName("TimesheetDataProjectID");

                entity.Property(e => e.TimesheetId).HasColumnName("timesheetID");

                //entity.HasOne(d => d.TimesheetDataProject)
                //    .WithMany();
                  //  .HasForeignKey(d => d.TimesheetDataProjectId)
                   // .HasConstraintName("FK_HR_Emp_TimesheetData_HR_Projects");

                //entity.HasOne(d => d.Timesheet)
                //    .WithMany(p => p.HrEmpTimesheetData)
                //    .HasForeignKey(d => d.TimesheetId)
                //    .HasConstraintName("FK_HR_Emp_TimesheetData_HR_Emp_Timesheets");
            });

            modelBuilder.Entity<HrEmpTimesheets>(entity =>
            {
                entity.HasKey(e => e.TimesheetId);

                entity.ToTable("HR_Emp_Timesheets");

                entity.Property(e => e.TimesheetId).HasColumnName("timesheetID");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("date");

                entity.Property(e => e.Employee).HasColumnName("employee");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Timesheetdate)
                    .HasColumnName("timesheetdate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<HrExcelOtdetails>(entity =>
            {
                entity.HasKey(e => e.ExId);

                entity.ToTable("HR_ExcelOTDetails");

                entity.Property(e => e.ExId).ValueGeneratedNever();

                entity.Property(e => e.ExMonthName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HolOt).HasColumnName("HolOT");

                entity.Property(e => e.NorOt).HasColumnName("NorOT");

                entity.Property(e => e.StaffCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('R')");
            });

            modelBuilder.Entity<HrFamilyDetails>(entity =>
            {
                entity.ToTable("HR_FamilyDetails");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.RelId).HasColumnName("RelID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");
            });

            modelBuilder.Entity<HrFamilyDetailsproperty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_FamilyDetailsproperty");

                entity.Property(e => e.EmirateExpDate).HasColumnType("datetime");

                entity.Property(e => e.EmirateIssuDate).HasColumnType("datetime");

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ftype)
                    .HasColumnName("FType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PassporIssuDate).HasColumnType("datetime");

                entity.Property(e => e.Passportexpdate).HasColumnType("datetime");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RelId).HasColumnName("RelID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Visaexpdate).HasColumnType("datetime");

                entity.Property(e => e.VisaissuDate).HasColumnType("datetime");

                entity.Property(e => e.Visano)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrFinePenalty>(entity =>
            {
                entity.ToTable("HR_FinePenalty");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Actiontaken)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Nature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rwdtype)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrFormCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_HR_ServiceType");

                entity.ToTable("HR_FormCategory");

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrFormNames>(entity =>
            {
                entity.HasKey(e => e.FormName);

                entity.ToTable("HR_Form_Names");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormAlias)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FormId)
                    .HasColumnName("FormID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FormType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrGeneralSettings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_General_Settings");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.GenId)
                    .HasColumnName("GenID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasColumnName("Key_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TableName)
                    .HasColumnName("Table_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TextValue)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ValueType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrGeneralSettings1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_GeneralSettings");

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.KeyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SettingName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SettingValue)
                    .HasMaxLength(900)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrGradeMaster>(entity =>
            {
                entity.HasKey(e => e.Gid);

                entity.ToTable("HR_GradeMaster");

                entity.Property(e => e.Gid)
                    .HasColumnName("GID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GradeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrGratAmtPolicyDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_GratAmtPolicyDetails");

                entity.Property(e => e.CheckStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetPolId)
                    .HasColumnName("Det_Pol_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PolId).HasColumnName("Pol_ID");

                entity.Property(e => e.SalHeadId).HasColumnName("SalHeadID");
            });

            modelBuilder.Entity<HrGratAmtPolicyMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_GratAmtPolicyMaster");

                entity.Property(e => e.PolId).HasColumnName("Pol_ID");

                entity.Property(e => e.PolicyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<HrGratuityCriteria>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Gratuity_Criteria");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrGratuityMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_GratuityMaster");

                entity.Property(e => e.AddRemarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Alamt).HasColumnName("ALAmt");

                entity.Property(e => e.Aldays).HasColumnName("ALDays");

                entity.Property(e => e.AlsettDate)
                    .HasColumnName("ALSettDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Clamt).HasColumnName("CLAmt");

                entity.Property(e => e.Cldays).HasColumnName("CLDays");

                entity.Property(e => e.ClsettDate)
                    .HasColumnName("CLSettDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DedRemarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmpStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExcludeGratuity).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExcludeLeave).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExcludeLeaveSalary).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExcludeSalary).HasDefaultValueSql("((0))");

                entity.Property(e => e.GrId)
                    .HasColumnName("GrID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GrtAmtGrterFive).HasDefaultValueSql("((0))");

                entity.Property(e => e.GrtAmtLessFive).HasDefaultValueSql("((0))");

                entity.Property(e => e.GrtCalcChangeDate).HasColumnType("datetime");

                entity.Property(e => e.GrtDysGrtFive).HasDefaultValueSql("((0))");

                entity.Property(e => e.GrtYrsGrtFive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludePayroll).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastWorkingDay).HasColumnType("datetime");

                entity.Property(e => e.LeaveSalId).HasColumnName("LeaveSalID");

                entity.Property(e => e.PayrollId).HasColumnName("PayrollID");

                entity.Property(e => e.Pvno)
                    .HasColumnName("PVNO")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.TerminationAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotServYrs).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrGroupPermission>(entity =>
            {
                entity.HasKey(e => e.Gpid);

                entity.ToTable("HR_GroupPermission");

                entity.Property(e => e.Gpid)
                    .HasColumnName("GPId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Upadd).HasColumnName("UPAdd");

                entity.Property(e => e.Upallow).HasColumnName("UPAllow");

                entity.Property(e => e.Updelete).HasColumnName("UPDelete");

                entity.Property(e => e.Upedit).HasColumnName("UPEdit");

                entity.Property(e => e.Upprint).HasColumnName("UPPrint");

                entity.Property(e => e.Upview).HasColumnName("UPView");
            });

            modelBuilder.Entity<HrIncrRewards>(entity =>
            {
                entity.ToTable("HR_IncrRewards");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Achievement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Nature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rwdtype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrIncrementDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Increment_detail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Incramount).HasColumnName("incramount");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Salheadcode).HasColumnName("salheadcode");
            });

            modelBuilder.Entity<HrIncrementMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Increment_Master");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("staffID");
            });

            modelBuilder.Entity<HrLanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.ToTable("HR_Language");

                entity.Property(e => e.LanguageId).ValueGeneratedNever();

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrLeaveDataReq>(entity =>
            {
                entity.HasKey(e => e.LeavDataId);

                entity.ToTable("HR_LeaveDataReq");

                entity.Property(e => e.LeavDataId).HasColumnName("LeavDataID");

                entity.Property(e => e.LeaveDataFrom).HasColumnType("date");

                entity.Property(e => e.LeaveDataReason).HasColumnType("text");

                entity.Property(e => e.LeaveDataTo).HasColumnType("date");

                entity.Property(e => e.ReqDate).HasColumnType("datetime");
                
                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedBy).HasColumnName("ApprovedBy");

                entity.Property(e => e.RejectedDate).HasColumnType("datetime");

                entity.Property(e => e.RejectedBy).HasColumnName("RejectedBy");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.LeaveReqImage).HasColumnType("image");

                entity.HasOne(d => d.LeaveDataTypeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.LeaveDataType)
                    .HasConstraintName("FK_HR_LeaveDataReq_HR_LeaveDataReq");

                entity.HasOne(d => d.LeaveEmp)
                    .WithMany(p => p.HrLeaveDataReq)
                    .HasForeignKey(d => d.LeaveEmpid)
                    .HasConstraintName("FK_HR_LeaveDataReq_HR_Users");
            });

            modelBuilder.Entity<HrLeaveDetails>(entity =>
            {
                entity.ToTable("HR_Leave_Details");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AttCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lvmid).HasColumnName("LVMID");

                entity.Property(e => e.SwipeDate).HasColumnType("datetime");

                entity.HasOne(d => d.Lvm)
                    .WithMany(p => p.HrLeaveDetails)
                    .HasForeignKey(d => d.Lvmid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Leave_Details_LeaveMaster");
            });

            modelBuilder.Entity<HrLeaveDocumentImages>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_LeaveDocumentImages");

                entity.Property(e => e.Extension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveImage).HasColumnType("image");

                entity.Property(e => e.LeaveImageId).HasColumnName("LeaveImageID");
            });

            modelBuilder.Entity<HrLeaveEncashment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_LeaveEncashment");

                entity.Property(e => e.AirticketAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.AlCl)
                    .HasColumnName("AL_CL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EncahmentDate).HasColumnType("datetime");

                entity.Property(e => e.LastRejionDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveEndDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveStDate).HasColumnType("datetime");

                entity.Property(e => e.Lecid).HasColumnName("LECID");

                entity.Property(e => e.Lsid).HasColumnName("LSID");

                entity.Property(e => e.NoAlavailable).HasColumnName("NoALAvailable");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrLeaveMaster>(entity =>
            {
                entity.HasKey(e => e.LeaveId);

                entity.ToTable("HR_LeaveMaster");

                entity.Property(e => e.LeaveId).ValueGeneratedNever();

                entity.Property(e => e.Allowed).HasDefaultValueSql("((0))");

                entity.Property(e => e.AppLeaveFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AppLeaveTo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AppStaffId)
                    .HasColumnName("AppStaffID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AppStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('y')");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ApprovalDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Calcdays).HasColumnName("calcdays");

                entity.Property(e => e.ContactDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateThroughAtt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FinalTimeSheetId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IncludeHolAl).HasColumnName("IncludeHolAL");

                entity.Property(e => e.LappCode)
                    .HasColumnName("LAppCode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lastrejoindate)
                    .HasColumnName("lastrejoindate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LeaveCanAppDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveCanDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveEncashId).HasColumnName("LeaveEncashID");

                entity.Property(e => e.LeaveSalId).HasColumnName("LeaveSalID");

                entity.Property(e => e.LeaveStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LeavetypeId)
                    .HasColumnName("LeavetypeID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MedicalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noofdays).HasDefaultValueSql("((0))");

                entity.Property(e => e.Payrollid).HasColumnName("payrollid");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RejoiningDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeSheetNo).HasMaxLength(20);

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<HrLeaveMultiStaffDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_LeaveMultiStaffDetails");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.DetLvMulId).HasColumnName("Det_LvMul_ID");

                entity.Property(e => e.LeaveId).HasColumnName("LeaveID");

                entity.Property(e => e.LeaveMasterId).HasColumnName("LeaveMasterID");

                entity.Property(e => e.LvMulId).HasColumnName("LvMul_ID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");
            });

            modelBuilder.Entity<HrLeaveMultiStaffMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_LeaveMultiStaffMaster");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.LvMulId).HasColumnName("LvMul_ID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrLeaveSalAmtPolicyDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_LeaveSalAmtPolicyDetails");

                entity.Property(e => e.CheckStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetPolId)
                    .HasColumnName("Det_Pol_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PolId).HasColumnName("Pol_ID");

                entity.Property(e => e.SalHeadId).HasColumnName("SalHeadID");
            });

            modelBuilder.Entity<HrLeaveSalAmtPolicyMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_LeaveSalAmtPolicyMaster");

                entity.Property(e => e.PolId).HasColumnName("Pol_ID");

                entity.Property(e => e.PolicyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<HrLeaveSalary>(entity =>
            {
                entity.HasKey(e => e.LeaveSalId);

                entity.ToTable("HR_LeaveSalary");

                entity.Property(e => e.LeaveSalId).ValueGeneratedNever();

                entity.Property(e => e.AddLspayroll)
                    .HasColumnName("AddLSPayroll")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AirTicketAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.AlendDate)
                    .HasColumnName("ALEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AlongWithPayroll).HasDefaultValueSql("((0))");

                entity.Property(e => e.AlopnBal)
                    .HasColumnName("ALOpnBal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AlstartDate)
                    .HasColumnName("ALStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CalculateBasedOn)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateLeave).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatePayroll).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurLeaveDys).HasDefaultValueSql("((0))");

                entity.Property(e => e.GratuityAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastSettDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveSalaryDate).HasColumnType("datetime");

                entity.Property(e => e.LoanAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.NetAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoofTicket).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayrollAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PendingPayollAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrvMthSalary).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrvPayrollMonth)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RejoinDate).HasColumnType("datetime");

                entity.Property(e => e.RejoinStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.RmkVarAdd)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RmkVarDed)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SettDate).HasColumnType("datetime");

                entity.Property(e => e.SettlementType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VarAdd).HasColumnName("varAdd");
            });

            modelBuilder.Entity<HrLeaveType>(entity =>
            {
                entity.HasKey(e => e.LeaveTypeId);

                entity.ToTable("HR_LeaveType");

                entity.HasIndex(e => e.LeaveCode)
                    .HasName("UNQ_LeaveType")
                    .IsUnique();

                entity.HasIndex(e => e.LeaveTypeId)
                    .HasName("UNQ_Leavecode")
                    .IsUnique();

                entity.Property(e => e.LeaveTypeId)
                    .HasColumnName("LeaveTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LcodeEditable).HasColumnName("LCodeEditable");
                entity.Property(e => e.LeaveID).HasColumnName("LeaveID");

                entity.Property(e => e.LeaveCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LeaveType).HasMaxLength(50);
            });

            modelBuilder.Entity<HrLevelMaster>(entity =>
            {
                entity.HasKey(e => e.LvlId);

                entity.ToTable("HR_LevelMaster");

                entity.Property(e => e.LvlId)
                    .HasColumnName("LvlID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LevelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrLoandetails>(entity =>
            {
                entity.HasKey(e => e.Ldid);

                entity.ToTable("HR_LOANDETAILS");

                entity.Property(e => e.Ldid)
                    .HasColumnName("LDID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DedDate).HasColumnType("datetime");

                entity.Property(e => e.DedMonth)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.DedType)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.DedYear)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.LoanId)
                    .HasColumnName("LoanID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PayrollId)
                    .HasColumnName("PayrollID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Loan)
                    .WithMany(p => p.HrLoandetails)
                    .HasForeignKey(d => d.LoanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LOANDETAILS_LOANENTRY");
            });

            modelBuilder.Entity<HrLoanentry>(entity =>
            {
                entity.HasKey(e => e.LoanId);

                entity.ToTable("HR_LOANENTRY");

                entity.Property(e => e.LoanId)
                    .HasColumnName("LoanID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DedFromDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.Jvid)
                    .HasColumnName("JVID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoanHeadId)
                    .HasColumnName("LoanHeadID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrLocationComp>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("HR_LocationComp");

                entity.Property(e => e.LocationId).ValueGeneratedNever();

                entity.Property(e => e.LocaAdd)
                    .HasColumnName("Loca_Add")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrLocationMaster>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("HR_LocationMaster");

                entity.Property(e => e.LocationId).ValueGeneratedNever();

                entity.Property(e => e.LocaAdd)
                    .HasColumnName("Loca_Add")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrMachineMaster>(entity =>
            {
                entity.HasKey(e => e.MachineCode);

                entity.ToTable("HR_MachineMaster");

                entity.Property(e => e.MachineCode).ValueGeneratedNever();

                entity.Property(e => e.ComPort)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CommunicationKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Discription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExcelLastUpLoadDate).HasColumnType("datetime");

                entity.Property(e => e.HrlastUpLoadDate)
                    .HasColumnName("HRLastUpLoadDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PunchMode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrMaritalStatus>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusId);

                entity.ToTable("HR_MaritalStatus");

                entity.Property(e => e.MaritalStatusId).ValueGeneratedNever();

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrMemberTypes>(entity =>
            {
                entity.HasKey(e => e.MemberTypeId);

                entity.ToTable("HR_MemberTypes");

                entity.Property(e => e.MemberTypeId).ValueGeneratedNever();

                entity.Property(e => e.MemberType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrMemo>(entity =>
            {
                entity.ToTable("HR_Memo");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.MemoDate).HasColumnType("date");

                entity.Property(e => e.MemoId)
                    .HasColumnName("MemoID")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.Reply).HasColumnType("text");
            });

            modelBuilder.Entity<HrMobilization>(entity =>
            {
                entity.HasKey(e => e.MobId);

                entity.ToTable("HR_Mobilization");

                entity.Property(e => e.MobId)
                    .HasColumnName("MobID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MobDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitMob).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrMobilizationDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Mobilization_Details");

                entity.Property(e => e.DesigId).HasColumnName("DesigID");

                entity.Property(e => e.IsEdit).HasDefaultValueSql("((0))");

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MobDetId)
                    .HasColumnName("MobDetID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MobId).HasColumnName("MobID");

                entity.Property(e => e.RemarksDet)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<HrMonthNameTbl>(entity =>
            {
                entity.ToTable("HR_MonthNameTbl");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MthName)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrNationality>(entity =>
            {
                entity.HasKey(e => e.NationalityId);

                entity.ToTable("HR_Nationality");

                entity.Property(e => e.NationalityId).ValueGeneratedNever();

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrOptions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Options");

                entity.Property(e => e.Descriptions)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FromName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OptDesc)
                    .HasColumnName("Opt_Desc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OptType)
                    .HasColumnName("Opt_Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrOtherExpProperties>(entity =>
            {
                entity.ToTable("HR_Other_Exp_Properties");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BillNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Oeid).HasColumnName("OEId");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RewType)
                    .HasColumnName("Rew_Type")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrOtherExpenceMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_OtherExpenceMaster");

                entity.Property(e => e.Oeid).HasColumnName("OEId");

                entity.Property(e => e.OtherExpence)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrOvertimeSettings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Overtime_Settings");

                entity.Property(e => e.EarlyLatePlusYn).HasColumnName("EarlyLatePlusYN");

                entity.Property(e => e.ExtraHrsSlipYn).HasColumnName("ExtraHrsSlipYN");

                entity.Property(e => e.LateComOtnegoMnts).HasColumnName("LateComOTNegoMnts");

                entity.Property(e => e.OtlimitHrs).HasColumnName("OTLimitHrs");

                entity.Property(e => e.OtlimitMnt).HasColumnName("OTLimitMnt");

                entity.Property(e => e.OutMinShiftEndYn).HasColumnName("OutMinShiftEndYN");

                entity.Property(e => e.OvtPolicyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OvtmId)
                    .HasColumnName("Ovtm_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalarySlipOtyn).HasColumnName("SalarySlipOTYN");

                entity.Property(e => e.TimeBefOtstart).HasColumnName("TimeBefOTStart");

                entity.Property(e => e.TotalDurMinSftYn).HasColumnName("TotalDurMinSftYN");
            });

            modelBuilder.Entity<HrPayrollColumns>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_PayrollColumns");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Visible).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HrPayrollDetails>(entity =>
            {
                entity.HasKey(e => e.PayrollDetailsId);

                entity.ToTable("HR_PayrollDetails");

                entity.Property(e => e.PayrollDetailsId).ValueGeneratedNever();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Payroll)
                    .WithMany(p => p.HrPayrollDetails)
                    .HasForeignKey(d => d.PayrollId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PayrollDetails_PayrollMaster");

                entity.HasOne(d => d.Sh)
                    .WithMany(p => p.HrPayrollDetails)
                    .HasForeignKey(d => d.ShId)
                    .HasConstraintName("FK_PayrollDetails_SalaryHead");
            });

            modelBuilder.Entity<HrPayrollMaster>(entity =>
            {
                entity.HasKey(e => e.PayrollId);

                entity.ToTable("HR_PayrollMaster");

                entity.Property(e => e.PayrollId).ValueGeneratedNever();

                entity.Property(e => e.AdvOther).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bal).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.BankAccNo)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.Basic).HasDefaultValueSql("((0))");

                entity.Property(e => e.C1).HasDefaultValueSql("((0))");

                entity.Property(e => e.C10).HasDefaultValueSql("((0))");

                entity.Property(e => e.C100).HasDefaultValueSql("((0))");

                entity.Property(e => e.C1000).HasDefaultValueSql("((0))");

                entity.Property(e => e.C20).HasDefaultValueSql("((0))");

                entity.Property(e => e.C200).HasDefaultValueSql("((0))");

                entity.Property(e => e.C5).HasDefaultValueSql("((0))");

                entity.Property(e => e.C50).HasDefaultValueSql("((0))");

                entity.Property(e => e.C500).HasDefaultValueSql("((0))");

                entity.Property(e => e.Credit).HasDefaultValueSql("((0))");

                entity.Property(e => e.DaysInMonth).HasDefaultValueSql("((0))");

                entity.Property(e => e.Deduction).HasColumnName("DEDUCTION");

                entity.Property(e => e.Description)
                    .HasMaxLength(1750)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Earnings).HasColumnName("EARNINGS");

                entity.Property(e => e.EmployerId).HasColumnName("EmployerID");

                entity.Property(e => e.FixedDedAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.FriOt).HasColumnName("FriOT");

                entity.Property(e => e.FriOtamt).HasColumnName("FriOTAmt");

                entity.Property(e => e.FriOtrate).HasColumnName("FriOTRate");

                entity.Property(e => e.GratuityAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.GratuityAmtThisMonth).HasDefaultValueSql("((0))");

                entity.Property(e => e.GratuityDys).HasDefaultValueSql("((0))");

                entity.Property(e => e.GratuityDysThisMonth).HasDefaultValueSql("((0))");

                entity.Property(e => e.GrossPay).HasDefaultValueSql("((0))");

                entity.Property(e => e.HoldWps)
                    .HasColumnName("HoldWPS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HolyOt).HasColumnName("HolyOT");

                entity.Property(e => e.HolyOtamt).HasColumnName("HolyOTAmt");

                entity.Property(e => e.HolyOtrate).HasColumnName("HolyOTRate");

                entity.Property(e => e.Hra)
                    .HasColumnName("HRA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jvid)
                    .HasColumnName("JVID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveRmk)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveSalAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveSalDys).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveSalId).HasColumnName("LeaveSalID");

                entity.Property(e => e.LiveInOut)
                    .HasColumnName("LiveIN_OUT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Living).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mode)
                    .HasColumnName("MODE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NonElgDys).HasDefaultValueSql("((0))");

                entity.Property(e => e.NorOt).HasColumnName("NorOT");

                entity.Property(e => e.NorOtamt).HasColumnName("NorOTAmt");

                entity.Property(e => e.NorOtrate).HasColumnName("NorOTRate");

                entity.Property(e => e.OtendDate)
                    .HasColumnName("OTEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Others).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtstDate)
                    .HasColumnName("OTStDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaidAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidBasic).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidLeave).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayFrom).HasColumnType("datetime");

                entity.Property(e => e.PayMonth)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.PayTo).HasColumnType("datetime");

                entity.Property(e => e.PayType).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayYear).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PersonId).HasColumnName("personId");

                entity.Property(e => e.PrevCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalaryPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.School).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowZero).HasDefaultValueSql("((0))");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Ta)
                    .HasColumnName("TA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TansType)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Tel).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotOt)
                    .HasColumnName("TotOT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotOtamt)
                    .HasColumnName("TotOTAmt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Total).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnpaidLeave).HasDefaultValueSql("((0))");

                entity.Property(e => e.WpsIban)
                    .HasColumnName("WPS_IBAN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.HrPayrollMaster)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_PayrollMaster_StaffMaster");
            });

            modelBuilder.Entity<HrPendingPayroll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_PendingPayroll");

                entity.Property(e => e.LeavSalId).HasColumnName("LeavSalID");

                entity.Property(e => e.Paymonth)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PayrollId).HasColumnName("PayrollID");

                entity.Property(e => e.Ppid).HasColumnName("PPId");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('LS')");
            });

            modelBuilder.Entity<HrProcessedAttendance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Processed_Attendance");

                entity.Property(e => e.AfterNoonShiftTotal).HasColumnType("datetime");

                entity.Property(e => e.ApId).HasColumnName("AP_ID");

                entity.Property(e => e.AttLogIdIn).HasColumnName("Att_LogId_IN");

                entity.Property(e => e.AttLogIdOut).HasColumnName("Att_LogId_Out");

                entity.Property(e => e.BreakHr)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.BreakHrFloat).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DinnerBreakIn).HasColumnType("datetime");

                entity.Property(e => e.DinnerBreakInActual).HasColumnType("datetime");

                entity.Property(e => e.DinnerBreakOut).HasColumnType("datetime");

                entity.Property(e => e.DinnerBreakOutActual).HasColumnType("datetime");

                entity.Property(e => e.DinnerBreakTotal).HasColumnType("datetime");

                entity.Property(e => e.DutyIn).HasColumnType("datetime");

                entity.Property(e => e.DutyOut).HasColumnType("datetime");

                entity.Property(e => e.EarlyGoing)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.EveningShiftTotal).HasColumnType("datetime");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.InTimeManual)
                    .HasColumnName("InTime_Manual")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LateComing)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.LeaveStatusId)
                    .HasColumnName("LeaveStatusID")
                    .HasDefaultValueSql("((18))");

                entity.Property(e => e.LongBreakIn).HasColumnType("datetime");

                entity.Property(e => e.LongBreakInActual).HasColumnType("datetime");

                entity.Property(e => e.LongBreakOut).HasColumnType("datetime");

                entity.Property(e => e.LongBreakOutActual).HasColumnType("datetime");

                entity.Property(e => e.LongBreakTotal).HasColumnType("datetime");

                entity.Property(e => e.LunchBreakIn).HasColumnType("datetime");

                entity.Property(e => e.LunchBreakInActual).HasColumnType("datetime");

                entity.Property(e => e.LunchBreakOut).HasColumnType("datetime");

                entity.Property(e => e.LunchBreakOutActual).HasColumnType("datetime");

                entity.Property(e => e.LunchBreakTotal).HasColumnType("datetime");

                entity.Property(e => e.MachineIdIn).HasColumnName("MachineId_IN");

                entity.Property(e => e.MachineIdOut).HasColumnName("MachineId_Out");

                entity.Property(e => e.MorningShiftTotal).HasColumnType("datetime");

                entity.Property(e => e.NightShiftTotal).HasColumnType("datetime");

                entity.Property(e => e.NoPunch).HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalHr)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01 09:00:00.000')");

                entity.Property(e => e.Othr)
                    .HasColumnName("OTHr")
                    .HasColumnType("datetime");

                entity.Property(e => e.OthrFloat).HasColumnName("OTHrFloat");

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.OutTimeManual)
                    .HasColumnName("OutTime_Manual")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('NP')");

                entity.Property(e => e.PunchDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.SlabOthr)
                    .HasColumnName("SlabOTHr")
                    .HasColumnType("datetime");

                entity.Property(e => e.SlabOthrFloat).HasColumnName("SlabOTHrFloat");

                entity.Property(e => e.SplOthr)
                    .HasColumnName("SplOTHr")
                    .HasColumnType("datetime");

                entity.Property(e => e.SplOthrFloat).HasColumnName("SplOTHrFloat");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.TotTime).HasColumnType("datetime");
            });

            ////modelBuilder.Entity<HrProjects>(entity =>
            ////{
            ////    entity.HasKey(e => e.ProjectId);

            ////    entity.ToTable("HR_Projects");

            ////    entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            ////    entity.Property(e => e.Active).HasColumnName("active");

            ////    entity.Property(e => e.ProjectName).HasMaxLength(50);
            ////});

            modelBuilder.Entity<HrQualification>(entity =>
            {
                entity.HasKey(e => e.QualificationId);

                entity.ToTable("HR_Qualification");

                entity.Property(e => e.QualificationId).ValueGeneratedNever();

                entity.Property(e => e.Qualification)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrRelationship>(entity =>
            {
                entity.HasKey(e => e.RelId);

                entity.ToTable("HR_Relationship");

                entity.Property(e => e.RelId)
                    .HasColumnName("RelID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RelName).HasMaxLength(50);
            });

            modelBuilder.Entity<HrReligion>(entity =>
            {
                entity.HasKey(e => e.ReligionId)
                    .HasName("PK_HR_ReligionId");

                entity.ToTable("HR_Religion");

                entity.Property(e => e.ReligionId).ValueGeneratedNever();

                entity.Property(e => e.Religion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrSalaryHead>(entity =>
            {
                entity.HasKey(e => e.Shid)
                    .HasName("PK_HR_SalaryPackageType");

                entity.ToTable("HR_SalaryHead");

                entity.Property(e => e.Shid)
                    .HasColumnName("SHId")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DontShowWps).HasColumnName("DontShowWPS");

                entity.Property(e => e.FldName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nature)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalObject)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Shname)
                    .HasColumnName("SHName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrSalaryPackage>(entity =>
            {
                entity.HasKey(e => e.Spid);

                entity.ToTable("HR_SalaryPackage");

                entity.Property(e => e.Spid)
                    .HasColumnName("SPId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nature)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Shid).HasColumnName("SHId");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.HasOne(d => d.Sh)
                    .WithMany(p => p.HrSalaryPackage)
                    .HasForeignKey(d => d.Shid)
                    .HasConstraintName("FK_SalaryPackage_SalaryHead");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.HrSalaryPackage)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_SalaryPackage_StaffMaster");
            });

            modelBuilder.Entity<HrServiceRequest>(entity =>
            {
                entity.HasKey(e => e.ServiceReqId);

                entity.ToTable("HR_ServiceRequest");

                entity.Property(e => e.ServiceReqId).HasColumnName("ServiceReqID");

                entity.Property(e => e.ServiceReqDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceReqApproveDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceReqApprovedBy).HasColumnName("ServiceReqApprovedBy");

                entity.Property(e => e.ServiceReqAprovImg).HasColumnType("image");

                entity.Property(e => e.ServiceReqRemarks).HasColumnType("text");
                entity.Property(e => e.ServiceStaffReview).HasColumnType("ServiceStaffReview");
                entity.Property(e => e.CompanyName).HasColumnType("CompanyName");
                entity.Property(e => e.hruser).HasColumnType("hruser");



                entity.HasOne(d => d.ServiceReqTypeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ServiceReqType)
                    .HasConstraintName("FK_HR_ServiceRequest_HR_ServiceRequestType");

            });

            modelBuilder.Entity<HrServiceRequestType>(entity =>
            {
                entity.HasKey(e => e.ServiceReqTypeId);

                entity.ToTable("HR_ServiceRequestType");

                entity.Property(e => e.ServiceReqTypeId).HasColumnName("ServiceReqTypeID");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ServiceReqTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<HrShiftMemberAllocation>(entity =>
            {
                entity.ToTable("HR_Shift_Member_Allocation");

                entity.HasIndex(e => new { e.ShiftId, e.MemberId, e.ShiftDate })
                    .HasName("Shift_Member_ShiftDate")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.ShiftTypeId).HasColumnName("Shift_Type_ID");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.HrShiftMemberAllocation)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Shift_Member_Allocation_StaffMaster");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.HrShiftMemberAllocation)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("FK_Shift_Member_Allocation_TimeTable");
            });

            modelBuilder.Entity<HrShiftTypes>(entity =>
            {
                entity.HasKey(e => e.ShiftTypeId);

                entity.ToTable("HR_ShiftTypes");

                entity.Property(e => e.ShiftTypeId)
                    .HasColumnName("ShiftTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShiftType).HasMaxLength(50);
            });

            modelBuilder.Entity<HrShifts>(entity =>
            {
                entity.HasKey(e => e.ShiftId);

                entity.ToTable("HR_Shifts");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NormalHr).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShiftName).HasMaxLength(50);
            });

            modelBuilder.Entity<HrSites>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("HR_Sites");

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ErpSiteId).HasColumnName("ERP_SiteId");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HrSkillDetails>(entity =>
            {
                entity.HasKey(e => e.SkId);

                entity.ToTable("HR_SkillDetails");

                entity.Property(e => e.SkId).ValueGeneratedNever();

                entity.Property(e => e.SkillName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");
            });

            modelBuilder.Entity<HrSponser>(entity =>
            {
                entity.HasKey(e => e.SponserId);

                entity.ToTable("HR_Sponser");

                entity.Property(e => e.SponserId).ValueGeneratedNever();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sponser)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            ////modelBuilder.Entity<HrStaffMaster>(entity =>
            ////{
            ////    entity.HasKey(e => e.StaffId);

            ////    entity.ToTable("HR_StaffMaster");

            ////    entity.HasIndex(e => e.EnrollNo)
            ////        .HasName("enrollno")
            ////        .IsUnique();

            ////    entity.Property(e => e.StaffId)
            ////        .HasColumnName("StaffID")
            ////        .ValueGeneratedNever();

            ////    entity.Property(e => e.Accommodation)
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.AgentId).HasColumnName("AgentID");

            ////    entity.Property(e => e.BankAcNo)
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.CmpId).HasColumnName("CmpID");

            ////    entity.Property(e => e.CostCenterId).HasColumnName("CostCenter_Id");

            ////    entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

            ////    entity.Property(e => e.DateOfEntry).HasColumnType("datetime");

            ////    entity.Property(e => e.Dob)
            ////        .HasColumnName("DOB")
            ////        .HasColumnType("datetime");

            ////    entity.Property(e => e.Doj)
            ////        .HasColumnName("DOJ")
            ////        .HasColumnType("datetime");

            ////    entity.Property(e => e.EmpQid)
            ////        .HasColumnName("EmpQID")
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.EmpvisaId)
            ////        .HasColumnName("EMPVisaID")
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.FamilyName)
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.FatherName)
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.FileNo)
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.FirstName)
            ////        .HasMaxLength(100)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.FriOtrate).HasColumnName("FriOTRate");

            ////    entity.Property(e => e.FullName)
            ////        .HasMaxLength(500)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.Gender)
            ////        .HasMaxLength(10)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.GradeId).HasColumnName("GradeID");

            ////    entity.Property(e => e.GratStDate).HasColumnType("datetime");

            ////    entity.Property(e => e.HolOtrate).HasColumnName("HolOTRate");

            ////    entity.Property(e => e.ImgStaus)
            ////        .HasColumnName("IMG_Staus")
            ////        .HasMaxLength(10)
            ////        .IsUnicode(false)
            ////        .IsFixedLength();

            ////    entity.Property(e => e.LastName)
            ////        .HasMaxLength(100)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.LastReJoinDate).HasColumnType("datetime");

            ////    entity.Property(e => e.LastWorkingDay).HasColumnType("datetime");

            ////    entity.Property(e => e.LeaveFreq)
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.LeavePolcyId).HasColumnName("Leave_Polcy_ID");

            ////    entity.Property(e => e.LevelId).HasColumnName("LevelID");

            ////    entity.Property(e => e.MiddleName)
            ////        .HasMaxLength(100)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.NorOtrate).HasColumnName("NorOTRate");

            ////    entity.Property(e => e.NormalHr).HasColumnType("datetime");

            ////    entity.Property(e => e.Oteligible).HasColumnName("OTEligible");

            ////    entity.Property(e => e.Otremarks)
            ////        .HasColumnName("OTRemarks")
            ////        .HasMaxLength(100)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.OverTiPolcyId).HasColumnName("OverTI_Polcy_ID");

            ////    entity.Property(e => e.PortOfEntry)
            ////        .HasMaxLength(100)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.PreAlopnBal)
            ////        .HasColumnName("PreALOpnBal")
            ////        .HasDefaultValueSql("((0))");

            ////    entity.Property(e => e.PreviousEmployer)
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.RoutingCode)
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

            ////    entity.Property(e => e.ShiftTypeId).HasColumnName("ShiftTypeID");

            ////    entity.Property(e => e.ShiftTypeId1).HasColumnName("Shift_Type_ID");

            ////    entity.Property(e => e.SiteId).HasColumnName("SiteID");

            ////    entity.Property(e => e.StaffCode)
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.StaffPhoto).HasColumnType("image");

            ////    entity.Property(e => e.StaffTypeId).HasColumnName("StaffTypeID");

            ////    entity.Property(e => e.StatusChangeDate).HasColumnType("datetime");

            ////    entity.Property(e => e.SubDepId).HasColumnName("SubDepID");

            ////    entity.Property(e => e.SuperVisorId).HasColumnName("SuperVisorID");

            ////    entity.Property(e => e.TimePolcyId).HasColumnName("Time_Polcy_ID");

            ////    entity.Property(e => e.TransType)
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.Ttid).HasColumnName("TTId");

            ////    entity.Property(e => e.Uidno)
            ////        .HasColumnName("UIDNO")
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.VehicleNo)
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.WpsIban)
            ////        .HasColumnName("WPS_IBAN")
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.WpspersonId).HasColumnName("WPSPersonId");

            ////    entity.HasOne(d => d.BloodGroup)
            ////        .WithMany(p => p.HrStaffMaster)
            ////        .HasForeignKey(d => d.BloodGroupId)
            ////        .HasConstraintName("FK_StaffMaster_BloodGroup");

            ////    entity.HasOne(d => d.Company)
            ////        .WithMany(p => p.HrStaffMaster)
            ////        .HasForeignKey(d => d.CompanyId)
            ////        .OnDelete(DeleteBehavior.Cascade)
            ////        .HasConstraintName("FK_StaffMaster_CompanyMaster");

            ////    entity.HasOne(d => d.Department)
            ////        .WithMany(p => p.HrStaffMaster)
            ////        .HasForeignKey(d => d.DepartmentId)
            ////        .HasConstraintName("FK_StaffMaster_Department");

            ////    entity.HasOne(d => d.Designation)
            ////        .WithMany(p => p.HrStaffMaster)
            ////        .HasForeignKey(d => d.DesignationId)
            ////        .HasConstraintName("FK_StaffMaster_Designation");

            ////    entity.HasOne(d => d.Language)
            ////        .WithMany(p => p.HrStaffMaster)
            ////        .HasForeignKey(d => d.LanguageId)
            ////        .HasConstraintName("FK_StaffMaster_Language");

            ////    entity.HasOne(d => d.MaritalStatus)
            ////        .WithMany(p => p.HrStaffMaster)
            ////        .HasForeignKey(d => d.MaritalStatusId)
            ////        .HasConstraintName("FK_StaffMaster_MaritalStatus");

            ////    entity.HasOne(d => d.Nationality)
            ////        .WithMany(p => p.HrStaffMaster)
            ////        .HasForeignKey(d => d.NationalityId)
            ////        .HasConstraintName("FK_StaffMaster_Nationality");

            ////    entity.HasOne(d => d.Qualification)
            ////        .WithMany(p => p.HrStaffMaster)
            ////        .HasForeignKey(d => d.QualificationId)
            ////        .HasConstraintName("FK_StaffMaster_Qualification");

            ////    entity.HasOne(d => d.VisaCompany)
            ////        .WithMany(p => p.HrStaffMaster)
            ////        .HasForeignKey(d => d.VisaCompanyId)
            ////        .HasConstraintName("FK_StaffMaster_VisaCompany");

            ////    entity.HasOne(d => d.VisaDesignation)
            ////        .WithMany(p => p.HrStaffMaster)
            ////        .HasForeignKey(d => d.VisaDesignationId)
            ////        .HasConstraintName("FK_StaffMaster_VisaDesignation");
            ////});

            modelBuilder.Entity<HrStaffType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_StaffType");

                entity.Property(e => e.DebAccNo)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.NorOtrate).HasColumnName("NorOTRate");

                entity.Property(e => e.StaffType).HasMaxLength(50);

                entity.Property(e => e.StaffTypeId).HasColumnName("StaffTypeID");
            });

            modelBuilder.Entity<HrSubDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_SubDepartment");

                entity.Property(e => e.DepId).HasColumnName("DepID");

                entity.Property(e => e.SubDepCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubDepName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrTimeSettings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_Time_Settings");

                entity.Property(e => e.Braktime).HasColumnName("braktime");

                entity.Property(e => e.BreaktimeGe).HasColumnName("breaktimeGE");

                entity.Property(e => e.DedDaysGe).HasColumnName("DedDaysGE");

                entity.Property(e => e.ExcludeHolFriOt).HasColumnName("ExcludeHOL_FRI_OT");

                entity.Property(e => e.GracetimeGe).HasColumnName("GracetimeGE");

                entity.Property(e => e.GracetimeYn).HasColumnName("GracetimeYN");

                entity.Property(e => e.GracetimeYnge).HasColumnName("GracetimeYNGE");

                entity.Property(e => e.HalfDayLess)
                    .HasColumnName("halfDAyLess")
                    .HasColumnType("datetime");

                entity.Property(e => e.HalfDayLessYn).HasColumnName("halfDAyLessYN");

                entity.Property(e => e.HalfDayTimeHr).HasColumnName("halfDAyTimeHr");

                entity.Property(e => e.HalfDayTimeMnt).HasColumnName("halfDayTimeMnt");

                entity.Property(e => e.HalfdayGreater).HasColumnType("datetime");

                entity.Property(e => e.HalfdayGreaterYn).HasColumnName("HalfdayGreaterYN");

                entity.Property(e => e.HalfdayYn).HasColumnName("HAlfdayYN");

                entity.Property(e => e.HalfdayYnge).HasColumnName("HAlfdayYNGE");

                entity.Property(e => e.LateTimeNoGe).HasColumnName("LateTimeNoGE");

                entity.Property(e => e.LateTimesGe).HasColumnName("LateTimesGE");

                entity.Property(e => e.MarklateGe).HasColumnName("MarklateGE");

                entity.Property(e => e.PeriodType)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.PeriodTypeGe)
                    .HasColumnName("PeriodTypeGE")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Policyname)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SlogBefShift).HasColumnName("SLogBefShift");

                entity.Property(e => e.TimeSettingId)
                    .HasColumnName("TimeSetting_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrTimeSheet>(entity =>
            {
                entity.HasKey(e => e.Tsid);

                entity.ToTable("HR_TimeSheet");

                entity.Property(e => e.Tsid)
                    .HasColumnName("TSID")
                    .ValueGeneratedNever();

                entity.Property(e => e.HolHr).HasDefaultValueSql("((0))");

                entity.Property(e => e.MonthId).HasColumnName("MonthID");

                entity.Property(e => e.Othr)
                    .HasColumnName("OTHr")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.TotHr).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tsdate)
                    .HasColumnName("TSDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tsyear).HasColumnName("TSYear");
            });

            modelBuilder.Entity<HrTimeSheetBrkUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_TimeSheet_BrkUP");

                entity.Property(e => e.BrkUpDate)
                    .HasColumnName("BrkUP_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BrkUpDay)
                    .HasColumnName("BrkUP_Day")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrkUpDtlId).HasColumnName("BrkUP_DTL_ID");

                entity.Property(e => e.BrkUpId).HasColumnName("BrkUP_ID");

                entity.Property(e => e.BrkUpMastId).HasColumnName("BrkUP_MAST_ID");

                entity.Property(e => e.BrkUpNormal)
                    .HasColumnName("BrkUP_Normal")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BrkUpOt)
                    .HasColumnName("BrkUP_OT")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BrkUpProjId).HasColumnName("BrkUP_Proj_ID");

                entity.Property(e => e.BrkUpRemarks)
                    .HasColumnName("BrkUP_Remarks")
                    .HasMaxLength(500);

                entity.Property(e => e.NorAmt).HasColumnName("NorAMT");

                entity.Property(e => e.Otamt).HasColumnName("OTAMT");
            });

            modelBuilder.Entity<HrTimeSheetDetails>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("HR_TimeSheetDetails");

                entity.Property(e => e.Sno)
                    .HasColumnName("SNO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ot).HasColumnName("OT");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.TsdDate)
                    .HasColumnName("TSD_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tsid).HasColumnName("TSID");

                entity.HasOne(d => d.Ts)
                    .WithMany(p => p.HrTimeSheetDetails)
                    .HasForeignKey(d => d.Tsid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TimeSheetDetails_TimeSheet");
            });

            modelBuilder.Entity<HrTimeSheetDetailsKz>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("HR_TimeSheetDetailsKZ");

                entity.Property(e => e.Sno)
                    .HasColumnName("SNO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Intime)
                    .HasColumnName("INTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntimeFloat).HasColumnName("INTimeFloat");

                entity.Property(e => e.Outtime)
                    .HasColumnName("OUTTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjId).HasColumnName("ProjID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TotHr).HasColumnType("datetime");

                entity.Property(e => e.Tsid).HasColumnName("TSID");

                entity.HasOne(d => d.Ts)
                    .WithMany(p => p.HrTimeSheetDetailsKz)
                    .HasForeignKey(d => d.Tsid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TimeSheetDetails_TimeSheetKZ");
            });

            modelBuilder.Entity<HrTimeSheetDetailsTime>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("HR_TimeSheetDetailsTime");

                entity.Property(e => e.Sno)
                    .HasColumnName("SNO")
                    .ValueGeneratedNever();

                entity.Property(e => e.FromTime).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ot).HasColumnName("OT");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.ToTime).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TsdDate)
                    .HasColumnName("TSD_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tsid).HasColumnName("TSID");

                entity.HasOne(d => d.Ts)
                    .WithMany(p => p.HrTimeSheetDetailsTime)
                    .HasForeignKey(d => d.Tsid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TimeSheetDetailsTime_TimeSheetTime");
            });

            modelBuilder.Entity<HrTimeSheetDetailsTimeBrk>(entity =>
            {
                entity.HasKey(e => e.TsidDet);

                entity.ToTable("HR_TimeSheetDetailsTimeBrk");

                entity.Property(e => e.TsidDet).HasColumnName("TSID_Det");

                entity.Property(e => e.HolOt).HasColumnName("HolOT");

                entity.Property(e => e.NorOt).HasColumnName("NorOT");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).HasColumnName("SNO");

                entity.Property(e => e.TsdDate)
                    .HasColumnName("TSD_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tsid).HasColumnName("TSID");
            });

            modelBuilder.Entity<HrTimeSheetKz>(entity =>
            {
                entity.HasKey(e => e.Tsid);

                entity.ToTable("HR_TimeSheetKZ");

                entity.Property(e => e.Tsid)
                    .HasColumnName("TSID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.SubmitTs).HasColumnName("SubmitTS");

                entity.Property(e => e.Tsdate)
                    .HasColumnName("TSDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<HrTimeSheetMulStaff>(entity =>
            {
                entity.HasKey(e => e.Tsid);

                entity.ToTable("HR_TimeSheetMulStaff");

                entity.Property(e => e.Tsid)
                    .HasColumnName("TSID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MonthId).HasColumnName("MonthID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TsDate).HasColumnType("datetime");

                entity.Property(e => e.Tsyear).HasColumnName("TSYear");
            });

            modelBuilder.Entity<HrTimeSheetMulStaffDetails>(entity =>
            {
                entity.HasKey(e => e.TsId);

                entity.ToTable("HR_TimeSheetMulStaff_Details");

                entity.Property(e => e.TsId)
                    .HasColumnName("TsID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrInTimeFloat).HasDefaultValueSql("((0))");

                entity.Property(e => e.BrOutTimeFloat).HasDefaultValueSql("((0))");

                entity.Property(e => e.BrTotTimeFloat).HasDefaultValueSql("((0))");

                entity.Property(e => e.BrkIn).HasColumnType("datetime");

                entity.Property(e => e.BrkOut).HasColumnType("datetime");

                entity.Property(e => e.DesigId).HasColumnName("DesigID");

                entity.Property(e => e.FriOt).HasColumnName("FriOT");

                entity.Property(e => e.HolOt).HasColumnName("HolOT");

                entity.Property(e => e.InTimeFloat).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEdit).HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.NormOt).HasColumnName("NormOT");

                entity.Property(e => e.OutTimeFloat).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayrollId).HasColumnName("PayrollID");

                entity.Property(e => e.RemarksDet)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SiteIdmod).HasColumnName("SiteIDMod");

                entity.Property(e => e.SiteIdorg).HasColumnName("SiteIDOrg");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.TotHr).HasColumnType("datetime");

                entity.Property(e => e.TotTimeFloat).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Ts)
                    .WithOne(p => p.HrTimeSheetMulStaffDetails)
                    .HasForeignKey<HrTimeSheetMulStaffDetails>(d => d.TsId)
                    .HasConstraintName("FK_TimeSheetMulStaff_Details_TimeSheetMulStaff");
            });

            modelBuilder.Entity<HrTimeSheetTime>(entity =>
            {
                entity.HasKey(e => e.Tsid);

                entity.ToTable("HR_TimeSheetTime");

                entity.Property(e => e.Tsid)
                    .HasColumnName("TSID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MonthId).HasColumnName("MonthID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Tsdate)
                    .HasColumnName("TSDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tsyear).HasColumnName("TSYear");
            });

            modelBuilder.Entity<HrTimeSheetTimeBrk>(entity =>
            {
                entity.HasKey(e => e.Tsid);

                entity.ToTable("HR_TimeSheetTimeBrk");

                entity.Property(e => e.Tsid)
                    .HasColumnName("TSID")
                    .ValueGeneratedNever();

                entity.Property(e => e.HolOt).HasColumnName("HolOT");

                entity.Property(e => e.MonthId).HasColumnName("MonthID");

                entity.Property(e => e.NorOt).HasColumnName("NorOT");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.TotOt).HasColumnName("TotOT");

                entity.Property(e => e.Tsdate)
                    .HasColumnName("TSDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tsyear).HasColumnName("TSYear");
            });

            modelBuilder.Entity<HrTimeTable>(entity =>
            {
                entity.HasKey(e => e.Ttid);

                entity.ToTable("HR_TimeTable");

                entity.Property(e => e.Ttid)
                    .HasColumnName("TTId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NormalHr).HasColumnType("datetime");

                entity.Property(e => e.Tcode)
                    .HasColumnName("TCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrTimeTableDetails>(entity =>
            {
                entity.HasKey(e => e.TtdetailsId);

                entity.ToTable("HR_TimeTableDetails");

                entity.Property(e => e.TtdetailsId)
                    .HasColumnName("TTDetailsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.DayType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InTimeEarlyHr).HasColumnType("datetime");

                entity.Property(e => e.InTimeEarlyTrim1)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.InTimeEarlyTrim2)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.InTimeEarlyTrim3)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.InTimeHr).HasColumnType("datetime");

                entity.Property(e => e.InTimeLateHr).HasColumnType("datetime");

                entity.Property(e => e.InTimeLateTrim2)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.InTimeLateTrim3)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.IntimeLateTrim1)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.LunchIn).HasColumnType("datetime");

                entity.Property(e => e.LunchOut).HasColumnType("datetime");

                entity.Property(e => e.OutTimeEarlyHr).HasColumnType("datetime");

                entity.Property(e => e.OutTimeEarlyTrim1)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.OutTimeEarlyTrim2)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.OutTimeEarlyTrim3)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.OutTimeHr).HasColumnType("datetime");

                entity.Property(e => e.OutTimeLateHr).HasColumnType("datetime");

                entity.Property(e => e.OutTimeLateTrim1)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.OutTimeLateTrim2)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.OutTimeLateTrim3)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.Ttid).HasColumnName("TTId");

                entity.Property(e => e.WeekDay)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Tt)
                    .WithMany(p => p.HrTimeTableDetails)
                    .HasForeignKey(d => d.Ttid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TimeTableDetails_TimeTable");
            });

            modelBuilder.Entity<HrTrainingDetails>(entity =>
            {
                entity.ToTable("HR_TrainingDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseFee).HasColumnType("money");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Institution)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Period)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StaffCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HrUserPermission>(entity =>
            {
                entity.HasKey(e => e.Upid);

                entity.ToTable("HR_UserPermission");

                entity.Property(e => e.Upid)
                    .HasColumnName("UPId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Upadd).HasColumnName("UPAdd");

                entity.Property(e => e.Upallow).HasColumnName("UPAllow");

                entity.Property(e => e.Updelete).HasColumnName("UPDelete");

                entity.Property(e => e.Upedit).HasColumnName("UPEdit");

                entity.Property(e => e.Upprint).HasColumnName("UPPrint");

                entity.Property(e => e.Upview).HasColumnName("UPView");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HrUserPermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserPermission_Users");
            });

            modelBuilder.Entity<HrUserTracking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_User_Tracking");

                entity.Property(e => e.ChangeDt)
                    .HasColumnName("Change_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("Change_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fsno)
                    .HasColumnName("FSNO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasColumnName("staffId");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.Usno)
                    .HasColumnName("USNO")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Vpaction)
                    .IsRequired()
                    .HasColumnName("VPAction")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vpno)
                    .IsRequired()
                    .HasColumnName("VPNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vptype)
                    .HasColumnName("VPType")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("HR_Users");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passwd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkgroupId).HasColumnName("workgroupID");

                entity.Property(e => e.StaffName).HasColumnName("StaffName");

                entity.Property(e => e.PassportNo).HasColumnName("PassportNo");

                entity.Property(e => e.Designation).HasColumnName("Designation");

                entity.HasOne(d => d.WorkPositionNavigation)
                    .WithMany(p => p.HrUsers)
                    .HasForeignKey(d => d.WorkPosition)
                    .HasConstraintName("FK_Users_WorkPosition");
            });

            modelBuilder.Entity<HrVehicleMaster>(entity =>
            {
                entity.ToTable("HR_VehicleMaster");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChasisNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.EngineNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.VehicleNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTye)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrVisaCompany>(entity =>
            {
                entity.HasKey(e => e.VisaCompanyId);

                entity.ToTable("HR_VisaCompany");

                entity.Property(e => e.VisaCompanyId).ValueGeneratedNever();

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VisaCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrVisaDesignation>(entity =>
            {
                entity.HasKey(e => e.VisaDesignationId);

                entity.ToTable("HR_VisaDesignation");

                entity.Property(e => e.VisaDesignationId).ValueGeneratedNever();

                entity.Property(e => e.VisaDesignation)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrVisaType>(entity =>
            {
                entity.HasKey(e => e.VisaTypId);

                entity.ToTable("HR_VisaType");

                entity.Property(e => e.VisaTypId).ValueGeneratedNever();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VisaType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrWeekDays>(entity =>
            {
                entity.HasKey(e => e.WeekDays);

                entity.ToTable("HR_WeekDays");

                entity.Property(e => e.WeekDays)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DayType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrWorkGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_WorkGroup");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrWorkGroupPermissions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_WorkGroup_Permissions");

                entity.Property(e => e.Sno).ValueGeneratedOnAdd();

                entity.Property(e => e.Uadd).HasColumnName("UAdd");

                entity.Property(e => e.Uallow).HasColumnName("UAllow");

                entity.Property(e => e.Udelete).HasColumnName("UDelete");

                entity.Property(e => e.Uedit).HasColumnName("UEdit");

                entity.Property(e => e.Uprint).HasColumnName("UPrint");

                entity.Property(e => e.Uview).HasColumnName("UView");
            });

            modelBuilder.Entity<HrWorkPosition>(entity =>
            {
                entity.HasKey(e => e.WorkPosition);

                entity.ToTable("HR_WorkPosition");

                entity.Property(e => e.WorkPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDateTime).HasColumnType("datetime");
            });

            //======================new Tables

            ////modelBuilder.Entity<HrMultiStaffTimesheetData>(entity =>
            ////{
            ////    entity.HasKey(e => e.TimesheetDataId);

            ////    entity.ToTable("HR_MultiStaff_TimesheetData");

            ////    entity.Property(e => e.TimesheetDataId).HasColumnName("TimesheetDataID");

            ////    entity.Property(e => e.Description).HasColumnType("text");

            ////    entity.Property(e => e.EndDate).HasColumnType("date");

            ////    entity.Property(e => e.TimesheetDataProjectId).HasColumnName("TimesheetDataProjectID");

            ////    entity.Property(e => e.TimesheetDataStaffId).HasColumnName("TimesheetDataStaffID");

            ////    entity.Property(e => e.TimesheetId).HasColumnName("timesheetID");

            ////    ////entity.HasOne(d => d.Timesheet)
            ////    ////    .WithMany(p => p.HrMultiStaffTimesheetData)
            ////    ////    .HasForeignKey(d => d.TimesheetId)
            ////    ////    .HasConstraintName("FK_HR_MultiStaff_TimesheetData_HR_MultiStaff_Timesheets");
            ////});

            ////modelBuilder.Entity<HrMultiStaffTimesheets>(entity =>
            ////{
            ////    entity.HasKey(e => e.TimesheetId);

            ////    entity.ToTable("HR_MultiStaff_Timesheets");

            ////    entity.Property(e => e.TimesheetId).HasColumnName("timesheetID");

            ////    entity.Property(e => e.Created)
            ////        .HasColumnName("created")
            ////        .HasColumnType("date");

            ////    entity.Property(e => e.createdby).HasColumnName("createdby");

            ////    entity.Property(e => e.Employee).HasColumnName("employee");

            ////    entity.Property(e => e.Status).HasColumnName("status");

            ////    entity.Property(e => e.Timesheetdate)
            ////        .HasColumnName("timesheetdate")
            ////        .HasColumnType("date");
            ////});


            modelBuilder.Entity<HrMultiStaffTimesheetData>(entity =>
            {
                entity.HasKey(e => e.TimesheetDataId);

                entity.ToTable("HR_MultiStaff_TimesheetData");

                entity.Property(e => e.TimesheetDataId).HasColumnName("TimesheetDataID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.TimesheetDataProjectId).HasColumnName("TimesheetDataProjectID");

                entity.Property(e => e.TimesheetDataStaffId).HasColumnName("TimesheetDataStaffID");

                entity.Property(e => e.TimesheetId).HasColumnName("timesheetID");

                entity.HasOne(d => d.TimesheetDataProject)
                    .WithMany(p => p.HrMultiStaffTimesheetData)
                    .HasForeignKey(d => d.TimesheetDataProjectId)
                    .HasConstraintName("FK_HR_MultiStaff_TimesheetData_HR_Projects");

                entity.HasOne(d => d.TimesheetDataStaff)
                    .WithMany(p => p.HrMultiStaffTimesheetData)
                    .HasForeignKey(d => d.TimesheetDataStaffId)
                    .HasConstraintName("FK_HR_MultiStaff_TimesheetData_HR_StaffMaster");

                entity.HasOne(d => d.Timesheet)
                    .WithMany(p => p.HrMultiStaffTimesheetData)
                    .HasForeignKey(d => d.TimesheetId)
                    .HasConstraintName("FK_HR_MultiStaff_TimesheetData_HR_MultiStaff_Timesheets");
            });

            modelBuilder.Entity<HrMultiStaffTimesheets>(entity =>
            {
                entity.HasKey(e => e.TimesheetId);

                entity.ToTable("HR_MultiStaff_Timesheets");

                entity.Property(e => e.TimesheetId).HasColumnName("timesheetID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("date");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Employee).HasColumnName("employee");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Timesheetdate)
                    .HasColumnName("timesheetdate")
                    .HasColumnType("date");
            });



            //==========================

            modelBuilder.Entity<HrProjects>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("HR_Projects");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ProjectName).HasMaxLength(50);
            });

            modelBuilder.Entity<HrStaffMaster>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("HR_StaffMaster");

                entity.HasIndex(e => e.EnrollNo)
                    .HasName("enrollno")
                    .IsUnique();

                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accommodation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.BankAcNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CmpId).HasColumnName("CmpID");

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenter_Id");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DateOfEntry).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Doj)
                    .HasColumnName("DOJ")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpQid)
                    .HasColumnName("EmpQID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpvisaId)
                    .HasColumnName("EMPVisaID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FamilyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FriOtrate).HasColumnName("FriOTRate");

                entity.Property(e => e.FullName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.GratStDate).HasColumnType("datetime");

                entity.Property(e => e.HolOtrate).HasColumnName("HolOTRate");

                entity.Property(e => e.ImgStaus)
                    .HasColumnName("IMG_Staus")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastReJoinDate).HasColumnType("datetime");

                entity.Property(e => e.LastWorkingDay).HasColumnType("datetime");

                entity.Property(e => e.LeaveFreq)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeavePolcyId).HasColumnName("Leave_Polcy_ID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NorOtrate).HasColumnName("NorOTRate");

                entity.Property(e => e.NormalHr).HasColumnType("datetime");

                entity.Property(e => e.Oteligible).HasColumnName("OTEligible");

                entity.Property(e => e.Otremarks)
                    .HasColumnName("OTRemarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OverTiPolcyId).HasColumnName("OverTI_Polcy_ID");

                entity.Property(e => e.PortOfEntry)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreAlopnBal)
                    .HasColumnName("PreALOpnBal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PreviousEmployer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.ShiftTypeId).HasColumnName("ShiftTypeID");

                entity.Property(e => e.ShiftTypeId1).HasColumnName("Shift_Type_ID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.StaffCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffPhoto).HasColumnType("image");

                entity.Property(e => e.StaffTypeId).HasColumnName("StaffTypeID");

                entity.Property(e => e.StatusChangeDate).HasColumnType("datetime");

                entity.Property(e => e.SubDepId).HasColumnName("SubDepID");

                entity.Property(e => e.SuperVisorId).HasColumnName("SuperVisorID");

                entity.Property(e => e.TimePolcyId).HasColumnName("Time_Polcy_ID");

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ttid).HasColumnName("TTId");

                entity.Property(e => e.Uidno)
                    .HasColumnName("UIDNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WpsIban)
                    .HasColumnName("WPS_IBAN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WpspersonId).HasColumnName("WPSPersonId");
            });
            ///=============================

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
