using HR.Entity.Entities;
using LC.Data.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Mappings.Mappings
{
    public class EmployeeInfoMap : EntityBaseMap<EmployeeInfo>
    {
        /// <summary>
        /// 初始化实体属性
        /// </summary>
        protected override void InitProperties()
        {
            base.InitProperties();

            #region Property Mappings for class EmployeeInfo

            //this.Property(x => x.OwnerCorpId)
            //    .IsOptional();

            this.Property(x => x.PersonalId)
                .IsOptional();

            this.Property(x => x.CreatedById)
                .IsOptional();

            //this.Property(x => x.AvatarId)
            //    .IsOptional();

//#if !MapComplexTypeAsSingleFile

//            this.Property(x => x.IdInfo.IdNumber)
//                .IsUnicode()
//                //.HasMaxLength(100)
//#if MapComplexTypePropertyAsCascade
//                .HasColumnName("IdInfo.IdNumber")
//#endif
//                .IsOptional();

//            this.Property(x => x.IdInfo.IdType)
//#if MapComplexTypePropertyAsCascade
//                .HasColumnName("IdInfo.IdType")
//#endif
//                .IsOptional();

//#endif

            this.Property(x => x.JoinDate)
                .IsRequired();

            this.Property(x => x.AwayDate)
                .IsOptional();

            this.Property(x => x.LatestJoinDate)
                .IsRequired();

            //this.Property(x => x.State)
            //    .IsRequired();

            this.Property(x => x.Birthday)
                .IsRequired();

            this.Property(x => x.EmployeeNo)
                //.HasMaxLength(50)
                .IsRequired();

            this.Property(x => x.ProbationEndDate)
                .IsRequired();

            this.Property(x => x.Salary)
                .IsOptional();

//#if !MapComplexTypeAsSingleFile

//            this.Property(x => x.Name.FirstName)
//                .IsUnicode()
//                //.HasMaxLength(20)
//#if MapComplexTypePropertyAsCascade
//                .HasColumnName("Name.FirstName")
//#endif
//                .IsOptional();

//            this.Property(x => x.Name.MiddleName)
//                .IsUnicode()
//                //.HasMaxLength(20)
//#if MapComplexTypePropertyAsCascade
//                .HasColumnName("Name.MiddleName")
//#endif
//                .IsOptional();

//            this.Property(x => x.Name.LastName)
//                .IsUnicode()
//                //.HasMaxLength(20)
//#if MapComplexTypePropertyAsCascade
//                .HasColumnName("Name.LastName")
//#endif
//                .IsOptional();

//            this.Property(x => x.Name.FullName)
//                .IsUnicode()
//                //.HasMaxLength(50)
//#if MapComplexTypePropertyAsCascade
//                .HasColumnName("Name.FullName")
//#endif
//                .IsRequired();

//            this.Property(x => x.Name.ShortName)
//                .IsUnicode()
//                //.HasMaxLength(20)
//#if MapComplexTypePropertyAsCascade
//                .HasColumnName("Name.ShortName")
//#endif
//                .IsOptional();

//            this.Property(x => x.Name.NameType)
//#if MapComplexTypePropertyAsCascade
//                .HasColumnName("Name.NameType")
//#endif
//                .IsRequired();

//#endif

            #endregion
        }

        /// <summary>
        /// 初始化实体关系
        /// </summary>
        protected override void InitAssociations()
        {
            base.InitAssociations();

            #region Navigation Property Mappings for class EmployeeInfo

            //this.HasOptional(x => x.HighestEducationInfo)
            //    .WithMany()
            //    .HasForeignKey(x => x.HighestEducationId)
            //    .WillCascadeOnDelete(false);

            //this.HasOptional(x => x.LastAcademy)
            //    .WithMany()
            //    .HasForeignKey(x => x.LastAcademyId)
            //    .WillCascadeOnDelete(false);

            //this.HasOptional(x => x.ContactInfo)
            //    .WithMany()
            //    .HasForeignKey(x => x.ContactInfoId)
            //    .WillCascadeOnDelete(false);

            //this.HasOptional(x => x.Department)
            //    .WithMany(x => x.Employees)
            //    .HasForeignKey(x => x.DepartmentId)
            //    .WillCascadeOnDelete(false);

            #endregion
        }
    }
}
