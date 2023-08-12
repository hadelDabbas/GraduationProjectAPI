﻿using Microsoft.EntityFrameworkCore;
using GraduationProjectAPI.Model;
using GraduationProjectAPI.Data;

namespace GraduationProjectAPI.Data
{
    public class GraduationProjectDbContext : DbContext
    {
        public GraduationProjectDbContext(DbContextOptions<GraduationProjectDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookLibrary> BookLibraries { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<BookWriter> BookWriters { get; set; }
        public DbSet<Buybook> Buybooks { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameUser> GameUsers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
        public DbSet<UserReference> UserReferences { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Accessibility> Accessibilities { get; set; }
        public DbSet<UserAccessibility> UserAccessibilities { get; set; }
        public DbSet<Answer> Answers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Follow>()
                .HasOne(m => m.follow)
                .WithMany(m => m.follow)
                .HasForeignKey(m => m.followId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Follow>()
                .HasOne(x => x.followed)
                .WithMany(x => x.followed)
                .HasForeignKey(x => x.followedId)
                .OnDelete(DeleteBehavior.NoAction);

            //seeds for Users
            modelBuilder.Entity<User>().HasData(new User {Id=1,Name="Admin",Age="100",UserName="Admin",Password="Admin",Image=null,Study="Null",Address="Null",Paypal="Null",Email="Admin@gmail.com",Phone="Null",Description="Null" });
            modelBuilder.Entity<User>().HasData(new User { Id = 2, Name = "Asia Badenjki", Age = "22", UserName = "Asia21", Password = "0000", Image = null, Study = "Information Technology", Address = "ALfurkan next to SeriaTell", Paypal = "123451", Email = "AsiaBadenjki@gmail.com", Phone = "0911223344", Description = "Love Life" });
            modelBuilder.Entity<User>().HasData(new User { Id = 3, Name = "Haya Yousfi", Age = "23", UserName = "Haya22", Password = "1111", Image = null, Study = "Information Technology", Address = "Halab Aljadeda", Paypal = "123452", Email = "HayaYousfi@gmail.com", Phone = "0922113344", Description = "Enjoy ALL Day" });
            modelBuilder.Entity<User>().HasData(new User { Id = 4, Name = "Hamze Badenjki", Age = "18", UserName = "Hamze18", Password = "2222", Image = null, Study = "HighSchool", Address = "ALfourkan", Paypal = "123453", Email = "Hamzi18@gmail.com", Phone = "0922553344", Description = "Be Happy" });
            modelBuilder.Entity<User>().HasData(new User { Id = 5, Name = "Jawad Mohammad", Age = "35", UserName = "Jawad35", Password = "3333", Image = null, Study = "Null", Address = "ALShahba Aljadeda", Paypal = "123454", Email = "JawadMohammad@gmail.com", Phone = "0922553377", Description = "null" });
            //seeds for Accessibility
            modelBuilder.Entity<Accessibility>().HasData(new Accessibility { Id=1,AccessibilityType="All"});
            modelBuilder.Entity<Accessibility>().HasData(new Accessibility { Id = 2, AccessibilityType = "Add" });
            modelBuilder.Entity<Accessibility>().HasData(new Accessibility { Id = 3, AccessibilityType = "Update" });
            modelBuilder.Entity<Accessibility>().HasData(new Accessibility { Id = 4, AccessibilityType = "Delete" });
            //seeds for content
            modelBuilder.Entity<Content>().HasData(new Content { Id = 1, typeName="Physics" });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 2, typeName = "Earth" });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 3, typeName = "Medicine" });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 4, typeName = "Technology" });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 5, typeName = "General Science" });
            //seeds for follow
            modelBuilder.Entity<Follow>().HasData(new Follow { Id = 1, followId=2,followedId=3 });
            modelBuilder.Entity<Follow>().HasData(new Follow { Id = 2, followId = 2, followedId = 4 });
            modelBuilder.Entity<Follow>().HasData(new Follow { Id = 3, followId = 2, followedId = 5 });
            modelBuilder.Entity<Follow>().HasData(new Follow { Id = 4, followId = 3, followedId = 2 });
            modelBuilder.Entity<Follow>().HasData(new Follow { Id = 5, followId = 3, followedId = 4 });
            modelBuilder.Entity<Follow>().HasData(new Follow { Id = 6, followId = 3, followedId = 5 });
            modelBuilder.Entity<Follow>().HasData(new Follow { Id = 7, followId = 4, followedId = 2 });
            modelBuilder.Entity<Follow>().HasData(new Follow { Id = 8, followId = 4, followedId = 3 });
            modelBuilder.Entity<Follow>().HasData(new Follow { Id = 9, followId = 4, followedId = 5 });
            modelBuilder.Entity<Follow>().HasData(new Follow { Id = 10, followId = 5, followedId = 2 });
            modelBuilder.Entity<Follow>().HasData(new Follow { Id = 11, followId = 5, followedId = 3 });
            modelBuilder.Entity<Follow>().HasData(new Follow { Id = 12, followId = 5, followedId = 4 });
            //seeds for Group
            modelBuilder.Entity<Group>().HasData(new Group { Id = 1,groupName="Thee Physicists" , Description="A Group Of People Interested in History",IdContent=1,Image=null});
            modelBuilder.Entity<Group>().HasData(new Group { Id = 2, groupName = "The Earth", Description = "A Group Of People Interested in Geography", IdContent = 2, Image = null });
            modelBuilder.Entity<Group>().HasData(new Group { Id = 3, groupName = "Medicine Informations", Description = "A Group Of People Interested in Medicine", IdContent = 3, Image = null });
            modelBuilder.Entity<Group>().HasData(new Group { Id = 4, groupName = "Technology", Description = "A Group Of People Interested in Technology", IdContent = 4, Image = null });
            modelBuilder.Entity<Group>().HasData(new Group { Id = 5, groupName = "The Science ", Description = "A Group Of People Interested in Literature", IdContent = 5, Image = null });
            //seeds for User Group
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 1,IdGroup=1,IdUser=2 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 2, IdGroup = 2, IdUser = 2 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 3, IdGroup = 3, IdUser = 2 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 4, IdGroup = 4, IdUser = 2 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 5, IdGroup = 5, IdUser = 2 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 6, IdGroup = 1, IdUser = 3 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 7, IdGroup = 2, IdUser = 3});
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 8, IdGroup = 3, IdUser = 3 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 9, IdGroup = 4, IdUser = 3 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 10, IdGroup = 5, IdUser = 3 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 11, IdGroup = 1, IdUser = 4 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 12, IdGroup = 2, IdUser = 4 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 13, IdGroup = 3, IdUser = 4 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 14, IdGroup = 4, IdUser = 4 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 15, IdGroup = 5, IdUser = 4 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 16, IdGroup = 1, IdUser = 5 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 17, IdGroup = 2, IdUser = 5 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 18, IdGroup = 3, IdUser = 5 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 19, IdGroup = 4, IdUser = 5 });
            modelBuilder.Entity<UserGroup>().HasData(new UserGroup { Id = 20, IdGroup = 5, IdUser = 5 });
            //seeds for posts
            modelBuilder.Entity<Post>().HasData(new Post { Id = 1, Description= "Physics is a science that studies the general properties of matter and the laws that seek to modify its state or motion without changing its nature.", Image=null,dateTime=DateTime.Now,IdUser=2,IdContent=1,IdGroup=0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 2, Description = "Astrophysics is a branch of astronomy that studies the properties and physical phenomena of celestial bodies. It depends primarily on the spectrometer that analyzes starlight and shows the materials that make up it and the physical conditions prevailing on its surface and in its atmosphere.", Image = null, dateTime = DateTime.Now, IdUser = 3, IdContent = 1, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 3, Description = "Radiation is the process by which energy such as subatomic particles is emitted and transmitted. This process is characterized by the transmission of energy in straight lines in a source through a known medium such as air, water or vacuum.", Image = null, dateTime = DateTime.Now, IdUser = 4, IdContent = 1, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 4, Description = "Heat is a physical measure of the feeling of hotness or coldness resulting from contact with an object", Image = null, dateTime = DateTime.Now, IdUser = 5, IdContent = 1, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 5, Description = "Gravity is the mutual attraction between two bodies and its strength depends on the masses of the two bodies and the distance between them", Image = null, dateTime = DateTime.Now, IdUser = 2, IdContent = 1, IdGroup = 1 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 6, Description = "X-rays are similar to light rays, but they are more frequent. The most recent of them are objects under the influence of cathode rays. They were discovered by the scientist Roentgen and are sometimes called by his name. They are electromagnetic waves.", Image = null, dateTime = DateTime.Now, IdUser = 3, IdContent = 1, IdGroup = 1 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 7, Description = "Frequency is the number of waves or cycles that leave a known point or reach it per second. This word or convention is most often used in alternating electric current, light and sound waves.", Image = null, dateTime = DateTime.Now, IdUser = 4, IdContent = 1, IdGroup = 1 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 8, Description = "Gamma rays are special electromagnetic rays emitted by radium and some other radioactive materials", Image = null, dateTime = DateTime.Now, IdUser = 5, IdContent = 1, IdGroup = 1 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 10, Description = "The hurricane is a region of low atmospheric pressure in which the winds move in a spiral movement towards the center, and the spiral movement is counterclockwise in the northern hemisphere and agrees with it in the southern hemisphere", Image = null, dateTime = DateTime.Now, IdUser = 2, IdContent = 2, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 11, Description = "What is the definition of land shake?It is a tremor in the earth's crust caused either by volcanic activity underground or by the movement of rocks below the surface", Image = null, dateTime = DateTime.Now, IdUser = 3, IdContent = 2, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 12, Description = "Soil in stratigraphy is the part of the Earth's surface that contains a mixture of rock particles, minerals and organic matter that helps plant growth", Image = null, dateTime = DateTime.Now, IdUser = 4, IdContent = 2, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 13, Description = "The South Pole is the southernmost point on the Earth's surface, and it is one of two points that border the imaginary line that represents the axis of rotation of the earth around itself", Image = null, dateTime = DateTime.Now, IdUser = 5, IdContent = 2, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 14, Description = "The continent is a wide area of   land surrounded by seas and continents are Asia, Africa, America, Oceania, and occupies less than a third of the surface of the globe", Image = null, dateTime = DateTime.Now, IdUser = 2, IdContent = 2, IdGroup = 2 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 15, Description = "cumulus :  It is a group of pieces of rock that descended to a steep slope", Image = null, dateTime = DateTime.Now, IdUser = 3, IdContent = 2, IdGroup = 2 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 16, Description = "marble : A metamorphic rock consisting of calcite, which is a variable limestone that can be polished beautifully", Image = null, dateTime = DateTime.Now, IdUser = 4, IdContent = 2, IdGroup = 2 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 17, Description = "The North Pole is the point located in the far north of the Earth's surface, and it is one of the two points through which the imaginary line passes, which is the axis of the Earth's rotation around itself.", Image = null, dateTime = DateTime.Now, IdUser = 5, IdContent = 2, IdGroup = 2 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 18, Description = "Kidney is not  the only excretory organ ,but it is the most imporatnt", Image = null, dateTime = DateTime.Now, IdUser = 2, IdContent = 3, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 19, Description = "The Femur is the longest bone in the human body", Image = null, dateTime = DateTime.Now, IdUser = 3, IdContent = 3, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 20, Description = "There are 4 loose ribs in the human body", Image = null, dateTime = DateTime.Now, IdUser = 4, IdContent = 3, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 21, Description = "When inhaling, the diaphragm muscle contracts", Image = null, dateTime = DateTime.Now, IdUser = 5, IdContent = 3, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 22, Description = "Most food is absorbed in the intestines", Image = null, dateTime = DateTime.Now, IdUser = 2, IdContent = 3, IdGroup = 3 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 23, Description = "The tricuspid valve is located between the right atrium and the right ventricle", Image = null, dateTime = DateTime.Now, IdUser = 3, IdContent = 3, IdGroup = 3 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 24, Description = "There are 7 cervical vertebrae, 12 thoracic vertebrae, 5 lumbar vertebrae, 5 sacral vertebrae, and 4 coccygeal vertebrae.", Image = null, dateTime = DateTime.Now, IdUser = 4, IdContent = 3, IdGroup = 3 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 25, Description = "The eye lives within a cavity called the pilgrims", Image = null, dateTime = DateTime.Now, IdUser = 5, IdContent = 3, IdGroup = 3 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 26, Description = "The most used application is Facebook, with 1.3 billion users, while the second most used application is WeChat, with 1.26 billion users.", Image = null, dateTime = DateTime.Now, IdUser = 2, IdContent = 4, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 27, Description = "PAN, LAN, MAN, GAN, WAN and VPN are a kind of networking technology", Image = null, dateTime = DateTime.Now, IdUser = 3, IdContent = 4, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 28, Description = "SD-WAN is one of the fastest emerging segments in network technologies over the past two years", Image = null, dateTime = DateTime.Now, IdUser = 4, IdContent = 4, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 29, Description = "Artificial intelligence  - Artificial Intelligence - is a simulation and tradition of human intelligence in the machines programmed to think such as humans and images their actions such as electronic devices and robots, this term can also indicate any machine that displays attributes related to the human mind such as learning and solving problems", Image = null, dateTime = DateTime.Now, IdUser = 5, IdContent = 4, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 30, Description = "A GPU is a processor similar to the one on a computer's motherboard.  The job that the graphics card processor performs is to keep the graphics card connected to the computer system.  It is considered the most important component of the graphics card that processes graphics, and the graphics card processor is not separable, that is, it cannot be updated to a higher category.", Image = null, dateTime = DateTime.Now, IdUser = 2, IdContent = 4, IdGroup = 4 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 31, Description = "CPU is a machine or an electrical circuit that operates other machines or electronic circuits by giving them orders to perform operations or algorithms;  Most of these operations are data processing.", Image = null, dateTime = DateTime.Now, IdUser = 3, IdContent = 4, IdGroup = 4 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 32, Description = "Deepfake or deep falsification is a technique used to fake video clips in a way that makes it difficult for humans to distinguish between what is real and what is fake", Image = null, dateTime = DateTime.Now, IdUser = 4, IdContent = 4, IdGroup = 4 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 33, Description = "Bots download, Spam bots, Ticket Bots, Distributed Denial of Service (DDoS) bots, Fraudulent bots, File sharing bots and Social media bots are kind of Malicious bots", Image = null, dateTime = DateTime.Now, IdUser = 5, IdContent = 4, IdGroup = 4 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 34, Description = "Snow is a type of deposition in which water droplets are frozen in the form of ice crystals with various hexagonal shapes", Image = null, dateTime = DateTime.Now, IdUser = 2, IdContent = 5, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 35, Description = "A cold front is the dividing line between two masses of air, one warm and the other cold, heading towards the warm and pushing under it", Image = null, dateTime = DateTime.Now, IdUser = 3, IdContent = 5, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 36, Description = "Did you know that the duration of each cycle of the sun around itself is 24 days and three quarters", Image = null, dateTime = DateTime.Now, IdUser = 4, IdContent = 5, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 37, Description = "Absolute zero is the temperature of (162, 273 °) Celsius at which molecular motion vanishes and the body loses its thermal energy", Image = null, dateTime = DateTime.Now, IdUser = 5, IdContent = 5, IdGroup = 0 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 38, Description = "Giraffe neck The length of the giraffe's neck can reach more than 13.2 meters and contains the same number of vertebrae as the human neck, i.e. there are seven vertebrae in the giraffe's neck, and the length of each vertebra can exceed more than 25 cm", Image = null, dateTime = DateTime.Now, IdUser = 2, IdContent = 5, IdGroup = 5 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 39, Description = "The duration of the land of round about itself : The land that spirves around the same (1000) miles per hour along the tropical surroundings, in every 23 hours, and (56) minutes.", Image = null, dateTime = DateTime.Now, IdUser = 3, IdContent = 5, IdGroup = 5 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 40, Description = "The duration of the land of the ground around the sun : The duration of the land of the ground around the sun is only one time, [1/4 365] days.", Image = null, dateTime = DateTime.Now, IdUser = 4, IdContent = 5, IdGroup = 5 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 41, Description = "The oldest woman in the world is Maria Branyas Moreira, who is 115 years and 329 days old", Image = null, dateTime = DateTime.Now, IdUser = 5, IdContent = 5, IdGroup = 5 });
            //seeds Game
            modelBuilder.Entity<Game>().HasData(new Game { Id = 1,GameName="Letter Game",GameLevel=null,Image=null });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 2, GameName = "Word Game", GameLevel = null, Image = null });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 3, GameName = "Math Game", GameLevel = null, Image = null });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 4, GameName = "Foucs Game", GameLevel = null, Image = null });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 5, GameName = "Packet Game", GameLevel = null, Image = null });
            //seeds pof user game
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 1, IdGame=1,IdUser=1,Score=1,userLevel="1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 2, IdGame = 2, IdUser = 2, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 3, IdGame = 3, IdUser = 2, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 4, IdGame = 4, IdUser = 2, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 5, IdGame = 5, IdUser = 2, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 6, IdGame = 1, IdUser = 3, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 7, IdGame = 2, IdUser = 3, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 8, IdGame = 3, IdUser =3, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 9, IdGame = 4, IdUser = 3, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 10, IdGame = 5, IdUser = 3, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 11, IdGame = 1, IdUser = 4, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 12, IdGame = 2, IdUser = 4, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 13, IdGame = 3, IdUser = 4, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 14, IdGame = 4, IdUser = 4, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 15, IdGame = 5, IdUser = 4, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 16, IdGame = 1, IdUser = 5, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 17, IdGame = 2, IdUser = 5, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 18, IdGame = 3, IdUser = 5, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 19, IdGame = 4, IdUser = 5, Score = 1, userLevel = "1" });
            modelBuilder.Entity<GameUser>().HasData(new GameUser { Id = 20, IdGame = 5, IdUser = 5, Score = 1, userLevel = "1" });
            //seeds for BookType
            modelBuilder.Entity<BookType>().HasData(new BookType { Id = 1, bookType="Self Development",IsDeleted=false });
            modelBuilder.Entity<BookType>().HasData(new BookType { Id = 2, bookType = "Police Novels", IsDeleted = false });
            modelBuilder.Entity<BookType>().HasData(new BookType { Id = 3, bookType = "Psychology", IsDeleted = false });
            modelBuilder.Entity<BookType>().HasData(new BookType { Id = 4, bookType = "Marketing", IsDeleted = false });
            modelBuilder.Entity<BookType>().HasData(new BookType { Id = 5, bookType = "History", IsDeleted = false });
            modelBuilder.Entity<BookType>().HasData(new BookType { Id = 6, bookType = "Sport", IsDeleted = false });
            //seeds forb book
            modelBuilder.Entity<Book>().HasData(new Book { Id = 1,BookName="Happy Planning",BookPrice=1000,bookImage=null,IdBookType=1, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 2, BookName = "The High 5 Habit", BookPrice = 1000, bookImage = null, IdBookType = 1, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 3, BookName = "Big Magic", BookPrice = 1000, bookImage = null, IdBookType = 1, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 4, BookName = "Set Boundaries ,Find Peace", BookPrice = 1000, bookImage = null, IdBookType = 1, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 5, BookName = "The Power Of Writing It Down", BookPrice = 1000, bookImage = null, IdBookType = 1, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 6, BookName = "Life Is In The Transitions", BookPrice = 1000, bookImage = null, IdBookType = 1, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 7, BookName = "Why Social Media is Ruining Your Life", BookPrice = 1000, bookImage = null, IdBookType = 1, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 8, BookName = "Peak Mind", BookPrice = 1000, bookImage = null, IdBookType = 1, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 9, BookName = "Working Hard, Hardly Working", BookPrice = 1000, bookImage = null, IdBookType = 1, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 10, BookName = "The Everyday Hero Manifesto", BookPrice = 1000, bookImage = null, IdBookType = 1, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 11, BookName = "All Of Us Are Broken", BookPrice = 1000, bookImage = null, IdBookType = 2, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 12, BookName = "Burial Of Ghosts", BookPrice = 1000, bookImage = null, IdBookType = 2, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 13, BookName = "The Cat Who Caught A Killer", BookPrice = 1000, bookImage = null, IdBookType = 2, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 14, BookName = "Dirt Town", BookPrice = 1000, bookImage = null, IdBookType = 2, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 15, BookName = "The Rising Tide", BookPrice = 1000, bookImage = null, IdBookType = 2, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 16, BookName = "A Murder is Announced", BookPrice = 1000, bookImage = null, IdBookType = 2, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 17, BookName = "The Mysterious Affair at Styles", BookPrice = 1000, bookImage = null, IdBookType = 2, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 18, BookName = "The Murder of Roger Ackroyd", BookPrice = 1000, bookImage = null, IdBookType = 2, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 19, BookName = "Murder on the Orient Express", BookPrice = 1000, bookImage = null, IdBookType = 2, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 20, BookName = "Crooked House", BookPrice = 1000, bookImage = null, IdBookType = 2, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 21, BookName = "Thinking, Fast and Slow", BookPrice = 1000, bookImage = null, IdBookType = 3, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 22, BookName = "Influence: Science and Practice", BookPrice = 1000, bookImage = null, IdBookType = 3, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 23, BookName = "The Happiness Hypothesis", BookPrice = 1000, bookImage = null, IdBookType = 3, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 24, BookName = "Predictably Irrational", BookPrice = 1000, bookImage = null, IdBookType = 3, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 25, BookName = "Emotional Intelligence", BookPrice = 1000, bookImage = null, IdBookType = 3, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 26, BookName = "Contagious: Why Things Catch On", BookPrice = 1000, bookImage = null, IdBookType = 4, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 27, BookName = "This is Marketing: You Can’t Be Seen Until You Learn To See", BookPrice = 1000, bookImage = null, IdBookType = 4, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 28, BookName = "Building a StoryBrand: Clarify Your Message So Customers Will Listen", BookPrice = 1000, bookImage = null, IdBookType = 4, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 29, BookName = "Blue Ocean Strategy", BookPrice = 1000, bookImage = null, IdBookType = 4, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 30, BookName = "Top of Mind (PB)", BookPrice = 1000, bookImage = null, IdBookType = 4, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 31, BookName = "The Guns of August", BookPrice = 1000, bookImage = null, IdBookType = 5, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 32, BookName = "Guns, Germs, and Steel", BookPrice = 1000, bookImage = null, IdBookType = 5, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 33, BookName = "1776", BookPrice = 1000, bookImage = null, IdBookType = 5, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 34, BookName = "The Devil in the White City", BookPrice = 1000, bookImage = null, IdBookType = 5, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 35, BookName = "Orientalism", BookPrice = 1000, bookImage = null, IdBookType = 5, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 36, BookName = "Fever Pitch", BookPrice = 1000, bookImage = null, IdBookType = 6, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 37, BookName = "Open", BookPrice = 1000, bookImage = null, IdBookType = 6, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 38, BookName = "The Miracle of Castel di Sangro", BookPrice = 1000, bookImage = null, IdBookType = 6, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 39, BookName = "the Blind Side: Evolution of a Game", BookPrice = 1000, bookImage = null, IdBookType = 6, IsDeleted = false });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 40, BookName = "Laughing in the hills", BookPrice = 1000, bookImage = null, IdBookType = 6, IsDeleted = false });
            // seeds for writers
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 1,writerName= "Charlotte Blaine", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 2, writerName = "Mel Robbins", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 3, writerName = "Elizabeth Gilbert", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 4, writerName = "Nedra Glover Tawab", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 5, writerName = "Allison Fallon", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 6, writerName = "Bruce Feiler", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 7, writerName = "Catherine Ormerod", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 8, writerName = "Amish Jha", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 9, writerName = "Grace Beverly", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 10, writerName = "Robin Sharma", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 11, writerName = "Fiona Cummins", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 12, writerName = "Ann Cleeves", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 13, writerName = "L T Shearer", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 14, writerName = "Hayley Scrivenor", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 15, writerName = "Agatha Christie", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 16, writerName = "Daniel Kahneman", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 17, writerName = "Robert Cialdini", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 18, writerName = "Jonathan Haidt", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 19, writerName = "Dan Ariely", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 20, writerName = "Daniel Goleman", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 21, writerName = "Jonah Berger", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 22, writerName = "Seth Godin", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 23, writerName = "Donald Miller", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 24, writerName = "W. Chan Kim", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 25, writerName = "John Hall", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 26, writerName = "Barbara W. Tuchman", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 27, writerName = "Jared Diamond", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 28, writerName = "David McCullough", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 29, writerName = "Erik Larson", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 30, writerName = "Edward Said", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 31, writerName = "Nick Hornby", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 32, writerName = "Andre Agassi", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 33, writerName = "Joe McGinniss", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 34, writerName = "Michael Lewis", IsDeleted = false });
            modelBuilder.Entity<Writer>().HasData(new Writer { Id = 35, writerName = "Bill Barich", IsDeleted = false });

            //seeds for book writers
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 1, IdBook=1,IdWriter=1, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 2, IdBook = 2, IdWriter = 2, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 3, IdBook = 3, IdWriter = 3, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 4, IdBook = 4, IdWriter = 4, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 5, IdBook = 5, IdWriter = 5, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 6, IdBook = 6, IdWriter = 6, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 7, IdBook = 7, IdWriter = 7, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 8, IdBook = 8, IdWriter = 8, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 9, IdBook = 9, IdWriter = 9, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 10, IdBook = 10, IdWriter = 10, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id =11, IdBook = 11, IdWriter = 11, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 12, IdBook = 12, IdWriter =12 , IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 13, IdBook = 15, IdWriter = 12, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 14, IdBook = 13, IdWriter = 13, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 15, IdBook = 14, IdWriter = 14, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 16, IdBook = 16, IdWriter = 15, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 17, IdBook = 17, IdWriter = 15, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 18, IdBook = 18, IdWriter = 15, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 19, IdBook = 19, IdWriter = 15, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 20, IdBook = 20, IdWriter = 15, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 21, IdBook = 21, IdWriter = 16, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 22, IdBook = 22, IdWriter = 17, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 23, IdBook = 23, IdWriter = 18, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 24, IdBook = 24, IdWriter = 19, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 25, IdBook = 25, IdWriter = 20, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 26, IdBook = 26, IdWriter = 21, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 27, IdBook = 27, IdWriter =22, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 28, IdBook = 28, IdWriter = 23, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 29, IdBook = 29, IdWriter = 24, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 30, IdBook = 30, IdWriter = 25, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 31, IdBook = 31, IdWriter = 26, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 32, IdBook = 32, IdWriter = 27, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 33, IdBook = 33, IdWriter = 28, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 34, IdBook = 34, IdWriter = 29, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 35, IdBook = 35, IdWriter = 30, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 36, IdBook = 36, IdWriter = 31, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 37, IdBook = 37, IdWriter = 32, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 38, IdBook = 38, IdWriter = 33, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 39, IdBook = 39, IdWriter = 34, IsDeleted = false });
            modelBuilder.Entity<BookWriter>().HasData(new BookWriter { Id = 40, IdBook = 40, IdWriter = 35, IsDeleted = false });
            //seeds for libraries
            modelBuilder.Entity<Library>().HasData(new Library { Id = 1,libraryName="Sham",libraryAddress="AlSabel Street" });
            modelBuilder.Entity<Library>().HasData(new Library { Id = 2, libraryName = "Dar AlTurath", libraryAddress = "Aljamelia" });
            modelBuilder.Entity<Library>().HasData(new Library { Id = 3, libraryName = "Dar AlRabiea", libraryAddress = "AlMokambo"});
            modelBuilder.Entity<Library>().HasData(new Library { Id = 4, libraryName = "Shahmaa", libraryAddress = "AlShahbaa" });
            //seeds for book libraries
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 1,IdBook=1,IdLibrary=1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 2, IdBook = 2, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 3, IdBook = 3, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 4, IdBook = 4, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 5, IdBook = 5, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 6, IdBook = 6, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 7, IdBook = 7, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 8, IdBook = 8, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 9, IdBook = 9, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 10, IdBook = 10, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 11, IdBook = 11, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 12, IdBook = 12, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 13, IdBook = 13, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 14, IdBook = 14, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 15, IdBook = 15, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 16, IdBook = 16, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 17, IdBook = 17, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 18, IdBook = 18, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 19, IdBook = 19, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 20, IdBook = 20, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 21, IdBook = 21, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 22, IdBook = 22, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 23, IdBook = 23, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 24, IdBook = 24, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 25, IdBook = 25, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 26, IdBook = 26, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 27, IdBook = 27, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 28, IdBook = 28, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 29, IdBook = 29, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 30, IdBook = 30, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 31, IdBook = 31, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 32, IdBook = 32, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 33, IdBook = 33, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 34, IdBook = 34, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 35, IdBook = 35, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 36, IdBook = 36, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 37, IdBook = 37, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 38, IdBook = 38, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 39, IdBook = 39, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 40, IdBook = 40, IdLibrary = 1, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 41, IdBook = 1, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 42, IdBook = 2, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 43, IdBook = 3, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 44, IdBook = 4, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 45, IdBook = 5, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 46, IdBook = 6, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 47, IdBook = 7, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 48, IdBook = 8, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 49, IdBook = 9, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 50, IdBook = 10, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 51, IdBook = 11, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 52, IdBook = 12, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 53, IdBook = 13, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 54, IdBook = 14, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 55, IdBook = 15, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 56, IdBook = 16, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 57, IdBook = 17, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 58, IdBook = 18, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 59, IdBook = 19, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 60, IdBook = 20, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 61, IdBook = 21, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 62, IdBook = 22, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 63, IdBook = 23, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 64, IdBook = 24, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 65, IdBook = 25, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 66, IdBook = 26, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 67, IdBook = 27, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 68, IdBook = 28, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 69, IdBook = 29, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 70, IdBook = 30, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 71, IdBook = 31, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 72, IdBook = 32, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 73, IdBook = 33, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 74, IdBook = 34, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 75, IdBook = 35, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 76, IdBook = 36, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 77, IdBook = 37, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 78, IdBook = 38, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 79, IdBook = 39, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 80, IdBook = 40, IdLibrary = 2, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 81, IdBook = 1, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 82, IdBook = 2, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 83, IdBook = 3, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 84, IdBook = 4, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 85, IdBook = 5, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 86, IdBook = 6, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 87, IdBook = 7, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 88, IdBook = 8, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 89, IdBook = 9, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 90, IdBook = 10, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 91, IdBook = 11, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 92, IdBook = 12, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 93, IdBook = 13, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 94, IdBook = 14, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 95, IdBook = 15, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 96, IdBook = 16, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 97, IdBook = 17, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 98, IdBook = 18, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 99, IdBook = 19, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 100, IdBook = 20, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 101, IdBook = 21, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 102, IdBook = 22, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 103, IdBook = 23, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 104, IdBook = 24, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 105, IdBook = 25, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 106, IdBook = 26, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 107, IdBook = 27, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 108, IdBook = 28, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 109, IdBook = 29, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 110, IdBook = 30, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 111, IdBook = 31, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 112, IdBook = 32, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 113, IdBook = 33, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 114, IdBook = 34, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 115, IdBook = 35, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 116, IdBook = 36, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 117, IdBook = 37, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 118, IdBook = 38, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 119, IdBook = 39, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 120, IdBook = 40, IdLibrary = 3, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 121, IdBook = 1, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 122, IdBook = 2, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 123, IdBook = 3, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 124, IdBook = 4, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 125, IdBook = 5, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 126, IdBook = 6, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 127, IdBook = 7, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 128, IdBook = 8, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 129, IdBook = 9, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 130, IdBook = 10, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 131, IdBook = 11, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 132, IdBook = 12, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 133, IdBook = 13, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 134, IdBook = 14, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 135, IdBook = 15, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 136, IdBook = 16, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 137, IdBook = 17, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 138, IdBook = 18, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 139, IdBook = 19, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 140, IdBook = 20, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 141, IdBook = 21, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 142, IdBook = 22, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 143, IdBook = 23, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 144, IdBook = 24, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 145, IdBook = 25, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 146, IdBook = 26, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 147, IdBook = 27, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 148, IdBook = 28, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 149, IdBook = 29, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 150, IdBook = 30, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 151, IdBook = 31, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 152, IdBook = 32, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 153, IdBook = 33, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 154, IdBook = 34, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 155, IdBook = 35, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 156, IdBook = 36, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 157, IdBook = 37, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 158, IdBook = 38, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 159, IdBook = 39, IdLibrary = 4, IsDeleted = false });
            modelBuilder.Entity<BookLibrary>().HasData(new BookLibrary { Id = 160, IdBook = 40, IdLibrary = 4, IsDeleted = false });
            //seeds for buy book
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 1, Price = 3000, Count=3, IdUser=1,IdBookLibrary=1 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 2, Price = 4000, Count = 4, IdUser = 1, IdBookLibrary = 42 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 3, Price = 3000, Count = 3, IdUser = 1, IdBookLibrary = 83 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 4, Price = 3000, Count = 3, IdUser = 1, IdBookLibrary = 124 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 5, Price = 3000, Count = 3, IdUser = 2, IdBookLibrary = 5 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 6, Price = 3000, Count = 3, IdUser = 2, IdBookLibrary = 55 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 7, Price = 3000, Count = 3, IdUser = 2, IdBookLibrary = 56 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 8, Price = 3000, Count = 3, IdUser = 2, IdBookLibrary = 123 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 9, Price = 3000, Count = 3, IdUser = 2, IdBookLibrary = 144});
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 10, Price = 3000, Count = 3, IdUser = 3, IdBookLibrary = 7 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 11, Price = 3000, Count = 3, IdUser = 3, IdBookLibrary = 45 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 12, Price = 3000, Count = 3, IdUser = 3, IdBookLibrary = 88 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 13, Price = 3000, Count = 3, IdUser = 3, IdBookLibrary = 102 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 14, Price = 3000, Count = 3, IdUser = 4, IdBookLibrary = 9 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 15, Price = 3000, Count = 3, IdUser = 4, IdBookLibrary = 27 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 16, Price = 3000, Count = 3, IdUser = 4, IdBookLibrary = 89 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 17, Price = 3000, Count = 3, IdUser = 4, IdBookLibrary = 160 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 18, Price = 3000, Count = 3, IdUser = 5, IdBookLibrary = 33 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 19, Price = 3000, Count = 3, IdUser = 5, IdBookLibrary = 44 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 20, Price = 3000, Count = 3, IdUser = 5, IdBookLibrary = 122 });
            modelBuilder.Entity<Buybook>().HasData(new Buybook { Id = 21, Price = 3000, Count = 3, IdUser = 5, IdBookLibrary = 159 });
            //seeds for comment
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 1, comment="Wow" , IdUser = 2, IdPost=1 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 2, comment = "i do not Now That Before", IdUser = 3, IdPost = 1 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 3, comment = "very silly", IdUser = 4, IdPost = 1 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 4, comment = "nice one!", IdUser = 5, IdPost = 1 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 5, comment = "Wow", IdUser = 2, IdPost = 2 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 6, comment = "i do not Now That Before", IdUser = 3, IdPost = 2 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 7, comment = "very silly", IdUser = 4, IdPost = 2 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 8, comment = "nice one!", IdUser = 5, IdPost = 2 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 9, comment = "Wow", IdUser = 2, IdPost = 3 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 10, comment = "i do not Now That Before", IdUser = 3, IdPost = 3 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 11, comment = "very silly", IdUser = 4, IdPost = 3 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 12, comment = "nice one!", IdUser = 5, IdPost = 3 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 13, comment = "Wow", IdUser = 2, IdPost = 4 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 14, comment = "i do not Now That Before", IdUser = 3, IdPost = 4 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 15, comment = "very silly", IdUser = 4, IdPost = 4 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 16, comment = "nice one!", IdUser = 5, IdPost = 4 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 17, comment = "Wow", IdUser = 2, IdPost = 5 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 18, comment = "i do not Now That Before", IdUser = 3, IdPost = 5 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 19, comment = "very silly", IdUser = 4, IdPost = 5 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 20, comment = "nice one!", IdUser = 5, IdPost = 5 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 21, comment = "Wow", IdUser = 2, IdPost = 6 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 22, comment = "i do not Now That Before", IdUser = 3, IdPost = 6 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 23, comment = "very silly", IdUser = 4, IdPost = 6 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 24, comment = "nice one!", IdUser = 5, IdPost = 6 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 25, comment = "Wow", IdUser = 2, IdPost = 7 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 26, comment = "i do not Now That Before", IdUser = 3, IdPost = 7 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 27, comment = "very silly", IdUser = 4, IdPost = 7 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 28, comment = "nice one!", IdUser = 5, IdPost = 7 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 29, comment = "Wow", IdUser = 2, IdPost = 8 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 30, comment = "i do not Now That Before", IdUser = 3, IdPost = 8 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 31, comment = "very silly", IdUser = 4, IdPost = 8 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 32, comment = "nice one!", IdUser = 5, IdPost = 8 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 33, comment = "Wow", IdUser = 2, IdPost = 9 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 34, comment = "i do not Now That Before", IdUser = 3, IdPost = 9 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 35, comment = "very silly", IdUser = 4, IdPost = 9 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 36, comment = "nice one!", IdUser = 5, IdPost = 9 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 37, comment = "Wow", IdUser = 2, IdPost = 10 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 38, comment = "i do not Now That Before", IdUser = 3, IdPost = 10 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 39, comment = "very silly", IdUser = 4, IdPost = 10 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 40, comment = "nice one!", IdUser = 5, IdPost = 10 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 41, comment = "Wow", IdUser = 2, IdPost = 11 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 42, comment = "i do not Now That Before", IdUser = 3, IdPost = 11 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 43, comment = "very silly", IdUser = 4, IdPost = 11 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 44, comment = "nice one!", IdUser = 5, IdPost = 11 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 45, comment = "Wow", IdUser = 2, IdPost = 12 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 46, comment = "i do not Now That Before", IdUser = 3, IdPost = 12 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 47, comment = "very silly", IdUser = 4, IdPost = 12 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 48, comment = "nice one!", IdUser = 5, IdPost = 12 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 49, comment = "Wow", IdUser = 2, IdPost = 13 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 50, comment = "i do not Now That Before", IdUser = 3, IdPost = 13 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 51, comment = "very silly", IdUser = 4, IdPost = 13 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 52, comment = "nice one!", IdUser = 5, IdPost = 13 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 53, comment = "good", IdUser = 5, IdPost = 13 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 54, comment = "Wow", IdUser = 2, IdPost = 14 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 55, comment = "i do not Now That Before", IdUser = 3, IdPost = 14 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 56, comment = "very silly", IdUser = 4, IdPost = 14 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 57, comment = "nice one!", IdUser = 5, IdPost = 14 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 58, comment = "good", IdUser = 5, IdPost = 14 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 59, comment = "Wow", IdUser = 2, IdPost = 15 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 60, comment = "i do not Now That Before", IdUser = 3, IdPost = 15 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 61, comment = "very silly", IdUser = 4, IdPost = 15 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 62, comment = "nice one!", IdUser = 5, IdPost = 15 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 63, comment = "good", IdUser = 5, IdPost = 15 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 64, comment = "Wow", IdUser = 2, IdPost = 16 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 65, comment = "i do not Now That Before", IdUser = 3, IdPost = 16 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 66, comment = "very silly", IdUser = 4, IdPost = 16 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 67, comment = "nice one!", IdUser = 5, IdPost = 16 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 68, comment = "good", IdUser = 5, IdPost = 16 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 69, comment = "Wow", IdUser = 2, IdPost = 17 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 70, comment = "i do not Now That Before", IdUser = 3, IdPost = 17 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 71, comment = "very silly", IdUser = 4, IdPost = 17 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 72, comment = "nice one!", IdUser = 5, IdPost = 17 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 73, comment = "good", IdUser = 5, IdPost = 17 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 74, comment = "Wow", IdUser = 2, IdPost = 18 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 75, comment = "i do not Now That Before", IdUser = 3, IdPost = 18 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 76, comment = "very silly", IdUser = 4, IdPost = 18 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 77, comment = "nice one!", IdUser = 5, IdPost = 18 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 78, comment = "good", IdUser = 5, IdPost = 18 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 79, comment = "Wow", IdUser = 2, IdPost = 19 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 80, comment = "i do not Now That Before", IdUser = 3, IdPost = 19 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 81, comment = "very silly", IdUser = 4, IdPost = 19 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 82, comment = "nice one!", IdUser = 5, IdPost = 19 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 83, comment = "good", IdUser = 5, IdPost = 19 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 84, comment = "Wow", IdUser = 2, IdPost = 20 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 85, comment = "i do not Now That Before", IdUser = 3, IdPost = 20 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 86, comment = "very silly", IdUser = 4, IdPost = 20 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 87, comment = "nice one!", IdUser = 5, IdPost = 20 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 88, comment = "good", IdUser = 5, IdPost = 20 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 89, comment = "Wow", IdUser = 2, IdPost = 22 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 90, comment = "i do not Now That Before", IdUser = 3, IdPost = 22 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 91, comment = "very silly", IdUser = 4, IdPost = 22 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 92, comment = "nice one!", IdUser = 5, IdPost = 22 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 93, comment = "good", IdUser = 5, IdPost = 22 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 94, comment = "Wow", IdUser = 2, IdPost = 23 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 95, comment = "i do not Now That Before", IdUser = 3, IdPost = 23 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 96, comment = "very silly", IdUser = 4, IdPost = 23 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 97, comment = "nice one!", IdUser = 5, IdPost = 23 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 98, comment = "good", IdUser = 5, IdPost = 23 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 99, comment = "Wow", IdUser = 2, IdPost = 24 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 100, comment = "i do not Now That Before", IdUser = 3, IdPost = 24 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 101 ,comment = "very silly", IdUser = 4, IdPost = 24 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 102, comment = "nice one!", IdUser = 5, IdPost = 24 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 103, comment = "good", IdUser = 5, IdPost = 24 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 104, comment = "Wow", IdUser = 2, IdPost = 25 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 105, comment = "i do not Now That Before", IdUser = 3, IdPost = 25 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 106, comment = "very silly", IdUser = 4, IdPost = 25 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 107, comment = "nice one!", IdUser = 5, IdPost = 25 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 108, comment = "good", IdUser = 5, IdPost = 25 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 109, comment = "Wow", IdUser = 2, IdPost = 26 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 110, comment = "i do not Now That Before", IdUser = 3, IdPost = 26 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 111, comment = "very silly", IdUser = 4, IdPost = 26 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 112, comment = "nice one!", IdUser = 5, IdPost = 26 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 113, comment = "good", IdUser = 5, IdPost = 26 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 114, comment = "Wow", IdUser = 2, IdPost = 27 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 115, comment = "i do not Now That Before", IdUser = 3, IdPost = 27 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 116, comment = "very silly", IdUser = 4, IdPost = 27 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 117, comment = "nice one!", IdUser = 5, IdPost = 27 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 118, comment = "good", IdUser = 5, IdPost = 27 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 119, comment = "Wow", IdUser = 2, IdPost = 28 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 120, comment = "i do not Now That Before", IdUser = 3, IdPost = 28 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 121, comment = "very silly", IdUser = 4, IdPost = 28 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 122, comment = "nice one!", IdUser = 5, IdPost = 28 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 123, comment = "good", IdUser = 5, IdPost = 28});
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 124, comment = "Wow", IdUser = 2, IdPost = 29 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 125, comment = "i do not Now That Before", IdUser = 3, IdPost = 29 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 126, comment = "very silly", IdUser = 4, IdPost = 29 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 127, comment = "nice one!", IdUser = 5, IdPost = 29 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 128, comment = "good", IdUser = 5, IdPost = 29 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 129, comment = "Wow", IdUser = 2, IdPost = 30 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 130, comment = "i do not Now That Before", IdUser = 3, IdPost = 30 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 131, comment = "very silly", IdUser = 4, IdPost = 30 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 132, comment = "nice one!", IdUser = 5, IdPost = 30 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 133, comment = "good!", IdUser = 5, IdPost = 30 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 134, comment = "Wow", IdUser = 2, IdPost = 31 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 135, comment = "i do not Now That Before", IdUser = 3, IdPost = 31 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 136, comment = "very silly", IdUser = 4, IdPost = 31 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 137, comment = "nice one!", IdUser = 5, IdPost = 31 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 138, comment = "good", IdUser = 5, IdPost = 31 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 139, comment = "Wow", IdUser = 2, IdPost = 32 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 140, comment = "i do not Now That Before", IdUser = 3, IdPost = 32 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 141, comment = "very silly", IdUser = 4, IdPost = 32 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 142, comment = "nice one!", IdUser = 5, IdPost = 32 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 143, comment = "good!", IdUser = 5, IdPost = 32 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 144, comment = "Wow", IdUser = 2, IdPost =33 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 145, comment = "i do not Now That Before", IdUser = 3, IdPost = 33 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 146, comment = "very silly", IdUser = 4, IdPost = 33 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 147, comment = "nice one!", IdUser = 5, IdPost = 33 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 148, comment = "good", IdUser = 5, IdPost = 33 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 149, comment = "Wow", IdUser = 2, IdPost = 34 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 150, comment = "i do not Now That Before", IdUser = 3, IdPost = 34 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 151, comment = "very silly", IdUser = 4, IdPost = 34 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 152, comment = "nice one!", IdUser = 5, IdPost = 34 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 153, comment = "good", IdUser = 5, IdPost = 34 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 154, comment = "Wow", IdUser = 2, IdPost = 35 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 155, comment = "i do not Now That Before", IdUser = 3, IdPost = 35 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 156, comment = "very silly", IdUser = 4, IdPost = 35 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 157, comment = "nice one!", IdUser = 5, IdPost = 35 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 158, comment = "good", IdUser = 5, IdPost = 35 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 159, comment = "Wow", IdUser = 2, IdPost = 36 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 160, comment = "i do not Now That Before", IdUser = 3, IdPost = 36 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 161, comment = "very silly", IdUser = 4, IdPost = 36 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 162, comment = "nice one!", IdUser = 5, IdPost = 36 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 163, comment = "good!", IdUser = 5, IdPost = 36 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 164, comment = "Wow", IdUser = 2, IdPost = 37 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 165, comment = "i do not Now That Before", IdUser = 3, IdPost = 37 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 166, comment = "very silly", IdUser = 4, IdPost = 37 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 167, comment = "nice one!", IdUser = 5, IdPost = 37 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 168, comment = "good", IdUser = 5, IdPost = 37 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 169, comment = "Wow", IdUser = 2, IdPost = 38 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 170, comment = "i do not Now That Before", IdUser = 3, IdPost = 38 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 171, comment = "very silly", IdUser = 4, IdPost = 38 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 172, comment = "nice one!", IdUser = 5, IdPost = 38 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 173, comment = "good!", IdUser = 5, IdPost = 38 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 174, comment = "Wow", IdUser = 2, IdPost = 39 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 175, comment = "i do not Now That Before", IdUser = 3, IdPost = 39 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 176, comment = "very silly", IdUser = 4, IdPost = 39 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 177, comment = "nice one!", IdUser = 5, IdPost = 39 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 178, comment = "good", IdUser = 5, IdPost = 39 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 179, comment = "Wow", IdUser = 2, IdPost =41 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 180, comment = "i do not Now That Before", IdUser = 3, IdPost = 41 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 181, comment = "very silly", IdUser = 4, IdPost = 41 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Id = 182, comment = "nice one!", IdUser = 5, IdPost = 41 });
            //seeds for user Access
            modelBuilder.Entity<UserAccessibility>().HasData(new UserAccessibility { Id = 1, IdAccessibility=1,IdUser=2,IdGroup=1,IdLibrary=1,IdReference=1 });
            modelBuilder.Entity<UserAccessibility>().HasData(new UserAccessibility { Id = 2, IdAccessibility = 1, IdUser = 3, IdGroup = 2, IdLibrary = 2, IdReference = 1 });
            modelBuilder.Entity<UserAccessibility>().HasData(new UserAccessibility { Id = 3, IdAccessibility = 1, IdUser = 4, IdGroup = 3, IdLibrary = 3, IdReference = 2 });
            modelBuilder.Entity<UserAccessibility>().HasData(new UserAccessibility { Id = 4, IdAccessibility = 1, IdUser = 5, IdGroup = 5, IdLibrary = 5, IdReference = 3 });
            modelBuilder.Entity<UserAccessibility>().HasData(new UserAccessibility { Id = 5, IdAccessibility = 2, IdUser = 2, IdGroup = 2, IdLibrary = 2, IdReference = 1 });
            //seeds for refrence
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 1,referenceName="dont now",Link= "https://accessmedicine.mhmedical.com/book.aspx?bookid=3095#259856986",IdContent=3 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 2, referenceName = "dont now", Link = "https://accessmedicine.mhmedical.com/book.aspx?bookid=3212#269128176",  IdContent = 3 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 3, referenceName = "dont now", Link = "https://accessmedicine.mhmedical.com/book.aspx?bookid=1477",  IdContent = 3 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 4, referenceName = "dont now", Link = "https://accessmedicine.mhmedical.com/book.aspx?bookid=2969",  IdContent = 3 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 5, referenceName = "dont now", Link = "https://openstax.org/books/college-physics-2e/pages/1-introduction-to-science-and-the-realm-of-physics-physical-quantities-and-units", IdContent = 1 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 6, referenceName = "dont now", Link = "https://openstax.org/books/college-physics-2e/pages/1-1-physics-an-introduction",  IdContent = 1 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 7, referenceName = "dont now", Link = "https://openstax.org/books/college-physics-2e/pages/1-2-physical-quantities-and-units", IdContent = 1 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 8, referenceName = "dont now", Link = "https://openstax.org/books/college-physics-2e/pages/1-4-approximation", IdContent = 1 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 9, referenceName = "Alfred Wegener: Creator of the Continental Drift Theory (Makers of Modern Science)", Link = "https://www.amazon.com/Alfred-Wegener-Creator-Continental-Science/dp/0816061742", IdContent = 2 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 10, referenceName = "The Earth: A Very Short Introduction", Link = "https://www.amazon.com/Earth-Very-Short-Introduction/dp/0192803077/ref=sr_1_9?dchild=1&keywords=earth+very+short&qid=1628980604&s=books&sr=1-9", IdContent = 2 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 11, referenceName = "Essentials of Geology (12th Edition)", Link = "https://www.amazon.com/Essentials-Geology-12th-Frederick-Lutgens/dp/0321947738/ref=sr_1_2?dchild=1&keywords=essential+geology+fredrick&qid=1628980672&s=books&sr=1-2-spell", IdContent = 2 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 12, referenceName = "Plate Tectonics: A Very Short Introduction (Very Short Introductions): Molnar, Peter", Link = "https://www.amazon.com/Plate-Tectonics-Short-Introduction-Introductions/dp/0198728263/ref=sr_1_3?dchild=1&keywords=earth+science+vsi&qid=1628980553&s=books&sr=1-3", IdContent = 2 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 13, referenceName = "R Programming in Statistics by Balasubramanian Thiagarajan", Link = "https://www.free-ebooks.net/internet-technology/R-Programming-in-Statistics", IdContent = 4 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 14, referenceName = "DISCOVER YOUR SPECIALTY by DISCOVER YOUR SPECIALTY", Link = "https://www.free-ebooks.net/internet-technology/DISCOVER-YOUR-SPECIALTY",  IdContent = 4 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 15, referenceName = "Become A Pro Designer Overnight. by Clickdesigns", Link = "https://www.free-ebooks.net/internet-technology/10-Ways-to-Create-The-Perfect-Online-Video", IdContent = 4 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 16, referenceName = "10 Ways to Create The Perfect Online Video by Mathew", Link = "https://www.amazon.com/Plate-Tectonics-Short-Introduction-Introductions/dp/0198728263/ref=sr_1_3?dchild=1&keywords=earth+science+vsi&qid=1628980553&s=books&sr=1-3",  IdContent = 4 });
            modelBuilder.Entity<Reference>().HasData(new Reference { Id = 17, referenceName = "Deep Analytics: Technologies for Humanity, AI & Security", Link = "https://www.free-ebooks.net/internet-technology/Deep-Analytics-Technologies-for-Humanity-AI-Security",  IdContent = 4 });
            //seeds for User Refrence
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 1,IdUser=2,IdReference=1 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 2, IdUser = 3, IdReference = 2 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 3, IdUser = 4, IdReference = 3 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 4, IdUser = 5, IdReference = 4 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 5, IdUser = 2, IdReference = 5 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 6, IdUser = 3, IdReference = 6 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 7, IdUser = 4, IdReference = 7 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 8, IdUser = 5, IdReference = 8 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 9, IdUser = 2, IdReference = 9 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 10, IdUser = 3, IdReference = 10 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 11, IdUser = 4, IdReference = 11 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 12, IdUser = 5, IdReference = 12 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 13, IdUser = 2, IdReference = 13 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 14, IdUser = 3, IdReference = 14 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 15, IdUser = 4, IdReference = 15 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 16, IdUser = 5, IdReference = 16 });
            modelBuilder.Entity<UserReference>().HasData(new UserReference { Id = 17, IdUser = 5, IdReference = 17 });
            //seeds for complaint
            modelBuilder.Entity<Complaint>().HasData(new Complaint { Id = 1,complaint= "Please accept my request to join the group", IdUser = 2, type=0 });
            modelBuilder.Entity<Complaint>().HasData(new Complaint { Id = 2, IdUser = 2,complaint= "I want to have admin authority", type = 1 });
            modelBuilder.Entity<Complaint>().HasData(new Complaint { Id = 3, IdUser = 2,complaint= "Please allow me to add new content", type = 2 });
            modelBuilder.Entity<Complaint>().HasData(new Complaint { Id = 4, IdUser = 3, complaint = "Please accept my request to join the group", type = 0 });
            modelBuilder.Entity<Complaint>().HasData(new Complaint { Id = 5, IdUser = 3, complaint = "I want to have admin authority", type = 1 });
            modelBuilder.Entity<Complaint>().HasData(new Complaint { Id = 6, IdUser = 3, complaint = "Please allow me to add new content", type = 2 });
            modelBuilder.Entity<Complaint>().HasData(new Complaint { Id = 7, IdUser = 4, complaint = "Please accept my request to join the group", type = 0 });
            modelBuilder.Entity<Complaint>().HasData(new Complaint { Id = 8, IdUser = 4, complaint = "I want to have admin authority", type = 1 });
            modelBuilder.Entity<Complaint>().HasData(new Complaint { Id = 9, IdUser = 4, complaint = "Please allow me to add new content", type = 2 });
            modelBuilder.Entity<Complaint>().HasData(new Complaint { Id = 10, IdUser = 5, complaint = "Please accept my request to join the group", type = 0 });
            modelBuilder.Entity<Complaint>().HasData(new Complaint { Id = 11, IdUser = 5, complaint = "I want to have admin authority", type = 1 });
            modelBuilder.Entity<Complaint>().HasData(new Complaint { Id = 12, IdUser = 5, complaint = "Please allow me to add new content", type = 2 });





        }

    }
}
