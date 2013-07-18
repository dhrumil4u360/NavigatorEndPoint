﻿using NavigatorApplication.Common.Helpers;

namespace NavigatorApplication.Service.DTO.AtomPub
{
    public class PublicationCategory : IPublicationCategory
    {
        public string Name { get; set; }
        public string Label { get; set; }

        public PublicationCategory(string name, string label = null)
        {
            Ensure.Argument.NotNullOrEmpty(name, "name");
            Name = name;
            Label = label;
        }
    }
}
