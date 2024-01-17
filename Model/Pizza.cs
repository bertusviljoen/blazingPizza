namespace BlazingPizza;

/// <summary>
/// Represents a customized pizza as part of an order
/// </summary>
public class Pizza
{
    public const int DefaultSize = 12;
    public const int MinimumSize = 9;
    public const int MaximumSize = 17;

    public int Id { get; set; }

    public int OrderId { get; set; }

    public PizzaSpecial Special { get; set; }

    public int SpecialId { get; set; }

    public int Size { get; set; }
    public List<PizzaTopping> Toppings { get; set; }

    //This C# code snippet defines a method called `GetBasePrice` that returns a decimal 
    //value. The method uses a conditional expression to calculate the base price based 
    //on the presence of a `Special` object and its properties.
    //Here's a breakdown of the code:
    //- The method uses the conditional operator (`? :`) to check if the `Special` object 
    //has a non-null `FixedSize` property.
    //- If the `FixedSize` property is not null, the method returns the `BasePrice` 
    //property of the `Special` object.
    //- If the `FixedSize` property is null, the method calculates the base price using the following formula:
    // - `(decimal)Size / DefaultSize * Special?.BasePrice ??1`
    // - If `Special` is not null, it multiplies the size by the ratio of `Size` to `DefaultSize` and then multiplies it by the `BasePrice` of the `Special` object. If `Special` is null, it defaults to1.
    //In summary, the `GetBasePrice` method calculates the base price based on the presence of a `Special` object and its properties, using a conditional expression to handle different scenarios.
    public decimal GetBasePrice() =>
        Special is { FixedSize: not null }
            ? Special.BasePrice
            : (decimal)Size / DefaultSize * Special?.BasePrice ?? 1;

    public decimal GetTotalPrice()
    {
        return GetBasePrice();
    }

    public string GetFormattedTotalPrice()
    {
        return GetTotalPrice().ToString("0.00");
    }
}
