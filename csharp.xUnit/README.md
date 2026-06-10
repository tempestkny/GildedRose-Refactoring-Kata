# Gilded Rose starting position in C# xUnit

## Build the project

Use your normal build tools to build the projects in Debug mode.
For example, you can use the `dotnet` command line tool:

``` cmd
dotnet build GildedRose.sln -c Debug
```

## Run the Gilded Rose Command-Line program

For e.g. 10 days:

``` cmd
GildedRose/bin/Debug/net8.0/GildedRose 10
```

## Run all the unit tests

``` cmd
dotnet test
```
# Exercise 6

## Code description

A GildedRose represents a list of items. Each item has a Name, SellIn, and Quality value.

The key method is UpdateQuality(), which simulates a day passing. When passing a day, both SellIn and Quality value decrease by 1 for each regular item. Once reaching a value of below 0 for the SellIn value, the Quality value for regular items decreases by 2

There are special item types with different behavior, such as the Aged Brie, Backstage passes and Sulfuras

Aged Brie: SellIn decreases by 1, Quality increases by 1. Once SellIn value is below 0, Quality increases by 2

Backstage passes: SellIn decreases by 1, Quality changes depending on SellIn value 
SellIn > 10: Quality increases by 1
SellIn <= 10: Quality increases by 2
SellIn <= 5: Quality increases by 3
SellIn < 0: Quality becomes 0

Sulfuras: values for both stay the same

Additonal Information: Quality can't get lower than 0 and can't get higher than 50, except for Sulfuras.

## Key testing areas

- Regular items decrease SellIn and Quality value by 1 after each day.
- Regular items Quality decreases by 2 after SellIn reaches value below 0.
- Quality never decreases below 0.
- Quality never increases above 50.
- Aged Brie increases Quality by 1 after each day.
- Aged Brie increases Quality by 2 after SellIn reaches value below 0.
- Backstage passes Quality increases by 1 when more than 10 days are left.
- Backstage passes Quality increases by 2 when 10 or less days are left.
- Backstage passes Quality increases by 3 when 5 or less days are left.
- Backstage passes Quality become 0 when SellIn reaches value below 0.
- Sulfuras values never change.