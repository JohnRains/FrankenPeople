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

        private static readonly Faker<AllProperty> fakeData = new Faker<AllProperty>()
            .RuleFor(p => p.Id, f => userId++)
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
        public static Faker<AllProperty> FakeData => fakeData;

    }
}
