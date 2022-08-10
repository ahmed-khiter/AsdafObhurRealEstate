using AsdafObhurRealEstate.Constants;
using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace AsdafObhurRealEstate.Infrastructure
{
    public class SeedData
    {




        public static void SeedRoles(ModelBuilder builder, ILoggerFactory loggerFactory)
        {
            try
            {
                builder.Entity<IdentityRole>(entity =>
                {
                    entity.HasData(

                        // General manager
                        //المدير العام
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[0],
                            Name = Role.GeneralManager,
                            NormalizedName = Role.GeneralManager.ToUpper(),
                            ConcurrencyStamp= Guid.NewGuid().ToString()
                        },
                        //مشرف مشاريع
                        // Project Supervisor
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[1],
                            Name = Role.ProjectSupervisor,
                            NormalizedName = Role.ProjectSupervisor.ToUpper(),
                            ConcurrencyStamp = Guid.NewGuid().ToString()
                        },

                        //سكرتير التنفيذي
                        //Executive Secretary
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[2],
                            Name = Role.ExecutiveSecretary,
                            NormalizedName = Role.ExecutiveSecretary.ToUpper(),
                            ConcurrencyStamp = Guid.NewGuid().ToString()
                        },

                        //شؤون موظفين
                        // Personnel
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[3],
                            Name = Role.Personnel,
                            NormalizedName = Role.Personnel.ToUpper(),
                            ConcurrencyStamp = Guid.NewGuid().ToString()
                        },

                        //تسويق
                        //marketing
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[4],
                            Name = Role.Marketing,
                            NormalizedName = Role.Marketing.ToUpper(),
                            ConcurrencyStamp = Guid.NewGuid().ToString()
                        },
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[5],
                            Name = Role.ProjectMonitor,
                            NormalizedName = Role.ProjectMonitor.ToUpper(),
                            ConcurrencyStamp = Guid.NewGuid().ToString()
                        },

                        //مهندس المشاريع
                        //ProjectsEngineer
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[6],
                            Name = Role.ProjectsEngineer,
                            NormalizedName = Role.ProjectsEngineer.ToUpper(),
                            ConcurrencyStamp = Guid.NewGuid().ToString()
                        },

                        //مالية
                        // Financial
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[7],
                            Name = Role.Financial,
                            NormalizedName = Role.Financial.ToUpper(),
                            ConcurrencyStamp = Guid.NewGuid().ToString()
                        });
                });
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<SeedData>();
                logger.LogError(ex.Message);
            }
        }


        public static void SeedUsers(ModelBuilder builder, ILoggerFactory loggerFactory)
        {
            try
            {
                builder.Entity<BaseUser>(entity =>
                {
                    entity.HasData
                    (
                        // General manager
                        //المدير العام
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[0],
                            FirstName = "المدير",
                            LastName = "العام",
                            Email = "gm@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            NormalizedEmail = "gm@gmail.com".ToUpper(),
                            UserName = "gm@gmail.com",
                            NormalizedUserName = "gm@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            ConcurrencyStamp = Guid.NewGuid().ToString()
                        },

                        //مشرف مشاريع
                        // Project Supervisor
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[1],
                            FirstName = "مشرف",
                            LastName = "مشاريع",
                            Email = "ps@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            NormalizedEmail = "ps@gmail.com".ToUpper(),
                            UserName = "ps@gmail.com",
                            NormalizedUserName = "ps@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            ConcurrencyStamp = Guid.NewGuid().ToString(),
                            DepartmentId = ConstantIDs.department[1]
                        },

                        //سكرتير التنفيذي
                        //Executive Secretary
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[2],
                            FirstName = "سكرتير",
                            LastName = "التنفيذي",
                            Email = "es@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            NormalizedEmail = "es@gmail.com".ToUpper(),
                            UserName = "es@gmail.com",
                            NormalizedUserName = "es@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            ConcurrencyStamp = Guid.NewGuid().ToString(),
                        },

                        //شؤون موظفين
                        // Personnel
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[3],
                            FirstName = "شؤون",
                            LastName = "موظفين",
                            Email = "p@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            NormalizedEmail = "p@gmail.com".ToUpper(),
                            UserName = "p@gmail.com",
                            NormalizedUserName = "p@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            ConcurrencyStamp = Guid.NewGuid().ToString(),
                            DepartmentId = ConstantIDs.department[4]

                        },

                        //تسويق
                        //marketing
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[4],
                            FirstName = "تسويق",
                            LastName = "تسويق",
                            Email = "m@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            NormalizedEmail = "m@gmail.com".ToUpper(),
                            UserName = "m@gmail.com",
                            NormalizedUserName = "m@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            ConcurrencyStamp = Guid.NewGuid().ToString(),
                            DepartmentId = ConstantIDs.department[3]
                        },

                        //مراقب مشاريع
                        //Project Monitor
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[5],
                            FirstName = "مراقب",
                            LastName = "مشاريع",
                            Email = "pMonitor@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            NormalizedEmail = "pMonitor@gmail.com".ToUpper(),
                            UserName = "pMonitor@gmail.com",
                            NormalizedUserName = "pMonitor@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            ConcurrencyStamp = Guid.NewGuid().ToString(),
                            DepartmentId = ConstantIDs.department[2]
                        },

                        //مهندس المشاريع
                        //projects Engineer
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[6],
                            FirstName = "مهندس",
                            LastName = "مشاريع",
                            Email = "pe@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            NormalizedEmail = "pe@gmail.com".ToUpper(),
                            UserName = "pe@gmail.com",
                            NormalizedUserName = "pe@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            ConcurrencyStamp = Guid.NewGuid().ToString(),
                            DepartmentId = ConstantIDs.department[2]
                        },
                        
                        //مالية
                        //Financial
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[7],
                            FirstName = "المالية",
                            LastName = "مالية",
                            Email = "f@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            NormalizedEmail = "f@gmail.com".ToUpper(),
                            UserName = "f@gmail.com",
                            NormalizedUserName = "f@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            ConcurrencyStamp = Guid.NewGuid().ToString(),
                            DepartmentId = ConstantIDs.department[4]
                            
                        }

                    );

                });
            }
            catch(Exception ex)
            {
                var logger = loggerFactory.CreateLogger<SeedData>();
                logger.LogError(ex.Message);

            }
        }

        public static void SeedRoleToUsers(ModelBuilder builder, ILoggerFactory loggerFactory)
        {
            try
            {
                builder.Entity<IdentityUserRole<string>>(entity =>
                {
                    entity.HasData
                    (
                        new IdentityUserRole<string>()
                        {
                            RoleId = ConstantIDs.roles[0],
                            UserId = ConstantIDs.users[0]
                        },
                        new IdentityUserRole<string>()
                        {
                            RoleId = ConstantIDs.roles[1],
                            UserId = ConstantIDs.users[1]
                        },
                        new IdentityUserRole<string>()
                        {
                            RoleId = ConstantIDs.roles[2],
                            UserId = ConstantIDs.users[2]
                        },
                        new IdentityUserRole<string>()
                        {
                            RoleId = ConstantIDs.roles[3],
                            UserId = ConstantIDs.users[3]
                        },
                        new IdentityUserRole<string>()
                        {
                            RoleId = ConstantIDs.roles[4],
                            UserId = ConstantIDs.users[4]
                        },
                        new IdentityUserRole<string>()
                        {
                            RoleId = ConstantIDs.roles[5],
                            UserId = ConstantIDs.users[5]
                        },
                        new IdentityUserRole<string>()
                        {
                            RoleId = ConstantIDs.roles[6],
                            UserId = ConstantIDs.users[6]
                        },
                        new IdentityUserRole<string>()
                        {
                            RoleId = ConstantIDs.roles[7],
                            UserId = ConstantIDs.users[7]
                        }

                    );
                });
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<SeedData>();
                logger.LogError(ex.Message);
            }
        }

        public static void SeedDepartment(ModelBuilder builder, ILoggerFactory loggerFactory)
        {
            try
            {
                builder.Entity<Department>(entity =>
                {
                    entity.HasData(
                        new Department()
                        {
                            Id = ConstantIDs.department[0],
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "الديكور",
                            UpdatedAt = DateTime.Now
                        },
                        new Department()
                        {
                            Id = ConstantIDs.department[1],
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "العقار",
                            UpdatedAt = DateTime.Now,
                        },
                        new Department()
                        {
                            Id = ConstantIDs.department[2],
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "المقاولات",
                            UpdatedAt = DateTime.Now,
                        },
                        new Department()
                        {
                            Id = ConstantIDs.department[3],
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "الأعلام و التسويق",
                            UpdatedAt = DateTime.Now,
                        },
                        new Department()
                        {
                            Id = ConstantIDs.department[4],
                            CreatedAt = DateTime.Now,
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "المالية",
                            UpdatedAt = DateTime.Now,
                        });
                });
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<SeedData>();
                logger.LogError(ex.Message);
            }
        }
        private static string PasswordHash(string password)
        {

            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException(password);
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);

            return Convert.ToBase64String(dst);
        }
    }
}
