﻿using Lion.AbpPro.Extension.Customs.Dtos;

namespace Lion.AbpPro.FileManagement.Files.Dto;

public class PagingFileInput : PagingBase
{
    public string Filter { get; set; }
}