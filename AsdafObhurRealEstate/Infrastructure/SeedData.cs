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
                            ConcurrencyStamp = "d0584e-fcd7-439c-8ae1-f5734664d6f"
                        },
                        //مشرف مشاريع
                        // Project Supervisor
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[1],
                            Name = Role.ProjectSupervisor,
                            NormalizedName = Role.ProjectSupervisor.ToUpper(),
                            ConcurrencyStamp = "d0584e-fcd7-439c-8ae1-f5734666d6f"
                        },

                        //سكرتير التنفيذي
                        //Executive Secretary
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[2],
                            Name = Role.ExecutiveSecretary,
                            NormalizedName = Role.ExecutiveSecretary.ToUpper(),
                            ConcurrencyStamp = "d0584e-fcd7-439c-9ae1-f5734666d6f"
                        },

                        //شؤون موظفين
                        // Personnel
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[3],
                            Name = Role.Personnel,
                            NormalizedName = Role.Personnel.ToUpper(),
                            ConcurrencyStamp = "d0554e-fcd7-439c-8ae1-f5734666d6f"
                        },

                        //تسويق
                        //marketing
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[4],
                            Name = Role.Marketing,
                            NormalizedName = Role.Marketing.ToUpper(),
                            ConcurrencyStamp = "d0584e-fgd7-439c-8ae1-f5734666d6f"
                        },
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[5],
                            Name = Role.ProjectMonitor,
                            NormalizedName = Role.ProjectMonitor.ToUpper(),
                            ConcurrencyStamp = "d3584e-fcd7-439c-8ae1-f5734666d6f"
                        },

                        //مهندس المشاريع
                        //ProjectsEngineer
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[6],
                            Name = Role.ProjectsEngineer,
                            NormalizedName = Role.ProjectsEngineer.ToUpper(),
                            ConcurrencyStamp = "s1584e-fcd7-439c-8ae1-f5734666d6f"
                        },

                        //مالية
                        // Financial
                        new IdentityRole()
                        {
                            Id = ConstantIDs.roles[7],
                            Name = Role.Financial,
                            NormalizedName = Role.Financial.ToUpper(),
                            ConcurrencyStamp = "d0584e-fcd7-439c-8ae1-f5734236d6f"
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
                            Code = 1,
                            FirstName = "المدير",
                            LastName = "العام",
                            Email = "gm@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = new DateTime(2022,8,14),
                            CreatedBy = "Developer",
                            NormalizedEmail = "gm@gmail.com".ToUpper(),
                            UserName = "gm@gmail.com",
                            NormalizedUserName = "gm@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                        },

                        //مشرف مشاريع
                        // Project Supervisor
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[1],
                            Code = 2,
                            FirstName = "مشرف",
                            LastName = "مشاريع",
                            Email = "ps@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = "Developer",
                            NormalizedEmail = "ps@gmail.com".ToUpper(),
                            UserName = "ps@gmail.com",
                            NormalizedUserName = "ps@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            DepartmentId = ConstantIDs.department[1]
                        },

                        //سكرتير التنفيذي
                        //Executive Secretary
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[2],
                            Code = 3,
                            FirstName = "سكرتير",
                            LastName = "التنفيذي",
                            Email = "es@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = "Developer",
                            NormalizedEmail = "es@gmail.com".ToUpper(),
                            UserName = "es@gmail.com",
                            NormalizedUserName = "es@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                        },

                        //شؤون موظفين
                        // Personnel
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[3],
                            Code = 4,
                            FirstName = "شؤون",
                            LastName = "موظفين",
                            Email = "p@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = "Developer",
                            NormalizedEmail = "p@gmail.com".ToUpper(),
                            UserName = "p@gmail.com",
                            NormalizedUserName = "p@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            DepartmentId = ConstantIDs.department[4]

                        },

                        //تسويق
                        //marketing
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[4],
                            Code = 5,
                            FirstName = "تسويق",
                            LastName = "تسويق",
                            Email = "m@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = "Developer",
                            NormalizedEmail = "m@gmail.com".ToUpper(),
                            UserName = "m@gmail.com",
                            NormalizedUserName = "m@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            DepartmentId = ConstantIDs.department[3]
                        },

                        //مراقب مشاريع
                        //Project Monitor
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[5],
                            Code = 6,
                            FirstName = "مراقب",
                            LastName = "مشاريع",
                            Email = "pMonitor@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = "Developer",
                            NormalizedEmail = "pMonitor@gmail.com".ToUpper(),
                            UserName = "pMonitor@gmail.com",
                            NormalizedUserName = "pMonitor@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            DepartmentId = ConstantIDs.department[2]
                        },

                        //مهندس المشاريع
                        //projects Engineer
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[6],
                            Code = 7,
                            FirstName = "مهندس",
                            LastName = "مشاريع",
                            Email = "pe@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = "Developer",
                            NormalizedEmail = "pe@gmail.com".ToUpper(),
                            UserName = "pe@gmail.com",
                            NormalizedUserName = "pe@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            DepartmentId = ConstantIDs.department[2]
                        },
                        
                        //مالية
                        //Financial
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[7],
                            Code = 8,
                            FirstName = "المالية",
                            LastName = "مالية",
                            Email = "f@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = "Developer",
                            NormalizedEmail = "f@gmail.com".ToUpper(),
                            UserName = "f@gmail.com",
                            NormalizedUserName = "f@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
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
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "الديكور",
                            UpdatedAt = new DateTime(2022, 8, 14)
                        },
                        new Department()
                        {
                            Id = ConstantIDs.department[1],
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "العقار",
                            UpdatedAt = new DateTime(2022, 8, 14)
                        },
                        new Department()
                        {
                            Id = ConstantIDs.department[2],
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "المقاولات",
                            UpdatedAt = new DateTime(2022, 8, 14),
                        },
                        new Department()
                        {
                            Id = ConstantIDs.department[3],
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "الأعلام و التسويق",
                            UpdatedAt = new DateTime(2022, 8, 14),
                        },
                        new Department()
                        {
                            Id = ConstantIDs.department[4],
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "المالية",
                            UpdatedAt = new DateTime(2022, 8, 14),
                        });
                });
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<SeedData>();
                logger.LogError(ex.Message);
            }
        }

        public static void SeedClients(ModelBuilder builder, ILoggerFactory loggerFactory)
        {
            try
            {
                builder.Entity<Client>(entity =>
                {
                    entity.HasData(
                        new Client()
                        {
                            Id = ConstantIDs.users[0],
                            
                            BaseUserId = ConstantIDs.users[0],
                            ClientName = "Client Ahmed",
                            ClientStatus = Enums.StatusOfClient.UnderProgress,
                            Code= 1,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy= ConstantIDs.users[0],
                            DepartmentId = ConstantIDs.department[0],
                            Notes = "ملاحظات من المبرمج ",
                            PhoneNumber = "035453650",
                            
                        },

                           new Client()
                           {
                               Id = ConstantIDs.users[1],
                               BaseUserId = ConstantIDs.users[0],
                               ClientName = "Client Ahmed2",
                               ClientStatus = Enums.StatusOfClient.UnderProgress,
                               Code = 2,
                               CreatedAt = new DateTime(2022, 8, 14),
                               CreatedBy = ConstantIDs.users[0],
                               DepartmentId = ConstantIDs.department[0],
                               Notes = "2ملاحظات من المبرمج ",
                               PhoneNumber = "01122332150",
                           },

                             new Client()
                             {
                                 Id = ConstantIDs.users[2],
                                 BaseUserId = ConstantIDs.users[0],
                                 ClientName = "Client Ahmed 3 ",
                                 ClientStatus = Enums.StatusOfClient.UnderProgress,
                                 Code = 3,
                                 CreatedAt = new DateTime(2022, 8, 14),
                                 CreatedBy = ConstantIDs.users[0],
                                 DepartmentId = ConstantIDs.department[0],
                                 Notes = "2ملاحظات من المبرمج ",
                                 PhoneNumber = "24400",
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
