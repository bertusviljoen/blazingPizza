namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<Pizza[]> GetPizzasAsync()
    {
        return await Task.FromResult(new Pizza[] {});
    }
}