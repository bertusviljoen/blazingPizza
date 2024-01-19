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

    /// <summary>
    /// Calculates the base price of the pizza.
    /// </summary>
    /// <returns>The base price of the pizza as a decimal value.</returns>
    /// <remarks>
    /// This method uses a conditional expression to calculate the base price based on the presence of a <see cref="Special"/> object and its properties.
    /// If the <see cref="Special"/> object has a non-null <see cref="PizzaSpecial.FixedSize"/> property, the method returns the <see cref="PizzaSpecial.BasePrice"/> property of the <see cref="Special"/> object.
    /// If the <see cref="Special"/> object is null or the <see cref="PizzaSpecial.FixedSize"/> property is null, the method calculates the base price using the formula: <c>(decimal)Size / DefaultSize * Special?.BasePrice ?? 1</c>.
    /// </remarks>
    public decimal GetBasePrice() =>
        Special is { FixedSize: not null }
            ? Special.BasePrice
            : (decimal)Size / DefaultSize * Special?.BasePrice ?? 1;
    /// <summary>
    /// Calculates the total price of the pizza.
    /// </summary>
    /// <returns>The total price of the pizza as a decimal value.</returns>
    public decimal GetTotalPrice()
    {
        return GetBasePrice();
    }

    /// <summary>
    /// Gets the formatted total price of the pizza.
    /// </summary>
    /// <returns>The formatted total price of the pizza as a string.</returns>
    public string GetFormattedTotalPrice()
    {
        return GetTotalPrice().ToString("0.00");
    }
}

