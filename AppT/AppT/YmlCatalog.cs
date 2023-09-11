using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace AppT
{
    [XmlRoot("yml_catalog")]
    public class YmlCatalog
    {
        [XmlElement("shop")]
        public Shop Shop { get; set; }

        [XmlAttribute("date")]
        public string Date { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    public class Currency
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("rate")]
        public int Rate { get; set; }

        [XmlAttribute("plus")]
        public int Plus { get; set; }
    }

    public class Currencies
    {
        [XmlElement("currency")]
        public Currency Currency { get; set; }
    }

    public class Category
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlAttribute("parentId")]
        public int ParentId { get; set; }
    }

    public class Categories
    {
        [XmlElement("category")]
        public List<Category> CategoryList { get; set; }
    }

    public class CategoryId
    {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    public class Offer
    {
        [XmlElement("url")]
        public string Url { get; set; }

        [XmlElement("price")]
        public int Price { get; set; }

        [XmlElement("currencyId")]
        public string CurrencyId { get; set; }

        [XmlElement("categoryId")]
        public CategoryId CategoryId { get; set; }

        [XmlElement("picture")]
        public string Picture { get; set; }

        [XmlElement("delivery")]
        public bool Delivery { get; set; }

        [XmlElement("local_delivery_cost")]
        public int LocalDeliveryCost { get; set; }

        [XmlElement("typePrefix")]
        public string TypePrefix { get; set; }

        [XmlElement("vendor")]
        public string Vendor { get; set; }

        [XmlElement("vendorCode")]
        public string VendorCode { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("manufacturer_warranty")]
        public bool ManufacturerWarranty { get; set; }

        [XmlElement("country_of_origin")]
        public string CountryOfOrigin { get; set; }

        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("bid")]
        public int Bid { get; set; }

        [XmlAttribute("cbid")]
        public int Cbid { get; set; }

        [XmlAttribute("available")]
        public bool Available { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("series")]
        public string Series { get; set; }

        [XmlElement("year")]
        public int Year { get; set; }

        [XmlElement("ISBN")]
        public string ISBN { get; set; }

        [XmlElement("volume")]
        public int Volume { get; set; }

        [XmlElement("part")]
        public int Part { get; set; }

        [XmlElement("language")]
        public string Language { get; set; }

        [XmlElement("binding")]
        public string Binding { get; set; }

        [XmlElement("page_extent")]
        public int PageExtent { get; set; }

        [XmlElement("downloadable")]
        public bool Downloadable { get; set; }

        [XmlElement("performed_by")]
        public string PerformedBy { get; set; }

        [XmlElement("performance_type")]
        public string PerformanceType { get; set; }

        [XmlElement("storage")]
        public string Storage { get; set; }

        [XmlElement("format")]
        public string Format { get; set; }

        [XmlElement("recording_length")]
        public string RecordingLength { get; set; }

        [XmlElement("artist")]
        public string Artist { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("media")]
        public string Media { get; set; }

        [XmlElement("starring")]
        public string Starring { get; set; }

        [XmlElement("director")]
        public string Director { get; set; }

        [XmlElement("originalName")]
        public string OriginalName { get; set; }

        [XmlElement("country")]
        public string Country { get; set; }

        [XmlElement("worldRegion")]
        public string WorldRegion { get; set; }
        
        [XmlElement("region")]
        public string Region { get; set; }

        [XmlElement("days")]
        public int Days { get; set; }

        [XmlElement("dataTour")]
        public List<string> DataTour { get; set; }

        [XmlElement("hotel_stars")]
        public string HotelStars { get; set; }

        [XmlElement("room")]
        public string Room { get; set; }

        [XmlElement("meal")]
        public string Meal { get; set; }

        [XmlElement("included")]
        public string Included { get; set; }

        [XmlElement("transport")]
        public string Transport { get; set; }

        [XmlElement("place")]
        public string Place { get; set; }

        [XmlElement("hall")]
        public Hall Hall { get; set; }

        [XmlElement("hall_part")]
        public string HallPart { get; set; }

        [XmlElement("date")]
        public string Date { get; set; }

        [XmlElement("is_premiere")]
        public int IsPremiere { get; set; }

        [XmlElement("is_kids")]
        public int IsKids { get; set; }
    }

    public class Hall
    {
        [XmlAttribute("plan")]
        public string Plan { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    public class Offers
    {
        [XmlElement("offer")]
        public List<Offer> OfferList { get; set; }
    }

    public class Shop
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("company")]
        public string Company { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }

        [XmlElement("currencies")]
        public Currencies Currencies { get; set; }

        [XmlElement("categories")]
        public Categories Categories { get; set; }

        [XmlElement("local_delivery_cost")]
        public int LocalDeliveryCost { get; set; }

        [XmlElement("offers")]
        public Offers Offers { get; set; }
    }
}
