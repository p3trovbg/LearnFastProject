﻿namespace LearnFast.Web.ViewModels.Course
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using LearnFast.Data.Models;
    using Microsoft.AspNetCore.Http;

    public class ImportCourseModel
    {
        [RegularExpression(@"([A-Za-z]\S+)")]
        [Required]
        [Display(Name = "Course title")]
        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(400)]
        public string Description { get; set; }

        [Required]
        public IFormFile MainImage { get; set; }

        [Required]
        [MaxLength(120)]
        public string Requirments { get; set; }

        [Required]
        [Display(Name = "Is free")]
        public bool IsFree { get; set; }

        [Required]
        public int Difficulty { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Duration { get; set; }

        [Required]
        public int LanguageId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public ApplicationUser Owner { get; set; }
    }
}