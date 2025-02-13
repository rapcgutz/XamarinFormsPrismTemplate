﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsPrismTemplate.Repository
{
    public interface IDataProvider
    {
        int SaveItem<T>(T item) where T : class, new();
        IEnumerable<T> GetItemList<T>() where T : class, new();
    }
}
