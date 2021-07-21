using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CourseTeachCook.Models
{
    public partial class CourseTeachCookContext : DbContext
    {
        public CourseTeachCookContext()
        {
        }

        public CourseTeachCookContext(DbContextOptions<CourseTeachCookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contactsinformation> Contactsinformations { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Imagelogo> Imagelogos { get; set; }
        public virtual DbSet<Imagescourse> Imagescourses { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Newsdetail> Newsdetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderdetail> Orderdetails { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user id=DuocVanLe;password=Donationminimum100$;port=3306;database=CourseTeachCook;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.HasIndex(e => e.Email, "email")
                    .IsUnique();

                entity.HasIndex(e => e.PhoneNumber, "phoneNumber")
                    .IsUnique();

                entity.Property(e => e.AdminId).HasColumnName("adminID");

                entity.Property(e => e.AdminName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("adminName");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("image");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("phoneNumber");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("banks");

                entity.HasIndex(e => e.AccountNumber, "accountNumber")
                    .IsUnique();

                entity.Property(e => e.BankId).HasColumnName("bankID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("accountNumber");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("bankName");

                entity.Property(e => e.NameOwner)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nameOwner");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("categoryName");
            });

            modelBuilder.Entity<Contactsinformation>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PRIMARY");

                entity.ToTable("contactsInformation");

                entity.HasIndex(e => e.Email, "email")
                    .IsUnique();

                entity.HasIndex(e => e.PhoneNumber, "phoneNumber")
                    .IsUnique();

                entity.Property(e => e.ContactId).HasColumnName("contactID");

                entity.Property(e => e.Description1)
                    .HasMaxLength(150)
                    .HasColumnName("description1");

                entity.Property(e => e.Description2)
                    .HasMaxLength(150)
                    .HasColumnName("description2");

                entity.Property(e => e.Description3)
                    .HasMaxLength(150)
                    .HasColumnName("description3");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("image");

                entity.Property(e => e.JobPosition)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("jobPosition");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("phoneNumber");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("courses");

                entity.HasIndex(e => e.CategoryId, "categoryID");

                entity.Property(e => e.CourseId).HasColumnName("courseID");

                entity.Property(e => e.AddressLearn)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("addressLearn");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.CourseDescription)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("courseDescription");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("courseName");

                entity.Property(e => e.CoursePrice).HasColumnName("coursePrice");

                entity.Property(e => e.CourseRates).HasColumnName("courseRates");

                entity.Property(e => e.DateOfOpening)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("dateOfOpening");

                entity.Property(e => e.FeatureImage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("featureImage");

                entity.Property(e => e.MaterialPrice).HasColumnName("materialPrice");
                entity.Property(e => e.NumberOfSession).HasColumnName("numberOfSessions");
                entity.Property(e => e.NumberOfDishs).HasColumnName("numberOfDishs");
                entity.Property(e => e.NumberOfHours).HasColumnName("numberOfHours");

                entity.Property(e => e.NumberOfStudent)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("numberOfStudent");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Views).HasColumnName("views");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("courses_ibfk_1");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.HasIndex(e => e.Email, "email")
                    .IsUnique();

                entity.HasIndex(e => e.PhoneNumber, "phoneNumber")
                    .IsUnique();

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("address");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("customerName");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("image");

                entity.Property(e => e.NumberOfPurchases).HasColumnName("numberOfPurchases");
                //entity.Property(e => e.LastLoggedTime).HasColumnName("LastLoggedTime");
                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.TimeRegister).HasColumnName("timeRegister");
            });

            modelBuilder.Entity<Imagelogo>(entity =>
            {
                entity.HasKey(e => e.ImageId)
                    .HasName("PRIMARY");

                entity.ToTable("imageLogo");

                entity.Property(e => e.ImageId).HasColumnName("imageID");

                entity.Property(e => e.ImageSource)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("imageSource");
            });

            modelBuilder.Entity<Imagescourse>(entity =>
            {
                entity.HasKey(e => e.ImageId)
                    .HasName("PRIMARY");

                entity.ToTable("imagesCourse");

                entity.HasIndex(e => e.CourseId, "courseID");

                entity.Property(e => e.ImageId).HasColumnName("imageID");

                entity.Property(e => e.CourseId).HasColumnName("courseID");

                entity.Property(e => e.ImageSource)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("imageSource");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Imagescourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imagescourse_ibfk_1");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("news");

                entity.Property(e => e.NewsId).HasColumnName("newsID");

                entity.Property(e => e.FeatureImage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("featureImage");

                entity.Property(e => e.NewsDate).HasColumnName("newsDate");

                entity.Property(e => e.NewsDescription)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("newsDescription");

                entity.Property(e => e.NewsTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("newsTitle");
            });

            modelBuilder.Entity<Newsdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("newsdetails");

                entity.Property(e => e.NewsDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("newsDescription");

                entity.Property(e => e.NewsId).HasColumnName("newsID");

                entity.Property(e => e.NewsImage)
                    .HasMaxLength(200)
                    .HasColumnName("newsImage");

                entity.Property(e => e.NewsTitle)
                    .HasMaxLength(200)
                    .HasColumnName("newsTitle");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.HasIndex(e => e.CustomerId, "customerID");

                entity.HasIndex(e => e.StaffId, "staffID");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.OrderDate).HasColumnName("orderDate");

                entity.Property(e => e.Canceler).HasColumnName("canceler");

                entity.Property(e => e.ReasonCancel).HasColumnName("reasonCancel");

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("orderStatus")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StaffId).HasColumnName("staffID");
                entity.Property(e => e.RequireInformation).HasColumnName("requireInformation");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orders_ibfk_2");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orders_ibfk_1");
            });

            modelBuilder.Entity<Orderdetail>(entity =>
            {
                entity.HasIndex(e => e.Id, "id");

                entity.ToTable("orderDetails");

                entity.HasIndex(e => e.CourseId, "courseID");

                entity.HasIndex(e => e.OrderId, "orderID");

                entity.Property(e => e.CourseId).HasColumnName("courseID");

                entity.Property(e => e.CoursePrice).HasColumnName("coursePrice");

                entity.Property(e => e.MaterialPrice).HasColumnName("materialPrice");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Course)
                    .WithMany()
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderdetails_ibfk_2");

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderdetails_ibfk_1");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("staffs");

                entity.HasIndex(e => e.Email, "email")
                    .IsUnique();

                entity.HasIndex(e => e.PhoneNumber, "phoneNumber")
                    .IsUnique();

                entity.Property(e => e.StaffId).HasColumnName("staffID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("image");

                entity.Property(e => e.JobPosition)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("jobPosition");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.StaffName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("staffName");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("teachers");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.TeacherDescription)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("teacherDescription");

                entity.Property(e => e.TeacherImage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("teacherImage");

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("teacherName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
