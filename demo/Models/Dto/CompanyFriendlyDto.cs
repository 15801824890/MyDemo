﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDemo.Models.Dto
{
    //从P43 Vendor-specific Media Types 开始，CompanyDto 分为 CompanyFriendlyDto 与 CompanyFullDto

    /// <summary>
    /// 输出 Company 使用的 Friendly Dto，仅含 Company 的部分属性/字段（P43）
    /// </summary>
    public class CompanyFriendlyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } //请注意，此处的属性名为 Name ，与视频中的 CompanyName 不同
    }
}
