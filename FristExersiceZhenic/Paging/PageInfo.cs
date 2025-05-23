﻿using System.Runtime.InteropServices;

namespace FristExersiceZhenic.Paging
{
    public class PageInfo
    {
        public int PageSize { get; set; }

        public int TotalCount { get; set; }

        public int PageNumber { get; set; }

        public int PageCount => (int)Math.Ceiling((double)TotalCount / PageSize);
    }
}
