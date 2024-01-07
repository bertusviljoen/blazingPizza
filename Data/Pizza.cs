namespace BlazingPizza.Data;

/// <summary>
/// Represents a pizza.
/// </summary>
public class Pizza
{
    /// <summary>
    /// Gets or sets the ID of the pizza.
    /// </summary>
    public int PizzaId { get; set; }
    
    /// <summary>
    /// Gets or sets the name of the pizza.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or sets the description of the pizza.
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Gets or sets the price of the pizza.
    /// </summary>
    public decimal Price { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether the pizza is vegetarian.
    /// </summary>
    public bool Vegetarian { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether the pizza is vegan.
    /// </summary>
    public bool Vegan { get; set; }
}
