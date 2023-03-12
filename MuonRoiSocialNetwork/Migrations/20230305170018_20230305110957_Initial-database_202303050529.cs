using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuonRoiSocialNetwork.Migrations
{
    public partial class _20230305110957_Initialdatabase_202303050529 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "float", nullable: false),
                    UpdatedDateTS = table.Column<double>(type: "float", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NameCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "float", nullable: false),
                    UpdatedDateTS = table.Column<double>(type: "float", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TagName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookMarkStory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "float", nullable: false),
                    UpdatedDateTS = table.Column<double>(type: "float", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StoryGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookmarkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookMarkStory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookMarkStory_AspNetUsers_UserGuid",
                        column: x => x.UserGuid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FollowingAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "float", nullable: false),
                    UpdatedDateTS = table.Column<double>(type: "float", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoryGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowingAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FollowingAuthor_AspNetUsers_UserGuid",
                        column: x => x.UserGuid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupUserMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "float", nullable: false),
                    UpdatedDateTS = table.Column<double>(type: "float", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    AppUserKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppRoleKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Manage = table.Column<int>(type: "int", nullable: false),
                    Staff = table.Column<int>(type: "int", nullable: false),
                    Viewer = table.Column<int>(type: "int", nullable: false),
                    Guest = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUserMember", x => new { x.AppUserKey, x.AppRoleKey });
                    table.ForeignKey(
                        name: "FK_GroupUserMember_AspNetRoles_AppRoleKey",
                        column: x => x.AppRoleKey,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupUserMember_AspNetUsers_AppUserKey",
                        column: x => x.AppUserKey,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoryPublish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "float", nullable: false),
                    UpdatedDateTS = table.Column<double>(type: "float", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StoryGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryPublish", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoryPublish_AspNetUsers_UserGuid",
                        column: x => x.UserGuid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoryReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "float", nullable: false),
                    UpdatedDateTS = table.Column<double>(type: "float", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StoryGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoryReview_AspNetUsers_UserGuid",
                        column: x => x.UserGuid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Story",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "float", nullable: false),
                    UpdatedDateTS = table.Column<double>(type: "float", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Story_Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Story_Synopsis = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Img_Url = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsShow = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    TotalView = table.Column<int>(type: "int", nullable: false),
                    TotalFavorite = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Story", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Story_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "float", nullable: false),
                    UpdatedDateTS = table.Column<double>(type: "float", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ChapterTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", maxLength: 100000, nullable: false),
                    NumberOfChapter = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NumberCharacter = table.Column<int>(type: "int", nullable: false),
                    StoryGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapter_Story_StoryGuid",
                        column: x => x.StoryGuid,
                        principalTable: "Story",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoryNotifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "float", nullable: false),
                    UpdatedDateTS = table.Column<double>(type: "float", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoryGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotifiUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    NotificationSate = table.Column<int>(type: "int", nullable: false),
                    ReadNotificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Img_Url = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoryNotifications_AspNetUsers_UserGuid",
                        column: x => x.UserGuid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoryNotifications_Story_StoryGuid",
                        column: x => x.StoryGuid,
                        principalTable: "Story",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagInStory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "float", nullable: false),
                    UpdatedDateTS = table.Column<double>(type: "float", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StoryGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagInStory", x => new { x.StoryGuid, x.TagId });
                    table.ForeignKey(
                        name: "FK_TagInStory_Story_StoryGuid",
                        column: x => x.StoryGuid,
                        principalTable: "Story",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagInStory_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("72377426-b057-46ca-98ff-1ca9d33ea0c1"), "ecda25d3-92f9-4ee4-bb64-cc59241c1b62", "Người quản lý cao nhất", "Administratior", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "GroupId", "LastLogin", "LockReason", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Note", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Salt", "SecurityStamp", "Status", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e0223a03-2945-49db-976e-736433465b7f"), 0, "Hoà trung - ngọc định", null, null, "342c35cf-baee-4196-ab95-4c18325e3f0a", "leanhphi1706@gmail.com", false, null, null, null, null, false, null, "Phi Le", null, null, null, "AQAAAAEAACcQAAAAEOyvy74t2iHmvOreeZrGKebcFsZaGRuxZqgWXRM/kV14In1d/Ig4jnbW38MpBtatfQ==", "093.310.5367", false, "12345", null, 1, "Anh", false, "muonroi" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedDateTS", "CreatedUserId", "CreatedUserName", "DeletedDateTS", "DeletedUserId", "DeletedUserName", "Guid", "IsActive", "IsDeleted", "NameCategory", "SiteId", "UpdatedDateTS", "UpdatedUserId", "UpdatedUserName" },
                values: new object[,]
                {
                    { 1, 1672531200.0, 1, "muonroi", null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Tiên hiệp", 0, null, null, null },
                    { 2, 1672531200.0, 1, "muonroi", null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Huyền huyễn", 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "CreatedDateTS", "CreatedUserId", "CreatedUserName", "DeletedDateTS", "DeletedUserId", "DeletedUserName", "Details", "Guid", "IsDeleted", "SiteId", "TagName", "UpdatedDateTS", "UpdatedUserId", "UpdatedUserName" },
                values: new object[,]
                {
                    { 1, 1672531200.0, 1, "muonroi", null, null, null, "Truyện đã hoàn thành xong", new Guid("00000000-0000-0000-0000-000000000000"), false, 0, "Đã hoàn thành", null, null, null },
                    { 2, 1672531200.0, 1, "muonroi", null, null, null, "Truyện chưa hoàn thành xong", new Guid("00000000-0000-0000-0000-000000000000"), false, 0, "Chưa hoàn thành", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "GroupUserMember",
                columns: new[] { "AppRoleKey", "AppUserKey", "CreatedDateTS", "CreatedUserId", "CreatedUserName", "DeletedDateTS", "DeletedUserId", "DeletedUserName", "Guest", "Guid", "Id", "IsDeleted", "Manage", "SiteId", "Staff", "UpdatedDateTS", "UpdatedUserId", "UpdatedUserName", "Viewer" },
                values: new object[] { new Guid("72377426-b057-46ca-98ff-1ca9d33ea0c1"), new Guid("e0223a03-2945-49db-976e-736433465b7f"), 1672531200.0, 1, "muonroi", null, null, null, 0, new Guid("00000000-0000-0000-0000-000000000000"), 1, false, 0, 0, 0, null, null, null, 0 });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "Guid", "CategoryId", "CreatedDateTS", "CreatedUserId", "CreatedUserName", "DeletedDateTS", "DeletedUserId", "DeletedUserName", "Img_Url", "IsDeleted", "IsShow", "Rating", "SiteId", "Slug", "Story_Synopsis", "Story_Title", "TotalFavorite", "TotalView", "UpdatedDateTS", "UpdatedUserId", "UpdatedUserName" },
                values: new object[] { new Guid("32048316-149b-4838-bd27-1b5da11bd4fd"), 1, 1672531200.0, 1, "muonroi", null, null, null, "aacd50da-4e0d-47e4-939c-a4ace0f707ea.image/jpeg*Stories/MuonRoi_ta-co-mot-toa-khi-van-te-dan-cbde5bc2e8.jpg", false, true, 0.0, 0, "ta-co-mot-toa-khi-van-te-dan", "Bình An huyện nha dịch Trần Uyên xuyên qua mà đến, trong đầu cất giấu một tòa khí vận tế đàn .  Chỉ cần hiến tế khí vận, liền có thể thu được thiên cơ chỉ dẫn, thần thông, công pháp, tà thuật, thiên tài địa bảo ...  Mọi loại đều là hạ phẩm, chỉ có tập võ cao!  Đại Tấn những năm cuối, Tây vực Phật môn truyền đạo Trung Nguyên, Nam Cương yêu tộc nhìn chằm chằm .  Bắc man thiết kỵ 300 ngàn, uy áp biên cảnh .  Đạo môn chân nhân, Kiếm Tông kiếm tiên, ma đạo cự phách, giang hồ danh túc ... Thiên hạ đem loạn!  Đây là xấu nhất thời đại, cũng là tốt nhất thời đại ...  Ta gọi Trần Uyên, đến từ vực sâu!  Sát phạt quả đoán .  Chúc bạn có những giây phút vui vẻ khi đọc truyện Ta Có Một Tòa Khí Vận Tế Đàn!", "Ta Có Một Tòa Khí Vận Tế Đàn", 0, 0, null, null, null });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "Guid", "CategoryId", "CreatedDateTS", "CreatedUserId", "CreatedUserName", "DeletedDateTS", "DeletedUserId", "DeletedUserName", "Img_Url", "IsDeleted", "IsShow", "Rating", "SiteId", "Slug", "Story_Synopsis", "Story_Title", "TotalFavorite", "TotalView", "UpdatedDateTS", "UpdatedUserId", "UpdatedUserName" },
                values: new object[] { new Guid("c5c9ce29-28b5-4121-a1ce-7d03d8c22839"), 1, 1672531200.0, 1, "muonroi", null, null, null, "079dec71-43fd-4701-8450-a1ad1e6c39ff.image/jpeg*Stories/MuonRoi_nhan-sinh-tuy-tien-bat-dau-tu-tuoi-ba-muoi-ban-dic-7a54bfe686.jpg", false, true, 0.0, 0, "nhan-sinh-tuy-tien-bat-dau-tu-tuoi-ba-muoi", "Người khác xuyên việt trẻ thêm vài tuổi, Trần Tự xuyên việt thành ông chú 30.  Tưởng đâu đã có mái ấm êm đềm, ai ngờ xuyên đến lại đúng dịp ly hôn  Nếu như đã không có gì để mà lo lắng, vậy thì sống cho thật thoải mái đi.", "Nhân Sinh Tùy Tiện Bắt Đầu Từ Tuổi Ba Mươi (Bản Dịch)", 0, 0, null, null, null });

            migrationBuilder.InsertData(
                table: "Chapter",
                columns: new[] { "Id", "Body", "ChapterTitle", "CreatedDateTS", "CreatedUserId", "CreatedUserName", "DeletedDateTS", "DeletedUserId", "DeletedUserName", "Guid", "IsDeleted", "NumberCharacter", "NumberOfChapter", "SiteId", "Slug", "StoryGuid", "UpdatedDateTS", "UpdatedUserId", "UpdatedUserName" },
                values: new object[] { 1, "Chương 1: Trần Uyên  Bình An huyện, huyện nha .  Trần Uyên thăm thẳm tỉnh lại, ngửi được một vòng mùi rượu, trong bụng có chút khó chịu, a-xít dạ dày cuồn cuộn .  \"Ta ... Ta không phải tại rửa chân sao? Làm sao trên thân sẽ có mùi rượu?\"  Mọi người đều biết, uống rượu, không cho ...  Mà hôm nay là Trần Uyên thích nhất tám mươi tám hào về quê quán ra mắt thời gian .  Trần Uyên mới trong trăm công ngàn việc rút ra chút thời gian cùng tám mươi tám hào tạm biệt .  Lâu ngày sinh tình, bọn hắn cũng coi là có chút \"Giao\" tình .  Trần Uyên tập trung ánh mắt tại bốn phía hơi hơi đánh giá, có chút kinh ngạc .  Làm từ gỗ đơn sơ cái bàn, có chút phát vàng cây cột, còn có trên thân che phủ lấy màu xanh đệm chăn .  \"Cái này ... Đây là nơi nào?\"  Trần Uyên đứng người lên, nhanh chóng hướng về đến vạc nước trước, sau đó cương tại chỗ .  Trên mặt nước phản chiếu ra một khuôn mặt người, dày đặc mày kiếm, cao thẳng mũi, thâm thúy con ngươi, kiên nghị khuôn mặt .  Nhưng, đây không phải hắn!  \"Ta ... Ta xuyên qua?\"  Ngay tại Trần Uyên hoài nghi nhân sinh trong chốc lát, một cỗ như thủy triều ký ức mãnh liệt mà đến, chui vào đại não, cũng nhanh chóng lưu động .  Trần Uyên, Đại Tấn vương triều Thanh Châu Nam Lăng phủ Bình An huyện một tên nha dịch, lương tháng không đến hai lượng bạc .  Cha mẹ thời gian trước chết bệnh, bị đại bá nuôi dưỡng lớn lên, về sau đại bá cũng được bệnh nặng, bởi vì không yên lòng hắn, nhờ quan hệ khiến bạc để hắn tiến vào nha môn .  Nghĩ tới đây, Trần Uyên trong lòng một trận nhẹ nhõm, mình bây giờ không có vướng víu, lẻ loi một mình .  Trọng yếu nhất là, phụ mẫu đều mất người bình thường đều không đơn giản .  \"Hệ thống?\"  Trầm mặc thật lâu, gian phòng bên trong vang lên Trần Uyên thăm dò thanh âm .  Nhưng cực kỳ đáng tiếc, hệ thống không có phản ứng hắn .  \"Đánh dấu?\"  Trần Uyên lại nói .  ...  ...  \"Không có bất kỳ cái gì ngón tay vàng, vậy phải làm sao bây giờ ...\"  Huyện nha bên trong, Trần Uyên cau mày .  Bảy ngày, Trần Uyên kêu không biết bao nhiêu lần hệ thống, nhưng là một lần đều không có đạt được đáp lại .  Nếu như là phổ thông cổ đại thế giới thì cũng thôi đi, nhưng mấy ngày nay Trần Uyên đã hiểu rõ đến, đây là một cái võ đạo chí thượng siêu phàm thế giới .  Trong truyền thuyết, có cường giả một kiếm đoạn sông, quyền nát núi xanh ...  Nếu là mình tư chất tuyệt đỉnh Trần Uyên vậy sẽ không như thế mong đợi ngón tay vàng, nhưng hắn thử nghiệm tu luyện, sau đó liền phát hiện tự thân thiên phú nát nhừ, đại chúng trình độ .  Hoàn toàn không có một cái nào người xuyên việt nên có phong thái .  \"Được rồi, tốt xấu có cái nha dịch thân phận ...\" Trần Uyên thở dài thở ra một hơi .  Mấy ngày, Trần Uyên tiếp nhận hiện thực, ngón tay vàng không có ưu ái hắn .  Duy nhất đáng giá vui mừng là mình cũng không phải là Địa ngục bắt đầu, có huyện nha bộ khoái thân phận, lại thế nào vậy sẽ không nghèo rớt mùng tơi, chỉ phải tiếp nhận mình phổ thông liền tốt .  \"Uyên ca nhi, bộ đầu triệu tập!\"  Đang tại Trần Uyên suy nghĩ lung tung thời điểm, một đạo tuổi trẻ bóng dáng vội vàng xông vào .  \"Thế nào?\" Trần Uyên lập tức đứng người lên, đưa tay lấy cực nhanh tốc độ sờ lấy bên hông chuôi đao, hiện ra nội tâm của hắn vô cùng không an toàn cảm giác .  \"Thiết Thủ tung tích tìm được!\"  Trần Uyên ánh mắt sâu co lại, cái này mấy ngày \"Thiết Thủ\" cái này tên cũng không có ít tại hắn bên tai vang lên, trúc cơ cảnh giới Luyện Máu cấp độ hảo thủ, liên tiếp tại Bình An huyện phạm phải mấy lần án mạng .  Huyện lệnh đại nhân tức giận, giao trách nhiệm ngày quy định đem Thiết Thủ tróc nã quy án .  Liên lụy Trần Uyên đều không có nghỉ ngơi thật tốt qua, nhưng là Thiết Thủ tựa như là nhân gian biến mất bình thường mảy may tung tích đều không có, không nghĩ tới bây giờ vậy mà tìm được, trách không được bộ đầu Hoàng Hưng như vậy vội vã triệu tập nha dịch .  \"Đi!\"  Trần Uyên không dám trì hoãn, lúc này nếu là cho bộ đầu rơi mất dây xích, về sau không thiếu được mình nếm mùi đau khổ, mà bộ đầu tại Bình An huyện quyền thế rất nặng .  Không chỉ có là trên người hắn cửu phẩm quan thân, còn có hắn Bình An huyện Hoàng gia bối cảnh .  Liền xem như huyện lệnh, huyện úy hai vị đại nhân, cũng không thể không nhìn thẳng vào hắn .  Vì bắt Thiết Thủ, huyện nha bên trong vô sự nha dịch dốc hết toàn lực, trọn vẹn hơn hai mươi vị, lại thêm trên trăm bạch dịch cộng tác viên, chiến trận không thể bảo là không lớn .  Thiết Thủ mặc dù là Luyện Máu cấp độ võ giả, nhưng là cho dù là cao hắn một cái cấp độ Hoàng bộ đầu, vậy không muốn tuỳ tiện đón lấy hắn cái kia một đôi Thiết Thủ .  Về phần Trần Uyên, chỉ là nha dịch bên trong bình thường nhất Luyện Da cấp độ, miễn cưỡng được xưng tụng là võ giả .  \"Trần Uyên, Vương Bình, các ngươi mang theo tám cái bạch dịch giữ vững bắc nhai .\"  \"Lý ...\"  Hoàng Hưng một mặt ngưng trọng quét qua tám cái nha dịch cùng mười mấy cái bạch dịch, thấp giọng nói:  \"Bất luận Thiết Thủ từ phương hướng nào thoát đi, không tiếc bất cứ giá nào ngăn hắn lại cho ta, ai dám trộm gian dùng mánh lới, để Thiết Thủ thoát đi, sau đó đừng trách ta trở mặt không quen biết!\"  Hoàng Hưng hình thể cao lớn thân thể, mang cho đám người một cỗ áp bách cảm giác .  \"Là, ti chức tuân mệnh!\"  Trần Uyên thanh âm tụ hợp vào cùng kêu lên bên trong .  Hoàng Hưng dặn dò qua về sau, mang theo một bọn nha dịch bắt đầu từng nhà điều tra, Thiết Thủ tung tích cuối cùng liền biến mất ở cái này phương viên mấy ngàn mét (m) bên trong .  \"Uyên ca nhi, ta có chút khẩn trương .\"  Bên cạnh Vương Bình giảm thấp xuống một chút thanh âm .  Trần Uyên trong lòng mặc dù vậy phi thường bối rối, dù sao là lần đầu tiên đối mặt loại thực lực này phi phàm giang hồ võ giả, tục truyền Thiết Thủ tại Bình An huyện đã dính không dưới mười cái nhân mạng .  Nhưng là mặt ngoài, Trần Uyên vẫn là giữ vững cơ bản trấn định:  \"Đừng hoảng hốt, bộ đầu là luyện cốt cấp độ cao thủ, tăng thêm một bọn nha dịch phụ trợ, bắt Thiết Thủ không khó .\"  Vương Bình tựa hồ bị Trần Uyên trên thân trấn định lây nhiễm một chút, nói khẽ:  \"Uyên ca nhi, ta làm sao phát hiện ngươi cái này mấy ngày có chút như trước kia không đồng dạng?\"  Trần Uyên trong lòng giật mình, tóc gáy trên người nổ lên:  \"Chỗ đó không đồng dạng? Ta vẫn là lúc trước ta .\"  \"Nói không nên lời, liền là cảm giác ... Dù sao là cảm giác không đồng dạng, trước mấy ngày bảo ngươi cùng đi câu lan, ngươi vậy không đi .\"  \"Đại trượng phu sinh ở giữa thiên địa, há có thể sa đọa đến tận đây?\"  \"Ta ...\"  \"Có động tĩnh!\" Trần Uyên thấp giọng truyền đến Vương Bình cùng mấy cái bạch dịch trong tai .  Trần Uyên vừa dứt lời, đám người liền nghe được mấy đạo thét lên, ngay sau đó là bộ đầu Hoàng Hưng gầm thét:  \"Thiết Thủ, nhận lấy cái chết!\"  \"Hừ, một đám nha dịch bộ khoái cũng muốn bắt lão tử, kiếp sau a ...\"  \"Nhanh, truy!\"  Hoàng Hưng ngữ khí có chút kinh sợ .  \"Sẽ không như thế xui xẻo ...\" Trần Uyên âm thầm nuốt nước miếng một cái, hai tay cầm thật chặt trường đao .  Sau đó ...  Trần Uyên liền thấy được một đạo gầy gò bóng dáng chạy nhanh đến, ở sau lưng hắn, là theo sát lấy bộ đầu Hoàng Hưng .  \"Ngăn lại hắn!\" Hoàng Hưng rống to .  Trần Uyên khoảng chừng xem xét, mấy cái bạch dịch đao đều cầm không vững, chỉ còn lại có Vương Bình cùng mình ngăn tại giữa đường .  \"Lăn!\"  Thiết Thủ quát khẽ một tiếng, cánh tay trong nháy mắt biến thanh, hướng phía Trần Uyên cùng Vương Bình chộp tới .  \"Giết!\"  Vương Bình trước tiên động thủ, tiếng rống tựa hồ là ở cho mình lực lượng, nắm đao liền muốn chặt bàn tay kia .  \"Phanh!\"  Bàn tay cùng trường đao va chạm, Vương Bình trường đao trong nháy mắt đứt gãy, toàn bộ người bị Thiết Thủ đánh bay, sau đó chỉ gặp Thiết Thủ âm lãnh một cười, dưới chân sinh gió liền muốn nắm Trần Uyên cổ .  \"Bá!\"  Trong chốc lát, ngay tại Vương Bình bị đánh bay một cái chớp mắt, một thanh vôi giơ lên, Thiết Thủ che mắt, Trần Uyên cầm đao đâm một cái, hậu phương Hoàng Hưng kịp thời đuổi tới, một chưởng đánh vào Thiết Thủ phía sau lưng, để hắn một cái liệt xu thế, bước chân bất ổn vẽ mấy bước .  \"Phốc .\"  Trường đao thấu ngực mà qua .  Trần Uyên biểu lộ cứng đờ, một dòng khí mát mẻ từ Thiết Thủ thi thể truyền vào trong đầu .", "Trần Uyên", 1672531200.0, 1, "muonroi", null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), false, 1751, "Chương 1", 0, "Tran-uyen", new Guid("c5c9ce29-28b5-4121-a1ce-7d03d8c22839"), null, null, null });

            migrationBuilder.InsertData(
                table: "Chapter",
                columns: new[] { "Id", "Body", "ChapterTitle", "CreatedDateTS", "CreatedUserId", "CreatedUserName", "DeletedDateTS", "DeletedUserId", "DeletedUserName", "Guid", "IsDeleted", "NumberCharacter", "NumberOfChapter", "SiteId", "Slug", "StoryGuid", "UpdatedDateTS", "UpdatedUserId", "UpdatedUserName" },
                values: new object[] { 2, "Chương 02: Khí vận tế đàn  \"Thiên Nhãn!\"  \"Khí vận tế đàn!\"  \"Hiến tế khí vận liền có thể chỉ dẫn cơ duyên!\"  \"Từ Ân Tự, Kim Cương Kinh!\"  Trần Uyên cứng ngắc đợi tại chỗ, giờ khắc này ở cái kia cỗ thanh lương chi khí tràn vào dưới, hắn mơ hồ thấy được trong đầu cái kia một tôn che kín huyết sắc đường vân không trọn vẹn tế đàn .  \"Nguyên lai ... Ta là có ngón tay vàng!\" Trần Uyên lóe lên ý nghĩ này .  \"Trần Uyên, làm không sai!\"  Bộ đầu Hoàng Hưng khen ngợi một câu, đi lên trước vỗ vỗ Trần Uyên bả vai, để hắn ý thức trong nháy mắt quay lại, về sau, liền thấy được thuận thân đao lưu đến tay máu tươi .  Thiết Thủ mở to hai mắt nhìn, tựa hồ là không nghĩ tới mình vậy mà chết tại một cái nho nhỏ nha dịch trong tay .  Trường đao cắm ở Thiết Thủ tả tâm miệng, thân đao chui vào một nửa .  Trần Uyên có chút thở dốc trong lòng hiện lên một vòng may mắn .  May mắn mình cơ linh, đã sớm chuẩn bị một bao vôi phấn giấu ở ngực .  Nếu không, nhìn Thiết Thủ một chưởng đánh bay Vương Bình tư thế, mình vậy tuyệt đối cũng không khá hơn chút nào .  \"Hảo tiểu tử, lại còn ẩn giấu một bao vôi phấn .\" Hoàng Hưng không có để ý Trần Uyên ngốc trệ biểu lộ .  Cho là hắn là tại Thiết Thủ áp bách phía dưới, nhất thời chưa có lấy lại tinh thần mà đến .  Trần Uyên cố nặn ra vẻ tươi cười: \"Chung quy là đem cái này ác đồ giết!\"  \"Trở về về sau, bản bộ đầu vì ngươi hướng huyện úy đại nhân thỉnh công .\"  Hoàng Hưng thật cao hứng, đánh giết Thiết Thủ, huyện lệnh cùng huyện úy bên kia vậy có bàn giao .  Bộ đầu nhìn như có quan thân, lại có Hoàng gia cái này địa đầu xà bối cảnh, nhưng là huyện lệnh đại nhân nếu là không cao hứng, nắm hắn vậy thập phần khó chịu .  \"Ách ... Ách ...\"  Vương Bình thanh âm rất nhỏ từ nơi không xa truyền đến, Trần Uyên rất nhanh phản ứng lại, buông lỏng tay ra bên trong đao, đi nâng Vương Bình .  Không có chèo chống, Thiết Thủ thi thể ầm vang ngã trên mặt đất .  \"Thế nào ... Còn có thể động sao?\" Trần Uyên đỡ lấy Vương Bình hỏi .  \"Khác ... Đừng nhúc nhích, đoạn ... Gãy mất ...\"  \"Gãy mất ... Mấy chiếc xương sườn ... Mẹ hắn Thiết Thủ ... Thật đúng là hung ác!\"  Vương Bình hít vào cảm lạnh khí .  Bộ đầu Hoàng Hưng dò xét một phen Thiết Thủ, xác nhận không có bất cứ vấn đề gì, quay người đi đến Vương Bình trước người nói:  \"Lần này nhớ ngươi một công, yên tâm, tất có khen thưởng .\"  \"Cảm ... ơn đại nhân .\"  Hoàng Hưng ánh mắt trở nên âm trầm một chút, quét qua mấy cái bạch dịch, thản nhiên nói:  \"Đem Vương Bình đưa đến y quán .\"  Hắn không có quá nhiều trách móc nặng nề, cái này chút bạch dịch vốn là lao dịch một loại, làm một chút sống, khi dễ khi dễ dân chúng vẫn được, thật đến liều mạng thời điểm, một điểm lá gan đều không có .  ...  ...  Đêm khuya .  Trần Uyên nằm ở trên giường, một mực tại suy tư hôm nay truyền vào trong đầu một cỗ ý thức .  Ngón tay vàng!  Hắn vậy có ngón tay vàng!  Chỉ bất quá khác biệt là, hắn ngón tay vàng có chút đặc biệt, cần hấp thu khí vận mới có thể dẫn động .  Nếu không, coi như Trần Uyên làm từng bước cả một đời, cũng sẽ không có bất kỳ phản ứng nào .  Mà hôm nay, liền là hấp thu Thiết Thủ trên thân thần bí khí vận .  Mới khiến cho ngón tay vàng có phản ứng .  Hắn ngón tay vàng gọi là khí vận tế đàn, chỉ cần hấp thu khí vận liền có thể vì hắn chỉ dẫn cơ duyên .  Về phần Thiên Nhãn ...  Thì là khí vận tế đàn bị dẫn động về sau, truyền vào Trần Uyên trong đầu một bộ đồng thuật .  Chỉ cần tu hành môn này đồng thuật, liền có thể tại trong phạm vi trăm thước phát giác được người mang khí vận người .  Đem hắn đánh giết, trên thân khí vận liền sẽ bị khí vận tế đàn hấp thu .  Từ Ân Tự, Kim Cương Kinh .  Chính là hấp thu Thiết Thủ khí vận về sau chỉ dẫn cơ duyên .  \"Cái này ... Chẳng phải là muốn ta săn giết thiên hạ khí vận chi tử!\"  Trần Uyên trong lòng một trận hoảng sợ .  Đây là muốn đi lên trùm phản diện trên đường a, với lại, không cần nghĩ cũng biết, có thể người mang khí vận người, đại bộ phận đều là võ đạo tư chất thiên tài đứng đầu .  Những thiên tài này phía sau nhưng đều là có hậu đài!  Đánh tiểu đến lão loại sự tình này, trong tiểu thuyết đã là lão có thể lại lão sáo lộ!  \"Với lại ... Hôm nay, ta giết người!\"  Khoảng cách gần, một đao đâm vào ngực, Thiết Thủ chết không nhắm mắt .  Nhưng là chân chính để Trần Uyên có chút kinh hãi là, hắn thế mà không có bất kỳ cái gì khác thường biểu hiện, thậm chí ... Có chút kích động .  Khát máu .  Đây là Trần Uyên trong đầu hiện lên một cái từ .  Trầm mặc 15 phút, Trần Uyên nhắm mắt lại .  ...  Sáng sớm, yên lặng như tờ, phía Đông đường chân trời nổi lên từng tia từng tia ánh sáng, cẩn thận từng li từng tí thấm vào lấy màn trời .  Bình An huyện, bắc môn .  Một đạo thân mang nha dịch chế phục nam tử, cưỡi một thớt màu nâu ngựa, rời đi Bình An huyện thành .  Người này chính là Trần Uyên .  Mà hắn chuyến này mắt, chính là trong đầu toà kia khí vận tế đàn truyền đến tin tức, Từ Ân Tự, Kim Cương Kinh .  Trời đất bao la, cũng không bằng ngón tay vàng lớn!  Đây là một cái nào đó điểm mười năm lão thư trùng giác ngộ .  Hắn tối hôm qua ngủ được cũng không tốt, trong đầu một mực tại hồi tưởng đến Thiết Thủ bị mình đâm chết trong nháy mắt đó, cùng truyền vào trong đầu của mình tin tức .  Cho nên, ngày mới tờ mờ sáng liền không thể chờ đợi được chạy tới chuyến này mục tiêu địa phương .  Từ Ân Tự, ở vào Bình An huyện bắc mười dặm chỗ, là một cái tiểu tự miếu, hai trăm năm trước Tây vực Phật môn truyền đạo Trung Nguyên, Phật môn chùa chiền bắt đầu ở Đại Tấn vương triều mọc lên như nấm .  Từ Ân Tự chính là trong đó cực không đáng chú ý một chi .  Phóng nhãn thiên hạ Từ Ân Tự không tính cái gì, nhưng ngày bình thường, cũng là hương hỏa không dứt .  Đã từng, tiền thân đã từng thường xuyên đi theo đại bá thắp hương bái Phật, là lấy, Trần Uyên đối với đường xá cũng không tính lạ lẫm .  Trên đường đi, Trần Uyên đều đang suy tư trong đầu toà kia tàn phá tế đàn chỗ truyền tới tin tức, khí vận, cơ duyên các loại chữ, không ngừng bị Trần Uyên suy nghĩ .  Dùng gần nửa canh giờ công phu, Trần Uyên giục ngựa đã tới Từ Ân Tự trước .  Hôm nay thiên hạ tai kiếp nổi lên bốn phía, bách tính sinh hoạt đều tương đối gian nan, tiến về Từ Ân Tự thắp hương người vậy ít đi rất nhiều .  Đem ngựa giao cho chùa chiền bên trong tăng ni trông giữ, Trần Uyên tìm được quen biết tăng nhân, muốn vào Tàng Kinh Các nhìn qua, bên trong kinh thư cũng không có thần công gì bí pháp, toàn bộ đều là Phật môn kinh văn .  Cho nên cũng không cấm khách hành hương tiến vào .  \"Cái này chút liền là trong chùa tất cả Kim Cương Kinh sao?\" Trần Uyên nhìn xem trước người mười mấy bản kinh văn hỏi .  Cái kia áo bào xanh tăng nhân cười mỉm gật đầu:  \"Trong chùa Kim Cương Kinh tất cả ở chỗ này, Trần thí chủ phải làm làm gì dùng?\"  Trầm ngâm một cái chớp mắt, Trần Uyên giải thích nói:  \"Đại bá khi còn sống thích nhất Kim Cương Kinh, qua mấy ngày chính là đại bá ngày giỗ, Trần mỗ muốn đem cái này chút kinh văn toàn bộ mang đi đốt cho đại bá, nhìn đại sư có thể ...\"  Cái kia tăng nhân khẽ cau mày một cái, lắc đầu:  \"Trần thí chủ, cái này chút Kim Cương Kinh nếu là chỉ đem đi một bản, bần tăng còn có thể làm chủ, nhưng toàn bộ mang đi cần chủ trì đồng ý .\"  Trần Uyên cười cười, đưa tới một lượng bạc .  \"Nhìn đại sư xem ở ta một mảnh hiếu tâm phân thượng, có thể dàn xếp dàn xếp .\"  Tăng nhân ánh mắt tại bốn phía đánh giá một phen, không chút biến sắc đem bạc thu nhập trong tay áo, hai tay chắp tay trước ngực nói:  \"Trần lão thí chủ lúc còn sống, thường đến trong chùa thắp hương, bần tăng tự nhiên sẽ không bất cận nhân tình, chắc hẳn chủ trì vậy sẽ đồng ý .\"  \"Đa tạ đại sư .\"  Trần Uyên đem kinh thư thu hồi, trong lòng nhẹ cười .  Thật là thơm định luật, vĩnh không lỗi thời .  Cho dù là người xuất gia cũng không ngoại lệ!", "Khí vận tế đàn", 1672531200.0, 1, "muonroi", null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), false, 1719, "Chương 2", 0, "khi-van-te-dan", new Guid("32048316-149b-4838-bd27-1b5da11bd4fd"), null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BookMarkStory_UserGuid",
                table: "BookMarkStory",
                column: "UserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_StoryGuid",
                table: "Chapter",
                column: "StoryGuid");

            migrationBuilder.CreateIndex(
                name: "IX_FollowingAuthor_UserGuid",
                table: "FollowingAuthor",
                column: "UserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_GroupUserMember_AppRoleKey",
                table: "GroupUserMember",
                column: "AppRoleKey");

            migrationBuilder.CreateIndex(
                name: "IX_Story_CategoryId",
                table: "Story",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StoryNotifications_StoryGuid",
                table: "StoryNotifications",
                column: "StoryGuid");

            migrationBuilder.CreateIndex(
                name: "IX_StoryNotifications_UserGuid",
                table: "StoryNotifications",
                column: "UserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_StoryPublish_UserGuid",
                table: "StoryPublish",
                column: "UserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_StoryReview_UserGuid",
                table: "StoryReview",
                column: "UserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_TagInStory_TagId",
                table: "TagInStory",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookMarkStory");

            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.DropTable(
                name: "FollowingAuthor");

            migrationBuilder.DropTable(
                name: "GroupUserMember");

            migrationBuilder.DropTable(
                name: "StoryNotifications");

            migrationBuilder.DropTable(
                name: "StoryPublish");

            migrationBuilder.DropTable(
                name: "StoryReview");

            migrationBuilder.DropTable(
                name: "TagInStory");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Story");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
