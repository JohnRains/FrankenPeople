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


        // Need to figure out the parameters tp pass
        private static readonly Faker<__Date> fakeDate = new Faker<__Date>(loc)
            //.RuleFor(p => p.Past, f => f.Date.Past(5, dt => DateTime.Now()))
            //.RuleFor(p => p.PastOffset, f => f.Date.PastOffset())
            //.RuleFor(p => p.Soon, f => f.Date.Soon())
            //.RuleFor(p => p.SoonOffset, f => f.Date.SoonOffset())
            //.RuleFor(p => p.Future, f => f.Date.Future())
            //.RuleFor(p => p.FutureOffset, f => f.Date.FutureOffset())
            //.RuleFor(p => p.Between, f => f.Date.Between())
            //.RuleFor(p => p.BetweenOffset, f => f.Date.BetweenOffset())
            //.RuleFor(p => p.Recent, f => f.Date.Recent())
            //.RuleFor(p => p.RecentOffset, f => f.Date.RecentOffset())
            //.RuleFor(p => p.Timespan, f => f.Date.Timespan())
            .RuleFor(p => p.Month, f => f.Date.Month())
            .RuleFor(p => p.Weekday, f => f.Date.Weekday())
            ;
        public static Faker<__Date> FakeDate => fakeDate;


        // Need to figure out the parameters tp pass
        private static readonly Faker<__Finance> fakeFinance = new Faker<__Finance>(loc)
            .RuleFor(p => p.Account, f => f.Finance.Account())
            .RuleFor(p => p.AccountName, f => f.Finance.AccountName())
            //.RuleFor(p => p.Amount, f => f.Finance.Amount())
            .RuleFor(p => p.TransactionType, f => f.Finance.TransactionType())
            //.RuleFor(p => p.Currency, f => f.Finance.Currency())
            .RuleFor(p => p.CreditCardNumber, f => f.Finance.CreditCardNumber())
            .RuleFor(p => p.CreditCardCvv, f => f.Finance.CreditCardCvv())
            .RuleFor(p => p.BitcoinAddress, f => f.Finance.BitcoinAddress())
            .RuleFor(p => p.EthereumAddress, f => f.Finance.EthereumAddress())
            .RuleFor(p => p.Bic, f => f.Finance.Bic())
            .RuleFor(p => p.Iban, f => f.Finance.Iban())
            ;
        public static Faker<__Finance> FakeFinance => fakeFinance;


        // Need to figure out the parameters tp pass
        private static readonly Faker<__Hacker> fakeHacker = new Faker<__Hacker>(loc)
            .RuleFor(p => p.Abbreviation, f => f.Hacker.Abbreviation())
            .RuleFor(p => p.Adjective, f => f.Hacker.Adjective())
            .RuleFor(p => p.Noun, f => f.Hacker.Noun())
            .RuleFor(p => p.Verb, f => f.Hacker.Verb())
            .RuleFor(p => p.IngVerb, f => f.Hacker.IngVerb())
            .RuleFor(p => p.Phrase, f => f.Hacker.Phrase())
            ;
        public static Faker<__Hacker> FakeHacker => fakeHacker;


        // Need to figure out the parameters tp pass
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
            //.RuleFor(p => p.IpAddress, f => f.Internet.IpAddress())
            //.RuleFor(p => p.IpEndPoint, f => f.Internet.IpEndPoint())
            .RuleFor(p => p.Ipv6, f => f.Internet.Ipv6())
            //.RuleFor(p => p.Ipv6Address, f => f.Internet.Ipv6Address())
            //.RuleFor(p => p.Ipv6EndPoint, f => f.Internet.Ipv6EndPoint())
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
    }
}
