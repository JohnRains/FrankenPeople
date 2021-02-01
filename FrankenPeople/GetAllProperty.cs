using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrankenPeople
{
    class GetAllProperty
    {
        private static int userId = 1;
        private const string loc = "en_US";

        private static readonly Faker<__Address> fakeAddress = new Faker<__Address>(loc)
            .RuleFor(p => p.Id, f => userId++)
            .RuleFor(p => p.RandomId, f => f.Random.Number(1, 1000))
            .RuleFor(p => p.BuildingNumber, f => f.Address.BuildingNumber())
            .RuleFor(p => p.CardinalDirection, f => f.Address.CardinalDirection())
            .RuleFor(p => p.City, f => f.Address.City())
            .RuleFor(p => p.CityPrefix, f => f.Address.CityPrefix())
            .RuleFor(p => p.CitySuffix, f => f.Address.CitySuffix())
            .RuleFor(p => p.Country, f => f.Address.Country())
            .RuleFor(p => p.ZipCode, f => f.Address.ZipCode())
            .RuleFor(p => p.CountryCode, f => f.Address.CountryCode())
            .RuleFor(p => p.Direction, f => f.Address.Direction())
            .RuleFor(p => p.FullAddress, f => f.Address.FullAddress())
            .RuleFor(p => p.State, f => f.Address.State())
            .RuleFor(p => p.StateAbbr, f => f.Address.StateAbbr())
            .RuleFor(p => p.StreetAddress, f => f.Address.StreetAddress())
            .RuleFor(p => p.StreetName, f => f.Address.StreetName())
            .RuleFor(p => p.StreetSuffix, f => f.Address.StreetSuffix())
            .RuleFor(p => p.ZipCode, f => f.Address.ZipCode())
            .RuleFor(p => p.SecondaryAddress, f => f.Address.SecondaryAddress())
            .RuleFor(p => p.SecondaryAddress, f => f.Address.SecondaryAddress())
            .RuleFor(p => p.OrdinalDirection, f => f.Address.OrdinalDirection())
            ;
        public static Faker<__Address> FakeAddress => fakeAddress;
        

        private static readonly Faker<__Commerce> fakeCommerce = new Faker<__Commerce>(loc)
            .RuleFor(p => p.Department, f => f.Commerce.Department())
            .RuleFor(p => p.Price, f => f.Commerce.Price())
            .RuleFor(p => p.Category, f => f.Commerce.Categories(1))
            .RuleFor(p => p.ProductName, f => f.Commerce.ProductName())
            .RuleFor(p => p.Color, f => f.Commerce.Color())
            .RuleFor(p => p.Product, f => f.Commerce.Product())
            .RuleFor(p => p.ProductAdjective, f => f.Commerce.ProductAdjective())
            .RuleFor(p => p.ProductMaterial, f => f.Commerce.ProductMaterial())
            .RuleFor(p => p.ProductMaterial, f => f.Commerce.ProductMaterial())
            .RuleFor(p => p.Ean8, f => f.Commerce.Ean8())
            .RuleFor(p => p.Ean13, f => f.Commerce.Ean13())
            ;
        public static Faker<__Commerce> FakeCommerce => fakeCommerce;


        private static readonly Faker<__Company> fakeCompany = new Faker<__Company>(loc)
            .RuleFor(p => p.CompanySuffix, f => f.Company.CompanySuffix())
            .RuleFor(p => p.CompanyName, f => f.Company.CompanyName())
            .RuleFor(p => p.CatchPhrase, f => f.Company.CatchPhrase())
            .RuleFor(p => p.Bs, f => f.Company.Bs())
            ;
        public static Faker<__Company> FakeCompany => fakeCompany;


        private static readonly Faker<__Database> fakeDatabase = new Faker<__Database>(loc)
            .RuleFor(p => p.Column, f => f.Database.Column())
            .RuleFor(p => p.Type, f => f.Database.Type())
            .RuleFor(p => p.Collation, f => f.Database.Collation())
            .RuleFor(p => p.Engine, f => f.Database.Engine())
            ;
        public static Faker<__Database> FakeDatabase => fakeDatabase;


        private static readonly Faker<__Date> fakeDate = new Faker<__Date>()
            .RuleFor(p => p.Past, f => f.Date.Past())
            .RuleFor(p => p.PastOffset, f => f.Date.PastOffset())
            .RuleFor(p => p.Soon, f => f.Date.Soon())
            .RuleFor(p => p.SoonOffset, f => f.Date.SoonOffset())
            .RuleFor(p => p.Future, f => f.Date.Future())
            .RuleFor(p => p.FutureOffset, f => f.Date.FutureOffset())
            .RuleFor(p => p.Between, f => f.Date.Between(DateTime.Now, DateTime.Now.AddDays(5)))
            .RuleFor(p => p.BetweenOffset, f => f.Date.BetweenOffset(DateTimeOffset.Now, DateTimeOffset.Now.AddDays(5)))
            .RuleFor(p => p.Recent, f => f.Date.Recent())
            .RuleFor(p => p.RecentOffset, f => f.Date.RecentOffset())
            .RuleFor(p => p.Timespan, f => f.Date.Timespan())
            .RuleFor(p => p.Month, f => f.Date.Month())
            .RuleFor(p => p.Weekday, f => f.Date.Weekday())
            ;
        public static Faker<__Date> FakeDate => fakeDate;


        // Need to figure out the parameters tp pass
        private static readonly Faker<__Finance> fakeFinance = new Faker<__Finance>(loc)
            .RuleFor(p => p.Account, f => f.Finance.Account())
            .RuleFor(p => p.AccountName, f => f.Finance.AccountName())
            .RuleFor(p => p.Amount, f => f.Finance.Amount())
            .RuleFor(p => p.TransactionType, f => f.Finance.TransactionType())
            .RuleFor(p => p.Currency, f => f.Finance.Currency().Description)
            .RuleFor(p => p.CreditCardNumber, f => f.Finance.CreditCardNumber())
            .RuleFor(p => p.CreditCardCvv, f => f.Finance.CreditCardCvv())
            .RuleFor(p => p.BitcoinAddress, f => f.Finance.BitcoinAddress())
            .RuleFor(p => p.EthereumAddress, f => f.Finance.EthereumAddress())
            .RuleFor(p => p.Bic, f => f.Finance.Bic())
            .RuleFor(p => p.Iban, f => f.Finance.Iban())
            ;
        public static Faker<__Finance> FakeFinance => fakeFinance;


        private static readonly Faker<__Hacker> fakeHacker = new Faker<__Hacker>(loc)
            .RuleFor(p => p.Abbreviation, f => f.Hacker.Abbreviation())
            .RuleFor(p => p.Adjective, f => f.Hacker.Adjective())
            .RuleFor(p => p.Noun, f => f.Hacker.Noun())
            .RuleFor(p => p.Verb, f => f.Hacker.Verb())
            .RuleFor(p => p.IngVerb, f => f.Hacker.IngVerb())
            .RuleFor(p => p.Phrase, f => f.Hacker.Phrase())
            ;
        public static Faker<__Hacker> FakeHacker => fakeHacker;


        private static readonly Faker<__Internet> fakeInternet = new Faker<__Internet>(loc)
            .RuleFor(p => p.Avatar, f => f.Internet.Avatar())
            .RuleFor(p => p.Email, f => f.Internet.Email())
            .RuleFor(p => p.ExampleEmail, f => f.Internet.ExampleEmail())
            .RuleFor(p => p.UserName, f => f.Internet.UserName())
            .RuleFor(p => p.UserNameUnicode, f => f.Internet.UserNameUnicode())
            .RuleFor(p => p.DomainName, f => f.Internet.DomainName())
            .RuleFor(p => p.DomainWord, f => f.Internet.DomainWord())
            .RuleFor(p => p.DomainSuffix, f => f.Internet.DomainSuffix())
            .RuleFor(p => p.Ip, f => f.Internet.Ip())
            .RuleFor(p => p.IpAddress, f => f.Internet.IpAddress().ToString())
            .RuleFor(p => p.IpEndPoint, f => f.Internet.IpEndPoint().ToString())
            .RuleFor(p => p.Ipv6, f => f.Internet.Ipv6())
            .RuleFor(p => p.Ipv6Address, f => f.Internet.Ipv6Address().ToString())
            .RuleFor(p => p.Ipv6EndPoint, f => f.Internet.Ipv6EndPoint().ToString())
            .RuleFor(p => p.UserAgent, f => f.Internet.UserAgent())
            .RuleFor(p => p.Mac, f => f.Internet.Mac())
            .RuleFor(p => p.Password, f => f.Internet.Password())
            .RuleFor(p => p.Color, f => f.Internet.Color())
            .RuleFor(p => p.Protocol, f => f.Internet.Protocol())
            .RuleFor(p => p.Url, f => f.Internet.Url())
            .RuleFor(p => p.UrlWithPath, f => f.Internet.UrlWithPath())
            .RuleFor(p => p.UrlRootedPath, f => f.Internet.UrlRootedPath())
    ;
        public static Faker<__Internet> FakeInternet => fakeInternet;


        private static readonly Faker<__Lorem> fakeLorem = new Faker<__Lorem>(loc)
            .RuleFor(p => p.Word, f => f.Lorem.Word())
            .RuleFor(p => p.Words, f => f.Lorem.Words())
            .RuleFor(p => p.Letter, f => f.Lorem.Letter())
            .RuleFor(p => p.Sentence, f => f.Lorem.Sentence())
            .RuleFor(p => p.Sentences, f => f.Lorem.Sentences())
            .RuleFor(p => p.Paragraph, f => f.Lorem.Paragraph())
            .RuleFor(p => p.Paragraphs, f => f.Lorem.Paragraphs())
            .RuleFor(p => p.Text, f => f.Lorem.Text())
            .RuleFor(p => p.Lines, f => f.Lorem.Lines())
            .RuleFor(p => p.Slug, f => f.Lorem.Slug())
    ;
        public static Faker<__Lorem> FakeLorem => fakeLorem;


        private static readonly Faker<__Name> fakeName = new Faker<__Name>(loc)
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.LastName, f => f.Name.LastName())
            .RuleFor(p => p.FullName, f => f.Name.FullName())
            .RuleFor(p => p.Prefix, f => f.Name.Prefix())
            .RuleFor(p => p.Suffix, f => f.Name.Suffix())
            .RuleFor(p => p.FindName, f => f.Name.FindName())
            .RuleFor(p => p.JobTitle, f => f.Name.JobTitle())
            .RuleFor(p => p.JobDescriptor, f => f.Name.JobDescriptor())
            .RuleFor(p => p.JobArea, f => f.Name.JobArea())
            .RuleFor(p => p.JobType, f => f.Name.JobType())
    ;
        public static Faker<__Name> FakeName => fakeName;


        private static readonly Faker<__Phone> fakePhone = new Faker<__Phone>(loc)
            .RuleFor(p => p.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(p => p.PhoneNumberFormat, f => f.Phone.PhoneNumberFormat())
            ;
        public static Faker<__Phone> FakePhone => fakePhone;


        private static readonly Faker<__Rant> fakeRant = new Faker<__Rant>(loc)
            .RuleFor(p => p.Review, f => f.Rant.Review())
            .RuleFor(p => p.Reviews, f => f.Rant.Reviews())
            ;
        public static Faker<__Rant> FakeRant => fakeRant;


        private static readonly Faker<__System> fakeSystem = new Faker<__System>(loc)
            .RuleFor(p => p.FileName, f => f.System.FileName())
            .RuleFor(p => p.DirectoryPath, f => f.System.DirectoryPath())
            .RuleFor(p => p.FilePath, f => f.System.FilePath())
            .RuleFor(p => p.CommonFileName, f => f.System.CommonFileName())
            .RuleFor(p => p.MimeType, f => f.System.MimeType())
            .RuleFor(p => p.CommonFileType, f => f.System.CommonFileType())
            .RuleFor(p => p.CommonFileExt, f => f.System.CommonFileExt())
            .RuleFor(p => p.FileType, f => f.System.FileType())
            .RuleFor(p => p.FileExt, f => f.System.FileExt())
            .RuleFor(p => p.Semver, f => f.System.Semver())
            .RuleFor(p => p.Version, f => f.System.Version().ToString())
            .RuleFor(p => p.Exception, f => f.System.Exception().ToString())
            .RuleFor(p => p.AndroidId, f => f.System.AndroidId())
            .RuleFor(p => p.ApplePushToken, f => f.System.ApplePushToken())
            .RuleFor(p => p.ApplePushToken, f => f.System.ApplePushToken())
;
        public static Faker<__System> FakeSystem => fakeSystem;


        private static readonly Faker<__Vehicle> fakeVehicle = new Faker<__Vehicle>(loc)
            .RuleFor(p => p.Vin, f => f.Vehicle.Vin())
            .RuleFor(p => p.Manufacturer, f => f.Vehicle.Manufacturer())
            .RuleFor(p => p.Model, f => f.Vehicle.Model())
            .RuleFor(p => p.Type, f => f.Vehicle.Type())
            .RuleFor(p => p.Fuel, f => f.Vehicle.Fuel())
        ;
        public static Faker<__Vehicle> FakeVehicle => fakeVehicle;




        /* 
         * Need to figure out how to use the "type" elements
         */
        private static readonly Faker<__Random> fakeRandom = new Faker<__Random>(loc)
            .RuleFor(p => p.Number, f => f.Random.Number(1, 10))
            .RuleFor(p => p.Digits, f => f.Random.Digits(3, 7, 9))
            .RuleFor(p => p.Even, f => f.Random.Even())
            .RuleFor(p => p.Odd, f => f.Random.Odd())
            .RuleFor(p => p.Double, f => f.Random.Double())
            .RuleFor(p => p.Decimal, f => f.Random.Decimal())
            .RuleFor(p => p.Float, f => f.Random.Float())
            .RuleFor(p => p.Byte, f => f.Random.Byte())
            .RuleFor(p => p.Bytes, f => f.Random.Bytes(5))
            .RuleFor(p => p.SByte, f => f.Random.SByte())
            .RuleFor(p => p.Int, f => f.Random.Int())
            .RuleFor(p => p.UInt, f => f.Random.UInt())
            .RuleFor(p => p.ULong, f => f.Random.ULong())
            .RuleFor(p => p.Long, f => f.Random.Long())
            .RuleFor(p => p.Short, f => f.Random.Short())
            .RuleFor(p => p.UShort, f => f.Random.UShort())
            .RuleFor(p => p.Char, f => f.Random.Char())
            .RuleFor(p => p.Chars, f => f.Random.Chars('d', 'g'))
            .RuleFor(p => p.String, f => f.Random.String())
            .RuleFor(p => p.String2, f => f.Random.String2(5))
            .RuleFor(p => p.Hash, f => f.Random.Hash())
            .RuleFor(p => p.Bool, f => f.Random.Bool())
            //.RuleFor(p => p.ArrayElementType, f => f.Random.ArrayElement<T>())
            //.RuleFor(p => p.ArrayElement, f => f.Random.ArrayElement())
            //.RuleFor(p => p.ArrayElementsType, f => f.Random.ArrayElementsType())
            //.RuleFor(p => p.ListItemType, f => f.Random.ListItemType())
            //.RuleFor(p => p.ListItemsType, f => f.Random.ListItemsType())
            //.RuleFor(p => p.CollectionItemType, f => f.Random.CollectionItemType())
            .RuleFor(p => p.ReplaceNumbers, f => f.Random.ReplaceNumbers("###", '#'))
            //.RuleFor(p => p.ReplaceSymbols, f => f.Random.ReplaceSymbols("###", '$', _ => ))
            .RuleFor(p => p.Replace, f => f.Random.Replace("###"))
            .RuleFor(p => p.ClampString, f => f.Random.ClampString("abcdefg", 1, 5))
            //.RuleFor(p => p.EnumType, f => f.Random.EnumType())
            //.RuleFor(p => p.ShuffleType, f => f.Random.ShuffleType())
            .RuleFor(p => p.Word, f => f.Random.Word())
            .RuleFor(p => p.Words, f => f.Random.Words())
            .RuleFor(p => p.WordsArray, f => f.Random.WordsArray(5))
            .RuleFor(p => p.Guid, f => f.Random.Guid())
            .RuleFor(p => p.Uuid, f => f.Random.Uuid())
            .RuleFor(p => p.RandomLocale, f => f.Random.RandomLocale())
            .RuleFor(p => p.AlphaNumeric, f => f.Random.AlphaNumeric(10))
            .RuleFor(p => p.Hexadecimal, f => f.Random.Hexadecimal())
            //.RuleFor(p => p.WeightedRandomType, f => f.Random.WeightedRandomType())
            ;
        public static Faker<__Random> FakeRandom => fakeRandom;





    }
}
