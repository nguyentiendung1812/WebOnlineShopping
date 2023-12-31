﻿using System;
using System.Collections.Generic;

namespace WebOnlineShopping.Models
{
    public partial class Page
    {
        public int PageId { get; set; }
        public string? PageName { get; set; }
        public string? Contents { get; set; }
        public string? Thumb { get; set; }
        public bool? Pulished { get; set; }
        public string? Title { get; set; }
        public string? MetaDesc { get; set; }
        public string? MetaKey { get; set; }
        public string? Alias { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Ordering { get; set; }
    }
}
