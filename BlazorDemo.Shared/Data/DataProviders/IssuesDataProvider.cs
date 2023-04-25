
using System.Runtime.InteropServices;

namespace BlazorDemo.Shared.Data.DataProviders
{
    [Guid("DD279962-7EC6-494E-8C8E-416C9065D64D")]
    public interface IIssuesDataProvider 
    {
        Task<IEnumerable<Issue>> GetIssuesAsync(CancellationToken ct = default);
        Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken ct = default);
        Task<IEnumerable<User>> GetUsersAsync(CancellationToken ct = default);
    }

    public class IssuesDataProvider : IIssuesDataProvider {

        static readonly IEnumerable<Project> projects = new List<Project>() {
                new Project() {ID = 2, Name = "Enterprise Accounting System", ManagerID = 2},
                new Project() {ID = 3, Name = "Small-Business Accounting System", ManagerID = 15},
                new Project() {ID = 4, Name = "Home-Office Accounting System", ManagerID = 16}
            };

        static readonly IEnumerable<User> users = new List<User>() {
                new User() {ID = 2, FirstName="Paul", LastName="Bailey" },
                new User() {ID = 3, FirstName="Brad", LastName="Barnes" },
                new User() {ID = 4, FirstName="Jerry", LastName="Campbell" },
                new User() {ID = 5, FirstName="Carl", LastName="Lucas" },
                new User() {ID = 6, FirstName="Peter", LastName="Dolan" },
                new User() {ID = 7, FirstName="Ryan", LastName="Fischer" },
                new User() {ID = 8, FirstName="Richard", LastName="Fisher" },
                new User() {ID = 9, FirstName="Tom", LastName="Hamlett" },
                new User() {ID = 10, FirstName="Mark", LastName="Hamilton" },
                new User() {ID = 11, FirstName="Steve", LastName="Lee" },
                new User() {ID = 12, FirstName="Jimmy", LastName="Lewis" },
                new User() {ID = 13, FirstName="Jeffrey", LastName="McClain" },
                new User() {ID = 14, FirstName="Andrew", LastName="Miller" },
                new User() {ID = 15, FirstName="Dave", LastName="Murrel" },
                new User() {ID = 16, FirstName="Bert", LastName="Parkins" },
                new User() {ID = 17, FirstName="Mike", LastName="Roller" },
                new User() {ID = 18, FirstName="Ray", LastName="Shipman" },
            };

        static readonly IEnumerable<Issue> issues = new List<Issue>() {
                new Issue() {Type = IssueType.Request, ProjectID = 4, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 12, CreatedDate = new DateTime(2022,07,01), OwnerID = 4, ModifiedDate = new DateTime(2022,07,10), FixedDate = new DateTime(2022,07,10), Name = "Accounting System: MasterView" },
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 3, CreatedDate = new DateTime(2021,12,04), OwnerID = 11, ModifiedDate = new DateTime(2021,12,05 ), FixedDate = new DateTime(2021,12,05), Name = "Web Edition: Data Entry Page" },
                new Issue() {Type = IssueType.Request, ProjectID = 3, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 18, CreatedDate = new DateTime(2022,07,11), OwnerID = 13, ModifiedDate = new DateTime(2022,07,23), FixedDate = new DateTime(2022,07,23), Name = "Payables Due Calculator" },
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 10, CreatedDate = new DateTime(2022,03,31), OwnerID = 9, ModifiedDate = new DateTime(2022,03,05), FixedDate = new DateTime(2022,08,09), Name = "Web Edition: Search Page" },
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.High, Status = IssueStatus.Fixed, CreatorID = 9, CreatedDate = new DateTime(2022,07,27), OwnerID = 17, ModifiedDate = new DateTime(2022,07,10), FixedDate = new DateTime(2022,07,10), Name = "Main Menu: Duplicate Items" },
                new Issue() {Type = IssueType.Request, ProjectID = 3, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 12, CreatedDate = new DateTime(2022,04,03), OwnerID = 16, ModifiedDate = new DateTime(2022,04,03), FixedDate = new DateTime(2022,08,11), Name = "Receivables Calculator" },
                new Issue() {Type = IssueType.Bug, ProjectID = 2, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 17, CreatedDate = new DateTime(2022,06,06), OwnerID = 16, ModifiedDate = new DateTime(2022,07,04), FixedDate = new DateTime(2022,07,04), Name = "Ledger: Inconsistency" },
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 3, CreatedDate = new DateTime(2022,07,04), OwnerID = 9, ModifiedDate = null, FixedDate = new DateTime(2022,08,10 ), Name = "Receivables Printing" },
                new Issue() {Type = IssueType.Request, ProjectID = 3, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 15, CreatedDate = new DateTime(2022,06,26), OwnerID = 7, ModifiedDate = new DateTime(2022,07,08), FixedDate = new DateTime(2022,08,18), Name = "Screen Redraw" },
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 15, CreatedDate = new DateTime(2021,11,05), OwnerID = 11, ModifiedDate = new DateTime(2022,01,28), FixedDate = new DateTime(2022,01,27), Name = "Email System" },
                new Issue() {Type = IssueType.Bug, ProjectID = 3, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 15, CreatedDate = new DateTime(2022,05,20), OwnerID = 13, ModifiedDate = null, FixedDate = new DateTime(2022,08,16), Name = "Adding New Vendors Fails" },
                new Issue() {Type = IssueType.Bug, ProjectID = 3, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 9, CreatedDate = new DateTime(2022,03,14), OwnerID = 11, ModifiedDate = new DateTime(2022,04,09), FixedDate = new DateTime(2022,08,10), Name = "History" },
                new Issue() {Type = IssueType.Request, ProjectID = 4, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 15, CreatedDate = new DateTime(2021,10,10), OwnerID = 16, ModifiedDate = null, FixedDate = new DateTime(2022,08,08), Name = "Main Menu: Add a File menu" },
                new Issue() {Type = IssueType.Request, ProjectID = 4, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 12, CreatedDate = new DateTime(2022,04,03), OwnerID = 13, ModifiedDate = null, FixedDate = new DateTime(2022,08,21), Name = "Currency Mask" },
                new Issue() {Type = IssueType.Request, ProjectID = 4, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 15, CreatedDate = new DateTime(2022,02,07), OwnerID = 4, ModifiedDate = null, FixedDate = new DateTime(2022,08,25), Name = "Drag & Drop" },
                new Issue() {Type = IssueType.Request, ProjectID = 4, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 3, CreatedDate = new DateTime(2022,05,15), OwnerID = 4, ModifiedDate = null, FixedDate = new DateTime(2022,08,15), Name = "Data Import" },
                new Issue() {Type = IssueType.Request, ProjectID = 4, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 10, CreatedDate = new DateTime(2022,03,13), OwnerID = 9, ModifiedDate = null, FixedDate = new DateTime(2022,08,16), Name = "Reports" },
                new Issue() {Type = IssueType.Request, ProjectID = 4, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 15, CreatedDate = new DateTime(2022,01,09), OwnerID = 17, ModifiedDate = null, FixedDate = null, Name = "Data Archiving" },
                new Issue() {Type = IssueType.Request, ProjectID = 4, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 3, CreatedDate = new DateTime(2022,02,22), OwnerID = 11, ModifiedDate = null, FixedDate = null, Name = "New Users"},
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 15, CreatedDate = new DateTime(2022,07,14), OwnerID = 17, ModifiedDate = null, FixedDate = new DateTime(2022,08,02), Name = "Email Attachments" },
                new Issue() {Type = IssueType.Request, ProjectID = 3, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 15, CreatedDate = new DateTime(2021,07,14), OwnerID = 17, ModifiedDate = new DateTime(2022-05-28), FixedDate = new DateTime(2022,09,1), Name = "Faxing" },
                new Issue() {Type = IssueType.Request, ProjectID = 3, Priority=IssuePriority.High, Status = IssueStatus.Fixed, CreatorID = 3, CreatedDate = new DateTime(2021,07,14), OwnerID = 17, ModifiedDate = new DateTime(2022-05-15), FixedDate = new DateTime(2022,08,8), Name = "Check Register" },
                new Issue() {Type = IssueType.Request, ProjectID = 3, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 18, CreatedDate = new DateTime(2021,07,14), OwnerID = 16, ModifiedDate = new DateTime(2022-04-19), FixedDate = new DateTime(2022,09,4), Name = "Vendor List" },
                new Issue() {Type = IssueType.Request, ProjectID = 3, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 15, CreatedDate = new DateTime(2021,07,14), OwnerID = 7, ModifiedDate = null, FixedDate = new DateTime(2023,06,11), Name = "Data Export" },
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 3, CreatedDate = new DateTime(2021,07,14), OwnerID = 5, ModifiedDate = new DateTime(2022-06-17), FixedDate = new DateTime(2022,08,16), Name = "Transaction Log" },
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 3, CreatedDate = new DateTime(2021,07,14), OwnerID = 5, ModifiedDate = null, FixedDate = new DateTime(2022,02,6), Name = "Transaction History" },
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 10, CreatedDate = new DateTime(2021,07,14), OwnerID = 14, ModifiedDate = new DateTime(2022-04-03), FixedDate = new DateTime(2022,08,16), Name = "Help: Phone scripts" },
                new Issue() {Type = IssueType.Request, ProjectID = 3, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 10, CreatedDate = new DateTime(2021,07,14), OwnerID = 5, ModifiedDate = null, FixedDate = new DateTime(2022,01,11), Name = "Help File Duplicates" },
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 15, CreatedDate = new DateTime(2021,07,14), OwnerID = 5, ModifiedDate = null, FixedDate = new DateTime(2022,08,13), Name = "Help File Topics" },
                new Issue() {Type = IssueType.Request, ProjectID = 3, Priority=IssuePriority.Low, Status = IssueStatus.Fixed, CreatorID = 12, CreatedDate = new DateTime(2021,07,14), OwnerID = 5, ModifiedDate = null, FixedDate = new DateTime(2022,07,15), Name = "Help File Integration" },
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 15, CreatedDate = new DateTime(2021,07,14), OwnerID = 14, ModifiedDate = null, FixedDate = new DateTime(2022,08,16), Name = "Installer" },
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 15, CreatedDate = new DateTime(2021,07,14), OwnerID = 16, ModifiedDate = null, FixedDate = new DateTime(2022,08,16), Name = "Installer" },
                new Issue() {Type = IssueType.Request, ProjectID = 3, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 10, CreatedDate = new DateTime(2021,07,14), OwnerID = 16, ModifiedDate = new DateTime(2022, 05, 01), FixedDate = new DateTime(2022,08,16), Name = "Vendor TAX IDs" },
                new Issue() {Type = IssueType.Request, ProjectID = 2, Priority=IssuePriority.Medium, Status = IssueStatus.Fixed, CreatorID = 3, CreatedDate = new DateTime(2021,07,14), OwnerID = 13, ModifiedDate = new DateTime(2022, 05, 01), FixedDate = new DateTime(2022,08,16), Name = "Vendor Name" },
            };

        public Task<IEnumerable<Issue>> GetIssuesAsync(CancellationToken ct = default) 
            => Task.FromResult(issues);
        
        public Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken ct = default) 
            => Task.FromResult(projects);
        
        public Task<IEnumerable<User>> GetUsersAsync(CancellationToken ct = default) 
            => Task.FromResult(users);
    }
}
