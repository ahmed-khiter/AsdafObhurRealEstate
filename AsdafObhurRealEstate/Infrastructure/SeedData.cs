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
                        // مراقب مشاريع 
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
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[12],
                            Code = 13,
                            FirstName = "حساب",
                            LastName = "المبرمج",
                            Email = "programmer@gmail.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            NormalizedEmail = "programmer@gmail.com".ToUpper(),
                            UserName = "programmer@gmail.com",
                            NormalizedUserName = "programmer@gmail.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "201100811024",
                            PhoneNumberConfirmed = true,
                        },
                        // General manager
                        //المدير العام
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[0],
                            Code = 1,
                            FirstName = "فؤاد",
                            LastName = "الغامدي",
                            Email = "ceo-foad@asdaf-aom.com",
                            AccountType = Enums.AccountType.GeneralManager,
                            CreatedAt = new DateTime(2022,8,14),
                            CreatedBy = ConstantIDs.users[0],
                            NormalizedEmail = "ceo-foad@asdaf-aom.com".ToUpper(),
                            UserName = "ceo-foad@asdaf-aom.com",
                            NormalizedUserName = "ceo-foad@asdaf-aom.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "966565523432",
                            PhoneNumberConfirmed = true,
                        },
                        //مشرف مشاريع
                        // Project Supervisor
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[1],
                            Code = 2,
                            FirstName = "مهند",
                            LastName = "حريري",
                            Email = "Muhannad@Asdaf-aom.com",
                            AccountType = Enums.AccountType.ProjectSupervisor,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            NormalizedEmail = "Muhannad@Asdaf-aom.com".ToUpper(),
                            UserName = "Muhannad@Asdaf-aom.com",
                            NormalizedUserName = "Muhannad@Asdaf-aom.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "966554331959",
                            PhoneNumberConfirmed = true,
                            DepartmentId = ConstantIDs.department[1]
                        },
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[8],
                            Code = 9,
                            FirstName = "صادق",
                            LastName = "الأبيض",
                            Email = "sadeq@asdaf-aom.com",
                            AccountType = Enums.AccountType.ProjectSupervisor,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            NormalizedEmail = "sadek@asdaf-aom.com".ToUpper(),
                            UserName = "sadek@asdaf-aom.com",
                            NormalizedUserName = "sadek@asdaf-aom.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "966556567826",
                            PhoneNumberConfirmed = true,
                            DepartmentId = ConstantIDs.department[1]
                        },
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[9],
                            Code = 10,
                            FirstName = "خليل",
                            LastName = "محمد",
                            Email = "Khalil@asdaf-aom.com",
                            AccountType = Enums.AccountType.ProjectSupervisor,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            NormalizedEmail = "khalil@asdaf-aom.com".ToUpper(),
                            UserName = "khalil@asdaf-aom.com",
                            NormalizedUserName = "khalil@asdaf-aom.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "966556986415",
                            PhoneNumberConfirmed = true,
                            DepartmentId = ConstantIDs.department[1]
                        },
                        //سكرتير التنفيذي
                        //Executive Secretary
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[2],
                            Code = 3,
                            FirstName = "غدير",
                            LastName = "ابو داود",
                            Email = "Ghadeer.Sec@Asdaf-aom.com",
                            AccountType = Enums.AccountType.ExecutiveSecretary,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            NormalizedEmail = "Ghadeer.Sec@Asdaf-aom.com".ToUpper(),
                            UserName = "Ghadeer.Sec@Asdaf-aom.com",
                            NormalizedUserName = "Ghadeer.Sec@Asdaf-aom.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "966544113770",
                            PhoneNumberConfirmed = true,
                        },
                        //تسويق
                        //marketing
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[4],
                            Code = 5,
                            FirstName = "تركي",
                            LastName = "العصلاني",
                            Email = "Turki@Asdaf-aom.com",
                            AccountType = Enums.AccountType.marketing,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            NormalizedEmail = "Turki@Asdaf-aom.com".ToUpper(),
                            UserName = "Turki@Asdaf-aom.com",
                            NormalizedUserName = "Turki@Asdaf-aom.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "966506278000",
                            PhoneNumberConfirmed = true,
                            DepartmentId = ConstantIDs.department[3]
                        },
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[10],
                            Code = 11,
                            FirstName = "أمل",
                            LastName = "الشريف",
                            Email = "Amal@Asdaf-aom.com",
                            AccountType = Enums.AccountType.marketing,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            NormalizedEmail = "Amal@Asdaf-aom.com".ToUpper(),
                            UserName = "Amal@Asdaf-aom.com",
                            NormalizedUserName = "Amal@Asdaf-aom.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "966505798800",
                            PhoneNumberConfirmed = true,
                            DepartmentId = ConstantIDs.department[0]
                        },
                        //مهندس المشاريع
                        //projects Engineer
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[6],
                            Code = 7,
                            FirstName = "حسام",
                            LastName = "الديني",
                            Email = "Husaam@asdaf-aom.com",
                            AccountType = Enums.AccountType.projectsEngineer,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            NormalizedEmail = "hossam@asdaf-aom.com".ToUpper(),
                            UserName = "hossam@asdaf-aom.com",
                            NormalizedUserName = "hossam@asdaf-aom.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "966547027990",
                            PhoneNumberConfirmed = true,
                            DepartmentId = ConstantIDs.department[2]
                        },
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[11],
                            Code = 12,
                            FirstName = "منصور",
                            LastName = "الأحمدي",
                            Email = "Eng.mansour@asdaf-aom.com",
                            AccountType = Enums.AccountType.projectsEngineer,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            NormalizedEmail = "Eng.mansour@asdaf-aom.com".ToUpper(),
                            UserName = "Eng.mansour@asdaf-aom.com",
                            NormalizedUserName = "Eng.mansour@asdaf-aom.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "966549810302",
                            PhoneNumberConfirmed = true,
                            DepartmentId = ConstantIDs.department[2]
                        },
                        //مالية
                        //Financial
                        new BaseUser()
                        {
                            Id = ConstantIDs.users[7],
                            Code = 8,
                            FirstName = "مروة",
                            LastName = "عبد العاطي",
                            Email = "Marwa@Asdaf-aom.com",
                            AccountType = Enums.AccountType.Financial,
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            NormalizedEmail = "Marwa@Asdaf-aom.com".ToUpper(),
                            UserName = "Marwa@Asdaf-aom.com",
                            NormalizedUserName = "Marwa@Asdaf-aom.com".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = PasswordHash("qaz2wsxedc"),
                            PhoneNumber = "966567791554",
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
                            UserId = ConstantIDs.users[12]
                        },

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
                            RoleId = ConstantIDs.roles[4],
                            UserId = ConstantIDs.users[4]
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
                        },
                        new IdentityUserRole<string>()
                        {
                            RoleId = ConstantIDs.roles[1],
                            UserId = ConstantIDs.users[8]
                        },
                        new IdentityUserRole<string>()
                        {
                            RoleId = ConstantIDs.roles[1],
                            UserId = ConstantIDs.users[9]
                        },
                        new IdentityUserRole<string>()
                        {
                            RoleId = ConstantIDs.roles[4],
                            UserId = ConstantIDs.users[10]
                        },
                        new IdentityUserRole<string>()
                        {
                            RoleId = ConstantIDs.roles[6],
                            UserId = ConstantIDs.users[11]
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
                            CreatedBy = ConstantIDs.users[0],
                            ModifiedBy = ConstantIDs.users[0],
                            Name = "الديكور",
                            UpdatedAt = new DateTime(2022, 8, 14)
                        },
                        new Department()
                        {
                            Id = ConstantIDs.department[1],
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            ModifiedBy = ConstantIDs.users[0],
                            Name = "العقار",
                            UpdatedAt = new DateTime(2022, 8, 14)
                        },
                        new Department()
                        {
                            Id = ConstantIDs.department[2],
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            ModifiedBy = ConstantIDs.users[0],
                            Name = "المقاولات",
                            UpdatedAt = new DateTime(2022, 8, 14),
                        },
                        new Department()
                        {
                            Id = ConstantIDs.department[3],
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            ModifiedBy = ConstantIDs.users[0],
                            Name = "الأعلام و التسويق",
                            UpdatedAt = new DateTime(2022, 8, 14),
                        },
                        new Department()
                        {
                            Id = ConstantIDs.department[4],
                            CreatedAt = new DateTime(2022, 8, 14),
                            CreatedBy = ConstantIDs.users[0],
                            ModifiedBy = ConstantIDs.users[0],
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

    
        public static string PasswordHash(string password)
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
