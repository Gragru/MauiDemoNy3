using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoNy3.ViewModels
{
    internal class ShopPageViewModel
    {
        public List<Models.Product> Products { get; set; }
        public Models.Shop Shop { get; set; }

        public ShopPageViewModel()
        {
            Products = new List<Models.Product>();

            Products.Add(new Models.Product { 
                ProductName = "Car",
                Price = 250000,
                ImageSource = "car.jpg",
                Details = "En väldigt fin bil"
            });

            Products.Add(new Models.Product
            {
                ProductName = "Boat",
                Price = 175000,
                ImageSource = "boat.jpg",
                Details = "En båt som flyter."
            });
            Products.Add(new Models.Product
            {
                ProductName = "Airplane",
                Price = 2500000,
                ImageSource = "plane.jpg",
                Details = "Högtflygande plan."

            });

            Shop = new Models.Shop()
            {
                Title = "Fordonsshoppen",
                HeaderImageSource = "shop.png"
            };

        }
    }
}
