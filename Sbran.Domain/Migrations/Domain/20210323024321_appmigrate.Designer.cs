﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Sbran.Domain.Data.Adapters;

namespace Sbran.Domain.Migrations.Domain
{
    [DbContext(typeof(DomainContext))]
    [Migration("20210323024321_appmigrate")]
    partial class appmigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Sbran.Domain.Entities.Alien", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("AlienUid");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uuid")
                        .HasColumnName("ContactUid");

                    b.Property<Guid?>("OrganizationId")
                        .HasColumnType("uuid")
                        .HasColumnName("OrganizationUid");

                    b.Property<Guid?>("PassportId")
                        .HasColumnType("uuid")
                        .HasColumnName("PassportUid");

                    b.Property<string>("Position")
                        .HasColumnType("text")
                        .HasColumnName("Position");

                    b.Property<Guid?>("StateRegistrationId")
                        .HasColumnType("uuid")
                        .HasColumnName("StateRegistrationUid");

                    b.Property<string>("StayAddress")
                        .HasColumnType("text")
                        .HasColumnName("StayAddress");

                    b.Property<string>("WorkAddress")
                        .HasColumnType("text")
                        .HasColumnName("WorkAddress");

                    b.Property<string>("WorkPlace")
                        .HasColumnType("text")
                        .HasColumnName("WorkPlace");

                    b.HasKey("Id");

                    b.HasIndex("ContactId")
                        .IsUnique();

                    b.HasIndex("OrganizationId")
                        .IsUnique();

                    b.HasIndex("PassportId")
                        .IsUnique();

                    b.HasIndex("StateRegistrationId")
                        .IsUnique();

                    b.ToTable("Aliens", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Chat.ChatMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("MessagesUid");

                    b.Property<Guid>("ChatRoomId")
                        .HasColumnType("uuid")
                        .HasColumnName("ChatRoomUid");

                    b.Property<DateTimeOffset>("DateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DateTime");

                    b.Property<string>("Message")
                        .HasColumnType("text")
                        .HasColumnName("Message");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("UserUid");

                    b.HasKey("Id");

                    b.HasIndex("ChatRoomId");

                    b.ToTable("ChatMessages", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Chat.ChatMessageFile", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("ChatMessageFileUid");

                    b.Property<Guid>("ChatMessageId")
                        .HasColumnType("uuid")
                        .HasColumnName("ChatMessageUid");

                    b.Property<byte[]>("FileBinary")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("File");

                    b.Property<string>("fileName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("FileName");

                    b.HasKey("Id");

                    b.HasIndex("ChatMessageId");

                    b.ToTable("ChatMessageFiles", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Chat.ChatRoom", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("ChatRoomUid");

                    b.HasKey("Id");

                    b.ToTable("ChatRooms", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Chat.ChatRoomList", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("ChatRoomListUid");

                    b.Property<Guid>("ChatRoomId")
                        .HasColumnType("uuid")
                        .HasColumnName("ChatRoomUid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("UserUid");

                    b.HasKey("Id");

                    b.HasIndex("ChatRoomId");

                    b.ToTable("ChatRoomLists", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.ConsularOffice", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("CityOfLocation")
                        .HasColumnType("text")
                        .HasColumnName("CityOfLocation");

                    b.Property<string>("CountryOfLocation")
                        .HasColumnType("text")
                        .HasColumnName("CountryOfLocation");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid")
                        .HasColumnName("EmployeeUid");

                    b.Property<Guid?>("EmployeeId1")
                        .HasColumnType("uuid");

                    b.Property<string>("NameOfTheConsularPost")
                        .HasColumnType("text")
                        .HasColumnName("NameOfTheConsularPost");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmployeeId1");

                    b.ToTable("ConsularOffices", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("HomePhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("HomePhoneNumber");

                    b.Property<string>("MobilePhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("MobilePhoneNumber");

                    b.Property<string>("Postcode")
                        .HasColumnType("text")
                        .HasColumnName("Postcode");

                    b.Property<string>("WorkPhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("WorkPhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Contacts", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Departure", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("BasicOfDeparture")
                        .HasColumnType("text")
                        .HasColumnName("BasicOfDeparture");

                    b.Property<string>("CityOfBusiness")
                        .HasColumnType("text")
                        .HasColumnName("CityOfBusiness");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DateEnd");

                    b.Property<DateTime?>("DateStart")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DateStart");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid")
                        .HasColumnName("EmployeeUid");

                    b.Property<Guid?>("EmployeeId1")
                        .HasColumnType("uuid");

                    b.Property<string>("HostOrganization")
                        .HasColumnType("text")
                        .HasColumnName("HostOrganization");

                    b.Property<string>("JustificationOfTheBusiness")
                        .HasColumnType("text")
                        .HasColumnName("JustificationOfTheBusiness");

                    b.Property<string>("PlaceOfResidence")
                        .HasColumnType("text")
                        .HasColumnName("PlaceOfResidence");

                    b.Property<string>("PurposeOfTheTrip")
                        .HasColumnType("text")
                        .HasColumnName("PurposeOfTheTrip");

                    b.Property<string>("SendingCountry")
                        .HasColumnType("text")
                        .HasColumnName("SendingCountry");

                    b.Property<string>("SourceOfFinancing")
                        .HasColumnType("text")
                        .HasColumnName("SourceOfFinancing");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmployeeId1");

                    b.ToTable("Departures", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("Content");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreatedDate");

                    b.Property<int>("DocumentType")
                        .HasColumnType("integer")
                        .HasColumnName("DocumentType");

                    b.Property<Guid>("InvitationId")
                        .HasColumnType("uuid")
                        .HasColumnName("InvitationUid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("InvitationId");

                    b.ToTable("Documents", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("AcademicDegree")
                        .HasColumnType("text")
                        .HasColumnName("AcademicDegree");

                    b.Property<string>("AcademicRank")
                        .HasColumnType("text")
                        .HasColumnName("AcademicRank");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uuid")
                        .HasColumnName("ContactUid");

                    b.Property<string>("Education")
                        .HasColumnType("text")
                        .HasColumnName("Education");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("uuid")
                        .HasColumnName("ManagerUid");

                    b.Property<Guid?>("OrganizationId")
                        .HasColumnType("uuid")
                        .HasColumnName("OrganizationUid");

                    b.Property<Guid?>("PassportId")
                        .HasColumnType("uuid")
                        .HasColumnName("PassportUid");

                    b.Property<string>("Position")
                        .HasColumnType("text")
                        .HasColumnName("Position");

                    b.Property<Guid?>("StateRegistrationId")
                        .HasColumnType("uuid")
                        .HasColumnName("StateRegistrationUid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("UserUid");

                    b.Property<string>("WorkPlace")
                        .HasColumnType("text")
                        .HasColumnName("WorkPlace");

                    b.HasKey("Id");

                    b.HasIndex("ContactId")
                        .IsUnique();

                    b.HasIndex("ManagerId");

                    b.HasIndex("OrganizationId")
                        .IsUnique();

                    b.HasIndex("PassportId")
                        .IsUnique();

                    b.HasIndex("StateRegistrationId")
                        .IsUnique();

                    b.ToTable("Employees", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.ForeignParticipant", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<Guid?>("InvitationId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PassportId")
                        .HasColumnType("uuid")
                        .HasColumnName("PassportUid");

                    b.HasKey("Id");

                    b.HasIndex("InvitationId");

                    b.HasIndex("PassportId")
                        .IsUnique();

                    b.ToTable("ForeignParticipants", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.InternationalAgreement", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<DateTime?>("DateOfEntry")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DateOfEntry");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid")
                        .HasColumnName("EmployeeUid");

                    b.Property<string>("PlaceOfSigning")
                        .HasColumnType("text")
                        .HasColumnName("PlaceOfSigning");

                    b.Property<string>("TextOfTheAgreement")
                        .HasColumnType("text")
                        .HasColumnName("TextOfTheAgreement");

                    b.Property<string>("TheFirstPartyToTheAgreement")
                        .HasColumnType("text")
                        .HasColumnName("TheFirstPartyToTheAgreement");

                    b.Property<string>("TheNameOfTheAgreement")
                        .HasColumnType("text")
                        .HasColumnName("TheNameOfTheAgreement");

                    b.Property<string>("TheSecondPartyToTheAgreement")
                        .HasColumnType("text")
                        .HasColumnName("TheSecondPartyToTheAgreement");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("InternationalAgreements", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Invitation", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<Guid>("AlienId")
                        .HasColumnType("uuid")
                        .HasColumnName("AlienUid");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedDate");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid")
                        .HasColumnName("EmployeeUid");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<DateTimeOffset>("UpdateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdateDate");

                    b.Property<Guid?>("VisitDetailId")
                        .HasColumnType("uuid")
                        .HasColumnName("VisitDetailUid");

                    b.HasKey("Id");

                    b.HasIndex("AlienId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("VisitDetailId")
                        .IsUnique();

                    b.ToTable("Invitations", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Membership", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<DateTime?>("DateOfEntry")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DateOfEntry");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid")
                        .HasColumnName("EmployeeUid");

                    b.Property<Guid?>("EmployeeId1")
                        .HasColumnType("uuid");

                    b.Property<string>("NameOfCompany")
                        .HasColumnType("text")
                        .HasColumnName("NameOfCompany");

                    b.Property<string>("SiteOfTheOrganization")
                        .HasColumnType("text")
                        .HasColumnName("SiteOfTheOrganization");

                    b.Property<string>("StatusInTheOrganization")
                        .HasColumnType("text")
                        .HasColumnName("StatusInTheOrganization");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmployeeId1");

                    b.ToTable("Memberships", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("LegalAddress")
                        .HasColumnType("text")
                        .HasColumnName("LegalAddress");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<string>("ScientificActivity")
                        .HasColumnType("text")
                        .HasColumnName("ScientificActivity");

                    b.Property<string>("ShortName")
                        .HasColumnType("text")
                        .HasColumnName("ShortName");

                    b.Property<Guid?>("StateRegistrationId")
                        .HasColumnType("uuid")
                        .HasColumnName("StateRegistrationUid");

                    b.HasKey("Id");

                    b.HasIndex("StateRegistrationId")
                        .IsUnique();

                    b.ToTable("Organizations", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Passport", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("BirthCountry")
                        .HasColumnType("text")
                        .HasColumnName("BirthCountry");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("BirthDate");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("text")
                        .HasColumnName("BirthPlace");

                    b.Property<string>("Citizenship")
                        .HasColumnType("text")
                        .HasColumnName("Citizenship");

                    b.Property<string>("DepartmentCode")
                        .HasColumnType("text")
                        .HasColumnName("DepartmentCode");

                    b.Property<int?>("Gender")
                        .HasColumnType("integer")
                        .HasColumnName("Gender");

                    b.Property<string>("IdentityDocument")
                        .HasColumnType("text")
                        .HasColumnName("IdentityDocument");

                    b.Property<DateTime?>("IssueDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("IssueDate");

                    b.Property<string>("IssuePlace")
                        .HasColumnType("text")
                        .HasColumnName("IssuePlace");

                    b.Property<string>("NameEng")
                        .HasColumnType("text")
                        .HasColumnName("NameEng");

                    b.Property<string>("NameRus")
                        .HasColumnType("text")
                        .HasColumnName("NameRus");

                    b.Property<string>("PatronymicNameEng")
                        .HasColumnType("text")
                        .HasColumnName("PatronymicNameEng");

                    b.Property<string>("PatronymicNameRus")
                        .HasColumnType("text")
                        .HasColumnName("PatronymicNameRus");

                    b.Property<string>("Residence")
                        .HasColumnType("text")
                        .HasColumnName("Residence");

                    b.Property<string>("ResidenceCountry")
                        .HasColumnType("text")
                        .HasColumnName("ResidenceCountry");

                    b.Property<string>("ResidenceRegion")
                        .HasColumnType("text")
                        .HasColumnName("ResidenceRegion");

                    b.Property<string>("SurnameEng")
                        .HasColumnType("text")
                        .HasColumnName("SurnameEng");

                    b.Property<string>("SurnameRus")
                        .HasColumnType("text")
                        .HasColumnName("SurnameRus");

                    b.HasKey("Id");

                    b.ToTable("Passports", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Publication", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("Abstract")
                        .HasColumnType("text")
                        .HasColumnName("Abstract");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid")
                        .HasColumnName("EmployeeUid");

                    b.Property<Guid?>("EmployeeId1")
                        .HasColumnType("uuid");

                    b.Property<string>("Keywords")
                        .HasColumnType("text")
                        .HasColumnName("Keywords");

                    b.Property<string>("Literature")
                        .HasColumnType("text")
                        .HasColumnName("Literature");

                    b.Property<string>("MainTextOfTheArticle")
                        .HasColumnType("text")
                        .HasColumnName("MainTextOfTheArticle");

                    b.Property<string>("ScientificAdvisor")
                        .HasColumnType("text")
                        .HasColumnName("ScientificAdvisor");

                    b.Property<string>("TitleOfTheArticle")
                        .HasColumnType("text")
                        .HasColumnName("TitleOfTheArticle");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmployeeId1");

                    b.ToTable("Publications", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.ScientificInterests", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid")
                        .HasColumnName("EmployeeUid");

                    b.Property<Guid?>("EmployeeId1")
                        .HasColumnType("uuid");

                    b.Property<string>("NameOfScientificInterests")
                        .HasColumnType("text")
                        .HasColumnName("ScientificAdvisor");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmployeeId1");

                    b.ToTable("ScientificInterestss", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.StateRegistration", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("Inn")
                        .HasColumnType("text")
                        .HasColumnName("INN");

                    b.Property<string>("Ogrnip")
                        .HasColumnType("text")
                        .HasColumnName("OGRNIP");

                    b.HasKey("Id");

                    b.ToTable("StateRegistrations", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.VisitDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<DateTime?>("ArrivalDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("ArrivalDate");

                    b.Property<string>("Country")
                        .HasColumnType("text")
                        .HasColumnName("Country");

                    b.Property<DateTime?>("DepartureDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DepartureDate");

                    b.Property<int?>("FinancialCondition")
                        .HasColumnType("integer")
                        .HasColumnName("FinancialCondition");

                    b.Property<string>("Goal")
                        .HasColumnType("text")
                        .HasColumnName("Goal");

                    b.Property<long?>("PeriodDays")
                        .HasColumnType("bigint")
                        .HasColumnName("PeriodDays");

                    b.Property<string>("TypeReception")
                        .HasColumnType("text")
                        .HasColumnName("TypeReception");

                    b.Property<string>("VisaCity")
                        .HasColumnType("text")
                        .HasColumnName("VisaCity");

                    b.Property<string>("VisaCountry")
                        .HasColumnType("text")
                        .HasColumnName("VisaCountry");

                    b.Property<int?>("VisaMultiplicity")
                        .HasColumnType("integer")
                        .HasColumnName("VisaMultiplicity");

                    b.Property<string>("VisaType")
                        .HasColumnType("text")
                        .HasColumnName("VisaType");

                    b.Property<string>("VisitingPoints")
                        .HasColumnType("text")
                        .HasColumnName("VisitingPoints");

                    b.HasKey("Id");

                    b.ToTable("VisitDetails", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Alien", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Contact", "Contact")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Alien", "ContactId");

                    b.HasOne("Sbran.Domain.Entities.Organization", "Organization")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Alien", "OrganizationId");

                    b.HasOne("Sbran.Domain.Entities.Passport", "Passport")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Alien", "PassportId");

                    b.HasOne("Sbran.Domain.Entities.StateRegistration", "StateRegistration")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Alien", "StateRegistrationId");

                    b.Navigation("Contact");

                    b.Navigation("Organization");

                    b.Navigation("Passport");

                    b.Navigation("StateRegistration");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Chat.ChatMessage", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Chat.ChatRoom", "ChatRoom")
                        .WithMany()
                        .HasForeignKey("ChatRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatRoom");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Chat.ChatMessageFile", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Chat.ChatMessage", "ChatMessage")
                        .WithMany()
                        .HasForeignKey("ChatMessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatMessage");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Chat.ChatRoomList", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Chat.ChatRoom", "ChatRoom")
                        .WithMany()
                        .HasForeignKey("ChatRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatRoom");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.ConsularOffice", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sbran.Domain.Entities.Employee", null)
                        .WithMany("ConsularOffices")
                        .HasForeignKey("EmployeeId1");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Departure", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sbran.Domain.Entities.Employee", null)
                        .WithMany("Departures")
                        .HasForeignKey("EmployeeId1");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Document", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Invitation", "Invitation")
                        .WithMany()
                        .HasForeignKey("InvitationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invitation");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Employee", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Contact", "Contact")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Employee", "ContactId");

                    b.HasOne("Sbran.Domain.Entities.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");

                    b.HasOne("Sbran.Domain.Entities.Organization", "Organization")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Employee", "OrganizationId");

                    b.HasOne("Sbran.Domain.Entities.Passport", "Passport")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Employee", "PassportId");

                    b.HasOne("Sbran.Domain.Entities.StateRegistration", "StateRegistration")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Employee", "StateRegistrationId");

                    b.Navigation("Contact");

                    b.Navigation("Manager");

                    b.Navigation("Organization");

                    b.Navigation("Passport");

                    b.Navigation("StateRegistration");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.ForeignParticipant", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Invitation", null)
                        .WithMany("ForeignParticipants")
                        .HasForeignKey("InvitationId");

                    b.HasOne("Sbran.Domain.Entities.Passport", "Passport")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.ForeignParticipant", "PassportId");

                    b.Navigation("Passport");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.InternationalAgreement", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Invitation", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Alien", "Alien")
                        .WithMany()
                        .HasForeignKey("AlienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sbran.Domain.Entities.Employee", "Employee")
                        .WithMany("Invitations")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sbran.Domain.Entities.VisitDetail", "VisitDetail")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Invitation", "VisitDetailId");

                    b.Navigation("Alien");

                    b.Navigation("Employee");

                    b.Navigation("VisitDetail");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Membership", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sbran.Domain.Entities.Employee", null)
                        .WithMany("Memberships")
                        .HasForeignKey("EmployeeId1");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Organization", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.StateRegistration", "StateRegistration")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Organization", "StateRegistrationId");

                    b.Navigation("StateRegistration");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Publication", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sbran.Domain.Entities.Employee", null)
                        .WithMany("Publications")
                        .HasForeignKey("EmployeeId1");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.ScientificInterests", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sbran.Domain.Entities.Employee", null)
                        .WithMany("ScientificInterests")
                        .HasForeignKey("EmployeeId1");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Employee", b =>
                {
                    b.Navigation("ConsularOffices");

                    b.Navigation("Departures");

                    b.Navigation("Invitations");

                    b.Navigation("Memberships");

                    b.Navigation("Publications");

                    b.Navigation("ScientificInterests");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Invitation", b =>
                {
                    b.Navigation("ForeignParticipants");
                });
#pragma warning restore 612, 618
        }
    }
}
