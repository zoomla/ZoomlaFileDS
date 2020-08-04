using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CommonHelper.Model
{
    [Serializable]
    [XmlRoot("Config")]
    public class Config
    {
        [XmlElement("CategoryConfig")]
        public CategoryConfig CategoryConfig { get; set; }
    }

    [Serializable]
    public class CategoryConfig
    {
        [XmlArray("CategoryList")]
        public List<Category> CategoryList { get; set; }
    }

    [Serializable]
    public class Category
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Sort")]
        public int Sort { get; set; }

        [XmlArray("CategoryItemList")]
        public List<CategoryItem> CategoryItemList { get; set; }
    }

    [Serializable]
    public class CategoryItem
    {
        [XmlAttribute("Sort")]
        public int Sort { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("AssemblyName")]
        public string AssemblyName { get; set; }
    }
}