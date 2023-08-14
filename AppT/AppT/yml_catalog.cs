using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace AppT
{
    [XmlRoot(ElementName = "yml_catalog")]
    public class yml_catalog
    {
        [XmlElement(ElementName = "shop")]
        public shop shop { get; set; }

        [XmlAttribute(AttributeName = "date")]
        public string date { get; set; }

        [XmlText]
        public string text { get; set; }
    }

    [XmlRoot(ElementName = "currency")]
    public class currency
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; }

        [XmlAttribute(AttributeName = "rate")]
        public int rate { get; set; }

        [XmlAttribute(AttributeName = "plus")]
        public int plus { get; set; }
    }

    [XmlRoot(ElementName = "currencies")]
    public class currencies
    {
        [XmlElement(ElementName = "currency")]
        public currency currency { get; set; }
    }

    [XmlRoot(ElementName = "category")]
    public class category
    {
        [XmlAttribute(AttributeName = "id")]
        public int id { get; set; }

        [XmlText]
        public string text { get; set; }

        [XmlAttribute(AttributeName = "parentId")]
        public int parentId { get; set; }
    }

    [XmlRoot(ElementName = "categories")]
    public class categories
    {
        [XmlElement(ElementName = "category")]
        public List<category> category { get; set; }
    }

    [XmlRoot(ElementName = "categoryId")]
    public class categoryId
    {
        [XmlAttribute(AttributeName = "type")]
        public string type { get; set; }

        [XmlText]
        public int text { get; set; }
    }

    [XmlRoot(ElementName = "offer")]
    public class offer
    {
        [XmlElement(ElementName = "url")]
        public string url { get; set; }

        [XmlElement(ElementName = "price")]
        public int price { get; set; }

        [XmlElement(ElementName = "currencyId")]
        public string currencyId { get; set; }

        [XmlElement(ElementName = "categoryId")]
        public categoryId categoryId { get; set; }

        [XmlElement(ElementName = "picture")]
        public string picture { get; set; }

        [XmlElement(ElementName = "delivery")]
        public bool delivery { get; set; }

        [XmlElement(ElementName = "local_delivery_cost")]
        public int local_delivery_cost { get; set; }

        [XmlElement(ElementName = "typePrefix")]
        public string typePrefix { get; set; }

        [XmlElement(ElementName = "vendor")]
        public string vendor { get; set; }

        [XmlElement(ElementName = "vendorCode")]
        public string vendorCode { get; set; }

        [XmlElement(ElementName = "model")]
        public string model { get; set; }

        [XmlElement(ElementName = "description")]
        public string description { get; set; }

        [XmlElement(ElementName = "manufacturer_warranty")]
        public bool manufacturer_warranty { get; set; }

        [XmlElement(ElementName = "country_of_origin")]
        public string country_of_origin { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int id { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string type { get; set; }

        [XmlAttribute(AttributeName = "bid")]
        public int bid { get; set; }

        [XmlAttribute(AttributeName = "cbid")]
        public int cbid { get; set; }

        [XmlAttribute(AttributeName = "available")]
        public bool available { get; set; }

        [XmlText]
        public string text { get; set; }

        [XmlElement(ElementName = "author")]
        public string author { get; set; }

        [XmlElement(ElementName = "name")]
        public string name { get; set; }

        [XmlElement(ElementName = "publisher")]
        public string publisher { get; set; }

        [XmlElement(ElementName = "series")]
        public string series { get; set; }

        [XmlElement(ElementName = "year")]
        public int year { get; set; }

        [XmlElement(ElementName = "ISBN")]
        public string ISBN { get; set; }

        [XmlElement(ElementName = "volume")]
        public int volume { get; set; }

        [XmlElement(ElementName = "part")]
        public int part { get; set; }

        [XmlElement(ElementName = "language")]
        public string language { get; set; }

        [XmlElement(ElementName = "binding")]
        public string binding { get; set; }

        [XmlElement(ElementName = "page_extent")]
        public int page_extent { get; set; }

        [XmlElement(ElementName = "downloadable")]
        public bool downloadable { get; set; }

        [XmlElement(ElementName = "performed_by")]
        public string performed_by { get; set; }

        [XmlElement(ElementName = "performance_type")]
        public string performance_type { get; set; }

        [XmlElement(ElementName = "storage")]
        public string storage { get; set; }

        [XmlElement(ElementName = "format")]
        public string format { get; set; }

        [XmlElement(ElementName = "recording_length")]
        public string recording_length { get; set; }

        [XmlElement(ElementName = "artist")]
        public string artist { get; set; }

        [XmlElement(ElementName = "title")]
        public string title { get; set; }

        [XmlElement(ElementName = "media")]
        public string media { get; set; }

        [XmlElement(ElementName = "starring")]
        public string starring { get; set; }

        [XmlElement(ElementName = "director")]
        public string director { get; set; }

        [XmlElement(ElementName = "originalName")]
        public string originalName { get; set; }

        [XmlElement(ElementName = "country")]
        public string country { get; set; }

        [XmlElement(ElementName = "worldRegion")]
        public string worldRegion { get; set; }

        [XmlElement(ElementName = "region")]
        public string region { get; set; }

        [XmlElement(ElementName = "days")]
        public int days { get; set; }

        [XmlElement(ElementName = "dataTour")]
        public List<string> dataTour { get; set; }

        [XmlElement(ElementName = "hotel_stars")]
        public string hotel_stars { get; set; }

        [XmlElement(ElementName = "room")]
        public string room { get; set; }

        [XmlElement(ElementName = "meal")]
        public string meal { get; set; }

        [XmlElement(ElementName = "included")]
        public string included { get; set; }

        [XmlElement(ElementName = "transport")]
        public string transport { get; set; }

        [XmlElement(ElementName = "place")]
        public string place { get; set; }

        [XmlElement(ElementName = "hall")]
        public hall hall { get; set; }

        [XmlElement(ElementName = "hall_part")]
        public string hall_part { get; set; }

        [XmlElement(ElementName = "date")]
        public string date { get; set; }

        [XmlElement(ElementName = "is_premiere")]
        public int is_premiere { get; set; }

        [XmlElement(ElementName = "is_kids")]
        public int is_kids { get; set; }
    }

    [XmlRoot(ElementName = "hall")]
    public class hall
    {
        [XmlAttribute(AttributeName = "plan")]
        public string plan { get; set; }

        [XmlText]
        public string text { get; set; }
    }

    [XmlRoot(ElementName = "offers")]
    public class offers
    {
        [XmlElement(ElementName = "offer")]
        public List<offer> offer { get; set; }
    }

    [XmlRoot(ElementName = "shop")]
    public class shop
    {
        [XmlElement(ElementName = "name")]
        public string name { get; set; }

        [XmlElement(ElementName = "company")]
        public string company { get; set; }

        [XmlElement(ElementName = "url")]
        public string url { get; set; }

        [XmlElement(ElementName = "currencies")]
        public currencies currencies { get; set; }

        [XmlElement(ElementName = "categories")]
        public categories categories { get; set; }

        [XmlElement(ElementName = "local_delivery_cost")]
        public int local_delivery_cost { get; set; }

        [XmlElement(ElementName = "offers")]
        public offers offers { get; set; }
    }

}

