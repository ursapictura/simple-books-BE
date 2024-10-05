﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Simply_Books_BE.Migrations
{
    [DbContext(typeof(SimplyBooksDbContext))]
    [Migration("20241004015301_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SimplyBooks.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Favorite")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "adillard@lit.com",
                            Favorite = false,
                            FirstName = "Annie",
                            Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fanniedillardportfolio.weebly.com%2Fuploads%2F1%2F3%2F6%2F8%2F13687218%2F2697410.png%3F416&f=1&nofb=1&ipt=62f1529e1d1a43a90be801e9cea7acda9c474ab6fff675db3da7413e2910f5a8&ipo=images",
                            LastName = "Dillard",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "tomrobbins@lit.com",
                            Favorite = false,
                            FirstName = "Tom",
                            Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fstatic01.nyt.com%2Fimages%2F2014%2F05%2F21%2Farts%2F21BOOK%2F21BOOK-superJumbo.jpg%3Fquality%3D90%26auto%3Dwebp&f=1&nofb=1&ipt=f6b63cda324dbc9f1a2bd0f9593cd71d5a6b5ab8fa30c09b8777337a97ecb60c&ipo=images",
                            LastName = "Robbins",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Email = "frankherbert@lit.com",
                            Favorite = false,
                            FirstName = "Frank",
                            Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmedia.snl.no%2Fmedia%2F190799%2Fstandard_compressed_Frank_Herbert.jpg&f=1&nofb=1&ipt=5fbd3f61054d9a6fc040034df3fbf214e43429c61e1ab729e5268921b755ff1a&ipo=images",
                            LastName = "Herbet",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            Email = "uklg@lit.com",
                            Favorite = true,
                            FirstName = "Ursula",
                            Image = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fres.cloudinary.com%2Fsagacity%2Fimage%2Fupload%2Fc_crop%2Ch_2064%2Cw_2858%2Cx_1097%2Cy_1051%2Fc_limit%2Cw_1080%2FUrsula_Le_Guin_photo_600dpi_mdiqqk.jpg&f=1&nofb=1&ipt=712fee86b88882e44d3bfa4bf2dfc23e64f3479c4c2621b8d96c2d990c5ad5d1&ipo=images",
                            LastName = "Le Guin",
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            Email = "ggmarguez@lit.com",
                            Favorite = true,
                            FirstName = "Gabriel",
                            Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fuploads.vibra.co%2F1%2F2019%2F04%2Fobras-literarias-de-gabriel-garcia-marquez-cual-es-la-mejor.jpg&f=1&nofb=1&ipt=776cc2efd28d81bb51550f757bd1fdef3e11a3e86d4114e7406a1e205c6aa992&ipo=images",
                            LastName = "Garcia Marguez",
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            Email = "silko@lit.com",
                            Favorite = true,
                            FirstName = "Leslie",
                            Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmedia.newyorker.com%2Fphotos%2F6411ea85652f9d9fe976ff65%2F16%3A9%2Fw_1280%2Cc_limit%2FIbrahim-Leslie-Marmon-Silko.jpg&f=1&nofb=1&ipt=932200b926251a35f4d2c8bcc7780689058713fa025d8c44818e2599e28f5eca&ipo=images",
                            LastName = "Marmon Silko",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("SimplyBooks.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<bool>("Sale")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("UserId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 5,
                            Description = "One Hundred Years of Solitude follows the Buendía family over several generations in the fictional town of Macondo, exploring themes of solitude, destiny, and the cyclical nature of history. Gabriel García Márquez weaves magical realism into the narrative, blending the extraordinary with the ordinary to reveal the complexities of human experience.",
                            Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Finteractive.wttw.com%2Fsites%2Fdefault%2Ffiles%2Fone-hundred-years-of-solitude%402x.jpg&f=1&nofb=1&ipt=cbac03a3b0df903d924c2f67663920737c2c2d4a8c1b3377df04fb82cac68553&ipo=images",
                            Price = 18.99m,
                            Sale = false,
                            Title = "One Hundred Years of Solitude",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 4,
                            Description = "The Dispossessed tells the story of Shevek, a physicist from the anarchist moon of Anarres, as he seeks to bridge the ideological divide between his home and the capitalist planet of Urras. Ursula K. Le Guin explores themes of freedom, societal structures, and the personal costs of revolutionary ideals through Shevek's quest for understanding and connection.",
                            Image = "https://pictures.abebooks.com/isbn/9780380003822-us.jpg",
                            Price = 12.99m,
                            Sale = true,
                            Title = "The Dispossessed",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Description = "Dune follows Paul Atreides, the heir to the noble House Atreides, as he navigates political intrigue, betrayal, and his destiny on the desert planet of Arrakis, the only source of the invaluable spice melange. Frank Herbert's epic tale explores themes of power, ecology, and human potential, set against a richly developed universe that examines the complexities of leadership and prophecy.",
                            Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmedia1.popsugar-assets.com%2Ffiles%2Fthumbor%2FHvm0qqOKCeobnINciFW_LdoAH_A%2Ffit-in%2F2048xorig%2Ffilters%3Aformat_auto-!!-%3Astrip_icc-!!-%2F2021%2F10%2F20%2F864%2Fn%2F1922283%2Ftmp_DAIOuz_56216a0eb18116e2_d_u_n_e.jpeg&f=1&nofb=1&ipt=3a090c0326116df7bad4576eb6f6a31051e69ff79c2f399f9c732f74b778f120&ipo=images",
                            Price = 19.99m,
                            Sale = false,
                            Title = "Dune",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            Description = "Even Cowgirls Get the Blues follows Sissy Hankshaw, a free-spirited woman born with oversized thumbs, as she embarks on a journey of self-discovery and rebellion against societal norms. Tom Robbins blends humor and philosophy, weaving a narrative that celebrates individuality and the pursuit of freedom in a quirky, vibrant world.",
                            Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.gr-assets.com%2Fimages%2FS%2Fcompressed.photo.goodreads.com%2Fbooks%2F1536085029l%2F635678._SY475_.jpg&f=1&nofb=1&ipt=9c6e4d10cfd7bbb1c920101c910cfeaad7cdcfaadbd27cfd7284ff97f10d6ef9&ipo=images",
                            Price = 8.99m,
                            Sale = true,
                            Title = "Even Cowgirls Get the Blues",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 1,
                            Description = "Pilgrim at Tinker Creek is a reflective exploration of nature and existence, where Annie Dillard observes the beauty and complexity of the natural world around Tinker Creek in Virginia's Blue Ridge Mountains. Through poetic prose, she delves into themes of creation, mortality, and the interconnectedness of life, inviting readers to contemplate the profound mysteries of nature and their place within it.",
                            Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdn.shopify.com%2Fs%2Ffiles%2F1%2F0582%2F9237%2Fproducts%2FShowImage_8ad843fc-575f-4e1f-b10e-bf83c9bcbb7e_grande.jpg%3Fv%3D1597159776&f=1&nofb=1&ipt=570028772e5ef74fff6385d55dcfd7589ceb168513b42a07011f2990528b5fa4&ipo=images",
                            Price = 15.99m,
                            Sale = false,
                            Title = "Pilgrim at Tinker Creek",
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 6,
                            Description = "Ceremony tells the story of Tayo, a mixed-race World War II veteran who returns to his Native American community in New Mexico, struggling with trauma and identity. Leslie Marmon Silko weaves traditional storytelling with themes of healing, cultural resilience, and the importance of rituals, as Tayo seeks to reconcile his experiences and reconnect with his heritage.",
                            Image = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fprodimage.images-bn.com%2Fpimages%2F9780143104919_p0_v1_s1200x630.jpg&f=1&nofb=1&ipt=a236a098551b6b27328e20ec8eaccf7163659115547c8d3c9f9a46ca93230d24&ipo=images",
                            Price = 17.99m,
                            Sale = false,
                            Title = "Ceremony",
                            UserId = 2
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 3,
                            Description = "Dune Messiah* continues the saga of Paul Atreides, now Emperor of the known universe, as he grapples with the burdens of power, prophecy, and the consequences of his own messianic rise. Frank Herbert delves into themes of political intrigue, the nature of leadership, and the moral complexities of a future shaped by fanaticism and the weight of legacy.",
                            Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fimg1.od-cdn.com%2FImageType-100%2F1523-1%2F%257B2AF64392-77FC-4727-BB47-1915646E0A0C%257DImg100.jpg&f=1&nofb=1&ipt=f48190fc5080516fe8b3decd4b47e00f74305f7a4416bcc2c9ddefb4feb1f03c&ipo=images",
                            Price = 14.99m,
                            Sale = true,
                            Title = "Dune Messiah",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("SimplyBooks.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "chaosGoblin@gmail.com",
                            UserName = "chaosGoblin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "cipher@gfalls.com",
                            UserName = "billCipher"
                        });
                });

            modelBuilder.Entity("SimplyBooks.Models.Book", b =>
                {
                    b.HasOne("SimplyBooks.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimplyBooks.Models.User", null)
                        .WithMany("Books")
                        .HasForeignKey("UserId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("SimplyBooks.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("SimplyBooks.Models.User", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
