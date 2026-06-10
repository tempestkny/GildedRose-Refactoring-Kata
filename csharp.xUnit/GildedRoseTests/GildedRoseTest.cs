using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void RegularItem_DecreasesSellInAndQualityByOne()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Regular Item", SellIn = 10, Quality = 10 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(9, Items[0].SellIn);
        Assert.Equal(9, Items[0].Quality);
    }

    [Fact]
    public void RegularItem_DecreasesQualityByTwoAfterSellByDate()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Regular Item", SellIn = 0, Quality = 10 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(-1, Items[0].SellIn);
        Assert.Equal(8, Items[0].Quality);
    }

    [Fact]
    public void RegularItem_QualityNeverGoesBelowZero()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Regular Item", SellIn = 10, Quality = 0 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(0, Items[0].Quality);
    }

    [Fact]
    public void AgedBrie_IncreasesQualityByOne()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(9, Items[0].SellIn);
        Assert.Equal(11, Items[0].Quality);
    }
}