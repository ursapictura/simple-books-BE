using SimplyBooks.Models;
using System.Net.NetworkInformation;

namespace SimplyBooks.Data
{
    public class BookData
    {
        public static List<Book> Books = new()
        {
            new()
            {
                Id = 1,
                userId = 1,
                Title = "One Hundred Years of Solitude",
                Description = "One Hundred Years of Solitude follows the Buendía family over several generations in the fictional town of Macondo, exploring themes of solitude, destiny, and the cyclical nature of history. Gabriel García Márquez weaves magical realism into the narrative, blending the extraordinary with the ordinary to reveal the complexities of human experience.",
                AuthorId = 5,
                Price = 18.99M,
                Sale = false,
                Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Finteractive.wttw.com%2Fsites%2Fdefault%2Ffiles%2Fone-hundred-years-of-solitude%402x.jpg&f=1&nofb=1&ipt=cbac03a3b0df903d924c2f67663920737c2c2d4a8c1b3377df04fb82cac68553&ipo=images",
            },

            new()
            {
                Id = 2,
                userId = 2,
                Title = "The Dispossessed",
                Description = "The Dispossessed tells the story of Shevek, a physicist from the anarchist moon of Anarres, as he seeks to bridge the ideological divide between his home and the capitalist planet of Urras. Ursula K. Le Guin explores themes of freedom, societal structures, and the personal costs of revolutionary ideals through Shevek's quest for understanding and connection.",
                AuthorId = 4,
                Price = 12.99M,
                Sale = true,
                Image = "https://pictures.abebooks.com/isbn/9780380003822-us.jpg",
            },

            new()
            {
                Id = 3,
                userId = 2,
                Title = "Dune",
                Description = "Dune follows Paul Atreides, the heir to the noble House Atreides, as he navigates political intrigue, betrayal, and his destiny on the desert planet of Arrakis, the only source of the invaluable spice melange. Frank Herbert's epic tale explores themes of power, ecology, and human potential, set against a richly developed universe that examines the complexities of leadership and prophecy.",
                AuthorId = 3,
                Price = 19.99M,
                Sale = false,
                Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmedia1.popsugar-assets.com%2Ffiles%2Fthumbor%2FHvm0qqOKCeobnINciFW_LdoAH_A%2Ffit-in%2F2048xorig%2Ffilters%3Aformat_auto-!!-%3Astrip_icc-!!-%2F2021%2F10%2F20%2F864%2Fn%2F1922283%2Ftmp_DAIOuz_56216a0eb18116e2_d_u_n_e.jpeg&f=1&nofb=1&ipt=3a090c0326116df7bad4576eb6f6a31051e69ff79c2f399f9c732f74b778f120&ipo=images"
            },

            new()
            {
                Id = 4,
                userId = 1,
                Title = "Even Cowgirls Get the Blues",
                Description = "Even Cowgirls Get the Blues follows Sissy Hankshaw, a free-spirited woman born with oversized thumbs, as she embarks on a journey of self-discovery and rebellion against societal norms. Tom Robbins blends humor and philosophy, weaving a narrative that celebrates individuality and the pursuit of freedom in a quirky, vibrant world.",
                AuthorId = 2,
                Price = 8.99M,
                Sale = true,
                Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.gr-assets.com%2Fimages%2FS%2Fcompressed.photo.goodreads.com%2Fbooks%2F1536085029l%2F635678._SY475_.jpg&f=1&nofb=1&ipt=9c6e4d10cfd7bbb1c920101c910cfeaad7cdcfaadbd27cfd7284ff97f10d6ef9&ipo=images",            
            },

            new()
            {
                Id = 5,
                userId = 1,
                Title = "Pilgrim at Tinker Creek",
                Description = "\r\nPilgrim at Tinker Creek is a reflective exploration of nature and existence, where Annie Dillard observes the beauty and complexity of the natural world around Tinker Creek in Virginia's Blue Ridge Mountains. Through poetic prose, she delves into themes of creation, mortality, and the interconnectedness of life, inviting readers to contemplate the profound mysteries of nature and their place within it.",
                AuthorId = 1,
                Price = 15.99M,
                Sale = false,
                Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdn.shopify.com%2Fs%2Ffiles%2F1%2F0582%2F9237%2Fproducts%2FShowImage_8ad843fc-575f-4e1f-b10e-bf83c9bcbb7e_grande.jpg%3Fv%3D1597159776&f=1&nofb=1&ipt=570028772e5ef74fff6385d55dcfd7589ceb168513b42a07011f2990528b5fa4&ipo=images",
            },

            new()
            {
                Id = 6,
                userId = 2,
                Title = "Ceremony",
                Description = "Ceremony tells the story of Tayo, a mixed-race World War II veteran who returns to his Native American community in New Mexico, struggling with trauma and identity. Leslie Marmon Silko weaves traditional storytelling with themes of healing, cultural resilience, and the importance of rituals, as Tayo seeks to reconcile his experiences and reconnect with his heritage.",
                AuthorId =  6,
                Price = 17.99M,
                Sale = false,
                Image = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fprodimage.images-bn.com%2Fpimages%2F9780143104919_p0_v1_s1200x630.jpg&f=1&nofb=1&ipt=a236a098551b6b27328e20ec8eaccf7163659115547c8d3c9f9a46ca93230d24&ipo=images",
            },

            new() { 
                Id = 7,
                userId = 2,
                Title = "Dune Messiah",
                Description = "Dune Messiah* continues the saga of Paul Atreides, now Emperor of the known universe, as he grapples with the burdens of power, prophecy, and the consequences of his own messianic rise. Frank Herbert delves into themes of political intrigue, the nature of leadership, and the moral complexities of a future shaped by fanaticism and the weight of legacy.",
                AuthorId = 3,
                Price = 14.99M,
                Sale = true,
                Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fimg1.od-cdn.com%2FImageType-100%2F1523-1%2F%257B2AF64392-77FC-4727-BB47-1915646E0A0C%257DImg100.jpg&f=1&nofb=1&ipt=f48190fc5080516fe8b3decd4b47e00f74305f7a4416bcc2c9ddefb4feb1f03c&ipo=images",
            }
        };
    }
}