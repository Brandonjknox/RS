using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Web;
using System.Web.Script.Serialization;
using Microsoft.Ajax.Utilities;
using Rs.Business;
using RS.Business.Contracts;
using RS.Business.Managers.Contracts;

namespace RS.Presentation.MVC.Infratructure
{
   public class SimpleDataStore:ISimpleDataStore
    {
       string ImagesFileLocation { get; set; }
       public SimpleDataStore()
       {
           ImagesFileLocation = HttpContext.Current.Server.MapPath("~/App_data")+@"\ImageData.txt";
           Load();
       }

       private void Load()
       {
           if (File.Exists(ImagesFileLocation))
           {
               using (var reader = new StreamReader(ImagesFileLocation))
               {
                   var json = reader.ReadToEnd();
                   var js = new JavaScriptSerializer();
                   Images = js.Deserialize<List<Image>>(json);

               }
           }
           else
           {
               Images = new List<Image>()
               {
                   new Image
                   {
                       Description = "The Cat who is fancy",
                       Genre = new Genre
                       {
                           Id = 1,
                           Name = "Fancy Cat"
                       },
                       Id = 1,
                       Title = "The Fancy Cat",
                       ImageUrl = "https://i.chzbgr.com/maxW500/3080997120/h68D5821D/"

                   }
               };
           }
       }
       public List<Image> Images { get; set; }
       public List<IGenre> Genres { get; set; }

       public void SaveChanges()
       {
           var s = new JavaScriptSerializer().Serialize(Images);
          
           using (var file = new StreamWriter(ImagesFileLocation))
           {
               file.Write(s);
           }   
       }
    }
}
