﻿// <auto-generated />
using System;
using GraduationProjectAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraduationProjectAPI.Migrations
{
    [DbContext(typeof(GraduationProjectDbContext))]
    [Migration("20230811121832_addPhotoGame")]
    partial class addPhotoGame
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GraduationProjectAPI.Model.Accessibility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccessibilityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accessibilities");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("CorrectAnswer")
                        .HasColumnType("bit");

                    b.Property<int?>("IdTest")
                        .HasColumnType("int");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.Property<string>("answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookPrice")
                        .HasColumnType("int");

                    b.Property<int?>("BookTypeId")
                        .HasColumnType("int");

                    b.Property<int>("IdBookType")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<byte[]>("bookImage")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookTypeId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.BookLibrary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("IdBook")
                        .HasColumnType("int");

                    b.Property<int>("IdLibrary")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LibraryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("LibraryId");

                    b.ToTable("BookLibraries");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.BookType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("bookType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.BookWriter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("IdBook")
                        .HasColumnType("int");

                    b.Property<int>("IdWriter")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("WriterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("WriterId");

                    b.ToTable("BookWriters");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Buybook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BookLibraryId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("IdBookLibrary")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookLibraryId");

                    b.HasIndex("UserId");

                    b.ToTable("Buybooks");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdPost")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Complaint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("complaint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("typeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Follow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("followId")
                        .HasColumnType("int");

                    b.Property<int?>("followedId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("followId");

                    b.HasIndex("followedId");

                    b.ToTable("Follows");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GameLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.GameUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("IdGame")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("userLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("GameUsers");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ContentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdContent")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("groupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("libraryAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("libraryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Libraries");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ContentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int?>("IdContent")
                        .HasColumnType("int");

                    b.Property<int?>("IdGroup")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("dateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Reference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ContentId")
                        .HasColumnType("int");

                    b.Property<int>("IdAdmin")
                        .HasColumnType("int");

                    b.Property<int>("IdContent")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("dateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("referenceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.ToTable("References");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ContentId")
                        .HasColumnType("int");

                    b.Property<int>("IdAdmin")
                        .HasColumnType("int");

                    b.Property<int>("IdContent")
                        .HasColumnType("int");

                    b.Property<string>("test")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Paypal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Study")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.UserAccessibility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AccessibilityId")
                        .HasColumnType("int");

                    b.Property<string>("AdminOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int?>("IdAccessibility")
                        .HasColumnType("int");

                    b.Property<int?>("IdGroup")
                        .HasColumnType("int");

                    b.Property<int?>("IdLibrary")
                        .HasColumnType("int");

                    b.Property<int?>("IdReference")
                        .HasColumnType("int");

                    b.Property<int?>("IdTest")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<int?>("LibraryId")
                        .HasColumnType("int");

                    b.Property<int?>("ReferenceId")
                        .HasColumnType("int");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccessibilityId");

                    b.HasIndex("GroupId");

                    b.HasIndex("LibraryId");

                    b.HasIndex("ReferenceId");

                    b.HasIndex("TestId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAccessibilities");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int?>("IdGroup")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.UserPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdPost")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<bool>("Interaction")
                        .HasColumnType("bit");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPosts");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.UserReference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdReference")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int?>("ReferenceId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReferenceId");

                    b.HasIndex("UserId");

                    b.ToTable("UserReferences");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Writer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("writerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Answer", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Test", "Test")
                        .WithMany("Answer")
                        .HasForeignKey("TestId");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Book", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.BookType", "BookType")
                        .WithMany("Book")
                        .HasForeignKey("BookTypeId");

                    b.Navigation("BookType");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.BookLibrary", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Book", "Book")
                        .WithMany("BookLibrary")
                        .HasForeignKey("BookId");

                    b.HasOne("GraduationProjectAPI.Model.Library", "Library")
                        .WithMany("BookLibrary")
                        .HasForeignKey("LibraryId");

                    b.Navigation("Book");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.BookWriter", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Book", "Book")
                        .WithMany("BookWriter")
                        .HasForeignKey("BookId");

                    b.HasOne("GraduationProjectAPI.Model.Writer", "Writer")
                        .WithMany("BookWriter")
                        .HasForeignKey("WriterId");

                    b.Navigation("Book");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Buybook", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.BookLibrary", "BookLibrary")
                        .WithMany("Buybook")
                        .HasForeignKey("BookLibraryId");

                    b.HasOne("GraduationProjectAPI.Model.User", "User")
                        .WithMany("Buybook")
                        .HasForeignKey("UserId");

                    b.Navigation("BookLibrary");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Comments", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Post", "Post")
                        .WithMany("Comment")
                        .HasForeignKey("PostId");

                    b.HasOne("GraduationProjectAPI.Model.User", "User")
                        .WithMany("Comment")
                        .HasForeignKey("UserId");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Complaint", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.User", "User")
                        .WithMany("Complaint")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Follow", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.User", "follow")
                        .WithMany("follow")
                        .HasForeignKey("followId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("GraduationProjectAPI.Model.User", "followed")
                        .WithMany("followed")
                        .HasForeignKey("followedId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("follow");

                    b.Navigation("followed");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.GameUser", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Game", "Game")
                        .WithMany("GameUser")
                        .HasForeignKey("GameId");

                    b.HasOne("GraduationProjectAPI.Model.User", "User")
                        .WithMany("GameUser")
                        .HasForeignKey("UserId");

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Group", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Content", "Content")
                        .WithMany("Group")
                        .HasForeignKey("ContentId");

                    b.Navigation("Content");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Post", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Content", "Content")
                        .WithMany("Post")
                        .HasForeignKey("ContentId");

                    b.HasOne("GraduationProjectAPI.Model.Group", "Group")
                        .WithMany("Post")
                        .HasForeignKey("GroupId");

                    b.HasOne("GraduationProjectAPI.Model.User", "User")
                        .WithMany("Post")
                        .HasForeignKey("UserId");

                    b.Navigation("Content");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Reference", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Content", "Content")
                        .WithMany("Reference")
                        .HasForeignKey("ContentId");

                    b.Navigation("Content");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Test", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Content", "Content")
                        .WithMany("Test")
                        .HasForeignKey("ContentId");

                    b.Navigation("Content");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.UserAccessibility", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Accessibility", "Accessibility")
                        .WithMany("UserAccessibility")
                        .HasForeignKey("AccessibilityId");

                    b.HasOne("GraduationProjectAPI.Model.Group", "Group")
                        .WithMany("UserAccessibility")
                        .HasForeignKey("GroupId");

                    b.HasOne("GraduationProjectAPI.Model.Library", "Library")
                        .WithMany("UserAccessibility")
                        .HasForeignKey("LibraryId");

                    b.HasOne("GraduationProjectAPI.Model.Reference", "Reference")
                        .WithMany("UserAccessibility")
                        .HasForeignKey("ReferenceId");

                    b.HasOne("GraduationProjectAPI.Model.Test", "Test")
                        .WithMany("UserAccessibility")
                        .HasForeignKey("TestId");

                    b.HasOne("GraduationProjectAPI.Model.User", "User")
                        .WithMany("UserAccessibility")
                        .HasForeignKey("UserId");

                    b.Navigation("Accessibility");

                    b.Navigation("Group");

                    b.Navigation("Library");

                    b.Navigation("Reference");

                    b.Navigation("Test");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.UserGroup", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Group", "Group")
                        .WithMany("UserGroup")
                        .HasForeignKey("GroupId");

                    b.HasOne("GraduationProjectAPI.Model.Post", null)
                        .WithMany("UserGroup")
                        .HasForeignKey("PostId");

                    b.HasOne("GraduationProjectAPI.Model.User", "User")
                        .WithMany("UserGroup")
                        .HasForeignKey("UserId");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.UserPost", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId");

                    b.HasOne("GraduationProjectAPI.Model.User", "User")
                        .WithMany("UserPost")
                        .HasForeignKey("UserId");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.UserReference", b =>
                {
                    b.HasOne("GraduationProjectAPI.Model.Reference", "Reference")
                        .WithMany("UserReference")
                        .HasForeignKey("ReferenceId");

                    b.HasOne("GraduationProjectAPI.Model.User", "User")
                        .WithMany("UserReference")
                        .HasForeignKey("UserId");

                    b.Navigation("Reference");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Accessibility", b =>
                {
                    b.Navigation("UserAccessibility");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Book", b =>
                {
                    b.Navigation("BookLibrary");

                    b.Navigation("BookWriter");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.BookLibrary", b =>
                {
                    b.Navigation("Buybook");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.BookType", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Content", b =>
                {
                    b.Navigation("Group");

                    b.Navigation("Post");

                    b.Navigation("Reference");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Game", b =>
                {
                    b.Navigation("GameUser");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Group", b =>
                {
                    b.Navigation("Post");

                    b.Navigation("UserAccessibility");

                    b.Navigation("UserGroup");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Library", b =>
                {
                    b.Navigation("BookLibrary");

                    b.Navigation("UserAccessibility");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Post", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("UserGroup");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Reference", b =>
                {
                    b.Navigation("UserAccessibility");

                    b.Navigation("UserReference");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Test", b =>
                {
                    b.Navigation("Answer");

                    b.Navigation("UserAccessibility");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.User", b =>
                {
                    b.Navigation("Buybook");

                    b.Navigation("Comment");

                    b.Navigation("Complaint");

                    b.Navigation("GameUser");

                    b.Navigation("Post");

                    b.Navigation("UserAccessibility");

                    b.Navigation("UserGroup");

                    b.Navigation("UserPost");

                    b.Navigation("UserReference");

                    b.Navigation("follow");

                    b.Navigation("followed");
                });

            modelBuilder.Entity("GraduationProjectAPI.Model.Writer", b =>
                {
                    b.Navigation("BookWriter");
                });
#pragma warning restore 612, 618
        }
    }
}
