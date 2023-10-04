using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestLinux
{
    public class UniqueCode
    {
        public readonly string BankIdRouteValue = "ShishirShuklaCRGB";
    }
    public class CustomIDataProtection
    {
        private readonly IDataProtector protector;
        public CustomIDataProtection(IDataProtectionProvider dataProtectionProvider, UniqueCode uniqueCode)
        {
            protector = dataProtectionProvider.CreateProtector(uniqueCode.BankIdRouteValue);
        }
        public string Decode(string data)
        {
            return protector.Protect(data);
        }
        public string Encode(string data)
        {
            return protector.Unprotect(data);
        }

    }
    public class Grievance
    {
        public Grievance()
        {
            Id = "";
            AmountInvolved = 0;
        }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Mobile Number must be numeric")]
        public string MobileNo { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string ApplicantName { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Complaint { get; set; }
        [Required]
        public string Segment { get; set; }
        public string Status { get; set; }
        public string Reply { get; set; }
        public string RO { get; set; }
        public string Branch { get; set; }
        
        public string District { get; set; }
        public string DigitalTxn { get; set; }
        public string AccountNumber { get; set; }
        public Single AmountInvolved { get; set; }

        public DateTime RegisterDate { get; set; }
        public string InternalReply { get; set; }

        public string BrReplyId { get; set; }

        public DateTime? BrReplyDate { get; set; }
        public string CheckerReply { get; set; }
        public string CheckerReplyId { get; set; }
        public DateTime? CheckerReplyDate { get; set; }

        public string ROReply { get; set; }
        public string ROReplyId { get; set; }
        public DateTime? ROReplyDate { get; set; }

        public string HOReply { get; set; }

        public string ComplaintChannel { get; set; }
        public string ComplaintType { get; set; }

        public string HOReplyId { get; set; }
        public DateTime? HOReplyDate { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? TransactionDate { get; set; }

        public DateTime? ClosureDate { get; set; }
    }
    public class User
    {
        [Key]

        public string UserId { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required]
        public string RegionalOffice { get; set; }

    }

    public class BranchPerformance
    {
        [Key]
        public string BranchCode { get; set; }
        
        public Single DepositPrevFy { get; set; }
        
        public Single DepositLastFy { get; set; }
        
        public Single DepositLastQuarter { get; set; }

        
        public Single DepositLastMonth { get; set; }
        
        public Single DepositLastDay { get; set; }

        
        public Single CASAPrevFy { get; set; }
        
        public Single CASALastFy { get; set; }
        
        public Single CASALastQuarter { get; set; }

        
        public Single CASALastMonth { get; set; }
        
        public Single CASALastDay { get; set; }

        
        public Single NPAPrevFy { get; set; }
        
        public Single NPALastFy { get; set; }
        
        public Single NPALastQuarter { get; set; }

        
        public Single NPALastMonth { get; set; }
        
        public Single NPALastDay { get; set; }

        
        public Single AdvancePrevFy { get; set; }
        
        public Single AdvanceLastFy { get; set; }
        
        public Single AdvanceLastQuarter { get; set; }

        
        public Single AdvanceLastMonth { get; set; }
        
        public Single AdvanceLastDay { get; set; }

        
        public Single PerPrevFy { get; set; }
        
        public Single PerLastFy { get; set; }
        
        public Single PerLastQuarter { get; set; }

        
        public Single PerLastMonth { get; set; }
        
        public Single PerLastDay { get; set; }


        
        public Single AgriPrevFy { get; set; }
        
        public Single AgriLastFy { get; set; }
        
        public Single AgriLastQuarter { get; set; }

        
        public Single AgriLastMonth { get; set; }
        
        public Single AgriLastDay { get; set; }

        
        public Single SMEPrevFy { get; set; }
        
        public Single SMELastFy { get; set; }
        
        public Single SMELastQuarter { get; set; }

        
        public Single SMELastMonth { get; set; }
        
        public Single SMELastDay { get; set; }

        
        public Single HLPrevFy { get; set; }
        
        public Single HLLastFy { get; set; }
        
        public Single HLLastQuarter { get; set; }

        
        public Single HLLastMonth { get; set; }
        
        public Single HLLastDay { get; set; }

        
        public Single CarPrevFy { get; set; }
        
        public Single CarLastFy { get; set; }
        
        public Single CarLastQuarter { get; set; }

        
        public Single CarLastMonth { get; set; }
        
        public Single CarLastDay { get; set; }


        
        public Single PLPrevFy { get; set; }
        
        public Single PLLastFy { get; set; }
        
        public Single PLLastQuarter { get; set; }

        
        public Single PLLastMonth { get; set; }
        
        public Single PLLastDay { get; set; }


        
        public Single GoldPrevFy { get; set; }
        
        public Single GoldLastFy { get; set; }
        
        public Single GoldLastQuarter { get; set; }

        
        public Single GoldLastMonth { get; set; }
        
        public Single GoldLastDay { get; set; }


        
        public Single KCCPrevFy { get; set; }
        
        public Single KCCLastFy { get; set; }
        
        public Single KCCLastQuarter { get; set; }

        
        public Single KCCLastMonth { get; set; }
        
        public Single KCCLastDay { get; set; }


        
        public Single NRLMPrevFy { get; set; }
        
        public Single NRLMLastFy { get; set; }
        
        public Single NRLMLastQuarter { get; set; }

        
        public Single NRLMLastMonth { get; set; }
        
        public Single NRLMLastDay { get; set; }


        
        public Single SMELPrevFy { get; set; }
        
        public Single SMELLastFy { get; set; }
        
        public Single SMELLastQuarter { get; set; }

        
        public Single SMELLastMonth { get; set; }
        
        public Single SMELLastDay { get; set; }
    }

    public class EmployeeMaster
    {
        [Key]

        public string UserId { get; set; }
        public string EmployeeName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string Scale { get; set; }
        [Required]
        public string BranchCode { get; set; }
        [Required]
        public string Role1 { get; set; }
        [Required]
        public string Role2 { get; set; }

    }
    public class Csp
    {
        [Key]
        public string UserId { get; set; }
        [Required]
        public string CSPName { get; set; }
        [Required]
        public string CorporateAgency { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        [ForeignKey("BranchMaster")]
        public string BrCode { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Photo { get; set; }
        public BranchMaster BranchMaster { get; set; }

    }
    public class ValueStatement
    {
        [Key]
        public int  Id { get; set; }
        [Required]
        public string Statement { get; set; }
        [Required]
        public string InputType { get; set; }
        [Required]
        public string Status { get; set; }
        

    }
    public class PreValueStatement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Statement { get; set; }
        [Required]
        public string InputType { get; set; }
        [Required]
        public string Status { get; set; }


    }
    public class PostValueStatement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Statement { get; set; }
        [Required]
        public string InputType { get; set; }
        [Required]
        public string Status { get; set; }


    }
    public static class ext
    {
        public static void CopyAllTo<T>(this T source, T target)
        {
            var type = typeof(T);
            foreach (var sourceProperty in type.GetProperties())
            {
                var targetProperty = type.GetProperty(sourceProperty.Name);
                targetProperty.SetValue(target, sourceProperty.GetValue(source, null), null);
            }
            foreach (var sourceField in type.GetFields())
            {
                var targetField = type.GetField(sourceField.Name);
                targetField.SetValue(target, sourceField.GetValue(source));
            }
        }
    }
    public class CSPVisitView : CSPVisit 
    {
        public EmployeeMaster EmployeeDetails { get; set; }
        public Csp BCDetails { get; set; }
    }
    public class CSPVisitWithStatement : VisitRemark
    {
        public string ValueStatement { get; set; }
    }
    public class PreVisitWithStatement : PreVisitRemark
    {
        public string ValueStatement { get; set; }
    }
    public class CPSVisitReport
    {
        public EmployeeMaster EmployeeDetails { get; set;}
        public Csp BCDetails { get; set; }
        public List<CSPVisitWithStatement> VisitRemarks { get; set; }
        public CSPVisit VisitDetails { get; set; }
    }
    public class PreVisitReport
    {
        public EmployeeMaster EmployeeDetails { get; set; }
        public List<PreVisitWithStatement> VisitRemarks { get; set; }
        public PreInspection VisitDetails { get; set; }
    }
    public class CSPVisit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("EmployeeMaster")]
        public string UserId { get; set; }
        [Required]
        [ForeignKey("CSP")]
        public string CSPId { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime VisitDate { get; set; }
        [Required]
        public DateTime SystemLogDate { get; set; }
        
        public DateTime? ClosureDate { get; set; }
        
        public string ClosureOfficialId { get; set; }
        
        public string VisitRemarks { get; set; }
        public string Location_lat { get; set; }
        public string Location_long { get; set; }
        public virtual  Csp Csp { get; set; }
        public virtual EmployeeMaster EmployeeMaster { get; set; }


    }

    public class PreInspection
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string ApplicationId { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime VisitDate { get; set; }
        [Required]
        public DateTime SystemLogDate { get; set; }

        public DateTime? ClosureDate { get; set; }

        public string ClosureOfficialId { get; set; }

        public string VisitRemarks { get; set; }


    }
    public class PostInspection
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime VisitDate { get; set; }
        [Required]
        public DateTime SystemLogDate { get; set; }

        public DateTime? ClosureDate { get; set; }

        public string ClosureOfficialId { get; set; }

        public string VisitRemarks { get; set; }


    }

    public class VisitRemark
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int VisitId { get; set; }
        [Required]
        public int  ValueStatementId { get; set; }
        [Required]
        public string RemarksVisitingOfficial { get; set; }
        [Required]
        public string RemarksVerifyingOfficial { get; set; }
        [Required]
        public string Status { get; set; }


    }
    public class PreVisitRemark
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int VisitId { get; set; }
        [Required]
        public int ValueStatementId { get; set; }
        [Required]
        public string RemarksVisitingOfficial { get; set; }
        [Required]
        public string RemarksVerifyingOfficial { get; set; }
        [Required]
        public string Status { get; set; }


    }
    public class PostVisitRemark
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int VisitId { get; set; }
        [Required]
        public int ValueStatementId { get; set; }
        [Required]
        public string RemarksVisitingOfficial { get; set; }
        [Required]
        public string RemarksVerifyingOfficial { get; set; }
        [Required]
        public string Status { get; set; }


    }


    public class Logs
    {
        

        public int Id { get; set; }
        
        public string Type { get; set; }
        
        public string LogDateTime { get; set; }
        
        public string Remarks { get; set; }

    }
    public class BranchMaster
    {
        [Key]
        public string BrCode { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string BranchName { get; set; }
        [Required]
        public string RO { get; set; }

    }
    public class OTP
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string OTPValue { get; set; }
        [Required]
        public string Application { get; set; }

        [Required]
        public string IsUsed { get; set; }

    }
    public class UserProfile
    {
        [Key]
        public string MobileNumber { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Designation { get; set; }

        [Required]
        public string Posting { get; set; }

    }

    public class AttendanceProfie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string Attendance { get; set; }

        [Required]
        public string Remarks { get; set; }

        [Required]
        public string LatLong { get; set; }

        [Required]
        public DateTime MarkDate { get; set; }

        [Required]
        public DateTime ForDate { get; set; }

    }
    public class DeafData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Cust_Name { get; set; }
        [Required]
        public string Branch { get; set; }

        [Required]
        public string Address { get; set; }


    }
    public class LearningData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Heading { get; set; }
        [Required]
        public string Link { get; set; }
        public string Address { get; set; }


    }
}