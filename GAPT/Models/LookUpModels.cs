﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GAPT.Models
{
    public class ViewModelCategory
    {
        public List<Category> categories { get; set; }
    }
    public class AttractionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Island
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Rating
    {
        public int Id { get; set; }
        public int NumOfStars { get; set; }
        public string Description { get; set; }
    }

    public class Town
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IslandId { get; set; }
    }

    public class ViewModelLookUp
    {
        public List<Category> categories { get; set; }
        public List<AttractionType> attractionTypes { get; set; }
        public List<ViewModelTour> tours { get; set; }
        public List<Island> islands { get; set; }
        public IEnumerable<int> selectedcategory { get; set; }
        public List<WishList> wishlist { get; set; }
    }

    public class ViewModelWishlist
    {
        public List<ViewModelTour> wishlisttours { get; set; }
    }

    public class ViewModelTour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal AdultPrice { get; set; }
        public decimal ChildPrice { get; set; }
        public int MaxGroupSize { get; set; }
        public int AverageRatingId { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public string Duration { get; set; }
        public string ThumbImage { get; set; }
    }
}