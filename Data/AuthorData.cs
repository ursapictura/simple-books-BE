using Microsoft.Extensions.Diagnostics.HealthChecks;
using SimplyBooks.Models;

namespace SimplyBooks.Data
{
    public class AuthorData
    {
        public static List<Author> Authors = new()
        {
            new()
            {
                Id = 1,
                FirstName = "Annie",
                LastName = "Dillard",
                Email = "adillard@lit.com",
                Image ="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fanniedillardportfolio.weebly.com%2Fuploads%2F1%2F3%2F6%2F8%2F13687218%2F2697410.png%3F416&f=1&nofb=1&ipt=62f1529e1d1a43a90be801e9cea7acda9c474ab6fff675db3da7413e2910f5a8&ipo=images",
                Favorite = false,
                UserId = 1
            },

            new()
            {
                Id = 2,
                FirstName = "Tom",
                LastName = "Robbins",
                Email = "tomrobbins@lit.com",
                Image ="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fstatic01.nyt.com%2Fimages%2F2014%2F05%2F21%2Farts%2F21BOOK%2F21BOOK-superJumbo.jpg%3Fquality%3D90%26auto%3Dwebp&f=1&nofb=1&ipt=f6b63cda324dbc9f1a2bd0f9593cd71d5a6b5ab8fa30c09b8777337a97ecb60c&ipo=images",
                Favorite = false,
                UserId = 1
            },

            new()
            {
                Id = 3,
                FirstName = "Frank",
                LastName = "Herbet",
                Email = "frankherbert@lit.com",
                Image ="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmedia.snl.no%2Fmedia%2F190799%2Fstandard_compressed_Frank_Herbert.jpg&f=1&nofb=1&ipt=5fbd3f61054d9a6fc040034df3fbf214e43429c61e1ab729e5268921b755ff1a&ipo=images",
                Favorite = false,
                UserId = 2
            },

            new()
            {
                Id = 4,
                FirstName = "Ursula",
                LastName = "Le Guin",
                Email = "uklg@lit.com",
                Image ="https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fres.cloudinary.com%2Fsagacity%2Fimage%2Fupload%2Fc_crop%2Ch_2064%2Cw_2858%2Cx_1097%2Cy_1051%2Fc_limit%2Cw_1080%2FUrsula_Le_Guin_photo_600dpi_mdiqqk.jpg&f=1&nofb=1&ipt=712fee86b88882e44d3bfa4bf2dfc23e64f3479c4c2621b8d96c2d990c5ad5d1&ipo=images",
                Favorite = true,
                UserId = 2
            },

            new()
            {
                Id = 5,
                FirstName = "Gabriel",
                LastName = "Garcia Marguez",
                Email = "ggmarguez@lit.com",
                Image ="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fuploads.vibra.co%2F1%2F2019%2F04%2Fobras-literarias-de-gabriel-garcia-marquez-cual-es-la-mejor.jpg&f=1&nofb=1&ipt=776cc2efd28d81bb51550f757bd1fdef3e11a3e86d4114e7406a1e205c6aa992&ipo=images",
                Favorite = true,
                UserId = 1
            },

            new()
            {
                Id = 6,
                FirstName = "Leslie",
                LastName = "Marmon Silko",
                Email = "silko@lit.com",
                Image ="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmedia.newyorker.com%2Fphotos%2F6411ea85652f9d9fe976ff65%2F16%3A9%2Fw_1280%2Cc_limit%2FIbrahim-Leslie-Marmon-Silko.jpg&f=1&nofb=1&ipt=932200b926251a35f4d2c8bcc7780689058713fa025d8c44818e2599e28f5eca&ipo=images",
                Favorite = true,
                UserId = 1
            }
        };
    }
}