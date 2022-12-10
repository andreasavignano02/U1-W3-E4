using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_E4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) 
            { 
                List<Item> list = new List<Item>();
                list = Item.GetItem();

                Repeater1.DataSource = list;
                Repeater1.DataBind();
            }
        }

        
        public class Item 
        { 
            public int id { get; set; }

            public string Name { get; set; }

            public string Img { get; set; }

            public string Description { get; set; }

            public double Prezzo { get; set; }

            public static List<Item> Items = new List<Item>();

            public static List<Item> GetItem() 
            { 
               List<Item> list = new List<Item>();

               Item I1 = new Item { id= 1, Img= "~/img_pokemon/AstriLucenti.jpg", Name = "Astri Lucenti", Description="Box da 36 bustine di Astri Lucenti dove puoi trovare arceus v alternative art", Prezzo = 170 };
               Item I2 = new Item { id = 2, Img = "~/img_pokemon/LucentezzaSiderale.webp", Name = "Lucentezza Siderale", Description = "Box da 36 bustine di Lucentezza Siderale dove puoi trovare sia Palkia che Dialga v alternative art", Prezzo = 180 };
               Item I3 = new Item { id = 3, Img = "~/img_pokemon/OriginePerduta.webp", Name = "Origine Perduta", Description = "Box da 36 bustine di Origine Perduta dove puoi trovare Giratina v alternative art", Prezzo = 190 };
               Item I4 = new Item { id = 4, Img = "~/img_pokemon/TempestaArgentata.jpg", Name = "Tempesta Argentata", Description = "Box da 36 bustine di Tempesta Argentata dove puoi trovare lugia v alternative art", Prezzo = 200 };

               list.Add(I1);
               list.Add(I2);
               list.Add(I3);
               list.Add(I4);
               return list;
            }
        }
    }
}
    

    