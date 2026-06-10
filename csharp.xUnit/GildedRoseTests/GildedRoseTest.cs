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

    [Fact]
    public void AgedBrie_IncreasesQualitybyTwoAfterSellByDate()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 10 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(-1, Items[0].SellIn);
        Assert.Equal(12, Items[0].Quality);
    }

    [Fact]
    public void AgedBrie_QualityNeverExceedsFifty()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(50, Items[0].Quality);
    }

    [Fact]
    public void BackstagePasses_IncreaseQualityByOneWhenSellInGreaterThanTen()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 10 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(14, Items[0].SellIn);
        Assert.Equal(11, Items[0].Quality);
    }

    [Fact]
    public void BackstagePasses_IncreaseQualityByTwoWhenSellInTenOrLess()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(9, Items[0].SellIn);
        Assert.Equal(12, Items[0].Quality);
    }

    [Fact]
    public void BackstagePasses_IncreaseQualityByThreeWhenSellInFiveOrLess()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(4, Items[0].SellIn);
        Assert.Equal(13, Items[0].Quality);
    }

    [Fact]
    public void BackstagePasses_QualityZeroWhenBelowSellByDate()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(-1, Items[0].SellIn);
        Assert.Equal(0, Items[0].Quality);
    }

    [Fact]
    public void BackstagePasses_QualityNeverExceedsFifty()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 50 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(50, Items[0].Quality);
    }

    [Fact]
    public void Sulfuras_DoesNotChangeSellInOrQuality()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(10, Items[0].SellIn);
        Assert.Equal(80, Items[0].Quality);
    }
}