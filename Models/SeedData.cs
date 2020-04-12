using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace restApiDataset.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder app){
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            // if(!context.OcrClasses.Any()) {
            //     context.OcrClasses.AddRange(
            //         new OcrClass {
            //             FileName = "image1.png",
            //             ImageData = "datgehjgfhdsft",
            //             GraphemeRootId = 13,
            //             VowelDiacreticId = 9,
            //             ConsonantDiacreticId = 4
            //         },new OcrClass {
            //             FileName = "image2.png",
            //             ImageData = "gdgdgdzzg",
            //             GraphemeRootId = 13,
            //             VowelDiacreticId = 7,
            //             ConsonantDiacreticId = 3
            //         },new OcrClass {
            //             FileName = "image3.png",
            //             ImageData = "dfhdfzhh",
            //             GraphemeRootId = 180,
            //             VowelDiacreticId = 9,
            //             ConsonantDiacreticId = 4
            //         },new OcrClass {
            //             FileName = "image4.png",
            //             ImageData = "datgehjgsdggsgfhdsft",
            //             GraphemeRootId = 13,
            //             VowelDiacreticId = 9,
            //             ConsonantDiacreticId = 1
            //         }
            //     );
            //     context.SaveChanges();
            // }

        }
    }
}