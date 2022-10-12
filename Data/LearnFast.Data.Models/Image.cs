﻿// ReSharper disable VirtualMemberCallInConstructor
namespace LearnFast.Data.Models
{
    using LearnFast.Data.Common.Models;

    public class Image : BaseDeletableModel<int>
    {
        public string Path { get; set; }
    }
}
