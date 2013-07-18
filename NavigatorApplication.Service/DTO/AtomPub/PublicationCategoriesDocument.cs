﻿using System.Collections.Generic;
using NavigatorApplication.Common.Helpers;

namespace NavigatorApplication.Service.DTO.AtomPub
{
    public class PublicationCategoriesDocument : IPublicationCategoriesDocument
    {
        public string Scheme { get; set; }
        public IEnumerable<IPublicationCategory> Categories { get; set; }
        public bool IsFixed { get; set; }
        
        public PublicationCategoriesDocument(string scheme, IEnumerable<IPublicationCategory> categories, bool isFixed = false)
        {
            Ensure.Argument.NotNullOrEmpty(scheme, "scheme");
            Ensure.Argument.NotNull(categories, "categories");

            Scheme = scheme;
            Categories = categories;
            IsFixed = isFixed;
        }
    }
}
